   M S B A M L   `   `   `  ���� F  BTimeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TimeManagerTimeManager  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ComboBoxToggleButton  �� 
TargetType � ColumnDefinitions ��Name �� CornerRadius  
WhiteBrush F�Name  	GrayBrush �� Triggers P� Property P� Value �� 
TargetName  GainsboroBrush	 �� Value
 �� Property  ComboBoxTextBox  MainContentComboBox �� 
TargetType  BaseFont �� 	ClickMode d� 	IsChecked �� Path �� Mode �� RelativeSource J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name �� TextAlignment �� 
IsReadOnly �� 
IsReadOnly �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth  CustomScrollViewer K� IsItemsHost-   'System.Windows.Input.KeyboardNavigation    DirectionalNavigation P� 
SourceName �� Padding  UserContentComboBox�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     #localclr-namespace:TimeManager  %3  &	        7  7  7  7  &	 �    &	 �    7  7   7  7  7  7  '�� �    &	 �	    7  7   7  7  7  7  �� "  d�.R��  �� $��* ��� $��20 �.+��� $ Border��$��2��$ 0��8��  ���	#FF97A0A5$��1q��� $
 Fill��$��0��$ 0��$��1q�#��z�����	#FF97A0A5$��0,0,1,0q�F� $ Arrow��$��1��8�� $��Center=�$��Center=�=����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	 P�  �@J�IsMouseOver . . ��� $ Border��8	  
 � ���� $
 Fill��8	  
 � ���� "  ��.R��� $ PART_ContentHost��|�.  #��z���� " ��.��� 
 � ��$		 0 0q��� 
 � ��$	 25���� 
 � ��8	   �� 
 �@J�SnapsToDevicePixels	 . �� 
 �@�OverridesDefaultStyle	 . �� 
 � ��$
	 Auto=��� 
 � ��$
	 Auto=��� 
 � ��	 . �� 
 � ��$	 40���� 
 � ��$	 20���� 
 � ��
	 �   ��� 
 � ��	 �� "  ��.R�� .+�d� $��ToggleButton��8�� $��2��|�.  $ Press=�
������� �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+�� $��ContentSite�� .  #��z $��Center=�#��z #��z��$��3,3,23,3q�$��Center=��� $ PART_EditableTextBox��8�� #��z��# z��$��Center=�$��3,3,23,3q�|�. 8�� 
��� � �$y�Hidden=�# z ��Z� � $��Popup��$��Bottom=�#��z  . |�.  $��Slide=�.��� $��DropDown�� . #��z $	��100��.+��� $ DropDownBorder��8�� $��1q����#888888�� $��4,6,4,6q� . 8�� .����  . $ 	Contained=� P�  �@��HasItems .  . ��� $ DropDownBorder��
 � ��$	 95��P�  � {� .  . ��� 
 � ��	 �#888888P�  �@��
IsGrouping . . ��� 
 � ��	 .  P� $ Popup�� �@�AllowsTransparency . . ��� $ DropDownBorder��
 �@��CornerRadius$	 0���� $ DropDownBorder��
 � ��$	 0,2,0,0q�P�  �@��
IsEditable . . ��� 
 � ��	 .  �� $ PART_EditableTextBox��
 � y�$	 Visible=��� $ ContentSite��
 � y�$	 Hidden=�P�  �@��SelectedValue$
 high��. ��� $ ToggleButton��
 � ��	 �#f4656d�� 
 � ��
	 �����P�  �@��SelectedValue$ normal��. ��� $ ToggleButton��
 � ��	 �#9ab740�� 
 � ��
	 �����P�  �@��SelectedValue$	 low��. ��� $ ToggleButton��
 � ��	 �#ffdc7f�� 
 � ��
	 ������� " ��.��� 
 �@J�SnapsToDevicePixels	 . �� 
 � ��
	 �   ��� 
 �@�OverridesDefaultStyle	 . �� 
 � ��	 �� "  ��.R��� $��Border��$ 2q� . ._���  P�  �@��IsHighlighted . . ��� $ Border��
 � ��
	 �����P�  � {� .  . ��� 
 � ��	 �#888888�� " ��.��� 
 � ��$		 0 0q��� 
 � ��$	 25���� 
 � ��8	   �� 
 �@J�SnapsToDevicePixels	 . �� 
 �@�OverridesDefaultStyle	 . �� 
 � ��$
	 Auto=��� 
 � ��$
	 Auto=��� 
 � ��	 . �� 
 � ��$	 40���� 
 � ��$	 20���� 
 � ��
	 �   ��� 
 � ��	 �� "  ��.R�� .+�d� $��ToggleButton��8�� $��2��|�.  $ Press=�
������� �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+�� $��ContentSite�� .  #��z $
��Left=�#��z #��z��$��5,3,23,3q�$��Center=��� $ PART_EditableTextBox��8�� #��z��# z��$��Center=�$��3,3,23,3q�|�. 8�� 
��� � �$y�Hidden=�# z ��Z� � $��Popup��$��Bottom=�#��z  . |�.  $��Slide=�.��� $��DropDown�� . #��z $	��100��.+��� $ DropDownBorder��8�� $��1q����#888888�� $��4,6,4,6q� . 8�� .����  . $ 	Contained=� P�  �@��HasItems .  . ��� $ DropDownBorder��
 � ��$	 95��P�  � {� .  . ��� 
 � ��	 �#888888P�  �@��
IsGrouping . . ��� 
 � ��	 .  P� $ Popup�� �@�AllowsTransparency . . ��� $ DropDownBorder��
 �@��CornerRadius$	 0���� $ DropDownBorder��
 � ��$	 0,2,0,0q�P�  �@��
IsEditable . . ��� 
 � ��	 .  �� $ PART_EditableTextBox��
 � y�$	 Visible=��� $ ContentSite��
 � y�$	 Hidden=�P�  �@��SelectedValue$
 high��. ��� $ ToggleButton��
 � ��	 �#f4656d�� 
 � ��
	 �����P�  �@��SelectedValue$ normal��. ��� $ ToggleButton��
 � ��	 �#9ab740�� 
 � ��
	 �����P�  �@��SelectedValue$	 low��. ��� $ ToggleButton��
 � ��	 �#ffdc7f�� 
 � ��
	 �����