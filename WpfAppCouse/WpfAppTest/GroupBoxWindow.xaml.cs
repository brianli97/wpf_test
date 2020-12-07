using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppTest
{
    /// <summary>
    /// GroupBoxWindow.xaml 的交互逻辑
    /// </summary>
    public partial class GroupBoxWindow : Window
    {
        public GroupBoxWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //如果我们没有设置TextBox的name属性，通过GroupBox控件去获取
            StackPanel spFirst = gbInfo.Content as StackPanel;
            foreach (var ele in spFirst.Children)
            {
                StackPanel sp = ele as StackPanel;
                foreach (var ele2 in sp.Children)
                {
                    if (ele2 is TextBox)
                    {
                        TextBox txt = ele2 as TextBox;
                        string name = txt.Text;
                    }
                }
            }

            string name1 = txtuserName.Text;//直接通过name属性获取控件的text
        }
    }
}
