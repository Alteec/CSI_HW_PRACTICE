class Practice2
{
    static void task_1()
    {
        Console.WriteLine("Task 1:");
        int a = 1; 
        int b=2; 
        int c=3;
        Console.WriteLine($"{a} {b,2} {c,2}");
    }

    static void task_2()
    {
        Console.WriteLine("Task 2:");
        Console.WriteLine("5\n10\n21");
    }

    static void task_3()
    {
        Console.WriteLine("Task 3:\nEnter cm:");
        int cm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{cm} cm in meters: {cm/100.0}");
    }

    static void task_4()
    {
        Console.WriteLine("Task 4:");
        Console.WriteLine($"{234/7} full weeks in 234 days");
    }

    static void task_5()
    {
        Console.WriteLine("Task 5:");
        Console.WriteLine("Num: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int tens = num / 10;
        int ones = num % 10;
        Console.WriteLine($"{num}\n Tens: {tens}\n Ones: {ones} \n Sum: {tens+ones} \n Product: {tens*ones}");

    }

    static void task_6()
    {
        Console.WriteLine("Task 6:");
        bool A = true;
        bool B = false;
        bool C = false;
        Console.WriteLine($" A or B: {A || B} \n A and B: {A && B} \n B or C: {B || C}");

    }

    static void task_7()
    {
        Console.WriteLine("Task 7: \n Circle radius: ");
        int r_circle = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Square side: ");
        int a_square = Convert.ToInt32(Console.ReadLine());

        var circle_area = Math.PI * Math.Pow(r_circle, 2);
        var square_area = Math.Pow(a_square, 2);

        if (circle_area>square_area )
        {
            Console.WriteLine("Circle area");
        }
        else if (circle_area==square_area)
        {
            Console.WriteLine("Equal");
        }
        else 
        {
            Console.WriteLine("Square area");
        }
        
    }

    static void task_8()
    {
        Console.WriteLine("Task 8: \n Object 1 mass and volume: ");
        int m1 = Convert.ToInt32(Console.ReadLine());
        int v1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Object 2 mass and volume: ");
        int m2 = Convert.ToInt32(Console.ReadLine());
        int v2 = Convert.ToInt32(Console.ReadLine());

        if (m1/v1>m2/v2)
        {
            Console.WriteLine("First object");
        }
        else if (m1 / v1 == m2 / v2)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Second Object");
        }
    }

    static void task_9()
    {
        Console.WriteLine("Task 9: \n Circuit 1 Voltage and Resistance: ");
        int v1 = Convert.ToInt32(Console.ReadLine());
        int r1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Circuit 2 Voltage and Resistance:");
        int v2 = Convert.ToInt32(Console.ReadLine());
        int r2 = Convert.ToInt32(Console.ReadLine());

        if (v1 / r1 > v2 / r1)
        {
            Console.WriteLine("First circuit");
        }
        else if (v1 / r1 == v2 / r1)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Second circuit");
        }
    }
    static void task_10()
    {

        Console.WriteLine("Task 10: \n Circuit 1 Voltage and Resistance: ");

        for (int i = 20; i <= 35; i++)
        {
            Console.WriteLine(i);
        }


        int b = 0;

        while (b <= 10)
        {
            Console.WriteLine("b:");
            b = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 10; i < b; i++)
        {
            Console.WriteLine(i*i);
        }

        int a = 50;
        while (a >= 50)
        {
            Console.WriteLine("a:");
            a = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = a; i < 50; i++)
        {
            Console.WriteLine(i * i);
        }

        Console.WriteLine("a:");
        a = Convert.ToInt32(Console.ReadLine());
        b = a - 1;

        while (b <= a)
        {
            Console.WriteLine("b:");
            b = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = a; i < b; i++)
        {
            Console.WriteLine(i);
        }

    }

    static int task_11(int x)
    {
        Console.WriteLine("Task 11:");

        return x * x;
    }


    static void task_12(int r)
    {
        Console.WriteLine("Task 12: ");

        double circumference = 2 * Math.PI * r;
        double radius = Math.PI * Math.Pow(r, 2);
        Console.WriteLine($"Circumference: {circumference} \nRadius: {radius}");
    }

    static void task_13()
    {
        task_3();
    }

    static void task_14()
    {
        task_4();
    }


    static void task_15()
    {
        task_5();
    }

    static void task_16()
    {
        Console.WriteLine("Task 16:");
        Console.WriteLine("Num: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int thousands = num / 1000;
        int hundreds = (num % 1000) / 100;
        int tens = ((num%1000)%100) / 10;
        int ones = ((num % 1000) % 100)%10;
        Console.WriteLine($"Sum: {thousands+hundreds+tens + ones} \nProduct: {thousands*hundreds*tens * ones}");
    }

    static void task_17()
    {
        Console.WriteLine("Task 17:");

        int result = 456;
        int x=((result/100)*100)+((result%10)*10)+(result%100)/10;
        Console.WriteLine($"X: {x}");
    }

    static void task_18(bool x,bool y)
    {
        Console.WriteLine("Task 18:");
        Console.WriteLine($"not X and not Y: {!x && !y} \nX or (not X and not Y):{x || (!x && !y)} \n(not X and Y) or Y: {(!x && y)||y}");
    }

    static void task_19()
    {
        Console.WriteLine("Task 19:");

        int a = 12, b = 16;
        Console.WriteLine($"{a} {b}");

        unsafe
        {
            swap(&a, &b);  //task 19
        }
        Console.WriteLine($"{a} {b}");

    }


    unsafe static void swap(int* a, int* b)
    {
        int tmp = *a;
        *a = *b;
        *b = tmp;
    }

    static void task_20()
    {
        Console.WriteLine("Task 20:");

        task_19();

    }

    unsafe static int assign_values(int* a, int* b,int x,int y)
    {
        *a = x*y;
        *b = x/y;
        return 0;
    }

    static void task_21()
    {
        Console.WriteLine("Task 21:");

        int x = 100;
        int y = 10;
        int a = 0;
        int b = 0;
        unsafe
        {
            assign_values(&a, &b,x,y);
        }
    }

    static int task_22(int x,int y)
    {
        Console.WriteLine("Task 22:");

        if (x==0 && y == 0)
        {
            return 0;
        }
        else if (y == 0)
        {
            return 12 / x;
        }
        else if (y == 0)
        {
            return 12 / y;
        }
        else
        {
            return 144 / (x * y);
        }
    }

    static int task_23(int h, int m, int s)
    {
        Console.WriteLine("Task 23:");

        return (h * 3600) + m * 60 + s;
    }

    static int task_24(int m,int d)
    {
        Console.WriteLine("Task 24:");

        return ((m-1) * 30) + d;
    }

    static int task_25(int m, int d) {
        return task_24(m,d);
    }

    static int task_26(int m1=1000, int m2=1000,int m3=1000)

    {
        Console.WriteLine("Task 26:");

        if (m1<m2 && m1 < m3)
        {
            return m1;
        }
        else if(m2<m1 && m2 < m3)
        {
            return m2;
        }
        else
        {
            return m3;
        }
    }

    static bool task_27(int n)
    {
        Console.WriteLine("Task 27:");

        return n % 2==0;
    }

    static int task_28(int a,int b,int c)
    {
        Console.WriteLine("Task 28:");

        return task_26(a, b, c);
    }

    static void task_29()
    {
        Console.WriteLine("Task 29:");

        Random rnd = new Random();
        int grade = rnd.Next(2, 6);
        switch (grade)
        {
            case 2:
                Console.WriteLine("Fail");
                break;
            case 3:
                Console.WriteLine("OK");
                break;
            case 4:
                Console.WriteLine("Good");
                break;
            case 5:
                Console.WriteLine("Excellent");
                break;

        }
    }

    static void task_30(int M,int N)
    {
        Console.WriteLine("Task 30:");

        for (int i = M; i < N; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static int task_31(int N, int n)
    {
        Console.WriteLine("Task 31:");

        for (int i = N; ; i++)
        {
            if (i % n == 0)
            {
                Console.WriteLine(i);

                return i;
            }
        }
    }


    static void Main()
    {
        task_1();
        //task_2();
        //task_3();
        //task_4();
        //task_5();
        //task_6();
        //task_7();
        //task_8();
        //task_9();
        //task_10();
        //task_11(5);
        //task_12(12);
        //task_13();
        //task_14();
        //task_15();
        //task_16();
        //task_17();
        //task_18(true, true);
        //task_19();
        //task_20();
        //task_21();
        //task_22(12,15);
        //task_23(12,43,15);
        //task_24(11,5);
        //task_25(11,5);
        //task_26(800,500);
        //task_27();
        //task_28(400,600,300);
        //task_29();
        //task_30(22,100);
        //task_31(100,40);


    }
}