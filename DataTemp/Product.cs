using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemp
{
    public enum pCategories
    {
        Food,
        Mehanical
    }
    public class Product
    {
        public string pName { get; set; }
        public string pView { get; set; }
        public string pInfo { get; set; }
        public decimal pPrice { get; set; }
        public pCategories pCategory { get; set; }
    }
}
