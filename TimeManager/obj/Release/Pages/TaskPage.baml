   M S B A M L   `   `   `  ���� F  BTimeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TimeManager.PagesTimeManager.Pages  =#clr-namespace:TimeManager.ViewModelTimeManager.ViewModel  S.clr-namespace:TimeManager.ViewModel.Converters TimeManager.ViewModel.Converters       TimeManager.Pages.TaskPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:TimeManager.Pages     3vmt#clr-namespace:TimeManager.ViewModel     E
converters.clr-namespace:TimeManager.ViewModel.Converters       N� 
Background  �#dad4da N� Title$ TaskPage�� � DataContext )   #TimeManager.ViewModel.TaskViewModel   � 	Resources :  4TimeManager.ViewModel.Converters.BackgroundConverter   	converter��%   &	          .���  � RowDefinitions �� $��30 ��� $��* ��� $��50 � � ColumnDefinitions �� $	��200 ��� $��* ��� $��* �.+�� $��0��$��1��$��5 0 0 0q�.+��� .���� -   $��CategoryListBox�����#dde2e3$��1q����#c5c9c3  SimpleListBoxItem#��[ ���� *TaskTabItems+ �� SelectedItem �� *SelectedItem+ �� Mode$ TwoWay=����� .R�� $��30��$��0 0 0 0q�.+���  �� Orientation$ 
Horizontal=�$��Stretch=�.+�� $	��126��.+��� $��Center=�$��5 0 0 0q����� *CategoryName+� .+�A� $��17��$��17��$��Center=�$��Center=�$�� 0 0 0 0q����� *
Task.Count+	 �� 	Converter#	 [  �� 
�������$��11(�$��Center=�$��Center=�$��0 0 0 0q����� *
Task.Count+���� 
 �� 
TargetType"
 �� �� Triggers ��  �� Binding �� *
Task.Count+ �� Value 0.a���  �� Property � �� �� Value
 ���� ��  ��Name$ DrawCircleButton2��  ControlTaskButton#��[ $��Right=�$	��Top=�$��10 2 0 0q�$��15��$��15��
������ 
������ $��0q�{��� *
CanDeleted+����  �� Path$&  DataContext.RemoveCategory_Click� �� RelativeSource ��  �� AncestorType" N����� .��� .+�(� $��0��  CloseTaskIcon#��[ $��15��� $��1��$��1��.+��� .���� -   $��TaskListBox�����#dde2e3$��1q����#c5c9c3#��[ ���� *SelectedItem.Task+ �� *SelectedSubItem+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedIndex �� *SelectedItem/Task+$ TwoWay=����� .R�� .+��� $ Vertical=�$��60��$	��372��.+��� $ 
Horizontal=�$��25��.+��� $��Center=�$	��175��$��5 0 0 0q�$
��Bold"�$��13(�$��WordEllipsis=����� *
TaskName+�� $ Vertical=�$��5 0 5 0q�.+��� $��Center=�$��Center=�$��9(�
����������� *
CreateTime+ �� StringFormat$ 
dd.MM.yyyy���� $��Center=�$��Center=�$��9(�
����������� *
CreateTime+$ 
(HH:mm:ss)��� $��45��.+��� $��45��$��20�� �� RadiusX$ 10�� �� RadiusY$ 10��$��0 0 0 0q�$��Center=�$��Center=����� "
 �� ��  �� $ Priority� high.a���  � �� �#f4656d��  �� $ Priority�
 normal.a���  � �� �#9ab740��  �� $ Priority� low.a���  � �� �#ffdc7f�� $��Center=�$��0 0 0 0q�$��Center=�
����������� *
Priority+�� $��1��$
��Left=�$��Center=�$��10 0 0 0q�  FavoriteCheckBoxClasic#��[  d� 	IsChecked �� *
IsFavorite+$ TwoWay=��� $��1��$��5 0 0 0q�$
��Left=�$��Center=�  ReminderCheckBoxClasic#��[  �� *
IsReminder+$ TwoWay=��� $ DrawCircleButton��#��[ $��Center=�$��10 0 0 0q�$��20��$��20��
������ 
������ $��0q����� $" DataContext.RemoveTask_Click� �� " N����� .��� .+�(� $��0��#��[ $��20���� $��Center=�$��5 0 0 0q�$
��Wrap=�$��WordEllipsis=����� *
TaskBody+� $��2��$��1�����#dde2e3$��0 0 5 0q� �� $��32 ��� $��30 ��� $��30 ��� $��30 ��� $��30 ��� $��30 ��� $��* �.+��� $��0��  DefaultBorderContent#��[ $��3 2 3 0q�._�� $��0��
������  �� *SelectedItem+ �� $	��100 ��� $��* �.+��� $��0��$��	Category:��$��Center=�$��10 0 0 0q��� $��0q�$��Center=�$��1��$��0 1 10 1q����� *CategoryName+$ PropertyChanged=�{��� *
CanDeleted+�� $��1��#��[ ._�� $��1��
������  �� *SelectedSubItem+$ TwoWay=� �� $	��100 ��� $��* �.+��� $��0��$��Name:��$��Center=�$��10 0 0 0q��� $��1��$��0q�$��Center=�$��0 1 10 1q����� *
TaskName+$ PropertyChanged=��� $��2��#��[ ._�� $��2��
������  �� *SelectedSubItem+ �� $	��100 ��� $��* �.+��� $��0��$��	Priority:��$��Center=�$��10 0 0 0q�� $��70��$��1��$
��Left=�$��0 0 0 0q�.+��� $��1��  MainContentComboBox#��[ ���� *PriorityList+ �� *
Priority+�� $��3��#��[ ._�� $��3��
������  �� *SelectedSubItem+ �� $	��100 ��� $��* �.+��� $��0��$��	Favorite:��$��Center=�$��10 0 0 0q��� $��1��$��5 0 0 0q�$
��Left=�$��Center=�#��[  �� *
IsFavorite+$ TwoWay=��� $��4��#��[ ._�� $��4��
������  �� *SelectedSubItem+ �� $	��100 ��� $��* �.+��� $��0��$��Created:��$��Center=�$��10 0 0 0q��� $��1��$��Center=�$��0 0 0 0q����� *
CreateTime+$ dd.MM.yyyy (HH:mm)���� $��5��#��[ ._�� $��5��
������  �� *SelectedSubItem+.+��� $ 
Horizontal=�.+��� $��90��$��	Reminder:��$��Center=�$��10 0 0 0q��� $��1��$��5 0 0 0q�$
��Left=�$��Center=�#��[ ���� $&  DataContext.ReminderActive_Click� �� " N����� *
IsReminder+ �� *Self+$ OneWay=� �� *
IsReminder+$ TwoWay=�(  "System.Windows.Controls.DatePicker  $	��110��$��25��
 � Tag$ Select a date��$��8 0 0 0q�   SelectedDate �� *ReminderTime+{��� *
IsReminder+$ TwoWay=�� $��50��$
��Left=�$��5 0 0 0q�.+��� $��1��#��[ ���� *
HourList+ �� *ChackedHour+{��� *
IsReminder+$ TwoWay=��� $��:��$��Center=�$��Center=�$��5 0 0 0q�� $��50��$
��Left=�$��5 0 0 0q�.+��� $��1��#��[ ���� *
MinuteList+ �� *ChackedMinute+{��� *
IsReminder+$ TwoWay=��� $��6��#��[ $��3 0 3 2q�._�� $��6��
������  �� *SelectedSubItem+.+��� 
������ $	��420�� �� TextWrapping$
 Wrap=� �� AcceptsReturn .  �� 	IsEnabled .  � Language$ en-US�$	��Top=�$��5 10 5 5q����� *
TaskBody+$ PropertyChanged=��� $��0��$��2��  ControlPageButton#��[ 
�������$��35��$��35��$��0 0 0 0q�$��Center=�$��Center=����� *AddCategory_Click+.��� $��Center=�$��Center=�.+��� $��+��$��40(�$��Center=�$��Center=�$��
0,-13,0,-5q�  J� Opacity$	  0.5Q��� $��1��$��2��#��[ 
�������$��35��$��35��$��0 0 0 0q�$��Center=�$��Center=����� *AddTask_Click+.��� $��Center=�$��Center=�.+��� $��+��$��40(�$��Center=�$��Center=�$��
0,-13,0,-5q�$	  0.5Q��� $	��110��$��Center=�$��	50 0 10 0q� �� *ReminderItem+$ TwoWay=����� *
TaskName+$ TwoWay=�$ PropertyChanged=��� $��1��$��Center=�$��5 0 0 0q����� *SelectedTask.TaskName+$ TwoWay=�$ PropertyChanged=�