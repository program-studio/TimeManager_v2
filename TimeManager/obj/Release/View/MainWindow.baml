   M S B A M L   `   `   `  ���� F  BTimeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TimeManagerTimeManager  =#clr-namespace:TimeManager.ViewModelTimeManager.ViewModel  5clr-namespace:TimeManager.PagesTimeManager.Pages  S.clr-namespace:TimeManager.ViewModel.Converters TimeManager.ViewModel.Converters  5clr-namespace:TimeManager.ModelTimeManager.Model      TimeManager.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:TimeManager     2vm#clr-namespace:TimeManager.ViewModel     /appclr-namespace:TimeManager.Pages     E
converters.clr-namespace:TimeManager.ViewModel.Converters     -bclr-namespace:TimeManager.Model     -     � Title$  TimeManager��$	��620��$	��500�� � WindowStyle$
 None=� � AllowsTransparency .  � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=����#dad4da
�������$��1q�'  !System.Windows.Shell.WindowChrome   WindowChrome      CaptionHeight$ 5Q� � DataContext /   )TimeManager.ViewModel.MainWindowViewModel   � 	Resources )   #TimeManager.ViewModel.TaskViewModel   TaskViewModel)   #TimeManager.ViewModel.UserViewModel  UserViewModel)   #TimeManager.ViewModel.TimeViewModel  TimeViewModel    TimeManager.Pages.Reminder  Reminder:  4TimeManager.ViewModel.Converters.BackgroundConverter  	converter:  4TimeManager.ViewModel.Converters.ForegroundConverter  
converterF<	  6TimeManager.ViewModel.Converters.BoolToVisibleOrHidden  BoolToVisibleOrHidden��%i   &	        &	      &	 
     &	      &	      &	      &	                  	  .��� 	 � RowDefinitions	 �� $��30 ��� $��30 ��� $��40 ��� $��10 ��� $��* �.+��� -     ControlButton#��[ $��0��$��0 0 0 0q�$��30��$��Right=�.��� .+�(� $��0��  	CloseIcon#��[ $��15���� -   #��[ $��0��$��0 0 30 0q�$��30��$��Right=�.��� .+�(� $��0�� 	 MinimizeIcon#��[	 $��15���� -   
 ��Name$
 panel1��$��0���� $��1�� �� Orientation$ 
Horizontal=�.+��� $��User:��$��Center=�$��15 0 0 0q��� $��5 0 0 0q�$��Center=�����  �� Source# [  �� Path$ CurrentLogUser� �� Mode$ TwoWay=�� $��2��.+��� $ 
Horizontal=�$��2��.+�(�  
 MonitorIcon#��[
 $��25��$��15 0 0 0q�$
��Left=�$��Center=��� $��Start work: ��$��22(�$��5 0 0 2q�$
��Bold"�$��Center=��� # [ $��22(�$��5 0 0 2q�$
��Bold"�$��Center=����� *SelectedItem.StartTime+ �� StringFormat$ HH:mm:ss���� $ 
Horizontal=�$��2��$��Right=�.+���   ControlPageButton#��[ $��35��$��35��$��2.5 0 2.5 0q�$��Right=�
����������� *CurMainPage_Click+{��� *MainTabItems[0].IsChecked+.��(�   
AlarmIcon2#��[ $��7q��� #��[ $��35��$��35��$��2.5 0 2.5 0q�$��Right=�
����������� *CurChartPage_Click+{��� *MainTabItems[1].IsChecked+.��(�   ChartBar#��[ $��7q�� .+��� #��[ $��35��$��35��$��
2.5 0 15 0q�$��Right=�
����������� *CurTaskPage_Click+{��� *MainTabItems[2].IsChecked+.��(�   	TaskIcon1#��[ $��7q�� $��
24 0 0 20 q� �� *TaskVM+.+�A� $��17��$��17��$��Center=�$��Center=�$�� 0 0 0 0q����� *TaskTabItems[1].Task.Count+ �� 	Converter# [ �� $��11(�$��Center=�$��Center=�$��0 0 0 2q����� *TaskTabItems[1].Task.Count+���� *TaskTabItems[1].Task.Count+# [  � $��4��  � NavigationUIVisibility$ Hidden=����� *CurPageView+�� $��4��$	��250��$��0 0 0 5q�$��Bottom=�$��Right=� �� *TaskVM+.+��� -    ��Name$ ReminderShowButton��#��[ $��Right=�$��0 0 13 3q�$��30��$��30��
������� J� Opacity$	 0.4Q�
���  ��$��1q����� $' !DataContext.ReminderVisible_Click� �� RelativeSource ��  �� AncestorType" ����� .��� .+�(� $��0��  ReminderIcon#��[ $��15��$��0 0 1 0q�$	 0.8Q�$��Center=�$��Center=��� -    ��Name$ listBoxReminder��$��4��
������ $	��258��$	��125��$��Bottom=�$��Right=�$	��0 0q�
������ y��� *	IsVisible+# [ ���� *TaskTabItems[1].Task+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=����� .R��� .��� 
������ $	��233��$��40��$��0 0 0 2q�.+��� $��0q�
����������#ffb3b1$��1q� �� CornerRadius$ 8�� J� Effect 3
  -System.Windows.Media.Effects.DropShadowEffect
   
  Color$
 Gray�� 
  Opacity$	 0.2Q��  � ColumnDefinitions �� $��40 ��� $��* �.+�(� $��0��#��[ $��18��$��5q�� $��1��	 �� $��* ��� $��* �.+�� $��0�� �� $	��115 ��� $��* �.+��� $��0��$��0��$��0q�$��Center=�$��12(�$
��Bold"����� *
TaskName+�� $��0��$��1��$��0q�$��Center=�$��10(����� *ReminderTime+$ dd.MM.yy (HH:mm)���� $��1��$��0q�$	��Top=�$��9(�$
��Bold"����� *
TaskBody+