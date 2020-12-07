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
    /// CheckBoxWindow.xaml 的交互逻辑
    /// </summary>
    public partial class CheckBoxWindow : Window
    {
        public CheckBoxWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            

            //代码动态不回checkbox
            string[] names = { "体育", "唱歌", "跳舞", "绘画" };
            for (int i = 0; i < names.Length; i++)
            {
                CheckBox chk = new CheckBox();
                chk.Content = names[i];
                chk.HorizontalAlignment = HorizontalAlignment.Left;
                chk.VerticalAlignment = VerticalAlignment.Top;
                chk.Margin = new Thickness(40+i*80, 60, 0, 0);
                grid1.Children.Add(chk);


            }

           

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show( chkSport.IsChecked.ToString());
            //获取到窗口中所有勾选的CheckBox的Content
            string strContents = "";
            foreach (UIElement ele in grid1.Children)
            {
                if (ele is CheckBox)
                {
                    CheckBox chk = ele as CheckBox;
                    if (chk.IsChecked == true)
                    {
                        if (strContents != "")
                            strContents += ",";
                        strContents += chk.Content.ToString();
                    }
                }
            }
            MessageBox.Show(strContents);
        }
    }
}
