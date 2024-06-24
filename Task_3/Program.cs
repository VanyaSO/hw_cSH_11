namespace Task_3;
// Завдання 3
// Створіть додатки для виконання арифметичних операцій. Підтримувані операції:
// ■ Перевірка числа на парність;
// ■ Перевірка числа на непарність;
// ■ Перевірка на просте число;
// ■ Перевірка на число Фібоначчі.
// Обов’язково використовуйте делегат типу Predicate.
class Program
{
    public static bool ArithmeticOperations(int a, Predicate<int> predicate)
    {
        return predicate(a);
    }

    
    static void Main(string[] args)
    {

        Predicate<int> IsEven = Math.IsEven;
        Predicate<int> IsOdd = Math.IsOdd;
        Predicate<int> IsPrime = Math.IsPrime;
        Predicate<int> IsFibonacci = Math.IsFibonacci;
        
        Console.WriteLine(ArithmeticOperations(12, IsEven));
        Console.WriteLine(ArithmeticOperations(12, IsOdd));
        Console.WriteLine(ArithmeticOperations(12, IsPrime));
        Console.WriteLine(ArithmeticOperations(12, IsFibonacci));
    }
}