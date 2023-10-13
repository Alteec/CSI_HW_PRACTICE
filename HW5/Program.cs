using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;

class HW5
{
    static int[] generate_random_array(int len = 5)
    {
        var rand = new Random();
        int[] arr = new int[len];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(255);
        }
        return arr;
    }


    static void task_1(string site) // Первое задание, перехват исключения запроса к несуществующему веб-ресурсу
    {
        HttpWebRequest req =
            (HttpWebRequest)WebRequest.Create(site);   //Создание запроса к сайту {site}
        WebResponse response= null; // Объявление пустого ответа на запрос
        
        try
        {
            Console.WriteLine($"Connecting to {site}");  

            response = req.GetResponse(); // Попытка запроса к сайту
        }
        catch(Exception e)
        {
            Console.WriteLine($"Unsuccessful \nError: {e.Message}"); // Перехват исключения
            /*throw e;*/

        }
        finally
        {
            Console.WriteLine($"Finished\n _____");
        }
    }

    static void task_2(int[] arr) // Второе задание, обработка исключения выхода за пределы массива
    {
    

        try
        {
            for(int i=0; i<arr.Length+5; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"\nError: {e.Message}");
            /*throw e;*/

        }
        finally
        {
            Console.WriteLine($"Finished processing the array\n _____");
        }
    }

    static void task_3_2()
    {
        try
        {
            int test = 0;
            test = 100 / test;
        }
        catch (Exception e)
        {
            throw new Exception("EXCEPTION", e);

        }

    }


    static void task_3() // Третье задание, вызов метода из другого метода, поднять исключение в вызывающий метод(не совсем понял условие)
    {

          task_3_2();

    }

    static void task_4() // Тоже самое что в 3 задании(опечатка?)
    {

        task_3_2();

    }



    static void Main()
    {
        //task_1("https://sso.satbayev.university/");
        //task_1("https://asdf");
        //task_2(generate_random_array(10));
        //task_3();
        task_4();


    }
}