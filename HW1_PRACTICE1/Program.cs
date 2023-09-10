class HW1
{
    static void task_1()
    {

        Console.WriteLine("Task 1\nName: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello { name}");
    }

    static void task_2()
    {
        string num="";
        int sum = 0;
        Console.WriteLine("Task 2");

        while (num.CompareTo("0")!=0)
        {
            Console.WriteLine("Num(0 to stop): ");

            num = Console.ReadLine();

            sum += Convert.ToInt32(num);
        }

        Console.WriteLine($"Sum is: {sum}");
    }

    static void Main()
    {
        task_1();
        task_2();
    }
}