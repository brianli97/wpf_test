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
    /// ListBoxWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ListBoxWindow : Window
    {
        public ListBoxWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbClasses.ItemsSource = GetClassInfos();
            lbClasses.SelectedValuePath = "ClassId";//项的值对应的属性名
            lbClasses.DisplayMemberPath = "ClassName";//项的显示文本对应的属性名
            lbClasses.SelectedIndex = 0;      
            
            //如果动态添加、移除项，情况与combobox类似
        }

        private List<ClassInfo> GetClassInfos()
        {
            List<ClassInfo> list = new List<ClassInfo>();
            list.AddRange(new ClassInfo[]
                {           
                    new ClassInfo()
                    {
                        ClassId=1,
                        ClassName="计算机一班"
                    },
                    new ClassInfo()
                    {
                        ClassId=2,
                        ClassName="计算机二班"
                    },
                     new ClassInfo()
                    {
                        ClassId=3,
                        ClassName="商务英语一班"
                    },
                      new ClassInfo()
                    {
                        ClassId=3,
                        ClassName="商务英语二班"
                    },
                });
            return list;

        }
    }
}
