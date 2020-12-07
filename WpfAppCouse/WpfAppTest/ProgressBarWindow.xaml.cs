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
using System.Threading;

namespace WpfAppTest
{
    /// <summary>
    /// ProgressBarWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ProgressBarWindow : Window
    {
        public ProgressBarWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //pbar2.Value=0;
            //for (int i = 0; i <= pbar2.Maximum; i++)
            //{
            //    pbar2.Value = i;
            //    label.Content = pbar2.Value + "%";
            //    Thread.Sleep(100);
            //}

            double max = pbar2.Maximum;
            //开启子线程
            Task.Run(() =>
            {
                for (int i = 0; i <= max; i++)
                {
                    //任务投放  线程
                    pbar2.Dispatcher.Invoke(()=>
                    {
                        pbar2.Value = i;
                        //label.Content = pbar2.Value + "%";
                    });
                    
                    Thread.Sleep(100);
                }
            });
           
        }

        //进度条主线程
        private void pbar2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
            label.Content = e.NewValue + "%";
        }
    }
}
