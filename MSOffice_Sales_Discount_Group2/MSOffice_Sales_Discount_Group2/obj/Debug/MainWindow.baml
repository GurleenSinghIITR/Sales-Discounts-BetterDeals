   M S B A M L   `   `   `  ����Y  UMSOffice_Sales_Discount_Group2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:MSOffice_Sales_Discount_Group2MSOffice_Sales_Discount_Group2  5   	   /    )MSOffice_Sales_Discount_Group2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:MSOffice_Sales_Discount_Group2     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��600��6)   .��5	      � $��10q�6   ���#eee � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��1.5* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��3* �6#   .+�5      �� $��0��6   $��2.png��6$   �� 5      $��1��6   $��Microsoft Office Package��6$   $��30(�6G   $��Center=�6U   5      � 5   
   $��1��6    5      �� 5      $��* �6     5      �� 5      $��2* �6#   �� 5       $��* �6#   .+�5"      �� -   5        $��
inputLabel��5"      $��1��6&   $��0��63   $
��Bold"�6C   $��4q�6U   $��15(�6`   $&�� Enter Quantity ($99 per Package)��6n   $��Center=�6�   $��Center=�6�   �� 5#      -   5        $��	inputText��5#      $��1��6'   $��1��64   $��10q�6D   $��20(�6Q    �� TextAlignment$ Center=�6_   $��Center=�6v   $��Center=�6�   5$      �� 5%   
   -   5        $
��DoIt��5%      $��2��6   $��	CALCULATE��6*   $��30(�6>   $��140,20q�6_   �� 5&   
   -   5        $��showDiscount��5&      $��3��6$   $��15(�61   $
��Bold"�6?   $��Center=�6Q   �� 5'   
   -   5        $��showMe��5'      $��4��6   $��15(�6,   $
��Bold"�6:   $��Center=�6L   � 5(   
   $��5��6    5)      �� 5*      $��* �6#   �� 5+      $��* �6#   .+�5-      �� -   5        $��
UndoButton��5-      $��0��6(   $
��Undo��68   $��10q�6G   
�������$
��Bold"�6i   $��20(�6{   6�   �� 5.      -   5        $��CloseButton��5.      $��1��6(   $��Close��68   $��10q�6H   
�������$
��Bold"�6j   $��20(�6|   6�   5/      51      52      