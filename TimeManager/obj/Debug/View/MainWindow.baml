   M S B A M L   `   `   `  ����F  BTimeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TimeManagerTimeManager  5   	   =#clr-namespace:TimeManager.ViewModelTimeManager.ViewModel  5   	   5clr-namespace:TimeManager.PagesTimeManager.Pages  5   	   S.clr-namespace:TimeManager.ViewModel.Converters TimeManager.ViewModel.Converters  5	   	   5clr-namespace:TimeManager.ModelTimeManager.Model  5
          TimeManager.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TimeManager     5   	   2vm#clr-namespace:TimeManager.ViewModel     5   	   /appclr-namespace:TimeManager.Pages     5   	   E
converters.clr-namespace:TimeManager.ViewModel.Converters     5	   	   -bclr-namespace:TimeManager.Model     5
      -   5          � Title$  TimeManager��5   	   $	��620��6   $	��500��6*    � WindowStyle$
 None=�67    � AllowsTransparency .  � 
ResizeMode$ NoResize=�6d    � WindowStartupLocation$ CenterScreen=�6z   ���#dad4da
�������$��1q�6�   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 5Q�6    � DataContext 5      /   )TimeManager.ViewModel.MainWindowViewModel  5   
    � 	Resources 5      )   #TimeManager.ViewModel.TaskViewModel   TaskViewModel)   #TimeManager.ViewModel.UserViewModel  UserViewModel)   #TimeManager.ViewModel.TimeViewModel  TimeViewModel    TimeManager.Pages.Reminder  Reminder:  4TimeManager.ViewModel.Converters.BackgroundConverter  	converter:  4TimeManager.ViewModel.Converters.ForegroundConverter  
converterF<	  6TimeManager.ViewModel.Converters.BoolToVisibleOrHidden  BoolToVisibleOrHidden��%�   &	        &	      &	 &     &	 9     &	 L     &	 _     &	 r       5   
   6     5   
   6     5   
   6     5   
   6     5   
   6)     5   
   6)   	  5   
   6+   5       .��5-      � 	 � RowDefinitions	 5H   
   �� 5I      $��30 �6   �� 5J      $��30 �6   �� 5K      $��40 �6   �� 5L      $��10 �6   �� 5M      $��* �6   .+�5Q   
   �� -   5          ControlButton#��[ 5Q      $��0��68   $��0 0 0 0q�6E   $��30��6V   $��Right=�6b   .��5R      � .+�5S      (� $��0��6     	CloseIcon#��[ 6'   $��15��6J   5T      5U      �� 5V   
   -   5        #��[ 5V      $��0��68   $��0 0 30 0q�6E   $��30��6W   $��Right=�6c   .��5W      � .+�5X      (� $��0��6    	 MinimizeIcon#��[	 6'   $��15��6M   5Y      5Z      �� 5]   
   -   5        
 ��Name$
 panel1��5]      $��0��6   60   �� 5_   
   $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5`      �� $��User:��6   $��Center=�6&   $��15 0 0 0q�6B   �� 5a      $��5 0 0 0q�6   $��Center=�6,   ��6H   ��  �� Source# [  �� Path$ CurrentLogUser� �� Mode$ TwoWay=�6�   5b      � 5d   
   $��2��6   .+�5e      �� $ 
Horizontal=�6   $��2��63   .+�5f      (�  
 MonitorIcon#��[
 6   $��25��6@   $��15 0 0 0q�6K   $
��Left=�6]   $��Center=�6x   �� 5g      $��Start work: ��6   $��22(�61   $��5 0 0 2q�6?   $
��Bold"�6P   $��Center=�6b   �� 5h      # [ 6   $��22(�6�   $��5 0 0 2q�6�   $
��Bold"�6�   $��Center=�6�   ��6J   �� *SelectedItem.StartTime+ �� StringFormat$ HH:mm:ss��6�   5i      �� 5k      $ 
Horizontal=�6   $��2��63   $��Right=�6@   .+�5l      ��   ControlPageButton#��[ 6   $��35��6D   $��35��6O   $��2.5 0 2.5 0q�6[   $��Right=�6p   
���������6�   �� *CurMainPage_Click+{�6�   �� *MainTabItems[0].IsChecked+.��5n      (�   
AlarmIcon2#��[ 6   $��7q�6D   5o      �� 5r      #��[ 6   $��35��6D   $��35��6O   $��2.5 0 2.5 0q�6[   $��Right=�6p   
���������6�   �� *CurChartPage_Click+{�6�   �� *MainTabItems[1].IsChecked+.��5s      (�   ChartBar#��[ 6   $��7q�6B   5t      � 5v      .+�5z      �� #��[ 6   $��35��6H   $��35��6S   $��
2.5 0 15 0q�6_   $��Right=�6s   
���������6�   �� *CurTaskPage_Click+{�6�   �� *MainTabItems[2].IsChecked+.��5{      (�   	TaskIcon1#��[ 6#   $��7q�6G   5|      � 5~      $��
24 0 0 20 q�6    60   �� *TaskVM+.+�5�      A� $��17��6t   $��17��6�   $��Center=�6�   $��Center=�6�   $�� 0 0 0 0q�6�   ��6"   �� *TaskTabItems[1].Task.Count+ �� 	Converter# [ 5�      �� 5�      $��11(�6�   $��Center=�6�   $��Center=�6�   $��0 0 0 2q�6�   ��6&   �� *TaskTabItems[1].Task.Count+��6R   �� *TaskTabItems[1].Task.Count+# [ 5�      5�      5�      5�      5�       � 5�   
   $��4��6     � NavigationUIVisibility$ Hidden=�6=   ��6   �� *CurPageView+6=   �� 5�   
   $��4��6   $	��250��6A   $��0 0 0 5q�6M   $��Bottom=�6^   $��Right=�6y    6"   �� *TaskVM+.+�5�      �� -   5         ��Name$ ReminderShowButton��5�      #��[ 67   $��Right=�5�   %   $��0 0 13 3q�6A   $��30��6S   $��30��6^   
������� J� Opacity$	 0.4Q�5�   �   
���  ��$��1q�6�   ��6%   �� $' !DataContext.ReminderVisible_Click� �� RelativeSource ��  �� AncestorType" ���6�   �� .��5�      � .+�5�      (� $��0��6"     ReminderIcon#��[ 6/   $��15��6U   $��0 0 1 0q�6`   $	 0.8Q�6q   $��Center=�6   $��Center=�6�   5�      5�      �� 5�      -   5         ��Name$ listBoxReminder��5�      $��4��5�      
������ $	��258��6>   $	��125��6J   $��Bottom=�6Z   $��Right=�6u   $	��0 0q�5�      
������ y�5�   /   �� *	IsVisible+# [ ��5�   #   �� *TaskTabItems[1].Task+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���5�      �� 5�      .R�5�      �� .��5�      � 
������ $	��233��6<   $��40��6H   $��0 0 0 2q�6T   .+�5�   "   �� $��0q�6)   
����������#ffb3b1$��1q�6]    �� CornerRadius$ 8��6q    J� Effect 5�   &   3
  -System.Windows.Media.Effects.DropShadowEffect
  5�   *    
  Color$
 Gray��6;    
  Opacity$	 0.2Q�6H   5�   #   � 5�   "    � ColumnDefinitions 5�   &   �� 5�   *   $��40 �6;   �� 5�   *   $��* �6;   .+�5�   &   (� $��0��6.   #��[ 6>   $��18��6d   $��5q�6o   � 5�   &   $��1��6+   	 5�   *   �� 5�   .   $��* �6<   �� 5�   .   $��* �6<   .+�5�   *   � $��0��6/    5�   .   �� 5�   2   $	��115 �6C   �� 5�   2   $��* �6C   .+�5�   .   �� $��0��68   $��0��6E   $��0q�6V   $��Center=�6a   $��12(�6�   $
��Bold"�6�   ��6|   �� *
TaskName+6�   �� 5�   .   $��0��68   $��1��6E   $��0q�6U   $��Center=�6`   $��10(�6�   ��6{   �� *ReminderTime+$ dd.MM.yy (HH:mm)��6�   5�   +   �� 5�   *   $��1��64   $��0q�6A   $	��Top=�6L   $��9(�6~   $
��Bold"�6�   ��6d   �� *
TaskBody+6�   5�   '   5�   #   5�      5�      5�      5�      5�      5�     5�     