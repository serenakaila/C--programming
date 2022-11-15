using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("What is the most loved animal in the world");

        Console.WriteLine("1. cat");
        Console.WriteLine("2. dog");
        Console.WriteLine("3. bird");
        Console.WriteLine("4. elephant");

        Console.WriteLine("Enter the correct choice");

        int opt = Convert.ToInt32(Console.ReadLine());

        if (opt == 2)
        {
            Console.WriteLine("Correct");
        }
      else
      {
                Console.WriteLine("Incorrect");
        }

      Console.WriteLine("When is the next olympics");

        Console.WriteLine("1. 2022");
        Console.WriteLine("2. 2023");
        Console.WriteLine("3. 2024");
        Console.WriteLine("4. 2025");

        Console.WriteLine("Enter the correct choice");

        int opt1 = Convert.ToInt32(Console.ReadLine());

        if (opt1 == 3)
        {
            Console.WriteLine("Correct");
        }
      else
      {
                Console.WriteLine("Incorrect");
        }

      Console.WriteLine("What is the closest planet to the sun");

        Console.WriteLine("1. Mercury");
        Console.WriteLine("2. Venus");
        Console.WriteLine("3. Mars");
        Console.WriteLine("4. Saturn");

        Console.WriteLine("Enter the correct choice");

        int opt3 = Convert.ToInt32(Console.ReadLine());

        if (opt3 == 1)
        {
            Console.WriteLine("Correct");
        }
      else
      {
                Console.WriteLine("Incorrect");
        }


      Console.WriteLine("What is the oldest age someone lived to");

        Console.WriteLine("1. 117");
        Console.WriteLine("2. 189");
        Console.WriteLine("3. 122");
        Console.WriteLine("4. 110");

        Console.WriteLine("Enter the correct choice");

        int opt4 = Convert.ToInt32(Console.ReadLine());

        if (opt4 == 3)
        {
            Console.WriteLine("Correct");
        }
      else
      {
                Console.WriteLine("Incorrect");
        }

      
    }
}
