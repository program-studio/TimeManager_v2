   M S B A M L   `   `   `  ����F  BTimeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TimeManager.PagesTimeManager.Pages  5      =#clr-namespace:TimeManager.ViewModelTimeManager.ViewModel  5   
   5clr-namespace:TimeManager.ModelTimeManager.Model  5           TimeManager.Pages.MainPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TimeManager.Pages     5      4vvvm#clr-namespace:TimeManager.ViewModel     5   
   0vmmmclr-namespace:TimeManager.Model     5        N� 
Background  �#dad4da N� Title$ MainPage��5       � DataContext 5      )   #TimeManager.ViewModel.TimeViewModel  5   
    � 	Resources 5         timeViewModel��%   &	          5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      $	��130 �6   �� 5      $��40 �6   �� 5      $��* �6   .+�5%   
   � $��0��6   $��5 0 5 0q�6    � ColumnDefinitions 5&      �� 5'      $��* �6#   �� 5(      $��* �6#   .+�5*      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62    6O   �� *WorkTimeItems[6]+.+�5+      �� $��0��6   $��Work time: ��6,   $��14(�6?   $��Center=�6M   $��0 2 0 0q�6j   �� 5,      $��0��6   $��14(�6J   $��Center=�6X   $��0 2 0 0q�6u   ��6,   �� *WorkTimeSpan+6u   5-      �� 5/      $ 
Horizontal=�6   $��1��62   $��Center=�6B    6_   �� *SelectedItem+.+�50      �� $��0��6   $��Break time: ��6,   $��14(�6@   $��Center=�6N   $��0 2 0 0q�6k   �� 51      $��0��6   $��14(�6J   $��Center=�6X   $��0 2 0 0q�6u   ��6,   �� *WorkTimeSpan+53      54      d� 56      $��0��6D   $��	10 30 5 5q�6�   $��20(�6�   
���2�2�  ControlPauseButton#��[ 6"   6   �� *WorkTimeItems[6]+{�6T   �� *	IsEnabled+��6u   ��  �� Path$" DataContext.StartTimer_Click� �� RelativeSource �� 	 �� AncestorType"	 N�.��57      � .+�58      (�   
AlarmIcon2#��[ 6   $��	0 20 0 45q�6C   �� 59      $��
Start work��6    $��0 35 0 0q�62   $��Center=�6E   5:      5;      d� 5>      $��1��6@   $��	5 30 10 5q�6  $��20(�6  
��� ���#��[ 6;   6   �� *SelectedItem+{�6P   �� *	IsEnabled+��6q   �� $" DataContext.PauseTimer_Click� �� "	 N���6�   �� .��5?      � .+�5@      (�   ProgressClockIcon#��[ 6   $��	0 20 0 45q�6J   �� 5A      $��Break��6    $��0 35 0 0q�6-   $��Center=�6@   5B      5C      5H      �� 5O   
   $ 
Horizontal=�6   $��1��6.   .+�5P      �� $��0��6   $%��Name of the Meeting / Training:��6(   $��15 0 0 0q�6O   $��14(�6a   $��Center=�6o   $��Right=�6�   �� 5Q      $��1��6   $��6 5 10 5q�6'   $	��263��69   
�������$��1q�6X   6n   5S      � 5U   
   $��2��6   $��0 0 0 0q�6   .+�5W      �� -   5        $��
ListBoxBtm��5W        PauseListBoxItem#��[ 6(   $��5 0 5 0q�6_   $��Disabled=�6�   $	��Top=�6  
������ 
������ ��6q   �� *WorkTimeItems+
 �� SelectedItem
 6�   �� *SelectedItem+ �� Mode$ TwoWay=���5g      �� 5i       �� Triggers 5k      �� 5u       �� Value$ 	Work time��5w       �� Binding 5v      �� *Name+.a�5x   "   ��  �� Property � y� �� Value$ 	Collapsed=�6?   5y      �� 5z      $ 
Break time��5|       5{      �� *Name+.a�5}   "   ��  � y�$ 	Collapsed=�6?   5~      .R�5�      �� $	��0 3q�6H    �� 
IsSelected 6&   �� *
IsSelected+.��5�      � .+�5�   "   d� $��btmTest��6/   
�������$��75��6�   $��141.3��6�   #��[ 6@   d� 	IsChecked 6?   �� *
IsSelected+{�6`   �� *	IsEnabled+��6�   �� $# DataContext.PauseButton_Click� �� "	 N���6#  �� .��5�   &   �� $��Center=�61   .+�5�   *   � $��25��6/   .+�5�   .   F� 
���   � �� Stretch$ Uniform=�6@   ��6R   �� *	ImagePath+5�   +   �� 5�   *   $��0 0 0 0q�6J   $��Center=�6\   $��Center=�6w   ��64   �� *Name+6�   �� 5�   *   $��0 0 0 0q�6f    J� Opacity$	 0.5Q�6w   $��Center=�6�   $��Center=�6�   ��64   �� *WorkTimeSpan+ �� StringFormat$ ({0})����5�   .   �� 5�   2    �� 
TargetType" ��68    �� Triggers 5�   6   �� 5�   :    6F   �� *WorkTimeSpan+ 06g   .a�5�   >   ��  � y�$ 	Collapsed=�6[   5�   ;   5�   3   5�   +   5�   '   5�   #   5�      5�      5�      ��5�      �� 5�      .R�5�      �  K� IsItemsHost . 6(   5�      5�      5�      5�      5�      