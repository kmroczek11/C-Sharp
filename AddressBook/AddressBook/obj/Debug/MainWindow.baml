   M S B A M L   `   `   `  ����F  BAddressBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AddressBookAddressBook  5   	       AddressBook.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AddressBook     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ 	btConnect��5
      $��Connect��6$   $
��Left=�66   $��307,233,0,0q�6Q   $	��Top=�6f   $	��100��6~   $��50��6�   �� 5   
   -   5         ��Name$ tbServer��5      $
��Left=�6$   $��23��6?   $��
397,49,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ 	btGetData��5      $��Get Data��6$   $
��Left=�67   $��307,308,0,0q�6R   $	��Top=�6g   $	��100��6   $��50��6�   6�   �� 5   
   -   5        $ 
tbDatabase��5      $
��Left=�6&   $��23��6A   $��
397,90,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $ tbUID��5      $
��Left=�6!   $��23��6<   $��397,129,0,0q�6H   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   $��Server��6   $
��Left=�6!   $��
307,48,0,0q�6<   $	��Top=�6P    J� RenderTransformOrigin$ 0.505,0.528&�6h   �� 5   
   $��Database��6   $
��Left=�6#   $��
307,89,0,0q�6>   $	��Top=�6R   �� 5   
   $	��UID��6   $
��Left=�6   $��307,132,0,0q�69   $	��Top=�6N   �� 5   
   $��Password��6   $
��Left=�6#   $��307,166,0,0q�6>   $	��Top=�6S   �� 5   
   -   5         ��Name$ lbStatus��5      $��No connection��6"   $
��Left=�6:   $��429,245,0,0q�6U   $	��Top=�6j   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgContacts��5   @   $
��Left=�6T   $	��399��6o   $��	23,10,0,0q�6|   $	��Top=�6�   $	��255��6�    J� IsManipulationEnabled .    CanUserDeleteRows .  ��6   �� 	 �� Path$	 LoadDataBinding�
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+  5      $
 Name��6%    63   �� *Name+  5      $	 Age��6%    62   �� *Age+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Usuwanie��6)      CellTemplate 5      �� 5      .R�5      �� -   5        .��5   4   Delete6<   5      5         5!      $ Aktualizacja��6)    5"      �� 5#      .R�5$      �� -	   5        .��5$   4   Update6<   5%      5'      5*      G� 5+   
   -
   5         G�Name$ 
pbPassword��5+      $
��Left=�6*   $��397,166,0,0q�6E   $	��Top=�6Z   $	��120��6r   $��23��6~   �� 5,   
   -   5        $ btAdd��5,      $	��Add��6    $
��Left=�6.   $��
605,99,0,0q�6I   $	��Top=�6]   $	��100��6u   $��50��6�   6�   �� 5-   
   -   5        $ lbName��5-      $��Search by name��6    $
��Left=�69   $��542,265,0,0q�6T   $	��Top=�6i   �� 5.   
   -   5        $ lbAge��5.      $��Search by age��6   $
��Left=�67   $��678,265,0,0q�6R   $	��Top=�6g   �� 5/   
   -   5        $ tbName��5/      $
��Left=�6"   $��23��6=   $��532,308,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 50   
   -   5        $ tbAge��50      $
��Left=�6!   $��23��6<   $��657,308,0,0q�6H   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 51   
   -   5        $ btSearch��51      $��Search��6#   $
��Left=�64   $��605,336,0,0q�6O   $	��Top=�6d   $	��100��6|   $��50��6�   6�   52      53      