   M S B A M L   `   `   `  ����C  ?CGv5_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CGv5_App.Frames.HelpPagesCGv5_App.Frames.HelpPages  5      /    )CGv5_App.Frames.HelpPages.ColorModelsHelp   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:CGv5_App.Frames.HelpPages     5        N� Title$   CGv5 | Color Models | Help��5	       � 	Resources 5         CustomButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property	 P� Value  	BoolToVis��%�  &	        &	 o    �� 5   
   " ��6*   .�5      ��  � ��$
 16px(�6)   �� 5       � �� �#2196F36+   �� 5       � ��
 �����6+   �� 5       � ��$ 1q�60   �� 5       � �� �#1565C06,   �� 5       � ��$	 100��6)   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��6K   #��z��6w   $ 5��6�   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5       �@J�IsMouseOver	 . . �5      ��  � �� �#1976D263   �� 5        � �� �#11529364   5!      5#      �� 5%   
   6'   5&      .��5(      �� ���	#FFECF1FF$��50, 10, 50, 10q�6*   .��5)   
   �� 
 �� Orientation$
 Vertical=�6   $��Center=�6,   $��Center=�6G   .+�5+      �� $��0, 20, 0, 10q�6   $��Center=�6.   $
��Wrap=�5,      $)��#It's a Help Materials for Fractals!��6%   $��24(�6P   $
��Bold"�6^   �� 5.      $��0, 10, 0, 10q�6   $��Center=�6.   $
��Wrap=�5/      ���#2196F3$A��;Please, read carefully to understand program functionality!��6/   $��24(�6r   $
��Bold"�6�   �� 52      $��0, 10q�6   .+�53      �� $��1. Color Models Display:��6   $
��Bold"�6<   $��20(�6N   $��0, 0, 0, 10q�6\   �� 54      $��15(�6   $��Italic$�6+   $
��Wrap=�6>   ��This section offers an interactive display of images illustrating distinct color models, such as RGB, HSL, and CMYK. The visual representations provide valuable insights into the composition and structure of each color model. Navigate through the images to gain a comprehensive understanding of RGB, HSL, and CMYK color representations.56      ]� 59      ��. $��0, 10, 0, 0q�61   .+�5:      �� $	��Top=�6    $��Center=�65   $��1��6R   $��22(�6_   $
��Bold"�6m   $��0,0,0,6q�6   ���	#FF929292	RGB image6�   �� 5;      $	��Top=�6   ���	#FFACACAC$	��1.5q�6J   ���	#FFF0F0F0._�5<      �� -   5        $��RgbImage��5<       $��Center=�60   $��Center=�6M   $��Uniform=�6h    � Cursor$
 Hand��6z   {�.  6�   5=      5>      ]� 5A      ��. $��0, 10, 0, 0q�61   .+�5B      �� $	��Top=�6    $��Center=�65   $��1��6R   $��22(�6_   $
��Bold"�6m   $��0,0,0,6q�6   ���	#FF929292	HSL image6�   �� 5C      $	��Top=�6   ���	#FFACACAC$	��1.5q�6J   ���	#FFF0F0F0._�5D      �� -   5        $��HslImage��5D       $��Center=�60   $��Center=�6M   $��Uniform=�6h   $
 Hand��6z   {�.  6�   5E      5F      ]� 5I      ��. $��0, 10, 0, 0q�61   .+�5J      �� $	��Top=�6    $��Center=�65   $��1��6S   $��22(�6`   $
��Bold"�6n   $��0,0,0,6q�6�   ���	#FF929292
CMYK Image6�   �� 5K      $	��Top=�6   ���	#FFACACAC$	��1.5q�6J   ���	#FFF0F0F0._�5L      �� -   5        $��	CmykImage��5L   !   $��Center=�62   $��Center=�6O   $��Uniform=�6j   $
 Hand��6|   {�.  6�   5M      5N      5O      �� 5R      $��0, 10q�6   .+�5S      �� $��2. Color Options:��6   $
��Bold"�65   $��20(�6G   $��0, 0, 0, 10q�6U   �� 5T      $��15(�6   $��Italic$�6*   $
��Wrap=�6=   $��0, 0, 0, 20q�6Q   ��This section empowers you to finely adjust color options for both HSL and CMYK color models. Utilize the sliders to modify parameters such as Hue, Saturation, Lightness for HSL, and Cyan, Magenta, Yellow, and Key (black) for CMYK. As you make adjustments, observe the real-time changes in the corresponding color models. Dive into the customization options to achieve precise and tailored color effects based on your preferences.5V      �� 5Y      6   �� 5Z      -   5         ��Name$ HSLtb��5Z      $��20(�6+   $
��Bold"�69   $��0,0,0,6q�6K   HSL J� Effect 5\      3  -System.Windows.Media.Effects.DropShadowEffect  5]         ShadowDepth$ 1Q�6+      	Direction$	 330Q�6;      Color$ Black��6K      Opacity$	 0.5Q�6Y      
BlurRadius$ 4Q�6g   5_      ]� 5b      $��0,0,0,10q�6   .+�5c      �� $	��190��6q   $��Center=�6}   $��16(�6�   $
��Left=�6�   
���   �$
��Bold"�6�   $��0,0,5,0q�6�   ��6    ��  �� ElementName$ HueScaleSlider�� �� Path$ Value� �� StringFormat$ 	{0}° Hue��6�   �� 5d      ���	#FFACACAC$	��1.5q�65   $��0,3,0,0q�6L   ._�5e      �� -   5        $��HueScaleSlider��5e   !    � Minimum$ 0Q�67    � Maximum$	 359Q�6C    � Value$ 0Q�6Q    �� IsSnapToTickEnabled .  �� TickFrequency$ 1Q�6v   $��Right=�6�   ���	#FFFAFAFA
�������{�.  5g      5h      5i      ]� 5l      $��0,0,0,10q�6   .+�5m      �� $	��190��6   $��Center=�6�   $��16(�6�   $
��Left=�6�   
���   �$
��Bold"�6�   $��0,0,5,0q�6�   ��6    �� $ SaturationScaleSlider��$ Value�$ {0}% Saturation��6�   �� 5n      ���	#FFACACAC$	��1.5q�65   $��0,3,0,0q�6L   ._�5o      �� -   5        $��SaturationScaleSlider��5o   !   $ 0Q�6>   $	 100Q�6J   $ 0Q�6X    . $ 1Q�6}   $��Right=�6�   {�.  5q      5r      5s      ]� 5v      $��0,0,0,10q�6   .+�5w      �� $	��190��6}   $��Center=�6�   $��16(�6�   $
��Left=�6�   ���	#FF1B0000$
��Bold"�6�   $��0,0,5,0q�6�   ��6    �� $ LightnessScaleSlider��$ Value�$ {0}% Lightness��6�   �� 5x      ���	#FFACACAC$	��1.5q�65   $��0,3,0,0q�6L   ._�5y      �� -   5        $��LightnessScaleSlider��5y   !   $ 0Q�6=   $	 100Q�6I   $ 50Q�6W    . $ 1Q�6}   $��Right=�6�   {�.  5{      5|      5}      �� 5�      6   �� 5�      -   5        $ CMYKtb��5�      $��20(�6,   $
��Bold"�6:   $��0,0,0,6q�6L   CMYK 5�        5�      $ 1Q�6+   $	 330Q�6;   $ Black��6K   $	 0.5Q�6Y   $ 4Q�6g   5�      ]� 5�      $��0,0,0,10q�6   .+�5�      �� $	��150��6s   $��Center=�6�   $��16(�6�   $
��Left=�6�   ���	#FF3D9BBE$
��Bold"�6�   $	��190��6�   $��0,0,5,0q�6�   ��6    �� $ CyanScaleSlider��$ Value�$ 	{0}% Cyan��6�   �� 5�      -	   5        $��CyanScaleSlider��5�      $ 0Q�64   $	 100Q�6@   $ 0Q�6N    . $ 1Q�6s   $��Right=�6�   $��0,3,0,0q�6�   ���	#FFFAFAFA
�������{�.  ��6�   Z� 6�   5�      ]� 5�      $��0,0,0,10q�6   .+�5�      �� $	��150��6y   $��Center=�6�   $��16(�6�   $
��Left=�6�   ���	#FFD2067D$
��Bold"�6�   $	��190��6�   $��0,0,5,0q�6�   ��6    �� $ MagentaScaleSlider��$ Value�$ {0}% Magenta��6�   �� 5�      -
   5        $��MagentaScaleSlider��5�      $ 0Q�67   $	 100Q�6C   $ 0Q�6Q    . $ 1Q�6v   $��Right=�6�   $��0,3,0,0q�6�   {�.  6�   5�      ]� 5�      $��0,0,0,10q�6   .+�5�      �� $	��150��6w   $��Center=�6�   $��16(�6�   $
��Left=�6�   ���	#FFF6BB00$
��Bold"�6�   $	��190��6�   $��0,0,5,0q�6�   ��6    �� $ YellowScaleSlider��$ Value�$ {0}% Yellow��6�   �� 5�      -   5        $��YellowScaleSlider��5�      $ 0Q�66   $	 100Q�6B   $ 0Q�6P    . $ 1Q�6u   $��Right=�6�   $��0,3,0,0q�6�   {�.  6�   5�      ]� 5�      $��0,0,0,10q�6   .+�5�      �� $	��150��6q   $��Center=�6�   $��16(�6�   $
��Left=�6�   $
��Bold"�6�   $	��190��6�   $��0,0,5,0q�6�   ��6    �� $ KeyScaleSlider��$ Value�$ {0}% Key��6�   �� 5�      -   5        $��KeyScaleSlider��5�      $ 0Q�63   $	 100Q�6?   $ 0Q�6M    . $ 1Q�6r   $��Right=�6�   $��0,3,0,0q�6�   {�.  6�   5�      �� 5�      6   �� 5�      $��14��6   $��20(�6*   $
��Bold"�68   $��0,0,0,6q�6J   Additional Options 5�        5�      $ 1Q�6+   $	 330Q�6;   $ Black��6K   $	 0.8Q�6Y   $ 2Q�6g   5�      ]� 5�      $��0,0,0,10q�6   .+�5�      �� $	��190��6�   $��Center=�6�   $��16(�6�   $
��Left=�6�   
���   �$
��Bold"�6�   $��0,0,5,0q�6�   ��6    �� $ ShadeAccuracyScaleSlider��$ Value�$ Gray Accuracy Step: {0}��6�   �� 5�      -   5        $��ShadeAccuracyScaleSlider��5�      $ 0Q�6=   $	 100Q�6I   $ 0Q�6W    . $ 1Q�6|   $��Right=�6�   $��0,3,0,0q�6�   5�      ]� 5�      $��0,0,0,10q�6   .+�5�      �� $	��190��6�   $��Center=�6�   $��16(�6�   $
��Left=�6�   
���   �$
��Bold"�6�   $��0,0,5,0q�6�   ��6    �� $ GraynessScaleSlider��$ Value�$ {0}% Gray Lightness��6�   �� 5�      ���	#FFACACAC$	��1.5q�65   $��0,3,0,0q�6L   ._�5�      �� -   5        $��GraynessScaleSlider��5�   !   $ 1Q�6<   $	 400Q�6H   $	 100Q�6V    . $ 1Q�6}   $��Right=�6�   5�      5�      5�      �� 5�      $��Reset Gray Values��6   #��[  65   $��35��6`   {�.  $��	0,10,0,40q�6~   5�      5�      5�      5�      