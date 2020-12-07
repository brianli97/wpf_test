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
    /// TabControlWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TabControlWindow : Window
    {
        public TabControlWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object content = tabSystem.SelectedContent;//选项的选项卡的content对象  StackPanel
            object tabItem = tabSystem.SelectedItem;
        }


        /// <summary>
        /// 依次切换页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChang_Click(object sender, RoutedEventArgs e)
        {
            //tabSystem.SelectedItem = tabSystem.Items[2];
            if (tabSystem.SelectedIndex < tabSystem.Items.Count - 1)
            {
                tabSystem.SelectedIndex += 1;
            }
            else
            {
                tabSystem.SelectedIndex = 0;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Error
            //GridWindow gridWindow = new GridWindow();
            //grRole.Children.Add(gridWindow);
        }
    }
}
