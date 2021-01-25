using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Elma";
            double productPrice = 15;
            string productDescription = "Amasya Elması";

            string[] fruits = new string[] {"Elma","Karpuz" };

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.ProductPrice = 15;
            product1.ProductDescription = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.ProductPrice = 80;
            product2.ProductDescription = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            //type-safe -- tip güvenli
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.ProductPrice);
                Console.WriteLine(product.ProductDescription);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("-------------Metotlar------------");

            //instance - örnek ( class örneği )
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Add2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Add2("Karpuz", "Diyarbakır karpuzu", 12, 8);



        }
    }
}

//Dont repeat your self - DRY - Clean Code - Best Practice