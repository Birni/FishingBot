   M S B A M L   `   `   `  ����   	InnerCore!    InnerCore.Pages.Fishing_Bot   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Z VFirstFloor.ModernUI, Version=1.0.9.0, Culture=neutral, PublicKeyToken=bc9b0c37bf06c6a90mui&http://firstfloorsoftware.com/ModernUI  .���    ContentRoot#��[  .+��� -     ��Name$  button��$��Start Fishing Bot��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��130��$	��100��� $
��Left=�$	��100��$��
158,10,0,0q�$	��Top=�$	��130��.+��� -    ��Name$ aktiv_image�� 
 aktive#���   J� RenderTransformOrigin$ 0.515,1.306&�$��	0,0,31,10q�$��Right=�$��66��$��62��$��Bottom=� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect   J� OpacityMask ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ White��$ 1Q��� -   $ unaktiv_image��$
��Left=�$��62��$	��Top=�$��66��  unaktive#���  $ 0.515,1.306&�$��	33,28,0,0q�    �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q��� -   	 ��Name$	 textbotaktiv��$
��Left=�$
��Wrap=�$��66��$��18��$��
10,10,0,72q�$ 0.455,-0.833&��� $�
Bot aktiv:���� �� ��   BorderColor#���  $��1q�$	��100��$��-1,0,0,0q�$	��Top=��� #���  $��1q�$	��100��$��-1,0,0,0q�$	��Top=�� -   
 �Name$
 letterdetect��$
��Left=�$	��100��$��
305,10,0,0q�$	��Top=�$	��130��.+��� -   $	 detected_letter��$
��Left=�$��	10,10,0,0q�$
��Wrap=�$	��Top=�$��95���� $�Detected���� $� letter:���� -   $	 show_detected_letter��$��Stretch=�$��10,20,10,10q�$
��Wrap=�$
��Auto��$��50(�$ 1.054,0.492&� �� TextAlignment$ Center=��� #���  $��1q�$
��Left=�$	��100��$	��Top=�$	��130��