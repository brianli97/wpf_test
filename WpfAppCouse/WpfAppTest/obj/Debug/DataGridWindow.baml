   M S B A M L   `   `   `  ����E  AWpfAppTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfAppTest
WpfAppTest  5   	       WpfAppTest.DataGridWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfAppTest     5   	   -   5          � Title$  DataGridWindow��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��dgList��5   ?      HeadersVisibility$	 All=�5
         AutoGenerateColumns .     AlternatingRowBackground
 �2͚�   CanUserAddRows .    
IsReadOnly .  "   VerticalScrollBarVisibility$
 Auto=�5   &   $   HorizontalScrollBarVisibility$
 Auto=�6I    �� AlternationCount$ 3��6n   	   GridLinesVisibility$	 
Horizontal=�6�   
   SelectionUnit$

 Cell=�5         SelectionMode$ Single=�6(      RowHeaderWidth$ 20Q�5      ��5   M   �� *
UserList+   RowStyle 5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      ��  �� Property � �� �� Value
 ���� 63    �� Triggers 5      P� 5       P� Property �@��AlternationIndex P� Value$ 0��6K   . �5      ��  � ��
 �����6;   5      P� 5       �@��AlternationIndex$ 1��6K   . �5      ��  � ��
 ��ح�6;   5      P� 5       �@��AlternationIndex$ 2��6K   . �5      ��  � ��
 � ���6;   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 编号��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *UserId+6L     5       $ 姓名��6%   $ 80 6N    61   �� *
UserName+   HeaderTemplate 5!      �� 5"      .R�5#      �� 
���  ����6(   �� 69   5$      5&      4  .System.Windows.Controls.DataGridCheckBoxColumn  5(      $ 状态��6)    65   �� *	UserState+4  .System.Windows.Controls.DataGridComboBoxColumn  5)      $ 部门��6)   $	 100 6_      DisplayMemberPath$ DeptName��5*   )      SelectedValuePath$ DeptId��6F      SelectedValueBinding 5)   6   �� *DeptId+   ElementStyle 5+      �� 5,      " ��6    .�5-      ��  � �� 6<   �� *DataContext.DeptList+ �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ WindowL�5.          EditingElementStyle  50      �� 51      " ��6    .�52      ��  � �� 6<   �� *DataContext.DeptList+ �� $ FindAncestor=�$ WindowL�53      55      4	  .System.Windows.Controls.DataGridTemplateColumn	  57      $ 年龄��6)   $ 60 65   ! 	  CellTemplate! 58      �� 59      .R�5:      �� 
��� � �
����ح���6$   �� *	UserAge+6S   5;      " 	  CellEditingTemplate" 5=      �� 5>      .R�5?      �� ��6&   �� *	UserAge+5@      5B      5D      5E      5F      