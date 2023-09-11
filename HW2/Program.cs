using System;

class HW2
{
    static int task_1()
    {

        Console.WriteLine("Task 1\nText: ");
        int counter = 0;

        char chr='t';

        while (chr.CompareTo('.') != 0)
        {
            chr=Console.ReadKey().KeyChar;
            if(chr.CompareTo(' ') == 0)
            {
                counter++;
            }
        }
        //sum += Convert.ToInt32(num);

        Console.WriteLine("\n Amount of spaces:"+counter);
        return counter;
    
    }

    static bool task_2()
    {

        Console.WriteLine("Task 2");

        int num = Convert.ToInt32(Console.ReadLine());
        int first_half = 0;
        int second_half = 0;

        for(int i = 0; i < 6; i++)
        {
            if (i > 2)
            {
                first_half += num % 10;
                num = num / 10;
                continue;
            }
            second_half += num % 10;
            num = num / 10;
        }
        if (first_half == second_half)
        {
            Console.WriteLine($"Lucky number: {first_half} = {second_half}");

            return true;
        }
        return false;
    }

    static string task_3()
    {
        Console.WriteLine("Task 3");

        string text = Console.ReadLine();

        string converted = "";

        for(int i=0; i < text.Length; i++)
        {
            if ((int)text[i]>=65 && (int)text[i] <= 90){
                converted += (char)((int)text[i]+32);
            }
            else if ((int)text[i] >= 97 && (int)text[i] <= 122)
            {
               converted += (char)((int)text[i] - 32);
            }
            else
            {
                converted += text[i];
            }

        }
        Console.WriteLine(converted);
        return converted;
    }

    static void task_4()
    {
        Console.WriteLine("Task 4");

        int a = -1;
        int b = -3;

        while (b < a)
        {
            Console.Write("a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToInt32(Console.ReadLine());
        }

        for(int i=a;i<=b; i++)
        {
            for(int j = 0; j < i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }


    static void task_5()
    {
        Console.WriteLine("Task 5");

        int n =  Convert.ToInt32(Console.ReadLine());
        int new_num = 0;
        int temp = 1;

        while (n > 0)
        {
            new_num *= 10;
            new_num += (n % 10);
            n = n / 10;
            temp *= 10;
        }
        Console.WriteLine(new_num);
    }

    static void task_6()
    {
        Console.WriteLine("Task 6");
        var rand = new Random();
        for(int i = 0; i < 3; i++)
        {
            Console.Write($"{rand.Next(1, 100),4}");
        }
    }

    static double task_7(double x) //task 16 in the assignment 
    {
        Console.WriteLine("Task 7");

        double result = (7*x*x)-(3*x)+6;
        Console.WriteLine(result);
        return result;
    }



    static double task_8(double x) //task 18 in the assignment 
    {
        Console.WriteLine("Task 8");

        return x *x;
    }

    static void task_9(int a,int b) //task 22 in the assignment 
    {
        Console.WriteLine("Task 9");
        Console.WriteLine($" a. {(a+b)/2} ");

        Console.WriteLine($" b. {Math.Sqrt(a*b)}");

    }

    static void task_10(float km, float ft) //task 31 in the assignment 
    {
        Console.WriteLine("Task 10");
        if(km==ft* 0.0003048)
        {
            Console.WriteLine("Equal");
        }
        else if(km > ft * 0.0003048)
        {
            Console.WriteLine("KM");
        }
        else
        {
            Console.WriteLine("FT");

        }
    }

    static void task_11(int a) //task 32 in the assignment 
    {
        Console.WriteLine("Task 11");
        if (a%2==0)
        {
            Console.Write("Even");
        }
        else
        {
            Console.Write("Odd");
            if (a % 10 == 7)
            {
                Console.Write(", ends with 7");
            }
        }
    }

    static void task_12(int a) //task 33 in the assignment 
    {
        Console.WriteLine("Task 12");
        if (a / 10 == a % 10)
        {
            Console.Write("Equal");
        }
        else if(a / 10 > a % 10)
        {
            Console.Write("First");
        }
        else
        {
            Console.Write("Second");

        }

    }

    static string task_13(int a) //task 34 in the assignment 
    {
        Console.WriteLine("Task 13");
        switch (a)
        {
            case 1:
                return "Monday";
            case 2:
                return "Tuesday";
            case 3:
                return "Wednesday";
            case 4:
                return "Thursday";
            case 5:
                return "Friday";
            case 6:
                return "Saturday";
            case 7:
                return "Sunday";
        }
        return "";
    }

    static void task_14() //task 42 in the assignment 
    {
        Console.WriteLine("Task 14");
        for(int i = 1; i < 10; i++)
        {
            for(int j = 1;j < 10; j++)
            {
                Console.WriteLine($"{i}*{j}={i * j}");
            }
        }
    }

    static float task_15(float r) //task 19 in the assignment 
    {
        return r / 2;
    }

    static double task_16(double x) //task 17 in the assignment 
    {
        Console.WriteLine("Task 16");

        double result = (12 * x * x) - (7 * x) - 16;
        Console.WriteLine(result);
        return result;
    }

    static double task_17(double x,double y) //task 21 in the assignment 
    {
        Console.WriteLine("Task 17");

        Console.WriteLine("Task 7");

        double result = x*x*x - 2.5*x*y + 1.78*x*x - 2.5*y +1;
        Console.WriteLine(result);
        return result;
    }

    static void task_18() //task 25 in the assignment 
    {
        Console.WriteLine("Task 18:");
        Console.WriteLine("Num: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int tens = num / 10;
        int ones = num % 10;
        Console.WriteLine($"{num}\n Tens: {tens}\n Ones: {ones} \n Sum: {tens + ones} \n Product: {tens * ones}");
    }

    static void task_19() //task 26 in the assignment 
    {
        Console.WriteLine("Task 19:");
        Console.WriteLine("Num: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int thousands = num / 1000;
        int hundreds = (num % 1000) / 100;
        int tens = ((num % 1000) % 100) / 10;
        int ones = ((num % 1000) % 100) % 10;
        Console.WriteLine($"Sum: {thousands + hundreds + tens + ones} \nProduct: {thousands * hundreds * tens * ones}");
    }

    static void task_20() //task 28 in the assignment 
    {
        Console.WriteLine("Task 20:");
        Console.WriteLine($"not X and not Y: {!x && !y} \nX or (not X and not Y):{x || (!x && !y)} \n(not X and Y) or Y: {(!x && y) || y}");
    }

    static void Main()
    {
        task_1();
        //task_2();
        //task_3();
        //task_4();
        //task_5();
        //task_6();
        //task_7(2);
        //task_8(2);
        //task_9(2, 6);
        //task_10(10,333);
        //task_11(12);
        //task_12(11);
        //Console.WriteLine(task_13(5));
        //task_14();
        //Console.WriteLine(task_15(12));
        //task_16(12);
        //task_17(1,2);
        //task_18();
        //task_19();
        //task_20();
    }
}