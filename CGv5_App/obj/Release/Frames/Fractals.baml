   M S B A M L   `   `   `  ���� C  ?CGv5_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CGv5_App.FramesCGv5_App.Frames      CGv5_App.Frames.Fractals   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:CGv5_App.Frames     X TXceed.Wpf.Toolkit, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    N� Title$  CGv5 | Generate Fractals�� � 	Resources    CustomButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property	 P� Value��%�  &	        �� " ��.���  � ��$
 16px(���  � �� �#2196F3��  � ��
 �������  � ��$ 1q���  � �� �#1565C0��  � ��$	 100����  � �� �� " ��.R��� #��z��#��z��#��z��$ 5��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver	 . . ���  � �� �#1976D2��  � �� �#115293P�  � {�	 .  . ���  � ��
 �������  � ��
 �����.��� $��10q����	#FFFAFAFA
 � RowDefinitions
 �� $��3* � � ColumnDefinitions �� $��3* ��� $��2* �.+�� -   $��	ImageGrid��$��0��$��0q�.+��� -   $��ImageBorder�����	#FFACACAC$	��1.5q�._��� -   $��image�� � ForceCursor .  � Cursor$
 Hand��� $��1��$��10q�.+�� $��Center=�$��0,0,0,50q�
 �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��20(�$
��Bold"�$��0,0,0,6q�Fractal Options]� $��1��$��0,0,0,10q�.+��� $��Select Fractal: ��$��Center=�$��16(��� -   $��FractalTypeCB��$��10,0,0,0q�$��16(�.@��� -   $��MandelbrotCBI��$��
Mandelbrot�� �� 
IsSelected . �� -   $��PythagorasCBI��$��Pythagoras Tree���� -   $��ColorScheme��$��2��$��0,0,0,10q�{���  �� ElementName$ MandelbrotCBI�� �� Path$ 
IsSelected�.+��� $��Select Color Scheme: ��$��Center=�$
��Bold"�$��16(�$
��Left=�$��	0,10,0,10q�]� $��0,0,0,10q�.+��� $��	Color 1: ��$��Center=�$��16(�$
��Left=�$��0,0,5,0q�#  Xceed.Wpf.Toolkit.ColorPicker  -   $��ColorPicker1��   SelectedColor$ BlackX�]� $��0,0,0,10q�.+��� $��	Color 2: ��$��Center=�$��16(�$
��Left=�$��0,0,5,0q�  -	   $��ColorPicker2��$ 	RoyalBlueX�]� $��0,0,0,10q�.+��� $��	Color 3: ��$��Center=�$��16(�$
��Left=�$��0,0,5,0q�  -
   $��ColorPicker3��$
 CyanX�]� $��0,0,0,10q�.+��� $��	Color 4: ��$��Center=�$��16(�$
��Left=�$��0,0,5,0q�  -   $��ColorPicker4��$
 GoldX�]� $��0,0,0,10q�.+��� $��	Color 5: ��$��Center=�$��16(�$
��Left=�$��0,0,5,0q�  -   $��ColorPicker5��$	 RedX�]� $��3��$��0,5,0,18q�{��� $ MandelbrotCBI��$ 
IsSelected�.+��� $��Scale: ��$
��Bold"�$��Center=�$��16(�$
��Left=��� -   $��ScaleSlider�� � Minimum$ 0.000001Q� � Maximum$
 0.01Q� � Value$ 0.007Q�$��Right=�$��2,3,0,0q��� -   $��Generate Fractal��#��[  $��4��$��35��