using System;
using System.Linq;
using System.Reflection;

class HW2
{

    static int[] generate_random_array(int len=5)
    {
        var rand = new Random();
        int[] arr = new int[30];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(255);
        }
        return arr;
    }

    static void task_1(int[] arr)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"{i}. {arr[i]} ");
        }
    }

    static int task_2()
    {
        int[] arr = generate_random_array(20);
        //int max = 0;

        //for (int i = 1; i < arr.Length; i++)
        //{
        //    if (arr[i] > arr[max])
        //    {
        //        max = i;
        //    }
        //}
        int max =arr.Max();

        int max_index = Array.IndexOf(arr,max);

        //task_1(arr);

        Console.WriteLine(max_index);

        return max_index;
    }

    static int task_3()
    {
        int[] arr = generate_random_array(20);
        int max = Int32.MinValue;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i]%2==0 && arr[i] > max)
            {
                max = arr[i];
            }
        }

        task_1(arr);
        int max_index = Array.IndexOf(arr, max);

        Console.WriteLine(max_index);

        return max_index;
    }

    static int[] task_4(int index)
    {
        int[] arr = generate_random_array(20);

        int[] new_arr = new int[arr.Length-1];

        int tmp = arr[index];
        arr[index] = arr[arr.Length-1];
        arr[arr.Length - 1] = tmp;

        for (int i = 0; i < new_arr.Length; i++)
        {
            new_arr[i]= arr[i];
        }

        return new_arr;
    }


    static int[] task_5(int value)
    {
        //int[] arr = generate_random_array(20);
        int[] arr = {25, 12, 23, 23, 123, 123, 221, 31, 23, 25, 22, 5, 25, 2131, 123, 1231, 2, 12, 3123, 123, 25, 25, 25, 123, 122, 32, 52, 52, 25};
        int counter = 0;

        int tmp;
        //task_1(arr);

        for (int i = 0; i < arr.Length-counter; i++)
        {
            if (arr[i] == value)
            {
                tmp = arr[i];
                arr[i] = arr[arr.Length - 1 - counter];
                arr[arr.Length - 1 - counter] = tmp;
                counter++;
                i--;
            }
        }

        int[] new_arr = new int[arr.Length - counter];


        for (int i = 0; i < new_arr.Length; i++)
        {
            new_arr[i] = arr[i];
        }
        //task_1(new_arr);
        return new_arr;
    }

    static int[] task_6(int value,int index)
    {
        //int[] arr = generate_random_array(20);
        int[] arr = { 1,2,2,2,4,4,5,6,6,7,8,9 };
        int counter = 0;
        int duplicate_counter = 0;
        Array.Sort(arr);


        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                counter += 1;
            }
        }

        int[] new_arr = new int[arr.Length + 1];


        task_1(new_arr);
        return new_arr;
    }

    static void Main()
    {

        //task_1(generate_random_array(30));
        //task_2();
        //task_3();
        //task_4(3);
        //task_5(25);
        //task_6(3,2);
        task_7();

    }
}