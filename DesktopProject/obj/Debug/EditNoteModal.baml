   M S B A M L   `   `   `  ����I  EDesktopProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DesktopProjectDesktopProject  5   	   "    DesktopProject.EditNoteModal   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DesktopProject     5   	     � Title$  EditNoteModal��5   	   $	��220��6   $	��400��6,   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��3* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��3* �6#   �� 5      $��* �6#   .+�5      � $��0��6   .+�5      �� -   5        $��TitleBox��5      $��20(�6+   $��5 5 5 5q�69   6M   �� 5       J� IsHitTestVisible .  $�� ��65   $��20(�6=   $	��Top=�6K   $
��Left=�6c   $��	10,10,0,0q�6~   
���������5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � y� �� Value$ 	Collapsed=�6;    �� Triggers 5      �� 5   "    �� Binding 6.   �� *Text+	 �� ElementName$	 TitleBox��
 �� Value
  6]   .a�5   &   ��  � y�$ Visible=�6C   5   #   5      5       5!      �� 5"      -   5        $��1��5"      $��5 5 5 5q�6B   .��6T   	Edit Note6_   5#      � 5%   
   $��1��6   $��5 5 5 5q�6   .+�5&      �� -   5        $��
ContentBox��5'       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5)      .��5*      5+      �� 5,       .  $�� ��61   $	��Top=�69   $
��Left=�6Q   $��	10,10,0,0q�6l   
���������5-      �� 5.      " ��6   .�5/      ��  � y�$ 	Collapsed=�67    50      �� 51       6*   �� *Text+$	 
ContentBox��
  6[   .a�52   "   ��  � y�$ Visible=�6?   53      55      57      59      5:      5;      