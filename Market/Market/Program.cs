using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Product cur_product;
            int choose;
            List<Product> products = new List<Product>();
            Product insert_product;
            
            
            cur_product.Name = "Молоко"; cur_product.DateOfManufacture=new DateTime(2020,06,27);cur_product.ExpiryDate=new DateTime(2020,07,3); cur_product.Price=5;products.Add(cur_product);
            cur_product.Name = "Мясо"; cur_product.DateOfManufacture = new DateTime(2020, 10, 27); cur_product.ExpiryDate = new DateTime(2020, 07, 30); cur_product.Price = 50; products.Add(cur_product);
            while (true)
            { 
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($"Наименование продукта:{products[i].Name}    "+$"Дата изготовления:{products[i].DateOfManufacture}     "+$"Дата окончания срока годности:{products[i].ExpiryDate}    "+$"Цена:{products[i].Price}");
                }

                Console.WriteLine("Выберите действие:\n0-Выход из программы \n1-Добавить продукт \n2-Удалить продукт \n3-Редактировать ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch(choose)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("Введите название продукта:");
                        cur_product.Name=Console.ReadLine();
                        Console.WriteLine("Введите дату изготовления:");
                        cur_product.DateOfManufacture=DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Ввдите дату окончания срока годности:");
                        cur_product.ExpiryDate=DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Введите цену продукта:");
                        cur_product.Price=Convert.ToInt32(Console.ReadLine());
                        products.Add(cur_product);
                        break;
                    case 2:
                        Console.WriteLine("Введите порядковый номер товара");
                        int id = Convert.ToInt32(Console.ReadLine());
                        products.RemoveAt(id);   
                        break;
                    case 3:
                        Console.WriteLine("Введите порядковый номер товара");
                        int n = Convert.ToInt32(Console.ReadLine());
                        products.RemoveAt(n);
                        Console.WriteLine("Введите название продукта:");
                        cur_product.Name = Console.ReadLine();
                        Console.WriteLine("Введите дату изготовления:");
                        cur_product.DateOfManufacture = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Ввдите дату окончания срока годности:");
                        cur_product.ExpiryDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Введите цену продукта:");
                        cur_product.Price = Convert.ToInt32(Console.ReadLine());
                        products.Insert(n,cur_product);
                        break;
                    default:
                        Console.WriteLine("Неверное значение");
                        break;
                       

                }
            }
        }
        struct Product
        {
            public string Name;
            public DateTime DateOfManufacture;
            public DateTime ExpiryDate;
            public int Price;
        }
    }
}
