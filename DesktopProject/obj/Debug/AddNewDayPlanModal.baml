   M S B A M L   `   `   `  ����I  EDesktopProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DesktopProjectDesktopProject  5   	   '    !DesktopProject.AddNewDayPlanModal   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DesktopProject     5   	     � Title$  AddNewDayPlanModal��5   	   $	��300��6$   $	��300��61   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��5* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��3* �6#   �� 5      $��* �6#   .+�5      � $��0��6   .+�5      (  "System.Windows.Controls.DatePicker  -   5        $��
DatePicker��5      $��5 5 5 5q�6]      SelectedDate 6/   ��  �� Path$ NewDayPlan.Date�6q   5      �� 5      -   5        $��1��5      $��5 5 5 5q�6G   .��6Y   
Add Note6c   5      � 5   
   $��1��6   $��5 5 5 5q�6    5      �� 5      $��6* �6    �� 5      $��* �6    $��30��6+   .+�5      ]� $��0��6   $��Stretch=�6%   .+�5      �� -   5        $��DayActivitiesList��5      $��0q�63   $��0q�6G   $��Stretch=�6S   $��Visible=�6x   ��5       �� 5!      .R�5"      �  5#   "   �� 5$   &   $��* �67   �� 5%   &   $��6* �67   �� 5&   &   $��* �67   .+�5(   "   ��  ��Name$ appbar_chevron_right��69   $��0��6)   $��20��6W   $��20��6b    J� Clip4 ��        � ��    � �� ���     ���        .+�5)   &   F� $��15��6+   $��15��66    �� Left$	 2.5��6B   
 �� Top$	 2.5��6T   	 �� Stretch$
	 Fill=�6e   
�������X�����_h�=�$s/|yфJ�X[d�xTX[dѸ�h�=�xTx;фJ�x;�$s/�nѬ�_h�=6�   5*   #   �� 5+   "   $��1��6,   $
��Left=�6Y   $��Center=�6t   $��12(�6�   ��6<   �� *Description+6�   �� 5,   "   -   5        $��2��5,   )   $��5 5 5 5q�6}   $��Center=�6�   $��Center=�6�   
������ 
�������$��20��5-   ^   $��20��6i   

 � Tag
 5,   9   �� *Id+.��5-   u   X5/   #   50      51      53      54      � 55      $��1��6    56      �� 57      $��4* �6'   �� 58      $��* �6'   .+�5:      � $��0��6   .+�5;      �� -   5        $��NewActivityDescBox��5<       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5>      .��5?      5@      �� 5A       J� IsHitTestVisible .  $��New Activity Description��69   $	��Top=�6Y   $
��Left=�6q   $��10,8,0,0q�6�   
���������5B      �� 5C       �� 
TargetType" ��6$   .�5D   "   ��  �� Property � y� �� Value$ 	Collapsed=�6?    �� Triggers 5E   "   �� 5F   &    �� Binding 62   �� *Text+ �� ElementName$ NewActivityDescBox�� �� Value  6k   .a�5G   *   ��  � y�$ Visible=�6G   5H   '   5J      5L      5M      �� 5N      -   5        $��1��5N      $��5 0 5 0q�6)   .��6Z   Add6_   5O      5P      5Q      5R      