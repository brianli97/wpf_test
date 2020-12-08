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
using System.Data.SqlClient;

namespace WpfAppTest
{
    /// <summary>
    /// DataGridWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DataGridWindow : Window
    {
        public DataGridWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取用户信息列表
        /// </summary>
        /// <returns></returns>
        private List<UserInfoNew> GetUserList()
        {
            List<UserInfoNew> list = new List<UserInfoNew>();
            string sql = "select UserId,UserName,UserState,UserAge,Deptid from UserInfos where Deptid>0";
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, 1);
            while (dr.Read())
            {
                UserInfoNew user = new UserInfoNew();
                user.UserId = (int)dr["UserId"];
                user.UserName = dr["UserName"].ToString();
                user.UserState = (int)dr["UserState"] == 1 ? true : false;
                user.UserAge = (int)dr["UserAge"];
                user.DeptId = (int)dr["Deptid"];
                list.Add(user);
            }
            dr.Close();
            return list;
        }

        private List<DeptInfo> GetDepts()
        {
            List<DeptInfo> list = new List<DeptInfo>();
            string sql = "select Deptid,DeptName from DeptInfos";
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, 1);
            while (dr.Read())
            {
                DeptInfo dept = new DeptInfo();
                dept.DeptId = (int)dr["Deptid"];
                dept.DeptName = dr["DeptName"].ToString();
                list.Add(dept);
            }
            dr.Close();
            return list;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //首先，设置comboBox列的数据源
            //colDept.DisplayMemberPath = "DeptName";
            //colDept.SelectedValuePath = "DeptId";
            //colDept.ItemsSource = GetDepts();

            //没有显示下拉框？？？？
            //如果没有设置列的Name属性
            //DataGridComboBoxColumn deptCol = dgList.Columns[3] as DataGridComboBoxColumn;
            //deptCol.ItemsSource = GetDepts();

            //dgList.ItemsSource = GetUserList();


            //初始化DGVModel
            DGVModel vmodel = new DGVModel();
            vmodel.UserList = GetUserList();
            vmodel.DeptList = GetDepts();

            this.DataContext = vmodel;
        }
    }

    public class UserInfoNew
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool UserState { get; set; }
        public int UserAge { get; set; }
        public int DeptId { get; set; }

    }

    public class DeptInfo
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }

    }


    /// <summary>
    /// Window的数据上下文对象
    /// </summary>
    public class DGVModel
    { 
        public List<UserInfoNew> UserList { get; set; }
        public List<DeptInfo> DeptList { get; set; }
    }

}
