   M S B A M L   `   `   `  ����F  BTimeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TimeManager.PagesTimeManager.Pages  5      =#clr-namespace:TimeManager.ViewModelTimeManager.ViewModel  5      5clr-namespace:TimeManager.ModelTimeManager.Model  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5	      !    TimeManager.Pages.ChartPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TimeManager.Pages     5      3vvm#clr-namespace:TimeManager.ViewModel     5      .vmclr-namespace:TimeManager.Model     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5	        N� 
Background  �#dad4da N� Title$ 	TimeChart��5       � DataContext 5      *   $TimeManager.ViewModel.ChartViewModel  5   
    � 	Resources 5         chartViewModel"   TimeManager.Model.ChartModel  
chartModel)   #TimeManager.ViewModel.UserViewModel  userViewModel��%W   &	        &	      &	 &       5   
   6     5   
   6     5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��10 �6   �� 5      $��* �6   .+�5#   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5$      �� $��0 0 10 0q�6   $��
Date from:��6+   $��Center=�6=   (  "System.Windows.Controls.DatePicker  5%      
 � Tag$ Select a date��6   $��0 2.5 0 2.5q�6.      SelectedDate 6D   �� *SelectedChartInfo.FirstDate+�� 5&      $��	10 0 10 0q�6   $��Date by:��6+   $��Center=�6;     5'      $ Select a date��6   $��0 2.5 0 2.5q�6.    6C   �� *SelectedChartInfo.SecondDate+�� 5(      $��	10 0 10 0q�6   $��User:��6+   $��Center=�68   �� 5)      -   5        $��UserCmb��5)      $	��170��6&   $��0 0 0 0q�62     UserContentComboBox#��[ 6�    �� SelectedItem 6C   �� *SelectedChartInfo+��6n   �� *ChartSelectInfo+��5*      �� 5,      .R�5.      �� ��6$   �� *SelectedUser.FullNameShort+5/      52      �� 5;        ControlPageButton2#��[ 6   $	��130��6B   $��30��6N   $��10 0 0 0q�6Z   ���#41a3dd��6�   �� *Excel_Click+.��5<      �� $ 
Horizontal=�6   .+�5=      �� $��Download report��6    $��0 0 0 0q�67   $��Center=�6H   $
��Left=�6c   6�   (� 5>        ArrowDownIcon#��[ 6   $
��Left=�6F   $��5 0 0 0q�6a   $��20��6r   5@      5A      5C      � 5D   
   $��2��6   	 � ColumnDefinitions	 5E      �� 5F      $��* �6#   �� 5G      $��* �6#   .+�5K      �� $��0 0 2 0q�6   $��1q�6'     CornflowerBlueBrush#��[ 6;   �� 5L      $��1��6   $��0 0 2 0q�6%   $��1q�66   #��[ 6J   � 5�      $��0��6   .+�5�        LiveCharts.Wpf.PieChart  -   5        $��Chart��5�      $��1��6,   &   LiveCharts.Wpf.Charts.Base.Chart
   LegendLocation$
 Bottom=�5�         InnerRadius$	 100Q�6/   $
��0 15q�6A   
���   �   Series 5�   9   �� *SeriesCollection+ 5�        LiveCharts.Wpf.PieSeries �� 
TargetType  LiveCharts.Wpf.Series �� Property �� Value��%_   '        �� 5�      "  6    .�5�      ��  �@ 
Foreground
 �   �6K   5�      5�         ChartLegend 5�      "	  LiveCharts.Wpf.DefaultLegend	  5�       	  
BulletSize$ 20Q�6,   
���   �6R      DataTooltip 5�      #
  LiveCharts.Wpf.DefaultTooltip
  5�       
  
BulletSize$ 20Q�6-   
���   �6R   5�      5�      � 5�      $��1��6   	 5�      �� 5�      $	��39* �6'   �� 5�      $	��61* �6'   .+�5�      &   System.Windows.Controls.DataGrid    BaseDataGrid#��[ 66   $��2��6\   ��6   �� *Dt+5�      5�      5�      5     5     