using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.NewFolder1
{
    internal class Products
    {

        public Products(string n, string c, float p, int id, string brand,string category ) 
        {
            Name = n;
            Country = c;
            Category = category;
            ID = id;
            brandName = brand;
            price = p;
        }
        public string Name;
        public int ID;
        public float price;
        public string Category;
        public string Country;
        public string brandName;
        public float TotalPrice()
        {
            
                 
            
            return price;
        }
    }
}
