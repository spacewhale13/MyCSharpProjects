

/*Численное интегрирование методом прямоугольников*/

using System;
class Program{
    static void Main(string[] args) {
        Console.Write("Введите левую границу: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите правую границу: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите число итераций: ");
        int n = int.Parse(Console.ReadLine());
        if (b <= a || n <= 0)
             
        {
            Console.WriteLine("Ошибка: убедитесь, что правая граница больше левой, а число итераций положительно.");
            return;
        }

        double result_1 = Solution_left(Solve, a, b, n);
        double result_2 = Solution_right(Solve, a, b, n);
        double result_3 = Solution_medium(Solve, a, b, n);
        //double abs_result = Mistake(Solution_left, Solution_right, Solution_medium);
        Console.WriteLine("Результат методом левых прямоугольников" + result_1);
        Console.WriteLine("Результат методом правых прямоугольников" + result_2);
        Console.WriteLine("Результат методом средних прямоугольников" + result_3);
        
    }

    static double Solve(double x)
    {
        return Math.Log(x);
    }
    static double Solution_left(Func<double, double> f, double a, double b, int n)
    {

        double h = (b - a) / n;
        double total_l = 0.0;


        for (int i = 0; i < n; i++)
        {
            double x_i = a + i * h;
            total_l += f(x_i) * h;
        }
        return total_l;
    }


    static double Solution_right(Func<double, double> f, double a, double b, int n)
    {

        double h = (b - a) / n;
        double total_r = 0.0;


        for (int i = 0; i < n; i++)
        {
            double x_i = a + (i + 1) * h;
            total_r += f(x_i) * h;
        }
        return total_r;
    }

    static double Solution_medium(Func<double,double> f, double a, double b, int n) {

        double h = (b - a) / n;
        double total_m = 0.0;
        

        for (int i = 0; i < n; i++)
        {
                double x_i = a + (i + 0.5) * h;
                total_m += f(x_i) * h;
        }
        return total_m;
    }

    }

