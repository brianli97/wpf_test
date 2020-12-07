using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// ListViewWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ListViewWindow : Window
    {
        public ListViewWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //代码设置ItemSource
           // lvList.ItemsSource = GetUserList();
            lvList.DataContext= GetUserList();
        }

        /// <summary>
        /// 获取用户信息列表
        /// </summary>
        /// <returns></returns>
        private List<UserInfo> GetUserList()
        {
            List<UserInfo> list = new List<UserInfo>();
            string sql = "select UserId,UserName,UserState,UserAge,Deptid from UserInfos where Deptid>0";
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, 1);
            while (dr.Read())
            {
                UserInfo user = new UserInfo();
                user.UserId = (int)dr["UserId"];
                user.UserName = dr["UserName"].ToString();
                user.UserState = (int)dr["UserState"];
                user.UserAge = (int)dr["UserAge"];
                user.Deptid = (int)dr["Deptid"];
                list.Add(user);
            }
            dr.Close();
            return list;
        }
    }

    public class UserInfo
    { 
        public int UserId { get; set;}
        public string UserName { get; set; }
        public int UserState { get; set; }
        public int UserAge { get; set; }
        public int Deptid { get; set; }

    }


}
