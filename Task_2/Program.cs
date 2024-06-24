namespace Task_2;

// Створіть додаток для виконання арифметичних операцій. Підтримувані операції:
    // ■ Додавання двох чисел;
    // ■ Віднімання двох чисел;
    // ■ Множення двох чисел.
    // Код програми обов’язково має використати механізм 
    
// Завдання 4
// Реалізуйте додаток із другого практичного завдання
// за допомогою виклику Invoke.

class Program
{
    public static double Calculate(double a, double b, Func<double, double, double> method)
    {
        return method(a, b);
    }
    
    public static double CalculateInvoke(double a, double b, Func<double, double, double> method)
    {
        return method.Invoke(a, b);
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(Calculate(12,54, Math.Sum));
        Console.WriteLine(Calculate(12,54, Math.Sub));
        Console.WriteLine(CalculateInvoke(12,54, Math.Mul));
    }
}