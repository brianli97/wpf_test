using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfAppTest.Models
{
    //菜单项绑定实体
    public class MenuItemModel
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string MKey { get; set; }
        public List<MenuItemModel> SubItems { get; set; }
        public MenuItemModel()
        {
            SubItems = new List<MenuItemModel>();
        }
        public ICommand MICommand
        {
            get 
            {
                return new RelayCommand(o =>
                {
                    MessageBox.Show(MenuName);
                });
            }
        }
    }
}
