   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFWPF  5          WPF.ExpenseReportPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:WPF     5        N� Title$   Antonio David - Ver gastos��5	      .��5      � ��5   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � 	Resources 5   
      typeItemTemplate �� XPath  amountItemTemplate��%�   &	        &	 I     �� 5      .R�5      �� ��6   �� $ @ExpenseType��5      �� 5      .R�5       �� ��6   �� $ @ExpenseAmount��5!      5"      .+�5%   
   �� $��1��6     headerTextStyle#��[ 6    .��6I   Informe de gastos para:5(      � 5)   
   $��10q�6   $��1��6   $��1��6+    5+      �� 5,      �� 5-       5/      �� 50      $
��Auto �6    �� 51      $
��Auto �6    �� 52      .+�56      �� $��0��6   $��2��6)   $��0��6=    �� Orientation$ 
Horizontal=�6J   .+�57      ��   
labelStyle#��[ 6   .��6<   	Nombre:6E   �� 58      #��[ 6   ��6<   �� $ @Name��6^   59      �� 5<      $��0��6   $��2��6)   $��1��6=   $ 
Horizontal=�6J   .+�5=      �� #��[ 6   .��6<   Departamento:6K   �� 5>      #��[ 6   ��6<   �� $ @Department��6d   5?      � 5A      $��0��6   $��2��6#   $��2��67   $	��Top=�6D   $
��Left=�5B      .+�5F      &   System.Windows.Controls.DataGrid    columnHeaderStyle   ColumnHeaderStyle# [ 6A      AutoGenerateColumns .  	   RowHeaderWidth$	 0Q�6�   ��6   �� $ Expense��
   Columns
 5H      4  .System.Windows.Controls.DataGridTemplateColumn  5I      ,  &System.Windows.Controls.DataGridColumn   Header$ Tipo de gasto��61      CellTemplate# [  6H     5J      $ Cantidad��61   # [ 6C   5M      5N      5O      5P      5Q      