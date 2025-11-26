# 📋 Listar Nomes com Contador --- Windows Forms

Um projeto desenvolvido em **C# Windows Forms** para treinar manipulação
de componentes gráficos, uso de ListBox, validação de entrada e
atualização dinâmica de dados na interface. O usuário pode adicionar
nomes em uma lista e visualizar a quantidade total inserida.

## 🚀 Funcionalidades

-   Adicionar nomes a uma lista usando um **TextBox**
-   Validação de nome vazio ou inválido
-   Exibição dos nomes em um **ListBox**
-   Contador automático atualizado em um **Label**
-   Botão para **limpar** lista, contador e entrada

## 🖥 Estrutura da Interface

O formulário (`Frm_TelaInicial`) é composto por:

-   Txt_Nome --- Campo onde o usuário digita o nome\
-   Btn_Adicionar --- Botão para adicionar o nome à lista\
-   Lst_Nomes --- Lista exibindo todos os nomes adicionados\
-   Lbl_Quantidade --- Label que mostra o total de nomes cadastrados\
-   Btn_Limpar --- Botão para limpar toda a lista e zerar o contador

Todos os componentes seguem o padrão adequado de nomenclatura do Windows
Forms.

## 🎯 Objetivo do Projeto

Este projeto reforça conceitos fundamentais do Windows Forms:

-   Manipulação de coleções internas do ListBox
-   Atualização visual de Labels
-   Validação simples de entrada
-   Uso de variáveis de estado (contador)
-   Interação com eventos de clique

## 📚 Aprendizados

Ao concluir essa atividade, você pratica:

-   Uso de `ListBox.Items.Add()`
-   Limpeza de lista com `ListBox.Items.Clear()`
-   Atualização de contadores
-   Manipulação de strings com `.Trim()`
-   Exibição de mensagens com `MessageBox`
-   Direcionamento de foco com `.Focus()`

## 🧹 Função Limpar

O botão **Limpar** redefine:

-   A lista completa de nomes\
-   O contador (zerado)\
-   O texto do campo de entrada\
-   O foco retorna automaticamente para Txt_Nome

