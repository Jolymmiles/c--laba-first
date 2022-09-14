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
        Console.WriteLine("---------------------------------\n Task 4");
        fourthTask();
        Console.WriteLine("---------------------------------\n Task 5");
        fifthTask();
        Console.WriteLine("---------------------------------\n Task 6");
        sixthTask();
        Console.WriteLine("---------------------------------\n Task 7");
        seventhTask();
        Console.WriteLine("---------------------------------\n Task 7");
        eightTask();

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
        try
        {
            string last = array.Last(n => (n[0] == '-' ? (n.Length == Convert.ToInt32(l) + 1) : (n.Length == Convert.ToInt32(l))) & (n[0] == '-' ? n[1] == l.ToCharArray()[0] : n[0] == l.ToCharArray()[0]));
            Console.WriteLine(last);
        }
        catch (Exception)
        {
            Console.WriteLine(0);
        }
    }

    static void fourthTask()
    {
        var array = createListWithRandomDigit(20).Select(n => Convert.ToString(n));
        var symbolC = "5";
        printArray(array.ToArray());
        try
        {
            var lastElem = array.Single(elem => elem[elem.Length - 1].Equals(symbolC));
            Console.WriteLine(lastElem);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("\nAnswer: empty");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("\nAnswer: Error");
        }
    }
    /* Даны символ С и строковая последовательность A. Найти количество элементов
    A, которые содержат более одного символа и при этом начинаются и оканчиваются
    символом C. */
    static void fifthTask()
    {
        var array = createListWithRandomDigit(20).Select(n => Convert.ToString(n)).ToList();
        var symbolC = '5';
        array.Add("55");
        printArray(array.ToArray());

        try
        {
            var countOfElem = array.Count(n => n.Count(e => e.Equals(symbolC)) > 1 & n[0].Equals(symbolC) & n[n.Length - 1].Equals(symbolC));
            Console.WriteLine("\n" + countOfElem);
        }
        catch (Exception)
        {
            Console.WriteLine("zero");
        }
    }
    /* Дана целочисленная последовательность. Найти количество ее
    положительных двузначных элементов, а также их среднее арифметическое (как
    вещественное число). Если требуемые элементы отсутствуют, то дважды вывести 0
    (первый раз как целое, второй – как вещественное).*/
    static void sixthTask()
    {
        var array = createListWithRandomDigit(20);
        printArray(array.ToArray());
        var countPositive = array.Count(n => n > -1);
        int sumOfPositiveDigit = array.Where(n => n > 0).Sum();
        decimal middle = Convert.ToDecimal(sumOfPositiveDigit) / Convert.ToDecimal(countPositive);
        Console.WriteLine("\nCount: " + countPositive + "\nSum: " + sumOfPositiveDigit + "\nMiddle: " + middle);
    }

    static void seventhTask()
    {
        var array = createListOfString(10);
        printArray(array.ToArray());
        Console.WriteLine();
        var l = 5;
        List<string> newArray = array.Where(n => n.Length == l).ToList();
        newArray.Sort();
        Console.WriteLine(newArray.Last());
    }

    static void eightTask(){
        var array = createListOfString(5);
        printArray(array.ToArray());
        Console.WriteLine();
        int a = 0;
        var count = array.Aggregate(0, (n, o) => o.Length + n );
        Console.WriteLine(count);
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
        var array = new List<int>();
        for (int i = 0; i < lengthOfList; i++)
        {
            array.Add(random.Next(-100, 100));
        }
        return array;
    }

    static List<string> createListOfString(int lengthOfList)
    {
        Random random = new Random();
        var array = new List<string>();
        for (int i = 0; i < lengthOfList; i++)
        {
            string s = "";
            for (int j = 0; j < random.Next(3, 10); j++)
            {
                s += (char)random.Next(97, 122);
            }
            array.Add(s);
        }
        return array;
    }
}