   M S B A M L   `   `   `  ����B  >CalcWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CalcWPFCalcWPF  5   	       CalcWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CalcWPF     5   	     � Title$  Калькулятор��5   	   $	��400��6   $	��452��6)   .��5	      � -   5         �Name$ 
LayoutRoot��5	      
������� � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ 	textBlock��5      $��0��6'   $��4��67   $��Calibri)�6K   $��20(�6`   �� 5   
   $��6��6    J� RenderTransformOrigin$ -3.433,6.423&�6   $��0,0,0,-1q�6C   $��Calibri)�6U   $��14(�6j   $
��Bold"�6x   .��6�   DEL6�   �� 5   
   $��0��6   $��1��6!   $��Calibri)�6.   $��14(�6C   $
��Bold"�6Q   .��6c   MOD6h   �� 5   
   $��1��6   $��1��6!   $��Calibri)�6.   $��14(�6C   $
��Bold"�6Q   .��6c   π6f   �� 5   
   $��2��6   $��1��6!   $��Calibri)�6.   $��14(�6C   $
��Bold"�6Q   .��6c   e6f   �� 5   
   $��1��6   $��0,0,0,-1q�6!   $��6��63   $��Calibri)�6@   $��14(�6U   $
��Bold"�6c   .��6u   CLEAR6|   �� 5    
   $��2��6   $��6��6!   $��Calibri)�6.   $��14(�6C   $��0,0,0,-1q�6Q   .��6c   +/-6h   �� 5!   
   $��0��6   $��2��6!   $
��Bold"�6.   .��6@   DIV6E   �� 5"   
   $��1��6   $��2��6!   $
��Bold"�6.   .��6@   sin6E   �� 5#   
   $��2��6   $��2��6!   $��Calibri)�6.   $��14(�6C   $
��Bold"�6Q   .��6c   cos6h   �� 5$   
   $��3��6   $��2��6!   $��Calibri)�6.   $��14(�6C   $
��Bold"�6Q   $	��tan��6c   �� 5%   
   $��4��6   $��2��6!   $��Calibri)�6.   $��14(�6C   .��6Q   /6T   �� 5&   
   $��0��6   $��3��6!   $��Calibri)�6.   $��14(�6C   $
��Bold"�6Q   $	��√��6c   �� 5'   
   $��1��6   $��3��6!   $��Calibri)�6.   $��14(�6C   .��6Q   76T   �� 5(   
   $��2��6   $��3��6!   $��Calibri)�6.   $��14(�6C   .��6Q   86T   �� 5)   
   $��3��6   $��3��6!   $��Calibri)�6.   $��14(�6C   .��6Q   96T   �� 5*   
   $��4��6   $��3��6!   $��Calibri)�6.   $��14(�6C   .��6Q   *6T   �� 5+   
   $��0��6   $��4��6!   $��Calibri)�6.   $��14(�6C   $
��Bold"�6Q   .��6c   x^26h   �� 5,   
   $��1��6   $��4��6!   $��Calibri)�6.   $��14(�6C   .��6Q   46T   �� 5-   
   $��2��6   $��4��6!   $��Calibri)�6.   $��14(�6C   .��6Q   56T   �� 5.   
   $��3��6   $��4��6!   $��Calibri)�6.   $��14(�6C   .��6Q   66T   �� 5/   
   $��4��6   $��4��6!   $��Calibri)�6.   $��14(�6C   .��6Q   -6T   �� 50   
   $��0��6   $��5��6!   $��Calibri)�6.   $��14(�6C   $
��Bold"�6Q   .��6c   e^x6h   �� 51   
   $��1��6   $��5��6!   $��Calibri)�6.   $��14(�6C   .��6Q   16T   �� 52   
   $��2��6   $��5��6!   $��Calibri)�6.   $��14(�6C   .��6Q   26T   �� 53   
   $��3��6   $��5��6!   $��Calibri)�6.   $��14(�6C   .��6Q   36T   �� 54   
   $��4��6   $��5��6!   $��Calibri)�6.   $��14(�6C   .��6Q   +6T   �� 55   
   $��4��6   $��1��6!   $��Calibri)�6.   $��14(�6C   $
��Bold"�6Q   .��6c   1/x6h   �� 56   
   $��3��6   $��6��6!   $��Calibri)�6.   $��14(�6C   $��0,0,0,-1q�6Q   .��6c   06f   �� 57   
   $��3��6   $��1��6!   $��Calibri)�6.   $��14(�6C   $
��Bold"�6Q   .��6c   n!6g   �� 58   
   $��4��6   $��6��6!   $��Calibri)�6.   $��14(�6C   $��0,0,0,-1q�6Q   .��6c   =6f   59      5:      