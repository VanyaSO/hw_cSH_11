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
        Console.WriteLine(ArithmeticOperations(12, n => Math.IsEven(n)));
        Console.WriteLine(ArithmeticOperations(12, n => Math.IsOdd(n)));
        Console.WriteLine(ArithmeticOperations(12, n => Math.IsPrime(n)));
        Console.WriteLine(ArithmeticOperations(12, n => Math.IsFibonacci(n)));
    }
}