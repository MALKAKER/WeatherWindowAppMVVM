   M S B A M L   `   `   `  ����C  ?Weather_, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Weather_.ViewUserControlsWeather_.ViewUserControls  5      5    /Weather_.ViewUserControls.DayWeatherUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Weather_.ViewUserControls     5      $	��314��5      $	��256��6+   ��5      �� 5	   
     �� Opacity$	  0.1Q�6    �� Color$
 Aqua��6(   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� -   5         ��Name$ 	cityBlock��5      $��center=�6'   $
��City��6D      TitleTextBlock#��[  6Q    �� TextAlignment$ Center=�6y   $��center=�6�   $��20(�6�   $��0��6�   $��0��6�   $��2��6�   �� 5   
   -   5        $��image_1��5   -   $��center=�6   $��73��6<   $��55��6G   $��center=�6S   $$��../icons/nuagepartielicone.png��6n   $��1��6�   $��0��6�   �� 5   
   -   5        $ ans_Temp��5      $��Center=�6&   $��Center=�6C   $
��Temp��6_   $��22(�6k   #��[  6z   $��1��6�   $��1��6�   �� 5   
   $��
Condition:��6   #��[  6&   $��Center=�6N   $��Center=�6k   $��20(�6�   $��2��6�   $��0��6�   �� 5   
   $��	Humidity:��6   #��[  6&   $��center=�6N   $ Center=�6i   $��20(�6�   $��3��6�   $��0��6�   $��26��6�   $��	0,10,0,11q�6�   �� 5   
   $��Wind Speed:��6   #��[  6(   $��center=�6P   $��Center=�6k   $ Center=�6�   $��20(�6�   $��4��6�   $��0��6�   �� 5   
   -   5        $��ans_Condition��5      $��Center=�6)   $��Center=�6E   $ Center=�6b   $	��ans��6y   $��20(�6�   $��2��6�   $��1��6�   �� 5   
   -   5        $��ans_Hum��5      $	��ans��6#   $��center=�6.   $��Center=�6J   $ Center=�6g   $��20(�6~   $��3��6�   $��1��6�   �� 5   
   -   5        $��	ans_Speed��5      $	��ans��6%   $��center=�60   $ Center=�6K   $��Center=�6c   $��20(�6�   $��4��6�   $��1��6�   5"      5#      