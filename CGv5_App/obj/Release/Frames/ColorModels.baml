   M S B A M L   `   `   `  ���� C  ?CGv5_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CGv5_App.FramesCGv5_App.Frames  !    CGv5_App.Frames.ColorModels   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:CGv5_App.Frames       N� Title$  CGv5 | Color Models�� � 	Resources    CustomButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property	 P� Value  	BoolToVis��%{  &	        &	 b    �� " ��.���  � ��$
 16px(���  � �� �#2196F3��  � ��
 �������  � ��$ 1q���  � �� �#1565C0��  � ��$	 100����  � �� �� " ��.R��� #��z��#��z��#��z��$ 5��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver	 . . ���  � �� �#1976D2��  � �� �#115293�� .��� $��10q����	#FFFAFAFA
 � ColumnDefinitions
 �� $��2* ��� $��2* ��� $��2* ��� $��3* �.+�� $��0��$��0,0,20,0q�.+�]� ��. .+��� $	��Top=�$��Center=�$��1��$��22(�$
��Bold"�$��0,0,0,6q����	#FF929292	RGB image�� $	��Top=����	#FFACACAC$	��1.5q����	#FFF0F0F0._��� -   $��RgbImage��$��Center=�$��Center=�$��Uniform=� � Cursor$
 Hand��� $��1��$��0,0,20,0q�.+�]� ��. .+��� $	��Top=�$��Center=�$��1��$��22(�$
��Bold"�$��0,0,0,6q����	#FF929292	HSL image�� $	��Top=����	#FFACACAC$	��1.5q����	#FFF0F0F0._��� -   $��HslImage��$��Center=�$��Center=�$��Uniform=�$
 Hand��� $��2��$��0,0,20,0q�.+�]� ��. .+��� $	��Top=�$��Center=�$��1��$��22(�$
��Bold"�$��0,0,0,6q����	#FF929292
CMYK Image�� $	��Top=����	#FFACACAC$	��1.5q����	#FFF0F0F0._��� -   $��	CmykImage��$��Center=�$��Center=�$��Uniform=�$
 Hand��� $��3��.+�� $��Center=�$��0,0,0,50q� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��1��$��22(�$
��Bold"�$��0,0,0,6q����	#FF929292Color Options�� $��2���� -    ��Name$ HSLtb��$��3��$��20(�$
��Bold"�$��0,0,0,6q�HSL J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 1Q�   	Direction$	 330Q�   Color$ Black��   Opacity$	 0.5Q�   
BlurRadius$ 4Q�]� $��4��$��0,0,0,10q�.+��� $	��190��$��Center=�$��16(�$
��Left=�
���   �$
��Bold"�����  �� ElementName$ HueScaleSlider�� �� Path$ Value� �� StringFormat$ 	{0}° Hue���� ���	#FFACACAC$	��1.5q�$��0,3,0,0q�._��� -   $��HueScaleSlider�� � Minimum$ 0Q� � Maximum$	 359Q� � Value$ 0Q� �� IsSnapToTickEnabled .  �� TickFrequency$ 1Q�$��Right=����	#FFFAFAFA
�������{�.  ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&� � MappingMode$ RelativeToBoundingBox=� �� RelativeTransform V� .~���   �� CenterY$	  0.5Q�! �� CenterX$	! 0.5Q��� " �� CenterX$	" 0.5Q�# �� CenterY$	# 0.5Q��� $ �� Angle$	$ -90Q�% �� CenterX$	% 0.5Q�& �� CenterY$	& 0.5Q�T� .��� ' � Color$	' Red��( � Offset$( 0Q�� $' Yellow��$( 0.1667Q�� $
' Lime��$( 0.3333Q�� $
' Cyan��$	( 0.5Q�� $
' Blue��$( 0.6667Q�� $' Magenta��$( 0.8333Q�� $	' Red��$( 1Q�]� $��5��$��0,0,0,10q�.+��� $	��190��$��Center=�$��16(�$
��Left=�
���   �$
��Bold"����� $ SaturationScaleSlider��$ Value�$ {0}% Saturation���� ���	#FFACACAC$	��1.5q�$��0,3,0,0q�._��� -   $��SaturationScaleSlider��$ 0Q�$	 100Q�$ 0Q� . $ 1Q�$��Right=�{�.  ���� $ 0.5,1&�$ 0.5,0&�$ RelativeToBoundingBox=� V� .~��� $	  0.5Q�$	! 0.5Q��� $	" 0.5Q�$	# 0.5Q��� $	$ -90Q�$	% 0.5Q�$	& 0.5Q�T� .��� $' 	#FFFF002E��$( 1Q�� $' 	#FFFAFAFA��$( 0Q�]� $��6��$��0,0,0,10q�.+��� $	��190��$��Center=�$��16(�$
��Left=����	#FF1B0000$
��Bold"����� $ LightnessScaleSlider��$ Value�$ {0}% Lightness���� ���	#FFACACAC$	��1.5q�$��0,3,0,0q�._��� -   $��LightnessScaleSlider��$ 0Q�$	 100Q�$ 50Q� . $ 1Q�$��Right=�{�.  ���� $ 0.5,1&�$ 0.5,0&� V� .~��� $	  0.5Q�$	! 0.5Q��� $	" 0.5Q�$	# 0.5Q��� $	$ -90Q�$	% 0.5Q�$	& 0.5Q�T� .��� $' Black��� $' 	#FFFF002E��$	( 0.5Q�� $' White��$( 1Q��� $��7���� -   $ CMYKtb��$��8��$��20(�$
��Bold"�$��0,0,0,6q�CMYK   $ 1Q�$	 330Q�$ Black��$	 0.5Q�$ 4Q�]� $��9��$��0,0,0,10q�.+��� $	��150��$��Center=�$��16(�$
��Left=����	#FF3D9BBE$
��Bold"�$	��190������ $ CyanScaleSlider��$ Value�$ 	{0}% Cyan���� -	   $��CyanScaleSlider��$ 0Q�$	 100Q�$ 0Q� . $ 1Q�$��Right=�$��0,3,0,0q����	#FFFAFAFA
�������{�.  ��Z� ]� $��10��$��0,0,0,10q�.+��� $	��150��$��Center=�$��16(�$
��Left=����	#FFD2067D$
��Bold"�$	��190������ $ MagentaScaleSlider��$ Value�$ {0}% Magenta���� -
   $��MagentaScaleSlider��$ 0Q�$	 100Q�$ 0Q� . $ 1Q�$��Right=�$��0,3,0,0q�{�.  ]� $��11��$��0,0,0,10q�.+��� $	��150��$��Center=�$��16(�$
��Left=����	#FFF6BB00$
��Bold"�$	��190������ $ YellowScaleSlider��$ Value�$ {0}% Yellow���� -   $��YellowScaleSlider��$ 0Q�$	 100Q�$ 0Q� . $ 1Q�$��Right=�$��0,3,0,0q�{�.  ]� $��12��$��0,0,0,10q�.+��� $	��150��$��Center=�$��16(�$
��Left=�$
��Bold"�$	��190������ $ KeyScaleSlider��$ Value�$ {0}% Key���� -   $��KeyScaleSlider��$ 0Q�$	 100Q�$ 0Q� . $ 1Q�$��Right=�$��0,3,0,0q�{�.  �� $��13���� $��14��$��20(�$
��Bold"�$��0,0,0,6q�Additional Options   $ 1Q�$	 330Q�$ Black��$	 0.8Q�$ 2Q�]� $��15��$��0,0,0,10q�.+��� $	��190��$��Center=�$��16(�$
��Left=�
���   �$
��Bold"����� $ ShadeAccuracyScaleSlider��$ Value�$ Gray Accuracy Step: {0}���� -   $��ShadeAccuracyScaleSlider��$ 0Q�$	 100Q�$ 0Q� . $ 1Q�$��Right=�$��0,3,0,0q�]� $��16��$��0,0,0,10q�.+��� $	��190��$��Center=�$��16(�$
��Left=�
���   �$
��Bold"����� $ GraynessScaleSlider��$ Value�$ {0}% Gray Lightness���� ���	#FFACACAC$	��1.5q�$��0,3,0,0q�._��� -   $��GraynessScaleSlider��$ 1Q�$	 400Q�$	 100Q� . $ 1Q�$��Right=����� $ 0.5,1&�$ 0.5,0&�$ RelativeToBoundingBox=� V� .~��� $	  0.5Q�$	! 0.5Q��� $	" 0.5Q�$	# 0.5Q��� $	$ -90Q�$	% 0.5Q�$	& 0.5Q�T� .��� $' Black��$( 0Q�� $' 	#FFFAFAFA��$( 1Q��� -   $��Reset Gray Values��#��[  $��17��$��35��