   M S B A M L   `   `   `  ���� C  ?CGv5_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CGv5_App.FramesCGv5_App.Frames  "    CGv5_App.Frames.FigureMoving   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:CGv5_App.Frames     X TXceed.Wpf.Toolkit, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    N� Title$  CGv5 | Figure Moving�� � 	Resources    CustomButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property	 P� Value��%�  &	        �� " ��.���  � ��$
 16px(���  � �� �#2196F3��  � ��
 �������  � ��$ 1q���  � �� �#1565C0��  � ��$	 100����  � �� �� " ��.R��� #��z��#��z��#��z��$ 5��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver	 . . ���  � �� �#1976D2��  � �� �#115293P�  � {�	 .  . ���  � ��
 �������  � ��
 �����.��]� -   $��10q����	#FFFAFAFA.+�� $��10q�
 � ColumnDefinitions
 �� $
��507* ��� $	��95* ��� $
��159* �.+�� $��0��$��0,0,20,0q�.+��� -    ��Name$ drawingCanvasBorder�����	#FFACACAC$	��1.5q�._��� -    ��Name$ drawingCanvas��
�������� $��1��$	��200��$��Center=�$��2��.+�� $��1�� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��20(�$
��Bold"�$��0,0,0,6q�$��Figure Moving Options��$��Center=�]� $��1��$
��0,10q�$��Center=�.+��� $	��x1:��$	��5,0q�$
��Bold"��� -   $��	X1TextBox��$
��60px��$��10���� -   $��	Y1TextBox��$
��60px��$��Right=�$��5���� $	��y1:��$��15,0,5,0q�$
��15px��$��Right=�$
��Bold"�]� $��2��$��0, 10q�$��Center=�.+��� $	��x2:��$	��5,0q�$
��Bold"��� -   $��	X2TextBox��$
��60px��$��1���� -   $��	Y2TextBox��$
��60px��$��Right=�$��1���� $	��y2:��$��15,0,5,0q�$
��15px��$��Right=�$
��Bold"�]� $��3��$
��0,10q���. .+��� $��Rotate Step (-180; 0)��$	��130��$��Center=��� -   $��RotateStepTextBox��$	��-10��]� $��4��$��0,0,0,10q���. .+��� $��Vertical Moving Step:��$	��130��$��Center=��� -	   $��VerticalMovingStepTextBox��$��Right=�$��1��]� $��5��$��0,0,0,10q���. .+��� $��Time Step (s):��$	��130���� -
   $��TimeStepTextBox��$��1���� -   $	��Run��$��6��#��[  $��0,10,0,0q��� -   $
��Stop��$��7��#��[  $��0,10,0,0q����	#FFA3163A�� -   $��Clear��$��8��#��[  $��	0,10,0,45q����	#FF59BA47