   M S B A M L   `   `   `  ����E  AWpfAppTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfAppTest
WpfAppTest  5   	       WpfAppTest.ListViewWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfAppTest     5   	   -   5          � Title$  ListViewWindow��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   �� -   5        $��lvList��5
      $
��Left=�69   $	��249��6T   $��
47,105,0,0q�6a   $	��Top=�6u   $	��531��6�   ��6!   ��  �� View 5      �� 5      .P�5      �� ��5      �� 5      -   5        $��chkAll��5   '   $��全选��65    �� CellTemplate 5      �� 5      .R�5   "   �� $	��chk��6+   
 � Tag 66   �� *UserId+ d� 	IsChecked 6M   ��  �� ElementName$ chkAll�� �� Path$ 	IsChecked� �� Mode$ OneWay=�5      5      �� 5      $��编号��6%    �� Width$ 50��6Y   	 �� DisplayMemberBinding	 61   �� *UserId+
 �� HeaderTemplate
 5      �� 5      .R�5   "   �� 
���  ��$��1q�6M   
��� �����6(   �� 6a   5      5      �� 5      $��账号��6%   $ 80��61    5       �� 5!      .R�5"   "   �� 
���2͚�$
��Left=�6_   $��50��6{   ��6,   �� *
UserName+6{   5#      5%      �� 5&      $��用户状态��6%   $ 80��6^   	 63   �� *	UserState+6^   �� 5'      $��部门编号��6%   $ 80��6[   	 63   �� *Deptid+6[   �� 5(      $��用户年龄��6%   $ 80��6\   	 63   �� *	UserAge+6\   5)      5+      5-      5.      