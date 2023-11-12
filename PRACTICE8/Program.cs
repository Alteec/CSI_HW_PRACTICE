using System;

namespace Practice
{


    public class Practice
    {

        public class Pr1
        {
            int[] arr { get; set; } = { 1, 2, 3, 4, 5, 6 };
            int start { get; set; } = 0;

            public int this[int i]
            {
                get
                {
                    try
                    {
                        return this.arr[i - 1];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Out of Range");
                        throw;
                    }
                }
                set { }
            }
            public override string ToString()
            {
                string a = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    a += i + " ";
                }
                return a;
            }
        }
        public class Shop
        {
            public List<Product> products = null;
            public Shop()
            {
                this.products = new List<Product>();
            }

            public decimal this[string cat]
            {
                get
                {
                    TimeSpan from = new TimeSpan(8, 0, 0);
                    TimeSpan to = new TimeSpan(12, 0, 0);

                    decimal cost = 0;

                    foreach (Product product in this.products)
                    {
                        if (product.category == cat)
                        {
                            cost += product.cost;
                        }
                        TimeSpan time = DateTime.Now.TimeOfDay;
                        if (time > from && time < to)
                        {
                            return cost * 0.95m;
                        }
                    }
                    return cost;

                }

            }
        }
        public class Product
        {
            public string category { get; set; }
            string name { get; set; }

            public decimal cost { get; set; }

            public Product(string category, string name, decimal cost)
            {
                this.category = category;
                this.name = name;
                this.cost = cost;
            }
        }

        static void Main()
        {

            Pr1 test=new Pr1();
            Console.WriteLine(test[1]);

            Product pr1 = new Product("Meat", "Beef", 5.5m);
            Product pr2 = new Product("Dairy", "Milk", 2.5m);
            Product pr3 = new Product("Dairy", "Kefire", 3.5m);

            Shop shop = new Shop();
            shop.products.Add(pr1);
            shop.products.Add(pr2);
            shop.products.Add(pr3);

            Console.WriteLine(shop["Dairy"]);
        }
    }


    }