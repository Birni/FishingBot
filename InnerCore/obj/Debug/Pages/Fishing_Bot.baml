   M S B A M L   `   `   `  ����  	InnerCore!    InnerCore.Pages.Fishing_Bot   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFirstFloor.ModernUI, Version=1.0.9.0, Culture=neutral, PublicKeyToken=bc9b0c37bf06c6a90mui&http://firstfloorsoftware.com/ModernUI  5      .��5
      �    ContentRoot#��[  6   .+�5   
   �� -   5          ��Name$  button��5      $��Start Fishing Bot��6!   $
��Left=�6=   $��	10,10,0,0q�6X   $	��Top=�6k   $	��130��6�   $	��100��6�   6�   � 5   
   $
��Left=�6   $	��100��6*   $��
158,10,0,0q�67   $	��Top=�6K   $	��130��6c   .+�5      �� -   5         ��Name$ aktiv_image��5       
 aktive#���  6)    J� RenderTransformOrigin$ 0.515,1.306&�6K   $��	0,0,31,10q�6o   $��Right=�6�   $��66��6�   $��62��6�   $��Bottom=�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5       J� OpacityMask 5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5      �  � Color$ Black��6'    � Offset$ 0Q�65   � 5      $ White��6'   $ 1Q�65   5      5      �� 5      -   5        $ unaktiv_image��5      $
��Left=�6+   $��62��6F   $	��Top=�6R   $��66��6j     unaktive#���  6u   $ 0.515,1.306&�6�   $��	33,28,0,0q�6�    5        5       5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5      � $ Black��6'   $ 0Q�65   � 5      $ White��6'   $ 1Q�65   5       5"      �� 5#      -   5        	 ��Name$	 textbotaktiv��5#      $
��Left=�6.   $
��Wrap=�6I   $��66��6^   $��18��6i   $��
10,10,0,72q�6u   $ 0.455,-0.833&�6�   �� 6�   $�
Bot aktiv:��6�   �� 6�   �� 6�   6�   �� 5$        BorderColor#���  6   $��1q�6A   $	��100��6U   $��-1,0,0,0q�6b   $	��Top=�6t   �� 5%      #���  6   $��1q�6A   $	��100��6U   $��-1,0,0,0q�6b   $	��Top=�6t   5&      � 5'   
   -   5        
 �Name$
 letterdetect��5'      $
��Left=�6%   $	��100��6@   $��
305,10,0,0q�6M   $	��Top=�6a   $	��130��6y   .+�5(      �� -   5        $	 detected_letter��5(      $
��Left=�61   $��	10,10,0,0q�6L   $
��Wrap=�6_   $	��Top=�6s   $��95��6�   �� 6�   $�Detected��6�   �� 6�   $� letter:��6�   6�   �� 5)      -   5        $	 show_detected_letter��5)      $��Stretch=�66   $��10,20,10,10q�6T   $
��Wrap=�6i   $
��Auto��6}   $��50(�6�   $ 1.054,0.492&�6�    �� TextAlignment$ Center=�6�   6�   �� 5*      #���  6   $��1q�6A   $
��Left=�6U   $	��100��6p   $	��Top=�6}   $	��130��6�   5+      5,      5-      