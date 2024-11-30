
#region Top-level staitments

//class Program
//{
//    static void Main()
//    {
//        // локальная ф-ция
//        int add(int a, int b)
//        {
//            return a + b;
//        }
//    }
//    // метод
//    void Log(string message)
//    {

//    }
//}


// локальная ф-ция в Main
//void Log(string message)
//{

//}

#endregion

#region Intro, parameters

//int Sum(int a, int b)
//{
//    return a + b;
//}

//Console.WriteLine(Sum(4, 5));


//void Render1(string message)
//{
//    Console.WriteLine($"MESSAGE: {message}");
//}
//// >>> EQUALS <<<
//void Render2(string message) => Console.WriteLine($"MESSAGE: {message}");

//Render1("Vasia");



//int Sum1(int a, int b)
//{
//    return a + b;
//}
//// >>> EQUALS <<<
//int Sum2(int a, int b) => a + b;



//void Render(string content, ConsoleColor color = ConsoleColor.Red)
//{
//    Console.ForegroundColor = color;
//    Console.WriteLine(content);
//}

//Render("Vasia");
//Render("Petya", ConsoleColor.Blue);



// ========= именованные "параметры" ========

//void Render(string content, int level = 5, ConsoleColor color = ConsoleColor.Red)
//{
//    Console.ForegroundColor = color;
//    Console.WriteLine($"content: {content}, level: {level}, color: {color}");
//    Console.ResetColor();
//}

//Render("content", 5, ConsoleColor.Blue);
//Render(content: "Vasia", color: ConsoleColor.Green);
//Render(level: 10, content: "Petya");


// ======= return =======

//string ClearEmail(string email)
//{
//    return email.ToLower();
//}
//Console.WriteLine(ClearEmail("PETya@MaIl.CoM"));
// >>> EQUALS <<<
//string ClearEmail(string email) => email.ToLower();
//Console.WriteLine(ClearEmail("PETya@MaIl.CoM"));

#endregion

#region ref / in / out / ref readonly

// === Передача по-значению ====
// Значимый тип --> копируется значение (объект)
// Ссылочный тип --> копируется ссылка

// === Передача по ссылке ====
//void Modify(ref int a)
//{
//    a = 12;
//}

//int value = 3;
//Modify(ref value);
//Console.WriteLine(value);


void Modify1(User user)
{
    user.id = 12;               // :-)
    user = new User();          // второй объект под локальной ссылкой
}

void Modify2(ref User user)
{
    user.id = 12;               // :-)
    user = new User();          // пересоздание объекта под внешней ссылкой
}

//User user = new User();
//Modify1(user);
//Console.WriteLine(user.id);     // 12

User user = new User();
Modify2(ref user);
Console.WriteLine(user.id);      // 12





class User
{
    public int id = 1;
}

#endregion