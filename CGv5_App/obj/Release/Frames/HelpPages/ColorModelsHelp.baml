   M S B A M L   `   `   `  ���� C  ?CGv5_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CGv5_App.Frames.HelpPagesCGv5_App.Frames.HelpPages  /    )CGv5_App.Frames.HelpPages.ColorModelsHelp   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     9local'clr-namespace:CGv5_App.Frames.HelpPages       N� Title$   CGv5 | Color Models | Help�� � 	Resources    CustomButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property	 P� Value  	BoolToVis��%{  &	        &	 b    �� " ��.���  � ��$
 16px(���  � �� �#2196F3��  � ��
 �������  � ��$ 1q���  � �� �#1565C0��  � ��$	 100����  � �� �� " ��.R��� #��z��#��z��#��z��$ 5��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver	 . . ���  � �� �#1976D2��  � �� �#115293�� .���� ���	#FFECF1FF$��50, 10, 50, 10q�.���� 
 �� Orientation$
 Vertical=�$��Center=�$��Center=�.+��� $��0, 20, 0, 10q�$��Center=�$
��Wrap=�$)��#It's a Help Materials for Fractals!��$��24(�$
��Bold"��� $��0, 10, 0, 10q�$��Center=�$
��Wrap=����#2196F3$A��;Please, read carefully to understand program functionality!��$��24(�$
��Bold"��� $��0, 10q�.+��� $��1. Color Models Display:��$
��Bold"�$��20(�$��0, 0, 0, 10q��� $��15(�$��Italic$�$
��Wrap=���This section offers an interactive display of images illustrating distinct color models, such as RGB, HSL, and CMYK. The visual representations provide valuable insights into the composition and structure of each color model. Navigate through the images to gain a comprehensive understanding of RGB, HSL, and CMYK color representations.]� ��. $��0, 10, 0, 0q�.+��� $	��Top=�$��Center=�$��1��$��22(�$
��Bold"�$��0,0,0,6q����	#FF929292	RGB image�� $	��Top=����	#FFACACAC$	��1.5q����	#FFF0F0F0._��� -   $��RgbImage��$��Center=�$��Center=�$��Uniform=� � Cursor$
 Hand��{�.  ]� ��. $��0, 10, 0, 0q�.+��� $	��Top=�$��Center=�$��1��$��22(�$
��Bold"�$��0,0,0,6q����	#FF929292	HSL image�� $	��Top=����	#FFACACAC$	��1.5q����	#FFF0F0F0._��� -   $��HslImage��$��Center=�$��Center=�$��Uniform=�$
 Hand��{�.  ]� ��. $��0, 10, 0, 0q�.+��� $	��Top=�$��Center=�$��1��$��22(�$
��Bold"�$��0,0,0,6q����	#FF929292
CMYK Image�� $	��Top=����	#FFACACAC$	��1.5q����	#FFF0F0F0._��� -   $��	CmykImage��$��Center=�$��Center=�$��Uniform=�$
 Hand��{�.  �� $��0, 10q�.+��� $��2. Color Options:��$
��Bold"�$��20(�$��0, 0, 0, 10q��� $��15(�$��Italic$�$
��Wrap=�$��0, 0, 0, 20q���This section empowers you to finely adjust color options for both HSL and CMYK color models. Utilize the sliders to modify parameters such as Hue, Saturation, Lightness for HSL, and Cyan, Magenta, Yellow, and Key (black) for CMYK. As you make adjustments, observe the real-time changes in the corresponding color models. Dive into the customization options to achieve precise and tailored color effects based on your preferences.�� �� -    ��Name$ HSLtb��$��20(�$
��Bold"�$��0,0,0,6q�HSL J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 1Q�   	Direction$	 330Q�   Color$ Black��   Opacity$	 0.5Q�   
BlurRadius$ 4Q�]� $��0,0,0,10q�.+��� $	��190��$��Center=�$��16(�$
��Left=�
���   �$
��Bold"�$��0,0,5,0q�����  �� ElementName$ HueScaleSlider�� �� Path$ Value� �� StringFormat$ 	{0}° Hue���� ���	#FFACACAC$	��1.5q�$��0,3,0,0q�._��� -   $��HueScaleSlider�� � Minimum$ 0Q� � Maximum$	 359Q� � Value$ 0Q� �� IsSnapToTickEnabled .  �� TickFrequency$ 1Q�$��Right=����	#FFFAFAFA
�������{�.  ]� $��0,0,0,10q�.+��� $	��190��$��Center=�$��16(�$
��Left=�
���   �$
��Bold"�$��0,0,5,0q����� $ SaturationScaleSlider��$ Value�$ {0}% Saturation���� ���	#FFACACAC$	��1.5q�$��0,3,0,0q�._��� -   $��SaturationScaleSlider��$ 0Q�$	 100Q�$ 0Q� . $ 1Q�$��Right=�{�.  ]� $��0,0,0,10q�.+��� $	��190��$��Center=�$��16(�$
��Left=����	#FF1B0000$
��Bold"�$��0,0,5,0q����� $ LightnessScaleSlider��$ Value�$ {0}% Lightness���� ���	#FFACACAC$	��1.5q�$��0,3,0,0q�._��� -   $��LightnessScaleSlider��$ 0Q�$	 100Q�$ 50Q� . $ 1Q�$��Right=�{�.  �� �� -   $ CMYKtb��$��20(�$
��Bold"�$��0,0,0,6q�CMYK   $ 1Q�$	 330Q�$ Black��$	 0.5Q�$ 4Q�]� $��0,0,0,10q�.+��� $	��150��$��Center=�$��16(�$
��Left=����	#FF3D9BBE$
��Bold"�$	��190��$��0,0,5,0q����� $ CyanScaleSlider��$ Value�$ 	{0}% Cyan���� -	   $��CyanScaleSlider��$ 0Q�$	 100Q�$ 0Q� . $ 1Q�$��Right=�$��0,3,0,0q����	#FFFAFAFA
�������{�.  ��Z� ]� $��0,0,0,10q�.+��� $	��150��$��Center=�$��16(�$
��Left=����	#FFD2067D$
��Bold"�$	��190��$��0,0,5,0q����� $ MagentaScaleSlider��$ Value�$ {0}% Magenta���� -
   $��MagentaScaleSlider��$ 0Q�$	 100Q�$ 0Q� . $ 1Q�$��Right=�$��0,3,0,0q�{�.  ]� $��0,0,0,10q�.+��� $	��150��$��Center=�$��16(�$
��Left=����	#FFF6BB00$
��Bold"�$	��190��$��0,0,5,0q����� $ YellowScaleSlider��$ Value�$ {0}% Yellow���� -   $��YellowScaleSlider��$ 0Q�$	 100Q�$ 0Q� . $ 1Q�$��Right=�$��0,3,0,0q�{�.  ]� $��0,0,0,10q�.+��� $	��150��$��Center=�$��16(�$
��Left=�$
��Bold"�$	��190��$��0,0,5,0q����� $ KeyScaleSlider��$ Value�$ {0}% Key���� -   $��KeyScaleSlider��$ 0Q�$	 100Q�$ 0Q� . $ 1Q�$��Right=�$��0,3,0,0q�{�.  �� �� $��14��$��20(�$
��Bold"�$��0,0,0,6q�Additional Options   $ 1Q�$	 330Q�$ Black��$	 0.8Q�$ 2Q�]� $��0,0,0,10q�.+��� $	��190��$��Center=�$��16(�$
��Left=�
���   �$
��Bold"�$��0,0,5,0q����� $ ShadeAccuracyScaleSlider��$ Value�$ Gray Accuracy Step: {0}���� -   $��ShadeAccuracyScaleSlider��$ 0Q�$	 100Q�$ 0Q� . $ 1Q�$��Right=�$��0,3,0,0q�]� $��0,0,0,10q�.+��� $	��190��$��Center=�$��16(�$
��Left=�
���   �$
��Bold"�$��0,0,5,0q����� $ GraynessScaleSlider��$ Value�$ {0}% Gray Lightness���� ���	#FFACACAC$	��1.5q�$��0,3,0,0q�._��� -   $��GraynessScaleSlider��$ 1Q�$	 400Q�$	 100Q� . $ 1Q�$��Right=��� $��Reset Gray Values��#��[  $��35��{�.  $��	0,10,0,40q�