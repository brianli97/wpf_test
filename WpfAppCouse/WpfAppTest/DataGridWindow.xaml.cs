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
                user.UserState = (int)dr["UserState"] == 1 ? true : false;
                user.UserAge = (int)dr["UserAge"];
                user.Deptid = (int)dr["Deptid"];
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
                dept.DeptId = (int)dr["DeptId"];
                dept.DeptName = dr["DeptName"].ToString();
                list.Add(dept);
            }
            dr.Close();
            return list;

        }

        
    }
    public class DeptInfo
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }

    }
}
