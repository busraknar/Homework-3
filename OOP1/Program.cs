

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };
            //PascalCase     camelCase
            //İlkharbüyük   ilkharfküçük      case sensitive
            ProductManager productManager = new ProductManager();  //bellekteki yerine referans vererek gidiyorsun
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Topla2(3, 6); //işlem sonucunda çıkan değeri kullanamayız(void)

            int toplamaSonucu = productManager.Topla(3,6);
            Console.WriteLine(toplamaSonucu *2);

            //int sayi = 100;
            //productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi);

            //int, double, bool değer tipi
            //diziler, class, abstract, interface referans tipi


        }
    }
}