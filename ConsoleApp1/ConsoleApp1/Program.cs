/*
Напишите программу, которая считывает с 
клавиатуры десять целых чисел, определяет, 
сколько среди них положительных чисел, и если положительных чисел нет, 
выводит сообщение «Положительных чисел нет». Если положительные числа есть, 
программа вычисляет их среднее арифметическое (с использованием целочисленного деления) 
и выводит результат на экран.*/



using System;
class Program
{
    static void Main(string[] args)
    {
        int avarage_plus = 0;
        int count_plus = 0;
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            if (number > 0) {
                count_plus++;
                sum += number;
            }
            
           
        }
        if (count_plus == 0)
        {
            Console.WriteLine("Положительных чисел нет");
        }
        else
        {
            avarage_plus = sum / count_plus;
            Console.WriteLine(avarage_plus);
        }
            
        

    }
        
    }
