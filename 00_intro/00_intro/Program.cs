namespace _00_intro
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int a;

    //        int b = 12;

    //        const int c = 13;

    //        Console.WriteLine(c);
    //        Console.Write(b);
    //    }
    //}


    //internal class Program
    //{
    //    static void Main()
    //    {
    //        // Значимые типы (объекты --> в стеке) -> структуры и т.д...

    //        bool a = true;  // true / false

    //        byte b;         // 0 -> 255

    //        sbyte c;        // -128 -> 127

    //        short d;        // -32768 -> 32767

    //        ushort e;       // 0 -> 65535

    //        int f;

    //        uint g;

    //        long h;

    //        ulong i;

    //        float j;

    //        double k;

    //        decimal l;

    //        char m;

    //        // Ссылочные типы (объекты --> в куче) -> классы и т.д...

    //        string n;

    //        object o;

    //        // Неявная (отложенная) типизация

    //        int value1 = 12;
    //        var value2 = 12;
    //        // var value3;         // ERROR
    //    }
    //}



    class Program
    {
        static void Main(string[] args)
        {
            // ===== Console output

            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.SetCursorPosition(12, 4);

            //Console.WriteLine("Vasia");

            //Console.ResetColor();


            // ===== Console input

            Console.Write("Write your email: ");
            string email = Console.ReadLine();
            Console.Write("Write your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Email: {email}, Age: {age}");
        }
    }
}
