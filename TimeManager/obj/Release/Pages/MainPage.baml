   M S B A M L   `   `   `  ���� F  BTimeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TimeManager.PagesTimeManager.Pages  =#clr-namespace:TimeManager.ViewModelTimeManager.ViewModel  5clr-namespace:TimeManager.ModelTimeManager.Model       TimeManager.Pages.MainPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:TimeManager.Pages     4vvvm#clr-namespace:TimeManager.ViewModel     0vmmmclr-namespace:TimeManager.Model       N� 
Background  �#dad4da N� Title$ MainPage�� � DataContext )   #TimeManager.ViewModel.TimeViewModel   � 	Resources    timeViewModel��%   &	          .���  � RowDefinitions �� $	��130 ��� $��40 ��� $��* �.+�� $��0��$��5 0 5 0q� � ColumnDefinitions �� $��* ��� $��* �.+���  �� Orientation$ 
Horizontal=�$��Center=� �� *WorkTimeItems[6]+.+��� $��0��$��Work time: ��$��14(�$��Center=�$��0 2 0 0q��� $��0��$��14(�$��Center=�$��0 2 0 0q����� *WorkTimeSpan+�� $ 
Horizontal=�$��1��$��Center=� �� *SelectedItem+.+��� $��0��$��Break time: ��$��14(�$��Center=�$��0 2 0 0q��� $��0��$��14(�$��Center=�$��0 2 0 0q����� *WorkTimeSpan+d� $��0��$��	10 30 5 5q�$��20(�
���2�2�  ControlPauseButton#��[  �� *WorkTimeItems[6]+{��� *	IsEnabled+����  �� Path$" DataContext.StartTimer_Click� �� RelativeSource �� 	 �� AncestorType"	 N�.��� .+�(�   
AlarmIcon2#��[ $��	0 20 0 45q��� $��
Start work��$��0 35 0 0q�$��Center=�d� $��1��$��	5 30 10 5q�$��20(�
��� ���#��[  �� *SelectedItem+{��� *	IsEnabled+���� $" DataContext.PauseTimer_Click� �� "	 N����� .��� .+�(�   ProgressClockIcon#��[ $��	0 20 0 45q��� $��Break��$��0 35 0 0q�$��Center=��� $ 
Horizontal=�$��1��.+��� $��0��$%��Name of the Meeting / Training:��$��15 0 0 0q�$��14(�$��Center=�$��Right=��� $��1��$��6 5 10 5q�$	��263��
�������$��1q�� $��2��$��0 0 0 0q�.+��� -   $��
ListBoxBtm��  PauseListBoxItem#��[ $��5 0 5 0q�$��Disabled=�$	��Top=�
������ 
������ ���� *WorkTimeItems+
 �� SelectedItem
 �� *SelectedItem+ �� Mode$ TwoWay=�����  �� Triggers ��  �� Value$ 	Work time�� �� Binding �� *Name+.a���  �� Property � y� �� Value$ 	Collapsed=��� $ 
Break time�� �� *Name+.a���  � y�$ 	Collapsed=�.R��� $	��0 3q� �� 
IsSelected �� *
IsSelected+.��� .+�d� $��btmTest��
�������$��75��$��141.3��#��[  d� 	IsChecked �� *
IsSelected+{��� *	IsEnabled+���� $# DataContext.PauseButton_Click� �� "	 N����� .���� $��Center=�.+�� $��25��.+�F� 
���   � �� Stretch$ Uniform=����� *	ImagePath+�� $��0 0 0 0q�$��Center=�$��Center=����� *Name+�� $��0 0 0 0q� J� Opacity$	 0.5Q�$��Center=�$��Center=����� *WorkTimeSpan+ �� StringFormat$ ({0})������  �� 
TargetType" �� �� Triggers ��  �� *WorkTimeSpan+ 0.a���  � y�$ 	Collapsed=����� .R��  K� IsItemsHost . 