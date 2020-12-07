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
    /// DatePickerWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DatePickerWindow : Window
    {
        public DatePickerWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //dpDate.Text = Convert.ToDateTime(dpDate.Text).ToString("yyyy-MM-dd");
        }

        private void dpDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            dpDate.Text = Convert.ToDateTime(dpDate.Text).ToString("yyyy-MM-dd");
        }
    }
}
