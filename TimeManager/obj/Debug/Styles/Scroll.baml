   M S B A M L   `   `   `  ����F  BTimeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TimeManagerTimeManager  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ScrollBarLineButton  �� 
TargetType �� Property �� Value �� 
TargetType  ScrollBarPageButton  ScrollBarThumb ��Name �� CornerRadius J� Opacity �� Triggers :� RoutedEvent		 W� To
 g� Duration �� 
TargetName �� TargetProperty  VerticalScrollBar � RowDefinitions ]� DecreaseRepeatButton ]� Thumb  	GrayBrush ]� IncreaseRepeatButton  HorizontalScrollBar � ColumnDefinitions �� Triggers P� Property P� Value  CustomScrollViewer �� VerticalOffset � Value �� ScrollableHeight � Maximum �� ViewportHeight �� ViewportSize* �� #ComputedVerticalScrollBarVisibility �� Orientation �� HorizontalOffset �� ScrollableWidth �� ViewportWidth,  �� %ComputedHorizontalScrollBarVisibility�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      #localclr-namespace:TimeManager  5      %  &	        &	     &	 V    &	 J    7   7  7  7  7  7   &	 :    7   7  7  7  7  7   '�� 0	    7  7  &	 '    �� 5      "  ��6(   .�5   
   ��  �@J�SnapsToDevicePixels . 60   �� 5   
    �@�OverridesDefaultStyle . 62   �� 5   
    � |� .  6&   �� 5	   
    � �� 5
      �� 5      " ��6"   .R�5      �� 5      5      5      �� 5      "  ��6(   .�5   
   ��  �@J�SnapsToDevicePixels . 60   �� 5   
    �@�OverridesDefaultStyle . 62   �� 5   
    � �� .  6&   �� 5   
    � |� .  6&   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� 
������ 6   5      5      5      �� 5       "  n�6#   .�5!   
   ��  �@J�SnapsToDevicePixels . 60   �� 5"   
    �@�OverridesDefaultStyle . 62   �� 5#   
    � �� .  6&   �� 5$   
    � |� .  6&   �� 5%   
    � �� 5&      �� 5'      " n�6"   .R�5(      �� $ 	rectangle��6   $ 2��60   $	 0.2Q�6A   #��z��6O    5)      :� 5*      $ 
MouseEnter��6'   .[�5+      �� .��5,   "   �� .��5-   &   W� $	 1X�66   $
 0:0:0.3D�6=   $ 	rectangle��6P   $ Opacity�6r   5.   #   5/      50      :� 51      $ 
MouseLeave��6'   .[�52      �� .��53   "   �� .��54   &   W� $		 0.2X�66   $
 0:0:0.3D�6?   $ 	rectangle��6R   $ Opacity�6t   55   #   56      57      59      5;      5<      �� 5>      " ��60   .R�5?   
   �  5@      �� 5A      $��0.00001* �6    .+�5C      �� 8��  $��18��6H   $��ScrollBar.LineUpCommand��6T   ]� 5D      $��
PART_Track��6   ��.  5E      �� 5F      8�� $��ScrollBar.PageUpCommand��6P    5H      n� 5I      8�� $��1,0,1,0q�6D   8�� 6U    5K      �� 5L      8�� $��ScrollBar.PageDownCommand��6P   5N      �� 5O      8�� $��18��6H   $��ScrollBar.LineDownCommand��6T   5P      5Q      �� 5S      " ��62   .R�5T   
   �  5U      �� 5V      $��0.00001* �6#   .+�5X      �� 8��  $��18��6H   $��ScrollBar.LineLeftCommand��6S   ]� 5Y      $��
PART_Track��6   ��.   5Z      �� 5[      8�� $��ScrollBar.PageLeftCommand��6P    5]      n� 5^      8�� $��0,1,0,1q�6D   8�� 6U    5`      �� 5a      8�� $ ��ScrollBar.PageRightCommand��6P   5c      �� 5d      8�� $��18��6H   $ ��ScrollBar.LineRightCommand��6S   5e      5f      �� 5h      "  ��6'   .�5i   
   ��  �@J�SnapsToDevicePixels . 60   �� 5j   
    �@�OverridesDefaultStyle . 62    5k   
   P� 5l       �@��Orientation$ 
Horizontal=�6-   . �5m      ��  � ��$
 Auto��6*   �� 5n       � ��$ 8��6+   �� 5o       � ��8   6-   5p      P� 5q       �@��Orientation$ Vertical=�6-   . �5r      ��  � ��$ 8��6*   �� 5s       � ��$
 Auto��6+   �� 5t       � ��8  6-   5u      5w      �� 5z      "  ��6'   .�5{   
   ��  �@�OverridesDefaultStyle . 62   �� 5|   
    � �� 5}      �� 5~      " ��6"   .R�5      �  5�      �� 5�      $��* �6/   �� 5�      $
��Auto �6/    5�      �� 5�      �� 5�      $
��Auto �6,   .+�5�      �� $��0��61   �� 5�      $��PART_VerticalScrollBar��6$   $��1��6B   # z 6R   # z 6{   # z 5�   $   #y�z 6T   �� 5�      $��PART_HorizontalScrollBar��6$   $ 
Horizontal=�6D   $��1��6]   $��0��6j   # z 6z   # z 5�   $   # z 6P   #y�z  6   5�      5�      5�      5�      5�      