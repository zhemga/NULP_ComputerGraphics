   M S B A M L   `   `   `  ����  WpfApp1    WpfApp1.Fractal1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$+  %CGv5 | Fractal Generator | Mandelbrot��5   	    � SizeToContent$ WidthAndHeight=�67   ���	#FFFAFAFA � 	Resources 5         CustomButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers	 P� Property
 P� Value��%y  &	        �� 5   
   " ��6*   .�5      ��  � ��$
 16px(�6)   �� 5	       � �� �#2196F36+   �� 5
       � ��
 �����6+   �� 5       � ��$ 1q�60   �� 5       � �� �#1565C06,   �� 5       � ��$	 100��6)   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��6K   #��z��6w   $ 5��6�   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5      	 �@J�IsMouseOver
 . . �5      ��  � �� �#1976D263   �� 5       � �� �#11529364   5      5      5      .��5       ]� .+�5"   
   �� $	��Top=�6   ���	#FFACACAC$��0, 0, 0, 1.5q�6>   ._�5#      o� ���	#FF323232���	#FFE6E6E6.@�5$      m� $
��File��6   .@�5%      m� $
��Save��6   ���	#FF323232���	#FFE6E6E66D   5&      m� 5'      $��	Main Menu��6   m� 5(      $
��Help��6   5)      5*      � 5-   
   $��10q�6    � ColumnDefinitions 5.      �� 5/      $��2* �6#   �� 50      $��1* �6#   .+�54      � $��0��6   $��0,0,20,0q�6#   .+�55      �� ���	#FFACACAC$	��1.5q�61   ._�56      �� -   5        $��FractalImage��56      $	��400��60   $	��400��6=   $��Center=�6I   $��Center=�6f   $��/mandelbrot.png��6�   $
��Fill=�6�   57      58      � 5;      $��1��6   $	��350��6#   .+�5<      � $��Center=�6   $��0,0,0,50q�62    � RowDefinitions 5=      �� 5>      $
��Auto �6(   �� 5?      $
��Auto �6(   �� 5@      $
��Auto �6(   �� 5A      $
��Auto �6(   �� 5B      $
��Auto �6(   .+�5E      �� $��20(�6    $
��Bold"�6.   $��0,0,0,6q�6@   Fractal Options6b   ]� 5H      $��1��6    $��0,0,0,10q�6-   .+�5I      �� $��Select Fractal: ��6$   $��Center=�6<   $��16(�6W   �� 5J      -   5        $��FractalType��5J   #   $��10,0,0,0q�66   $	��150��6H   $��16(�6W   .@�5K      �� $��
Mandelbrot��6+    �� 
IsSelected . 6@   �� 5L      $��Pythagoras Tree��6+   5M      5N      ]� 5Q      $��2��6    $��0,0,0,10q�6-   .+�5R      �� ���	#FFACACAC$	��1.5q�69   $��0,0,10,0q�6O   $
��Left=�6a   ._�5S      �� -   5        $��ColorPreview��5S   (   $��20��6<   $��20��6G   ���	#FF0F82F26S   5T      �� 5U      $��Select Color��6!   #��[  68   $��Right=�6c   5V      ]� 5Y      $��3��6    $��0,0,0,10q�6-   .+�5Z      �� $��Scale: ��6$   $��Center=�63   $��16(�6N   $
��Left=�6\   �� 5[      -   5        $��ScaleSlider��5[   !    � Minimum$ 1Q�64    � Maximum$ 10Q�6@    � Value$ 7Q�6M   $��Right=�6X   $��2,3,0,0q�6o   5\      �� 5_      $��Generate Fractal��6   #��[  68   $��4��6c   $��35��6p   5`      5a      5b      5c      5d      