using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace lab8
{
    public class Product
    {
        public int idProd { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int idCategory { get; set; }
    }

    public class Category
    {
        public int idCategory { get; set; }
        public string name { get; set; }
    }

    class Program
    {
      

        static void Main(string[] args)
        {
            

            List<Product> prod = new List<Product>() { 
                new Product { idProd = 4, name = "Ложка", price = 15, idCategory = 1 },
                new Product { idProd = 65, name = "Розы", price = 20, idCategory = 2 },
                new Product { idProd = 22, name = "Тарелка", price = 30, idCategory = 3 },
                new Product { idProd = 12, name = "Машинка", price = 15, idCategory = 4 },
            };

            //СОЗДАНИЕ ТОВАРА ПОЛЬЗОВАТЕЛЯМ
         /*   Console.WriteLine("Создайте товар:\n\n");
            int inp = 0;
            string nm = "";
            int inp2 = 0;
            int inp3 = 0;

            for (int i = 0; i <= 10; i++ ) {
                Console.WriteLine("Номер товара: (Для отмены напишите 0)");
                if ((inp = Convert.ToInt32(Console.ReadLine())) == 0)
                {
                    break;
                }
                else { 
                inp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nНазвание товара:");
                nm = Console.ReadLine();
                Console.WriteLine("\nЦена товара:");
                inp2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n Номер категории товара:");
                inp3 = Convert.ToInt32(Console.ReadLine());
                prod.Add(new Product { idProd = inp, name = nm, price = inp2, idCategory = inp3 });
                }
            } 

            Console.WriteLine("Создайте категорию:"); */

            List<Category> categoriesPrint = new List<Category>() {
                new Category { idCategory = 1, name = "Столовые принадлежности" },
                new Category { idCategory = 2, name = "цветы"},
                new Category { idCategory = 3, name = "Посуда"},
                new Category { idCategory = 4, name = "Игрушки"},
            };

            //СОЗДАНИЕ КАТЕГОРИЙ ПОЛЬЗОВАТЕЛЯМ
            /*  int inp1 = 0;
              string nm1 = "";


              for (int i = 0; i <= 10; i++)
              {
                  Console.WriteLine("Номер категории:  (Для отмены напишите 0)");
                  if ((inp1 = Convert.ToInt32(Console.ReadLine())) == 0)
                  {
                      break;
                  }
                  else
                  {
                      inp1 = Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine("\nНазвание категории:");
                      nm1 = Console.ReadLine();
                      categoriesPrint.Add(new Category { idCategory = inp1, name = nm1  });
                  }
              }
            */


            var allProducts = from p in prod select p;
            Console.WriteLine(" Вывод товаров : \n");
            foreach (var item in allProducts)
            {
                Console.WriteLine(" Код товара: {0} \n Название товара: {1} \n Цена товара: {2} eur \n Категория товара: {3} \n " , item.idProd, item.name, item.price, item.idCategory);
            }
            Console.WriteLine("\n ------------------------------------------------------------- \n");

            var allCategories = from b in categoriesPrint select b;
            Console.WriteLine("\n Вывод категорий : \n");
            foreach (var cat in allCategories)
            {
                Console.WriteLine(" Категория товара: {0} \n Название категории: {1} \n", cat.idCategory, cat.name);
            }

            Console.WriteLine("\n ------------------------------------------------------------- \n");
            Console.WriteLine("\n Сортировка в обратном алфавитном порядке для товаров: \n");
            var sortingProd = from h in prod orderby h.name descending select h;


            foreach (var prodSort in sortingProd)
            {
                Console.WriteLine(" Название товара: {0} \n", prodSort.name);
            }

            Console.WriteLine("\n ------------------------------------------------------------- \n");
            Console.WriteLine("\n Сортировка в обратном алфавитном порядке для категорий: \n");
            var sortingCategories = from f in categoriesPrint orderby f.name descending select f;

            foreach (var catSort in sortingCategories)
            {
                Console.WriteLine(" Название категории: {0} \n", catSort.name);
            }

            Console.WriteLine("\n ------------------------------------------------------------- \n");
            Console.WriteLine("\n Сортировка товаров, цена которых превышает среднюю цену: \n");

            var avg = prod.Average(a => a.price);
            var sortingProdAveragePrice = from g in prod where g.price > avg select g;

            foreach (var prodsSort in sortingProdAveragePrice)
            {
                Console.WriteLine(" Название товара: {0} \n Цена товара: {1} \n", prodsSort.name, prodsSort.price);
            }

            Console.WriteLine("\n ------------------------------------------------------------- \n");
            Console.WriteLine("\n Cодержимое двух массивов с объединением по Коду категории : \n");

            var methodJoin = from l in prod
                             join y in categoriesPrint
                             on l.idCategory equals y.idCategory
                             select new { ProductName = l.name, categoryName =  y.name, 
                                          ProductPrice = l.price, ProductId = l.idProd,
                                          ProductidCat = y.idCategory};



            foreach (var joinMethod in methodJoin)
            {
                Console.WriteLine(" " +
                    "Название товара : {0} \n " +
                    "Цена товара: {2} \n " +
                    "Категория товара: {1} \n " +
                    "Номер товара: {3} \n " +
                    "Номер категории: {4}  \n", 
                    joinMethod.ProductName, 
                    joinMethod.categoryName, 
                    joinMethod.ProductPrice , 
                    joinMethod.ProductId, 
                    joinMethod.ProductidCat);
            }


            Console.Read();
        }
    } 
}
