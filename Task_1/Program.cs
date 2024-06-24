namespace Task_1;
// Створіть додаток, який відображає текстове повідомлення. Використовуйте механізми делегатів. Делегат має
// повертати void та приймати один параметр типу string
    // (текст повідомлення). Для тестування додатка створіть
    // різні методи виклику через делегат.



class Program
{
    static void Main(string[] args)
    {
        MessageDelegate message;

        int a = 5;
        if (a == 1)
        {
            message = Message.SuccessMessage;
        }
        else if (a == 0)
        {
            message = Message.WarningMessage;
        }
        else
        {
            message = Message.ErrorMessage;
        }

        message("Test");
    }

}