   M S B A M L   `   `   `  ����C  ?PDVprova, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PDVprova.ViewsPDVprova.Views  5      9!clr-namespace:PDVprova.ViewModelsPDVprova.ViewModels  69   !    PDVprova.Views.PontoDeVenda   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:PDVprova.Views     5      8
viewmodels!clr-namespace:PDVprova.ViewModels     69     J� InputBindings  5
      �� 5   
    �� Gesture$ Enter��6    �� Command 6%   �� *ComandoRegistrar+�� 5   
   $ F1��6    6%   �� *ComandoDesconto+�� 5   
   $ F2��6    6%   �� *ComandoMudarPreco+�� 5   
   $ F3��6    6%   �� *ComandoCadastrarProduto+�� 5   
   $	 Esc��6    6%   �� *ComandoVoltar+.��5      � $	��770��6   $
��1500��6   $y�Visible=�6%   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF628175��6    � Offset$ 0.989Q�61   � 5      $ 	#FF0E4230��6   $ 0Q�61   5      .+�5   
   �� -   5        $��ENTER -> Registrar��5      $
��Left=�61   $��
34,667,0,0q�6L   $	��Top=�6`   $��50��6�   $	��160��6�   ���	#FFDDDDDD$��18(�6�   �� 5   
   -   5         ��Name$ ListaProdutos��5      $��34,112,483,128q�6E   $��20(�6]    �� View 5      �� 5      .P�5      �� 	 �� Width$	 50��6&   $
��Item��61   
 �� DisplayMemberBinding
 6?   �� *Item+�� 5       $		 500��6%   $��Produto��61   
 6B   �� *DescrProduto+�� 5!      $		 100��6%   $	��Qtd��61   
 6>   �� *
Quantidade+�� 5"      $		 100��6%   $��Valor Unit.��61   
 6F   �� *ValorUnitario+�� 5#      $		 100��6%   $��Descon.��61   
 6B   �� *
Desconto+�� 5$      $		 100��6%   $��
Valor Tot.��61   
 6E   �� *
ValorTotal+5%      5'      �� 5(   
   -   5         ��Name$ BuscaProduto��5(      $
��Left=�6(   $��	34,35,0,0q�6C    �� TextWrapping$
 Wrap=�6V   $%��Codigo ou Descriçao do item...��6j   $	��Top=�6�   $	��983��6�   $��53��6�   $��36(�6�    J� Opacity$ 1Q�6�   $��Normal"�6�   ���	#FFD2C9C9$��Italic$�6  $��2��6  �� 5*   
   -   5        $��F1 -> Desconto��5*      $
��Left=�6-   $��199,667,0,0q�6H   $	��Top=�6]   $��50��6�   $	��160��6�   $��18(�6�   �� 5+   
   $��Informaçao de Venda��6   $��1057,403,34,128q�60   $��28(�6I   $
��Bold"�6W   
�������6i   �� 5,   
   -   5        $ TextBox1��5,      $
��Left=�6%   $��1271,448,0,0q�6@   $
 Wrap=�6V   $	��Top=�6k   $	��175��6�   $��50��6�   $��24(�6�   �� 5-   
   $
��Left=�6   $��1271,512,0,0q�6-   $
 Wrap=�6C   $��TextBox��6W   $	��Top=�6f   $	��175��6~   $��50��6�   �� 5.   
   $
��Left=�6   $��1271,574,0,0q�6-   $
 Wrap=�6C   $��TextBox��6W   $	��Top=�6f   $	��175��6~   $��50��6�   �� 5/   
   $��TOTAL��6   $
��Left=�6    $��1074,445,0,0q�6;   $	��Top=�6Q   
�������$��32(�6|   $��Normal$�6�   $
��Bold"�6�   �� 50   
   $��
TOTAL DESC��6   $
��Left=�6%   $��1074,509,0,0q�6@   $	��Top=�6V   
�������$��32(�6�   $��Normal$�6�   $
��Bold"�6�   �� 51   
   $��SUBTOTAL��6   $
��Left=�6#   $��1074,571,0,0q�6>   $	��Top=�6T   
�������$��32(�6   $��Normal$�6�   $
��Bold"�6�   �� 52   
   $
��Left=�6   $	��334��6+   $��1086,35,0,0q�68   $	��Top=�6M   $	��352��6e   $��/Views/309592-ffffff.png��6q   � 53   
   -   5         �Name$ TelaCadastro��53      y�6%   �� *VisibilidadeTelaCadastro+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.+�54      $   PDVprova.Views.CadastroProduto  55      �� 56   
   -   5        $��F2 -> Mudar Preço��56      $
��Left=�60   $��364,667,0,0q�6K   $	��Top=�6`   $��50��6�   $	��160��6�   $��18(�6�   �� 57   
   -   5        $��F3 -> Cadastro de Produto��57      $
��Left=�68   $��529,667,0,0q�6S   $	��Top=�6h   $��50��6�   $	��221��6�   $��18(�6�   5;      5>      