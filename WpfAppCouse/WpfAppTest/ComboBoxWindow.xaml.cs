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
    public  class ClassInfo
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }

    }

    /// <summary>
    /// ComboBoxWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ComboBoxWindow : Window
    {
        public ComboBoxWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //获取数据源
            List<ClassInfo> list = GetClassInfos();

            //cboClasses.DataContext = list;
            //cboClasses.ItemsSource = list;//指定数据源

            cboClasses.SelectedValuePath = "ClassId";//项的值对应的属性名
            cboClasses.DisplayMemberPath = "ClassName";//项的显示文本对应的属性名

            //不能直接移除
            cboClasses.Items.Add(new ClassInfo()
            {
                ClassId = 4,
                ClassName = "软件班"
            });
            //动态添加移除
            foreach (ClassInfo cinfo in list)
            {
                cboClasses.Items.Add(cinfo);

            }


        }

        private List<ClassInfo> GetClassInfos()
        {
            List<ClassInfo> list = new List<ClassInfo>();
            list.AddRange(new ClassInfo[]
                {
                    new ClassInfo()
                    {
                        ClassId=0,
                        ClassName="请选择"
                    },
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cboClasses.Items.RemoveAt(1);
        }

        //选择项改变时
        private void cboClasses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show((cboClasses.SelectedItem as ClassInfo).ClassName);
            MessageBox.Show(cboClasses.Text);
        }
    }
}
