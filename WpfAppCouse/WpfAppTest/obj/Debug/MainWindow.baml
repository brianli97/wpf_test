   M S B A M L   `   `   `  ����E  AWpfAppTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfAppTest
WpfAppTest  5   	       WpfAppTest.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfAppTest     5   	   -   5          � Title$  登录界面��5   	   $	��192��6   $	��311��6#    � ShowInTaskbar .  � WindowStartupLocation$ CenterScreen=�5	   	    � WindowState$ Normal=�6.    � Topmost .  � Icon$ image/123.jpg��5
   	   .��5      � -   5        $
��grid��5      .+�5   
   �� -   5        $��btnLogin��5      $��登录��6!   $
��Left=�6.   $��104,123,0,0q�6I   $	��Top=�6^   $��50��5      $��28��6    �� 	IsDefault . 
��� � �$��ExtraExpanded&�5   $   ��5      �� 5       �� ImageSource$ image/123.jpg��6   6;   5      �� 5   
   $��	账号：��6   $
��Left=�6   $��	48,20,0,0q�69   $	��Top=�6L   $��Right=�5      $��2��63   �� 5   
   -   5        $��txtUName��5      $��2��6"   $
��Left=�66   $��23��6Q   $��	94,20,0,0q�5       �� TextWrapping$ NoWrap=�6%   $��admin��6;   $	��Top=�6H   $	��120��6`   �� 5   
   $��	密码：��6   $
��Left=�6   $��	48,60,0,0q�6:   $	��Top=�6M   $��Right=�5      $��2��64   G� 5   
   -   5        $��txtUPwd��5      $��2��6%   $
��Left=�69   $��23��6T   $��	94,60,0,0q�6`   	 G� Password$	 123456��5      
 G� PasswordChar$
 *��6(   $	��Top=�69   $	��120��6Q   �� 5   
   -   5        $��	btnCancel��5      $��取消��6"   $
��Left=�6/   $��164,123,0,0q�6J   $	��Top=�6_   $��50��5      $��28��6    �� IsCancel . 
���2͚�
���  ��$��3q�5   =   	� 5    
   -   5        $��	管理员��5        	� 	GroupName$
 role��6$   $
��Left=�65    d� 	IsChecked$
 TrueY�6P   $��	61,88,0,0q�6a   $	��Top=�6t   6�   	� 5!   
   -   5        $��学生��5!      $
 role��6#   $
��Left=�64   $��
140,88,0,0q�6O   $	��Top=�6c   6{   	� 5"   
   -	   5        $��教师��5"      $
 role��6#   $
��Left=�64   $��
208,88,0,0q�6O   $	��Top=�6c   6{   5$      5%      