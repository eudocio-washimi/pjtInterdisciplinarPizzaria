import sys
import pandas as pd
import matplotlib.pyplot as plt
import matplotlib.ticker as ticker

plt.style.use('ggplot')
plt.rcParams['figure.figsize'] = [11, 6]
plt.rcParams['font.size'] = 10
plt.rcParams['axes.unicode_minus'] = False 

# Configuração de Encoding do Console (Prevenção de erros)
try:
    sys.stdout.reconfigure(encoding='utf-8')
except:
    pass

def limpar_valor(serie):
    if serie.dtype == object:
        return pd.to_numeric(
            serie.astype(str)
            .str.replace('R$', '', regex=False)
            .str.replace(' ', '', regex=False)
            .str.replace('.', '', regex=False)
            .str.replace(',', '.', regex=False)
        )
    return serie

def gerar_grafico(tipo_grafico, nome_arquivo_saida):
    arquivo_csv = "dados_temp.csv"
    
    try:
        # --- CORREÇÃO DEFINITIVA DE ACENTOS ---
        # utf-8-sig lê arquivos UTF-8 que começam com BOM (Byte Order Mark)
        # É o formato mais seguro para intercâmbio Windows <-> Python
        df = pd.read_csv(arquivo_csv, sep=';', encoding='utf-8-sig')
    except Exception as e:
        print(f"Erro ao ler CSV: {e}")
        # Fallback desesperado
        try:
            df = pd.read_csv(arquivo_csv, sep=';', encoding='latin1')
        except:
            return

    fig, ax = plt.subplots()

    # --- GRÁFICOS ---
    
    if tipo_grafico == "LUCRO":
        df['data'] = pd.to_datetime(df['data'], errors='coerce')
        df['mes_ano'] = df['data'].dt.strftime('%m/%Y')
        df['valor'] = limpar_valor(df['valor'])
        pivot = df.pivot_table(index='mes_ano', columns='tipo', values='valor', aggfunc='sum', fill_value=0)
        
        # Ordenação
        if not pivot.empty:
            pivot.index = pd.to_datetime(pivot.index, format='%m/%Y')
            pivot = pivot.sort_index()
            pivot.index = pivot.index.strftime('%m/%Y')
            
            colunas = pivot.columns.tolist()
            cores_reais = []
            for c in colunas:
                if 'Entrada' in str(c): cores_reais.append('#27ae60')
                elif 'Saida' in str(c) or 'Saída' in str(c): cores_reais.append('#c0392b')
                else: cores_reais.append('#555')
            
            pivot.plot(kind='bar', ax=ax, color=cores_reais)
            plt.title("Fluxo de Caixa: Entradas vs Saídas")
            ax.yaxis.set_major_formatter(ticker.StrMethodFormatter('R$ {x:,.0f}'))

    elif tipo_grafico == "PAGAMENTOS":
        contagem = df['forma_pagamento'].value_counts()
        if not contagem.empty:
            wedges, texts, autotexts = ax.pie(contagem, autopct='%1.1f%%', startangle=90)
            plt.legend(wedges, contagem.index, title="Meio", loc="center left", bbox_to_anchor=(1, 0, 0.5, 1))
            plt.title("Meios de Pagamento")
            plt.ylabel('')

    elif tipo_grafico == "TIPO_GASTO":
        df['valor'] = limpar_valor(df['valor'])
        agrupado = df.groupby('tipo_custo')['valor'].sum()
        agrupado.plot(kind='bar', color=['#e67e22', '#7f8c8d'], rot=0, ax=ax)
        plt.title("Despesas por Tipo")
        plt.ylabel("Total (R$)")
        ax.yaxis.set_major_formatter(ticker.StrMethodFormatter('R$ {x:,.0f}'))

    elif tipo_grafico == "FATURAMENTO":
        df['data_venda'] = pd.to_datetime(df['data_venda'], errors='coerce')
        df['mes_ano'] = df['data_venda'].dt.strftime('%m/%Y')
        df['valor_total'] = limpar_valor(df['valor_total'])
        agrupado = df.groupby('mes_ano')['valor_total'].sum()
        
        if not agrupado.empty:
            agrupado.index = pd.to_datetime(agrupado.index, format='%m/%Y')
            agrupado = agrupado.sort_index()
            agrupado.index = agrupado.index.strftime('%m/%Y')
            agrupado.plot(kind='bar', color='#2980b9', ax=ax)
            plt.title("Faturamento Mensal")
            ax.yaxis.set_major_formatter(ticker.StrMethodFormatter('R$ {x:,.0f}'))

    elif tipo_grafico == "PIZZAS":
        agrupado = df.groupby('nome_produto')['qtd'].sum().sort_values(ascending=True).tail(10)
        agrupado.plot(kind='barh', color='#d35400', ax=ax)
        plt.title("Top 10 Produtos")
        plt.xlabel("Qtd")

    elif tipo_grafico == "BAIRROS":
        contagem = df['bairro'].value_counts().head(10).sort_values(ascending=True)
        contagem.plot(kind='barh', color='#8e44ad', ax=ax)
        plt.title("Top 10 Bairros")

    elif tipo_grafico == "MOTOBOYS":
        contagem = df['nome_motoboy'].value_counts()
        if not contagem.empty:
            wedges, texts, autotexts = ax.pie(contagem, autopct='%1.1f%%', startangle=90)
            plt.title("Entregas por Motoboy")
            plt.ylabel('')

    elif tipo_grafico == "TIPO":
        contagem = df['tipo_pedido'].value_counts()
        contagem.plot(kind='bar', color=['#16a085', '#2c3e50', '#c0392b'], rot=0, ax=ax)
        plt.title("Canais de Venda")

    elif tipo_grafico == "DIAS":
        df['data_venda'] = pd.to_datetime(df['data_venda'], errors='coerce')
        dias_map = {'Monday': 'Segunda', 'Tuesday': 'Terça', 'Wednesday': 'Quarta', 'Thursday': 'Quinta', 'Friday': 'Sexta', 'Saturday': 'Sábado', 'Sunday': 'Domingo'}
        df['dia'] = df['data_venda'].dt.day_name().map(dias_map)
        ordem = ['Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta', 'Sábado', 'Domingo']
        df['dia'] = pd.Categorical(df['dia'], categories=ordem, ordered=True)
        contagem = df['dia'].value_counts().sort_index()
        contagem.plot(kind='line', marker='o', color='#e74c3c', linewidth=3, ax=ax)
        plt.title("Fluxo Semanal")
        plt.ylim(bottom=0)

    plt.tight_layout()
    plt.savefig(nome_arquivo_saida)
    print(f"Gerado: {nome_arquivo_saida}")

if __name__ == "__main__":
    if len(sys.argv) > 2:
        gerar_grafico(sys.argv[1], sys.argv[2])
    elif len(sys.argv) > 1:
        gerar_grafico(sys.argv[1], "grafico_gerado.png")