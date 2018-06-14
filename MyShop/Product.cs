using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    public abstract class Product
    {
        private string group;
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double cena;
        public double CCena
        {
            get { return cena; }
            set { cena = value; }
        }
        private string size;
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        private string desc;
        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        public Product (string group, string name, double cena, string size, string desc)
        {
            Group = group;
            Name = name;
            CCena = cena;
            Size = size;
            Desc = desc;
        }
        public Product(string group, string name, double cena, string size)
        {
            Group = group;
            Name = name;
            CCena = cena;
            Size = size;
        }
        public abstract string output(string group, string name, double cena, string size, string desc);
    }
}
