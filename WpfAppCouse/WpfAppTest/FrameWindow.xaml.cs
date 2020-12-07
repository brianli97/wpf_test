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
    /// FrameWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FrameWindow : Window
    {
        public FrameWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //1直接在xaml代码中设置Source
            //2.
            //framePage.Source = new Uri("PageRoleInfo.xaml",UriKind.Relative);
            //3.先实例化page对象
            PageRoleInfo pageRoleInfo = new PageRoleInfo();
            framePage.Navigate(pageRoleInfo);
            string ss = "aaa";
            framePage.Navigate(pageRoleInfo, ss);//假设需要传值
        }
    }
}
