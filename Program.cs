using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------------------------------\n Task 1");
        firstTask();
        Console.WriteLine("---------------------------------\n Task 2");
        secondTask();
        Console.WriteLine("---------------------------------\n Task 3");
        thirdTask();
    }

    static void firstTask()
    {
        var array = createListWithRandomDigit(20);
        printArray(array.ToArray());

        var plus = array.First(n => n > -1);
        var smallerZero = array.Last(n => n < 0);

        Console.WriteLine(
            "\n--------------\n" + plus + "\n" + smallerZero);

    }

    static void secondTask()
    {
        var d = "5";
        var array = createListWithRandomDigit(20);

        printArray(array.ToArray());
        Console.WriteLine();
        var flag = false;
        foreach (int element in array)
        {
            if (element.ToString()[element.ToString().Length - 1].ToString().Contains(d) & element > 0)
            {
                Console.WriteLine("Answer: " + element);
                flag = true;
                break;
            }

        }
        if (!flag)
        {
            Console.WriteLine("Answer: " + 0);
        }

    }

    static void thirdTask()
    {
        var array = createListWithRandomDigit(20).Select(n => Convert.ToString(n)).ToList();
        printArray(array.ToArray());
        Console.WriteLine();
        string l = "2";
        string last = array.Last(n => (n[0] == '-' ? (n.Length == Convert.ToInt32(l) + 1) : (n.Length == Convert.ToInt32(l))) & (n[0] == '-' ? n[1] == l.ToCharArray()[0] : n[0] == l.ToCharArray()[0]));
        if (last != null)
        {
            Console.WriteLine(last);
        }
        else
        {
            Console.WriteLine(0);
        }


    }

    static void printArray(Array array)
    {
        foreach (Object element in array)
        {
            Console.Write(element.ToString() + " ");
        }
    }

    static List<int> createListWithRandomDigit(int lengthOfList)
    {
        Random random = new Random();
        var array = new List<Int32>();
        for (int i = 0; i < lengthOfList; i++)
        {
            array.Add(random.Next(-100, 100));
        }
        return array;
    }
}