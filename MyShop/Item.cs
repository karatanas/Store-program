using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    class Item : Product
    {
        MainForm form = new MainForm();
        public Item(string group, string name, double cena, string size, string desc):base(group, name, cena, size, desc)
        {
        }
        public Item(string group, string name, double cena, string size) : base(group, name, cena, size)
        {
        }
        public override string output(string group, string name, double cena, string size, string desc)
        {
            
            return (form.listItems.Items.Add(String.Format(group, name, size, cena + "$", desc))).ToString();
        }
    }
}
