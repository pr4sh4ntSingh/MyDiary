   M S B A M L   `   `   `  ����  MyDiary    MyDiary.MainPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Prashant Singh's Diary��5   	   $	��760��6(   $
��1366��65   ���	#FF0EF7ED � WindowStyle$ ThreeDBorderWindow=�6Y    � WindowState$ 	Maximized=�6z   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��173* �6   �� 5	      $
��506* �6   .+�5   
   �� -   5         ��Name$ DateBox��5      $��1��6#   $
��Left=�63   $��33��6N   $��	57,22,0,0q�6Z    �� TextWrapping$
 Wrap=�6m   $��TextBox��6�   $	��Top=�6�   $	��223��6�   $��Mangal)�6�   $��16(�6�   �� 5   
   -   5        $ TimeBox��5      $��1��6#   $
��Left=�63   $��33��6N   $��
350,23,0,0q�6Z   $
 Wrap=�6n   $��TextBox��6�   $	��Top=�6�   $	��163��6�   $��Mangal)�6�   $��16(�6�   �� 5   
   -   5        $ MoodBox��5      $��1��6#   $
��Left=�63   $��34��6N   $��
571,22,0,0q�6Z   $
 Wrap=�6n   $��TextBox��6�   $	��Top=�6�   $	��392��6�   $��Mangal)�6�   $��16(�6�   �� 5   	   -   5         ��Name$ notesBox��5      $
��Auto=�6'    �� 	IsEnabled . $
��Auto=�5       �� AcceptsReturn . $��1��6J   $
��Left=�6Z   $	��564��6u   $��	57,87,0,0q�6�   $	��Top=�6�   $	��906��6�   $��Mangal)�6�   $��14(�6�   6�   �� 5   
   -   5        $
��Save��5      $��1��6    $
��Left=�60   $��350,656,0,0q�6K   $	��Top=�6`   $	��135��6x   $��38��6�   6�   �� 5   
   -   5        	 ��Name$	 CreateButton��5      $��
Create New��6'   $
��Left=�6<   $��
193,22,0,0q�6W   $	��Top=�6k   $	��105��6�   $��33��6�   6�   �� 5   
   -   5        
 ��Name$
 idLabel��5      $��id��6!   $��1��6.   $
��Left=�6>   $��	10,87,0,0q�6Y   $	��Top=�6l   $��Britannic Bold)�6�   $��18(�6�   �� 5   
   -   5        $ idBox��5      $
��Left=�6!   $��32��6<   $��7,23,0,0q�6H   $
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $��58��6�   $��Mangal)�6�   $��16(�6�   �� 5   
   -	   5        $	 
openButton��5      $
��Open��6%   $
��Left=�64   $��	70,23,0,0q�6O   $	��Top=�6b   $��80��6z   $��32��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -
   5        $��mydata��5   .   $
��Left=�6      AutoGenerateColumns .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6W      GridLinesVisibility$	 All=�5         CanUserAddRows .     CanUserResizeColumns .    ColumnHeaderHeight$ 40Q�6a      
IsReadOnly .    CanUserReorderColumns . $��Mangal)�6�   $��12(�6�   $��7,87,0,0q�6�   $	��Top=�6�   $	��339��6�   $	��564��6   ��5   j   �� 5      5      5      