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
using WpfAppTest.Sys;

namespace WpfAppTest
{
    /// <summary>
    /// MenuWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开角色管理页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miRole_Click(object sender, RoutedEventArgs e)
        {
            RoleWindow roleWin = new RoleWindow();
            roleWin.Show();
        }

        private void miUser_Click(object sender, RoutedEventArgs e)
        {
            UserManageWindow userWin = new UserManageWindow();
            userWin.Show();
        }

    }
}
