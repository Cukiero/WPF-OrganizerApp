   M S B A M L   `   `   `  ���� I  EDesktopProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DesktopProjectDesktopProject  '    !DesktopProject.AddNewDayPlanModal   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:DesktopProject       � Title$  Add New Day Plan��$	��300��$	��300��.���  � RowDefinitions �� $��1* ��� $��5* �.+�� $��0�� � ColumnDefinitions �� $��3* ��� $��* �.+�� $��0��.+�(  "System.Windows.Controls.DatePicker  -   $��
DatePicker��$��5 5 5 5q�   SelectedDate ��  �� Path$ NewDayPlan.Date��� -   $��1��$��5 5 5 5q�.��
Add Note� $��1��$��5 5 5 5q� �� $��6* ��� $��* �$��30��.+�]� $��0��$��Stretch=�.+��� -   $��DayActivitiesList��$��0q�$��0q�$��Stretch=�$��Visible=����� .R��  �� $��* ��� $��6* ��� $��* �.+���  ��Name$ appbar_chevron_right��$��0��$��20��$��20�� J� Clip4 ��        � ��    � �� ���     ���        .+�F� $��15��$��15�� �� Left$	 2.5��
 �� Top$	 2.5��	 �� Stretch$
	 Fill=�
�������X�����_h�=�$s/|yфJ�X[d�xTX[dѸ�h�=�xTx;фJ�x;�$s/�nѬ�_h�=�� $��1��$
��Left=�$��Center=�$��12(����� *Description+�� -   $��2��$��5 5 5 5q�$��Center=�$��Center=�
������ 
�������$��20��$��20��

 � Tag
 �� *Id+.��X� $��1�� �� $��4* ��� $��* �.+�� $��0��.+��� -   $��NewActivityDescBox�� �� AcceptsReturn .  �� TextWrapping$
 Wrap=�.����  J� IsHitTestVisible .  $��New Activity Description��$	��Top=�$
��Left=�$��10,8,0,0q�
�����������  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=� �� Triggers ��  �� Binding �� *Text+ �� ElementName$ NewActivityDescBox�� �� Value  .a���  � y�$ Visible=��� -   $��1��$��5 0 5 0q�.��Add