   M S B A M L   `   `   `  ����M  Ipr 2 arturio 01.01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:pr_2_arturio_01._01pr_2_arturio_01._01  5   	   $    pr_2_arturio_01._01.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:pr_2_arturio_01._01     5   	     � Title$0  *Практическая работа №2��5   	   $	��324��6(   $	��480��65    � 
ResizeMode$ NoResize=�6A    � WindowStartupLocation$ CenterScreen=�6W   .��5	      � .+�5
   
   o� $	��Top=�6   .@�5      m� $��Файл��6   .@�5      m� -   5         m�Name$
 open��5      $��Открыть��6)   6:   m� 5      -   5        $
 save��5      $��Сохранить��6)   6<   5      �� 5      m� 5      -   5        $ about��5      $��О программе��6&   6;   m� 5      -   5        $
 exit��5      $��
Выход��6%   64   5      �� 5   
   $
��Left=�6   $��	19,24,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $��20��6n   �� 6{    � Language$ ru-ru�6   $/�)Количество элементов: ��6�   6�   �� 5   
   -   5         ��Name$ inputLength��5      $
��Left=�6'   $��
155,24,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��120��6�   $��20��6�   �� 5   
   -   5         ��Name$ generate��5      $!��Сгенерировать ��6#   $
��Left=�6<   $��
305,24,0,0q�6W   $	��Top=�6k   $	��120��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridForArray��5      $	��Top=�6-   $	��180��6E   $��
20,49,40,0q�6R   �� 5   
   $
��Left=�6   $��
20,239,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��20��6o   �� 6|   $�Результат��6�   �� 6�   $ ru-ru�6�   $�: ��6�   6�   �� 5   
   -   5        $ result��5      $
��Left=�6"   $��
80,239,0,0q�6=   $
 Wrap=�6Q   $	��Top=�6e   $	��120��6}   $��20��6�   	 �� 
IsReadOnly$
	 True��6�   �� 5   
   -	   5        $ 	calculate��5      $��Рассчитать��6$   $
��Left=�69   $��225,239,0,0q�6T   $	��Top=�6i   $��95��6�   6�   �� 5   
   -
   5        $ clear��5      $��Очистить��6    $
��Left=�63   $��340,239,0,0q�6N   $	��Top=�6c   $��80��6{   6�   5      5      