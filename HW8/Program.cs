using System;
using System.Diagnostics.Metrics;

namespace HW8
{
    public enum Discount
    {
        Work_Veteran=30,
        War_Veteran=50,
        None=0,
    }

    public enum Season
    {
        winter=60,
        fall=60,
        summer=0,
        spring=0,
    }

    public enum Type
    {
        water=40,
        gas=50,
        fix=100,
    }
    class Task1
    {
        int[] arr { get; set; }

        public Task1(int len)
        {
            this.arr=new int[len];
        }

        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = (int)Math.Pow(value,2); }
        }

    }

    class Task2
    {
        public Discount discount { get; set; } = 0;

        int m { get; set; }
        public int people { get; set; }

        public Task2(int m, int people, Discount discount)
        {
            this.m = m;
            this.people = people;
            this.discount = discount;
        }



        public string this[Season season]
        {
            get {
                string a = "";
                double cost;
                double discount;
                double counter = 0;
                foreach (Type name in Enum.GetValues(typeof(Type))) { 

                    if(name==Type.fix || name == Type.water)
                    {
                        cost = (int)name * this.people;
                    }
                    else
                    {
                        cost = (int)name * this.m;
                    }
                    discount = cost - (cost * (double)this.discount/100);
                    counter += discount;
                    a += $"{name,-15}{cost,-15}{discount,-15}{discount,-15}\n";
                }
                discount = (int)season - (int)season * (double)this.discount / 100;
                a += $"{"Heat",-15}{(int)season,-15}{discount,-15}{discount,-15}";
                counter += discount;
                return $"{"Вид",-15}{"Начислено",-15}{"Скидка",-15}{"Итого",-15}\n {a}\n{counter,-15}"; 
            }
            }
        }



  

    class HW8
    {
        static void Main()
        {
            Task1 task1=new Task1(120);
            task1[0] = 2;
            task1[1] = 3;
            task1[2] = 4;
            for(int i = 0; task1[i]!=0; i++) {
                Console.WriteLine(task1[i]);
            }

            Task2 task2 = new Task2(40, 2,Discount.Work_Veteran);
            Console.WriteLine(task2[Season.winter]);
        }
    }
}