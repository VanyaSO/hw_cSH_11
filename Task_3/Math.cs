namespace Task_3;

public static class Math
{
    public static bool IsEven(int number) => number % 2 == 0;
    public static bool IsOdd(int number) => number % 2 != 0;
    public static bool IsPrime(int number)
    {
        for (int i = 2; i <= System.Math.Sqrt(number); i++) {
            if (number % i == 0) {
                return false;
            }
        }

        return true;
    }
    public static bool IsFibonacci(int number)
    {
        if (number < 0)
            return false;

        int a = 0, b = 1;
        while (b < number)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return b == number;
    }
    
}