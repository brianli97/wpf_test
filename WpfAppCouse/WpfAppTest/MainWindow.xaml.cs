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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RadioButton rbtn = new RadioButton();
            rbtn.Content = "主任";
            rbtn.GroupName = "role";
            //rbtn.IsChecked = false;
            rbtn.HorizontalAlignment = HorizontalAlignment.Left;
            rbtn.VerticalAlignment = VerticalAlignment.Top;
            rbtn.Margin = new Thickness(100, 100, 0, 0);
            this.grid.Children.Add(rbtn);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string name = txtUName.Text.Trim();
            string pwd = txtUPwd.Password.Trim();

            //登录过程
            MessageBox.Show("登录成功", "登录提示", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((sender as RadioButton).Content.ToString());
        }
    }
}
