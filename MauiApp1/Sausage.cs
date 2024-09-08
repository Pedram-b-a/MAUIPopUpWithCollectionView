using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    //fdsa
    public class Sausage
    {
        public string BrandName { set; get; }
        public string ImageSource { set; get; }
        public string Descreption { set; get; }
        public float Price { set; get; }

        public Sausage(string brandName, string imageSource, string descreption, float price) 
        {
            this.BrandName = brandName;
            this.ImageSource = imageSource;
            this.Descreption = descreption;
            this.Price = price;
        }
    }
}
