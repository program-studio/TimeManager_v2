   M S B A M L   `   `   `  ���� F  BTimeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TimeManagerTimeManager  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ColumnHeaderGripperStyle  �� 
TargetType �� Property �� Value �� 
TargetType �� Padding  DeafultColumnHeaderDataGrid=   7System.Windows.Controls.Primitives.DataGridColumnHeader  GainsboroBrush  	GrayBrush � RowDefinitions F�Name �� Stretch J� RenderTransformOrigin	 n�Name
 �� Triggers P� Property P� Value �� 
TargetName �� Angle �� Padding �� TextAlignment ! FilteringColumnHeaderDataGrid � ColumnDefinitions ��Name  TransparentButton  
FilterIcon  DefultRowDataGrid)  #System.Windows.Controls.DataGridRow  FilteringCellRowDataGrid*  $System.Windows.Controls.DataGridCell J� SnapsToDevicePixels 	 LightSlateGrayBrush �� Triggers 
 BaseDataGrid&   System.Windows.Controls.DataGrid  DefaultPageBackgroungBrush  DeafultDataGrid �� BasedOn  FilteringDataGrid�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     #localclr-namespace:TimeManager  %�  &	        &	 �     7  7  7  7  7   7   &	 �    7  7  7  7   7   7  7  &	 i    &	 �    7 	 &	
 �    7  7  7  7  &	 �
    7 
 7  &	 �
    7 
 7  �� "  n�.���  � ��$ 8����  � ��
 ���� ��  �@�Cursor$ SizeWE����  � �� �� " n�.R��� #��z��# z���� "    .���  � ��8   ��  � ��$ 0.5 0 0.5 0q���  � ��8  ��  � ��$ 50����  � ��$ Stretch=���  � �� �� "   .R�� .+��� $��0.5 0 0.5 0q�8�� ._�� 8�� .+��  �� $��6 ��� $��* �.+�F� $ 	SortArrow��$��Center=�$��Center=�$��8��$	��2 0q�$
 Fill=�
���   �$ 0.5,0.4&�$y�	Collapsed=�"����        �@B     � � @B 	�� $��1��n� $	 PART_LeftHeaderGripper��$
��Left=�8�� n� $	 PART_RightHeaderGripper��$��Right=�8�� 
 P�  �@  SortDirection$ 	AscendingX�. ��� $ 	SortArrow�� � y�$ Visible=��� $ 	SortArrow�� � z� �� $	 180Q�P�  �@  SortDirection$ 
DescendingX�. ��� $ 	SortArrow�� � y�$ Visible=���  � �� �� .R��� $ 5q�$
��Wrap=�$ Center=�$��Center=�$
��Bold"����� �� "    .���  � ��8   ��  � ��$ 50����  � ��$ Stretch=���  � ��$
 Bold"���  � �� �� "   .R�� .+��� $��0.5 0 0.5 0q�8�� ._�� 8��  �� $��6 ��� $��* �.+�F� $ 	SortArrow��$��Center=�$��Center=�$��8��$	��2 0q�$
 Fill=�
���   �$ 0.5,0.4&�$y�	Collapsed=�"����        �@B     � � @B 	�� $��1��n� $	 PART_LeftHeaderGripper��$
��Left=�8�� n� $	 PART_RightHeaderGripper��$��Right=�8�� 
 P�  �@  SortDirection$ 	AscendingX�. ��� $ 	SortArrow�� � y�$ Visible=��� $ 	SortArrow�� � z� �� $	 180Q�P�  �@  SortDirection$ 
DescendingX�. ��� $ 	SortArrow�� � y�$ Visible=���  � �� �� .R�� $	��5 0q� �� $��* ��� $��20 �.+��� $ 5q�$
��Wrap=�$��Center=�$ Center=����� �� $ tbSearch��$��1��$��16��$��Center=�8�� .��(� 8�� �� "   .���  � ��$ 35���� "   .���  � ��$ 30q���  � ��$ 0q���  �@�Cursor$
 Hand����  � �� �� "  .R��� $��Border��$ 5q�
������ $��0q� . ._��� $	��2 5q�# z $��Center=�
 P�  �@ 
IsSelected . . ��� $ Border��8    � �� P�  �@ 
IsSelected . . ���  � ��
 �   ��� "   .���  �@J�SnapsToDevicePixels . ��  � �� . ��  �@��PanningMode$
 Both=���  �@ CanUserAddRows .  ��  �@ CanUserDeleteRows .  ��  �@ AutoGenerateColumns . ��  � ��$ Stretch=���  � ��$ 5q���  �@ GridLinesVisibility$
 None=���  � ��8   ��  �@ RowBackground8  ��   �@ AlternatingRowBackground8  ��  �@ 	CellStyle8  �� "   8   .���  �@ ColumnHeaderStyle8  �� "   8   .���  �@ ColumnHeaderStyle8  