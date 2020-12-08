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
using WpfAppTest.Models;

namespace WpfAppTest
{
    /// <summary>
    /// MenuWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class MenuWindow1 : Window
    {
        public MenuWindow1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<MenuInfo> allMenus = GetMenuList();//基础菜单数据
            List<MenuItemModel> menusList = new List<MenuItemModel>();//目标菜单数据
            AddAllMenus(allMenus, menusList,null,0);
            VMenuModel vmodel = new VMenuModel();
            vmodel.MenuList = menusList;
            this.DataContext = vmodel;//当前window的数据上下文
        }


        /// <summary>
        /// 递归加载菜单项数据
        /// </summary>
        /// <param name="allMenus"></param>
        /// <param name="menusList"></param>
        /// <param name="pMenu"></param>
        /// <param name="parentId"></param>
        private void AddAllMenus(List<MenuInfo> allMenus, List<MenuItemModel> menusList, MenuItemModel pMenu, int parentId)
        {
            var subList = allMenus.Where(m => m.ParentId == parentId);
            foreach (var mi in subList)
            {
                MenuItemModel miInfo = new MenuItemModel();
                miInfo.MenuId = mi.MenuId;
                miInfo.MenuName = mi.MenuName;
                miInfo.MKey = mi.MKey;
                if (pMenu != null)
                {
                    pMenu.SubItems.Add(miInfo);
                }
                else
                {
                    menusList.Add(miInfo);
                }
                AddAllMenus(allMenus, menusList, miInfo, mi.MenuId);
            }
        }

        /// <summary>
        /// 获取菜单数据
        /// </summary>
        /// <returns></returns>
        private List<MenuInfo> GetMenuList()
        {
            string sql = "select MenuId,MenuName,ParentId,MKey from MenuInfos";
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, 1);
            List<MenuInfo> list = new List<MenuInfo>();
            while (dr.Read())
            {
                MenuInfo menu = new MenuInfo();
                menu.MenuId = (int)dr["MenuId"];
                menu.MenuName = dr["MenuName"].ToString();
                menu.ParentId = (int)dr["ParentId"];
                menu.MKey = dr["MKey"].ToString();
                list.Add(menu);
            }
            dr.Close();
            return list;
        }
    }

    public class VMenuModel
    { 
        /// <summary>
        /// Menu控件数据源属性
        /// </summary>
        public List<MenuItemModel> MenuList { get; set; }
    }
}
