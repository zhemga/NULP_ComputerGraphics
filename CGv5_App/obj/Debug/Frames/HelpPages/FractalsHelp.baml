   M S B A M L   `   `   `  ����C  ?CGv5_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CGv5_App.Frames.HelpPagesCGv5_App.Frames.HelpPages  5      ,    &CGv5_App.Frames.HelpPages.FractalsHelp   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:CGv5_App.Frames.HelpPages     5      X TXceed.Wpf.Toolkit, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  6=     N� Title$%  CGv5 | Generate Fractals | Help��5	       � 	Resources 5         CustomButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property	 P� Value  	BoolToVis��%�  &	        &	 o    �� 5   
   " ��6*   .�5      ��  � ��$
 16px(�6)   �� 5       � �� �#2196F36+   �� 5       � ��
 �����6+   �� 5       � ��$ 1q�60   �� 5       � �� �#1565C06,   �� 5       � ��$	 100��6)   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��6K   #��z��6w   $ 5��6�   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5       �@J�IsMouseOver	 . . �5      ��  � �� �#1976D263   �� 5        � �� �#11529364   5!      5#      �� 5%   
   6'   5&      .��5(      �� ���	#FFECF1FF$��50, 10, 50, 10q�6*   .��5)   
   �� 
 �� Orientation$
 Vertical=�6   $��Center=�6,   $��Center=�6G   .+�5+      �� $��0, 20, 0, 10q�6   $��Center=�6.   $
��Wrap=�5,      $)��#It's a Help Materials for Fractals!��6(   $��24(�6S   $
��Bold"�6a   �� 5.      $��0, 10, 0, 10q�6   $��Center=�6.   $
��Wrap=�5/      ���#2196F3$A��;Please, read carefully to understand program functionality!��61   $��24(�6t   $
��Bold"�6�   �� 52      $��0, 10q�6   .+�53      �� $��1. Fractal Options:��6   $
��Bold"�67   $��20(�6I   $��0, 0, 0, 10q�6W   ]� 56      $��0,0,0,15q�6   .+�57      �� $��1.1. Select Fractal: ��6    $��Center=�6=   $��18(�6X   �� 58      -   5        $��FractalTypeCB��58      $��10,0,0,0q�64   $��18(�6F   {�.  .@�59      �� -   5        $��MandelbrotCBI��59   '   $��
Mandelbrot��6<    �� 
IsSelected . 6Q   �� 5:      -   5        $��PythagorasCBI��5:   '   $��Pythagoras Tree��6<   5;      5<      �� 5=      $
��Wrap=�6   $��0,0,0,10q�60   $��15(�6B   $��Italic$�6P   ��Choose the type of fractal you want to generate. The Mandelbrot fractal is a classic and versatile option, while the Pythagoras Tree offers a unique and visually appealing structure.5?      �� 5B      -   5        $��ColorScheme��5B      {�.  $��0,0,0,15q�6B   .+�5C      �� $ ��1.2. Select Color Scheme: ��6    $��Center=�6B   $
��Bold"�6]   $��18(�6o   $
��Left=�6}   $��	0,10,0,10q�6�   ]� 5D      $��0,0,0,10q�6    .+�5E      �� $��	Color 1: ��6$   $��Center=�65   $��18(�6P   $
��Left=�6^   $��0,0,5,0q�6t   #  Xceed.Wpf.Toolkit.ColorPicker  5F      -   5        $��ColorPicker1��5F   +      SelectedColor$ BlackX�6?   {�.  6U   5G      ]� 5I      {�.  $��0,0,0,0q�62   .+�5J      �� $��Scale: ��6$   $
��Bold"�63   $��Center=�6E   $��18(�6`   $
��Left=�6n   �� 5K      -   5        $��ScaleSlider��5K   !    � Minimum$ 0.000001Q�64    � Maximum$
 0.01Q�6G    � Value$ 0.007Q�6V   $��Right=�6d   $��2,3,0,0q�6{   5L      5M      �� 5N      $
��Wrap=�6   $��0,0,0,30q�60   $��15(�6C   $��Italic$�6Q   ��1.2.1 Customize the visual appearance of your fractal by selecting a color scheme. Adjust the colors and scale for a personalized and visually stunning result.5P      �� 5S      $��1.3. Generate Fractal��6   #��[  69   $��40��6d   {�.  $��0,0,0,15q�6�   �� 5T      $
��Wrap=�6   $��0,0,0,40q�60   $��15(�6C   $��Italic$�6Q   �1.2.2 Once you've configured your fractal options, click this button to generate the fractal based on your selected parameters.5V      5W      5X      5Y      5Z      