   M S B A M L   `   `   `  ����C  ?PDVprova, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PDVprova.ViewsPDVprova.Views  5      9!clr-namespace:PDVprova.ViewModelsPDVprova.ViewModels  69   $    PDVprova.Views.CadastroProduto   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:PDVprova.Views     5      8
viewmodels!clr-namespace:PDVprova.ViewModels     69     J� InputBindings  5	      �� 5
   
    �� Gesture$ F4��6    �� Command 6"   �� *ComandoCadastrar+�� 5   
   $ F5��6    6"   �� *ComandoExcluir+.��5      � $��310,124,311,138q�6    � ColumnDefinitions 5   
   �� 5      $
��715* �6   �� 5      $
��166* �6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF628175��6    � Offset$ 0.989Q�61   � 5      $ 	#FF0E4230��6   $ 0Q�61   5      .+�5   
   �� $��Cadastro De Produtos��6   $��5,0,5,10q�61   $��36(�6C   $
��Bold"�6Q   
������� J� 	AllowDrop$
 True��6v   $��2��6�   �� 5   
   $��Descriçao do Produto��6   $��30,50,30,392q�61   $��2��6G   $��18(�6[   
�������.��5      �� -   5        	 ��Name$	 DescrProdutoCAD��5      $��Center=�6[   
 �� TextWrapping$

 Wrap=�6x   $	��788��6�   ��6/   �� *DadosCadastro.DescrProduto+6�   5      �� 5   
   $��Codigo do Produto��6   $��30,116,458,326q�6.   
�������$��18(�6Y   .��5      �� -   5        $	 CodProdutoCAD��5      $��Center=�6S   $

 Wrap=�6p   $	��193��6�   ��6-   �� *DadosCadastro.Codigo+6�   5       �� 5!   
   $��Preço de Custo��6   $��260,116,254,326q�6+   
�������$��18(�6W   .��5"      �� -   5        $	 ValCustoCAD��5"      $
��Left=�6U   $��10,0,0,0q�6p   $

 Wrap=�6�   $	��171��6�   ��6+   �� *DadosCadastro.PrecoCusto+6�   5#      �� 5$   
   $��Preço de Venda��6   $��464,116,49,326q�6+   
�������$��18(�6V   .��5%      �� -   5        $	 ValVendaCAD��5%      $
��Left=�6X   $��10,0,0,0q�6s   $

 Wrap=�6�   $	��171��6�   ��6+   �� *DadosCadastro.ValorUnitario+6�   5&      �� 5'   
   $��Quantidade(estoq.)��6   $��670,116,30,326q�6/   
�������$��18(�6Z   $��2��6h   .��5(      �� -   5        $	 QtdEstoqueCAD��5(      $��Center=�6T   $

 Wrap=�6q   $	��146��6�   ��6-   �� *DadosCadastro.Estoque+6�   5)      �� 5+   
   -   5         ��Name$ ListaProdutosCadastrados��5+      $��30,205,30,84q�6�   $��2��6�   ��65   �� *ListaProdutosCAD.ItemsSource+ �� UpdateSourceTrigger$ PropertyChanged=� �� View 5,      �� 5-      .P�5.      ��  �� Width$ 80��6&   $��Codigo��61    �� DisplayMemberBinding 6A   �� *Codigo+�� 5/      $	 420��6%   $��
Descriçao��61    6D   �� *DescrProduto+�� 50      $	 100��6%   $��Custo��61    6@   �� *
PrecoCusto+�� 51      $	 100��6%   $��Valor Venda.��61    6G   �� *ValorUnitario+�� 52      $	 100��6%   $��Quantidade.��61    6F   �� *	Estoque+53      55      �� 57   
   $��F4 -> Cadastrar��6   $
��Left=�6.   $��
30,439,0,0q�6I   $	��Top=�6]   $��43��6u   $	��138��6�   $��18(�6�   �� 58   
   $��F5 -> Excluir��6   $
��Left=�6,   $��173,439,0,0q�6G   $	��Top=�6\   $��43��6t   $	��138��6�   $��18(�6�   �� 59   
   $��ESC -> Voltar��6   $
��Left=�6,   $��711,439,0,0q�6G   $	��Top=�6\   $��43��6t   $	��138��6�   $��18(�6�   $��2��6�   5>      5?      