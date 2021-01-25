using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax

        public void Add(Product product)
        {
            Console.WriteLine("Ürününüz Sepete Eklendi: " + product.Name);
        }

        public void Add2(string productName, string productDescription, double productPrice, int stockQuantity)
        {
            Console.WriteLine("Ürününüz Sepete eklendi : " + productName);
        }


    }
}
