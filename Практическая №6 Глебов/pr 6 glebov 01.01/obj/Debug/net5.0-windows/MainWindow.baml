   M S B A M L   `   `   `  ����L  Hpr 6 glebov 01.01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:pr_6_glebov_01._01pr_6_glebov_01._01  5   	   #    pr_6_glebov_01._01.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:pr_6_glebov_01._01     5   	     � Title$$  Практическая  №5��5   	   $	��284��6"   $	��250��6/    � 
ResizeMode$ NoResize=�6;    � WindowStartupLocation$ CenterScreen=�6Q   .��5	      � .+�5
   
   �� $
��Left=�6   $��5,39,0,0q�6/   $
��Wrap=�6A   $	��Top=�6U   $��95��6m   $��15��6x   �� 6�    � Language$ ru-ru�6�   $�Введите число��6�   6�   �� 5   
   -   5         ��Name$ 
allNumbers��5      $
��Left=�6&   $��5,59,0,0q�6A    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $��80��6   $��20��6�   6�   �� 5   
   $
��Left=�6   $��
100,63,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   �� 6p   $ ru-ru�6t   $�или��6�   6�   �� 5   
   $
��Left=�6   $��	150,9,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $��15��6n   �� 6{   $ ru-ru�6   $�Три числа��6�   6�   �� 5   
   -   5        $ firstNumber��5      $
��Left=�6'   $��
145,29,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $��80��6�   $��20��6�   �� 5   
   -   5        $ secondNumber��5      $
��Left=�6(   $��
145,54,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $��80��6�   $��20��6�   �� 5   
   -   5        $ thirdNumber��5      $
��Left=�6'   $��
145,79,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $��80��6�   $��20��6�   �� 5   
   -   5         ��Name$ caluculateSum��5      $0��*Рассчитать сумму чисел��6(   $
��Left=�6I   $��	5,109,0,0q�6d   $	��Top=�6w   $	��220��6�   6�   �� 5   
   $
��Left=�6   $��
80,138,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   �� 6p   $�Результат��6t   �� 6�   $ ru-ru�6�   $�: ��6�   6�   �� 5   
   -   5        $ result��5      $
��Left=�6"   $��
45,159,0,0q�6=   $
 Wrap=�6Q   $	��Top=�6e   $	��120��6}    �� 
IsReadOnly$
 True��6�   �� 5   
   -   5        $ about��5      $��О программе��6    $
��Left=�66   $��	5,219,0,0q�6Q   $	��Top=�6d   $��95��6|   6�   �� 5   
   -   5        $
 exit��5      $��
Выход��6   $
��Left=�6/   $��130,219,0,0q�6J   $	��Top=�6_   $��95��6w   6�   �� 5   
   -	   5        $ checkEquality��5      $;��5Проверить числа на равенство��6(   $
��Left=�6O   $��	5,189,0,0q�6j   $	��Top=�6}   $	��220��6�   6�   5      5      