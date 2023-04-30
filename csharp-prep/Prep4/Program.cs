using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;    
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sumList = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sumList += numbers[i];
        }
        Console.WriteLine($"The sum of the numbers in the list is: {sumList}");
        
        float avgList = ((float)sumList) / numbers.Count;

        Console.WriteLine($"The average of the numbers in the list is: {avgList.ToString("0.00")}");

        int max = numbers[0];
        foreach ( int number in numbers )
        {
            if ( number > max )
            {
                max = number;
            }
        }

        Console.WriteLine($"The highest number in the list is: {max}");

        int min = numbers[0];
        foreach ( int number in numbers )
        if ( ( ( number < min ) ) && number > 0 )
        {
            min = number;
        }

        Console.WriteLine($"The smallest positive number in the list is: {min}");


        numbers.Sort();
        Console.WriteLine("Sorted numbers of the list:");
        for (int i = 0; i < numbers.Count; i++)
        {
            int number = numbers[i];
            Console.WriteLine(number);
        }
    }
}