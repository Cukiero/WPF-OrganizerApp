   M S B A M L   `   `   `  ���� I  EDesktopProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DesktopProjectDesktopProject  "    DesktopProject.EditNoteModal   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:DesktopProject       � Title$  	Edit Note��$	��220��$	��400��.���  � RowDefinitions �� $��1* ��� $��3* �.+�� $��0�� � ColumnDefinitions �� $��3* ��� $��* �.+�� $��0��.+��� -   $��TitleBox��$��20(�$��5 5 5 5q���  J� IsHitTestVisible .  $�� ��$��20(�$	��Top=�$
��Left=�$��	10,10,0,0q�
�����������  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=� �� Triggers ��  �� Binding �� *Text+	 �� ElementName$	 TitleBox��
 �� Value
  .a���  � y�$ Visible=��� -   $��1��$��5 5 5 5q�.��	Edit Note� $��1��$��5 5 5 5q�.+��� -   $��
ContentBox�� �� AcceptsReturn .  �� TextWrapping$
 Wrap=�.����  .  $�� ��$	��Top=�$
��Left=�$��	10,10,0,0q�
����������� " ��.���  � y�$ 	Collapsed=� ��  �� *Text+$	 
ContentBox��
  .a���  � y�$ Visible=�