using System;

public class AdvancedCalculator : ICalculatable
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new ArgumentException("Деление на ноль недопустимо.");
        }
        return a / b;
    }

    public double Power(double baseNumber, double exponent)
    {
        return Math.Pow(baseNumber, exponent);
    }

    public double SquareRoot(double number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Извлечение корня из отрицательного числа недопустимо.");
        }
        return Math.Sqrt(number);
    }

    public void PerformCalculation()
    {
        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        Console.WriteLine("5. Возведение в степень");
        Console.WriteLine("6. Извлечение квадратного корня");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        double result = 0;
        switch (choice)
        {
            case 1:
                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());
                result = Add(num1, num2);
                break;
            case 2:
                Console.Write("Введите второе число: ");
                double num3 = double.Parse(Console.ReadLine());
                result = Subtract(num1, num3);
                break;
            case 3:
                Console.Write("Введите второе число: ");
                double num4 = double.Parse(Console.ReadLine());
                result = Multiply(num1, num4);
                break;
            case 4:
                Console.Write("Введите второе число: ");
                double num5 = double.Parse(Console.ReadLine());
                result = Divide(num1, num5);
                break;
            case 5:
                Console.Write("Введите показатель степени: ");
                double exponent = double.Parse(Console.ReadLine());
                result = Power(num1, exponent);
                break;
            case 6:
                result = SquareRoot(num1);
                break;
            default:
                Console.WriteLine("Неверный выбор операции.");
                return;
        }

        Console.WriteLine($"Результат операции: {result}");
    }
}

class Program
{
    static void Main()
    {
        AdvancedCalculator calculator = new AdvancedCalculator();
        calculator.PerformCalculation();
    }
}
