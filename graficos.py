import sys
import pandas as pd
import matplotlib.pyplot as plt
import matplotlib.ticker as ticker

plt.style.use('ggplot')
plt.rcParams['figure.figsize'] = [10, 6]
plt.rcParams['font.size'] = 10
plt.rcParams['axes.unicode_minus'] = False # Garante que sinais de menos apareçam corretamente

def gerar_grafico(tipo_grafico):
    arquivo_entrada = "dados_temp.csv"
    arquivo_saida = "grafico_gerado.png"

    try:
        # Lê o CSV gerado pelo VB.NET
        # sep=';' é usado para separar as colunas
        # encoding='latin1' é fundamental para ler acentos do Windows corretamente
        df = pd.read_csv(arquivo_entrada, encoding='latin1', sep=';')
    except Exception as e:
        print(f"Erro ao ler CSV: {e}")
        return

    fig, ax = plt.subplots()

    # --- 1. COMPARAÇÃO DE FATURAMENTO (MÊS/ANO) ---
    if tipo_grafico == "FATURAMENTO":
        # Converte a coluna de data
        df['data_venda'] = pd.to_datetime(df['data_venda'], errors='coerce')
        df = df.dropna(subset=['data_venda']) # Remove datas inválidas
        
        # Cria coluna Mês/Ano (ex: 02/2025)
        df['mes_ano'] = df['data_venda'].dt.strftime('%m/%Y')
        
        # Limpeza do valor monetário (Remove 'R$', pontos de milhar e troca vírgula por ponto)
        if df['valor_total'].dtype == object:
            df['valor_total'] = df['valor_total'].astype(str).str.replace('R$', '', regex=False)
            df['valor_total'] = df['valor_total'].str.replace('.', '', regex=False) # Tira ponto de milhar
            df['valor_total'] = df['valor_total'].str.replace(',', '.', regex=False) # Troca virgula decimal
            df['valor_total'] = pd.to_numeric(df['valor_total'])

        # Agrupa por mês e soma
        agrupado = df.groupby('mes_ano')['valor_total'].sum()
        
        # Ordenação Cronológica (Truque para não ficar ordem alfabética)
        agrupado.index = pd.to_datetime(agrupado.index, format='%m/%Y')
        agrupado = agrupado.sort_index()
        agrupado.index = agrupado.index.strftime('%m/%Y')

        # Plota o gráfico
        cores = ['#27ae60' if i % 2 == 0 else '#2ecc71' for i in range(len(agrupado))]
        agrupado.plot(kind='bar', color=cores, ax=ax)
        
        plt.title("Comparativo de Faturamento Mensal")
        plt.ylabel("Valor Total (R$)")
        plt.xticks(rotation=45)
        
        # Formata o eixo Y para Moeda (R$)
        ax.yaxis.set_major_formatter(ticker.StrMethodFormatter('R$ {x:,.0f}'))

    # --- 2. PRODUTOS MAIS VENDIDOS ---
    elif tipo_grafico == "PIZZAS":
        # Soma a quantidade por nome do produto
        agrupado = df.groupby('nome_produto')['qtd'].sum().sort_values(ascending=True).tail(10)
        
        agrupado.plot(kind='barh', color='#e67e22', ax=ax)
        plt.title("Top 10 Produtos Mais Vendidos")
        plt.xlabel("Quantidade Vendida")
        
        # Coloca o número na ponta da barra
        for index, value in enumerate(agrupado):
            plt.text(value, index, str(value), va='center')

    # --- 3. BAIRROS (Mapa de Calor de Entregas) ---
    elif tipo_grafico == "BAIRROS":
        contagem = df['bairro'].value_counts().head(10).sort_values(ascending=True)
        contagem.plot(kind='barh', color='#2980b9', ax=ax)
        plt.title("Top 10 Bairros com Mais Pedidos")
        plt.xlabel("Número de Entregas")

    # --- 4. MOTOBOYS (Produtividade) ---
    elif tipo_grafico == "MOTOBOYS":
        contagem = df['nome_motoboy'].value_counts()
        if not contagem.empty:
            # Gráfico de Pizza
            wedges, texts, autotexts = ax.pie(contagem, autopct='%1.1f%%', startangle=90)
            plt.legend(wedges, contagem.index, title="Motoboys", loc="center left", bbox_to_anchor=(1, 0, 0.5, 1))
            plt.title("Entregas por Motoboy")
            plt.ylabel('')

    # --- 5. TIPO DE PEDIDO (Delivery vs Outros) ---
    elif tipo_grafico == "TIPO":
        contagem = df['tipo_pedido'].value_counts()
        cores = ['#8e44ad', '#34495e', '#c0392b']
        ax = contagem.plot(kind='bar', color=cores, rot=0)
        plt.title("Pedidos por Canal de Venda")
        plt.ylabel("Quantidade")
        
        # Etiquetas nas barras
        for p in ax.patches:
            ax.annotate(str(p.get_height()), (p.get_x() + p.get_width() / 2., p.get_height()), ha='center', va='bottom')

    # --- 6. DIAS DA SEMANA ---
    elif tipo_grafico == "DIAS":
        df['data_venda'] = pd.to_datetime(df['data_venda'])
        
        # Tradução para Português
        dias_traducao = {
            'Monday': 'Segunda', 'Tuesday': 'Terça', 'Wednesday': 'Quarta',
            'Thursday': 'Quinta', 'Friday': 'Sexta', 'Saturday': 'Sábado', 'Sunday': 'Domingo'
        }
        
        df['dia_semana'] = df['data_venda'].dt.day_name().map(dias_traducao)
        
        # Ordem correta da semana
        ordem = ['Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta', 'Sábado', 'Domingo']
        df['dia_semana'] = pd.Categorical(df['dia_semana'], categories=ordem, ordered=True)
        
        # Contagem
        contagem = df['dia_semana'].value_counts().sort_index()
        
        # Gráfico de Linha
        contagem.plot(kind='line', marker='o', color='#c0392b', linewidth=3, ax=ax)
        plt.title("Fluxo de Vendas por Dia da Semana")
        plt.grid(True, linestyle='--', alpha=0.7)
        plt.ylabel("Quantidade de Pedidos")
        plt.ylim(bottom=0)

    plt.tight_layout()
    plt.savefig(arquivo_saida)
    print(f"Gráfico gerado: {arquivo_saida}")

if __name__ == "__main__":
    if len(sys.argv) > 1:
        gerar_grafico(sys.argv[1])
    else:
        print("Erro: Nenhum tipo de gráfico especificado.")