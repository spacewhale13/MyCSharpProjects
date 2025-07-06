

/*Интеграл синуса методом трапеций*/

using System;
class Program
{
    static (double, double, int) Input()
    {
        Console.WriteLine("введите левую границу: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("введите правую границу: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("введите число итераций: ");
        int n = int.Parse(Console.ReadLine());
        if (b < a || n <= 0)
        {
            Console.WriteLine("Ошибка");
            throw new Exception("Сообщение");
        }
        else
        {
            return (a, b, n);
        }
            
    }
    static void Main(string[] args)
    {
        (double a, double b, int n) = Input();

        double result = Trapize(Solve, a, b, n);
        Console.WriteLine(result);
    }
    static double Solve(double x)
    {
        
        return Math.Sin(x);

    }
    static double Trapize(Func<double,double> f, double a, double b, int n)
    {
        double h = (b - a) / n;
        
        double total = f(a) + f(b);

        for (int i = 1; i < n ; i++)
        {
            total += 2 * (f(a + h * i));
        }
        return (h / 2) * total;
    }
}
