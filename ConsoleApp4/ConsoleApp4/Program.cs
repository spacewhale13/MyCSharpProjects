
/*Поиск максимального числа*/

using System;

class Solution
{
    public void Main(string[] args)
    {
        int num_max = 0;
        for (int i = 0; i <= 10; i++)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            if (num_max < number)
            {
                num_max = number;
            }

        }
        Console.WriteLine("Максимальное число равно " + num_max);
    }
}