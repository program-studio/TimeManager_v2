   M S B A M L   `   `   `  ���� F  BTimeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TimeManager.PagesTimeManager.Pages  =#clr-namespace:TimeManager.ViewModelTimeManager.ViewModel  5clr-namespace:TimeManager.ModelTimeManager.Model  U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf !    TimeManager.Pages.ChartPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:TimeManager.Pages     3vvm#clr-namespace:TimeManager.ViewModel     .vmclr-namespace:TimeManager.Model     Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf       N� 
Background  �#dad4da N� Title$ 	TimeChart�� � DataContext *   $TimeManager.ViewModel.ChartViewModel   � 	Resources    chartViewModel"   TimeManager.Model.ChartModel  
chartModel)   #TimeManager.ViewModel.UserViewModel  userViewModel��%-   &	        &	      &	 
           .���  � RowDefinitions �� $��30 ��� $��10 ��� $��* �.+��� $��0�� �� Orientation$ 
Horizontal=�$��Center=�.+��� $��0 0 10 0q�$��
Date from:��$��Center=�(  "System.Windows.Controls.DatePicker  
 � Tag$ Select a date��$��0 2.5 0 2.5q�   SelectedDate �� *SelectedChartInfo.FirstDate+�� $��	10 0 10 0q�$��Date by:��$��Center=�  $ Select a date��$��0 2.5 0 2.5q� �� *SelectedChartInfo.SecondDate+�� $��	10 0 10 0q�$��User:��$��Center=��� -   $��UserCmb��$	��170��$��0 0 0 0q�  UserContentComboBox#��[  �� SelectedItem �� *SelectedChartInfo+���� *ChartSelectInfo+���� .R��� ���� *SelectedUser.FullNameShort+��   ControlPageButton2#��[ $	��130��$��30��$��10 0 0 0q����#41a3dd���� *Excel_Click+.���� $ 
Horizontal=�.+��� $��Download report��$��0 0 0 0q�$��Center=�$
��Left=�(�   ArrowDownIcon#��[ $
��Left=�$��5 0 0 0q�$��20��� $��2��	 � ColumnDefinitions	 �� $��* ��� $��* �.+��� $��0 0 2 0q�$��1q�  CornflowerBlueBrush#��[ �� $��1��$��0 0 2 0q�$��1q�#��[ � $��0��.+�  LiveCharts.Wpf.PieChart  -   $��Chart��$��1��&   LiveCharts.Wpf.Charts.Base.Chart
   LegendLocation$
 Bottom=�   InnerRadius$	 100Q�$
��0 15q�
���   �   Series �� *SeriesCollection+   LiveCharts.Wpf.PieSeries �� 
TargetType  LiveCharts.Wpf.Series �� Property �� Value��%:   '        �� "  .���  �@ 
Foreground
 �   �   ChartLegend "	  LiveCharts.Wpf.DefaultLegend	   	  
BulletSize$ 20Q�
���   �   DataTooltip #
  LiveCharts.Wpf.DefaultTooltip
   
  
BulletSize$ 20Q�
���   �� $��1��	 �� $	��39* ��� $	��61* �.+�&   System.Windows.Controls.DataGrid    BaseDataGrid#��[ $��2������ *Dt+