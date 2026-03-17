
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { 1, 2, 3, 4, 6, 8 };
//        int value = 1;
//        Console.WriteLine($" Before: {string.Join(" ", arr)}");
//        IncreaseAll(ref arr,value);
//        Console.WriteLine($" After: {string.Join(" ",arr)}");
//    }
//    static void IncreaseAll(ref int[] arr, int value)
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {

//            arr[i] +=value;

//        }

//    }
//}

//class Program
//{
//    static void Main()
//    {
//        double balance = 10;
//        double amount = 2;
//        Withdraw(ref balance,amount);


//    }
//    static void Withdraw(ref double balance, double amount)
//    {
//        if (balance >= amount)
//            {
//               Console.WriteLine( balance -= amount);
//            }
//            else
//            {
//                Console.WriteLine("Not enough balance");
//            }

//        }
//}





//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 5, 2, 9, 1, 6, 3 };

//        GetMinMax(numbers, out int min, out int max);

//        Console.WriteLine($"Min: {min}, Max: {max}");
//    }

//    static void GetMinMax(int[] arr, out int min, out int max)
//    {
//        min = arr[0];
//        max = arr[0];

//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < min)
//                min = arr[i];
//            if (arr[i] > max)
//                max = arr[i];
//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        //bool s= true;
//        int number = 3;
//        bool isEven;
//        Console.WriteLine(ProcessNumber(ref number,out isEven));
//        Console.WriteLine($"number*2={number}");
//    }
//    static bool ProcessNumber(ref int number,out bool isEven)
//    {
//         if (number % 2 == 0)
//        {
//            isEven = true;
//        }
//        else
//        {
//            isEven = false;
//        }
//        number *= 2;

//        return isEven ;
//    }

//}


class Produck
{
    public string Name;
    public int Price;
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: {Price}");
    }
}
class Book : Produck
{
    public string Author;
    public void ShowInfoBook()
    {
        ShowInfo();
        Console.WriteLine($"Author: {Author}");
    }

}
class Program
{
    static void Main()
    {
        Book myBook = new Book();
        myBook.Name = "The Trial";
        myBook.Price = 100;
        myBook.Author = "Kafka";
        myBook.ShowInfoBook();

    }


}


