   M S B A M L   `   `   `  ���� C  ?CGv5_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CGv5_App.Frames.HelpPagesCGv5_App.Frames.HelpPages  ,    &CGv5_App.Frames.HelpPages.FractalsHelp   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     9local'clr-namespace:CGv5_App.Frames.HelpPages     X TXceed.Wpf.Toolkit, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    N� Title$%  CGv5 | Generate Fractals | Help�� � 	Resources    CustomButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property	 P� Value  	BoolToVis��%{  &	        &	 b    �� " ��.���  � ��$
 16px(���  � �� �#2196F3��  � ��
 �������  � ��$ 1q���  � �� �#1565C0��  � ��$	 100����  � �� �� " ��.R��� #��z��#��z��#��z��$ 5��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver	 . . ���  � �� �#1976D2��  � �� �#115293�� .���� ���	#FFECF1FF$��50, 10, 50, 10q�.���� 
 �� Orientation$
 Vertical=�$��Center=�$��Center=�.+��� $��0, 20, 0, 10q�$��Center=�$
��Wrap=�$)��#It's a Help Materials for Fractals!��$��24(�$
��Bold"��� $��0, 10, 0, 10q�$��Center=�$
��Wrap=����#2196F3$A��;Please, read carefully to understand program functionality!��$��24(�$
��Bold"��� $��0, 10q�.+��� $��1. Fractal Options:��$
��Bold"�$��20(�$��0, 0, 0, 10q�]� $��0,0,0,15q�.+��� $��1.1. Select Fractal: ��$��Center=�$��18(��� -   $��FractalTypeCB��$��10,0,0,0q�$��18(�{�.  .@��� -   $��MandelbrotCBI��$��
Mandelbrot�� �� 
IsSelected . �� -   $��PythagorasCBI��$��Pythagoras Tree���� $
��Wrap=�$��0,0,0,10q�$��15(�$��Italic$���Choose the type of fractal you want to generate. The Mandelbrot fractal is a classic and versatile option, while the Pythagoras Tree offers a unique and visually appealing structure.�� -   $��ColorScheme��{�.  $��0,0,0,15q�.+��� $ ��1.2. Select Color Scheme: ��$��Center=�$
��Bold"�$��18(�$
��Left=�$��	0,10,0,10q�]� $��0,0,0,10q�.+��� $��	Color 1: ��$��Center=�$��18(�$
��Left=�$��0,0,5,0q�#  Xceed.Wpf.Toolkit.ColorPicker  -   $��ColorPicker1��   SelectedColor$ BlackX�{�.  ]� {�.  $��0,0,0,0q�.+��� $��Scale: ��$
��Bold"�$��Center=�$��18(�$
��Left=��� -   $��ScaleSlider�� � Minimum$ 0.000001Q� � Maximum$
 0.01Q� � Value$ 0.007Q�$��Right=�$��2,3,0,0q��� $
��Wrap=�$��0,0,0,30q�$��15(�$��Italic$���1.2.1 Customize the visual appearance of your fractal by selecting a color scheme. Adjust the colors and scale for a personalized and visually stunning result.�� $��1.3. Generate Fractal��#��[  $��40��{�.  $��0,0,0,15q��� $
��Wrap=�$��0,0,0,40q�$��15(�$��Italic$��1.2.2 Once you've configured your fractal options, click this button to generate the fractal based on your selected parameters.