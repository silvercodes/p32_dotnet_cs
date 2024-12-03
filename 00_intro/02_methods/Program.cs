
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


// void Modify1(User user)
// {
//     user.id = 12;               // :-)
//     user = new User();          // второй объект под локальной ссылкой
// }

// void Modify2(ref User user)
// {
//     user.id = 12;               // :-)
//     user = new User();          // пересоздание объекта под внешней ссылкой
// }

// //User user = new User();
// //Modify1(user);
// //Console.WriteLine(user.id);     // 12

// User user = new User();
// Modify2(ref user);
// Console.WriteLine(user.id);      // 12


// class User
// {
//     public int id = 1;
// }






// === Передача по ссылке (in) Входной параметр ====

//void Modify(in User user)
//{
//    user.id = 120;              // :-)
//    // user = new User();       // ERROR
//}
//void Render(User u) => Console.WriteLine($"id: {u.id}");

//User u = new User();
//Modify(in u);
//Render(u);


//class User
//{
//    public int id;
//}




// === Передача по ссылке (out) Выходной параметр ====

//void Modify(out User user)
//{
//    // user.id = 120;           // ERROR

//    user = new User();
//    user.id = 120;
//}

//void Render(User u) => Console.WriteLine($"id: {u.id}");

//User user;
//Modify(out user);
//Render(user);
//// >>> EQUALS <<<
//Modify(out User user2);
//Render(user2);

//class User
//{
//    public int id;
//}




// === Передача по ссылке (ref readonly) Ссылка только для чтения ====

//void Modify(ref readonly User user)
//{
//    // user = new User();       // ERROR
//    // user.id = 120;           // ERROR
//}

//void Render(User u) => Console.WriteLine($"id: {u.id}");

//User user = new User(101);
//// user.id = 120;               // ERROR
//Modify(user);
//Render(user);

//readonly struct User
//{
//    public readonly int id;
//    public User(int id)
//    {
//        this.id = id;
//    }
//}

#endregion

#region params

//int Sum(params int[] values)
//{
//    int result = 0;
//    foreach (int value in values)
//        result += value;

//    return result;
//}

//Console.WriteLine(Sum(3, 5, 6, 7, 8, 9, 2, 1, 1, 1));
//Console.WriteLine(Sum());
//int[] arr = [3, 4, 6, 7, 8];
//Console.WriteLine(Sum(arr));



//int Sum(int init, params int[] values)
//{
//    int result = init;
//    foreach (int value in values)
//        result += value;

//    return result;
//}

//Console.WriteLine(Sum(3, 1, 1, 1, 1, 1));
//Console.WriteLine(Sum(0));
//int[] arr = [1, 1, 1, 1, 1];
//Console.WriteLine(Sum(0, arr));

#endregion

#region Local functions

//void Compare(int[] a, int[] b)
//{
//    int init = 0;                   // <<<---
//    int sum1 = Sum(a);
//    int sum2 = Sum(b);

//    if (sum1 > sum2)
//        Console.WriteLine("a > b");
//    else
//        Console.WriteLine("a <= b");

//    int Sum(int[] arr)
//    {
//        int result = init;          // <<<---
//        foreach(int value in arr)
//            result += value;

//        return result;
//    }

//    static void Test()
//    {
//        // Console.WriteLine(init);        // ERROR
//    }
//}

#endregion

#region switch

//int val = 34;
//switch(val)
//{
//    case 1:
//        //
//        break;
//    case 2:
//    case 3:
//        //
//        break;
//    case 4:
//        goto case 3;
//    default:
//        //
//        break;
//}



//int Calculate(int a, int b, int operation)
//{
//    switch(operation)
//    {
//        case 0:
//            return a + b;
//        case 1: 
//            return a - b;
//        case 2:
//            return a * b;
//        case 3:
//            return a / b;
//        default:
//            throw new NotImplementedException();
//    }
//}

// >>> EQUALS <<<

//int Calculate(int a, int b, int operation)
//{
//    return operation switch
//    {
//        0 => a + b,
//        1 => a - b,
//        2 => a * b,
//        3 => a / b,
//        _ => throw new NotImplementedException()
//    };
//}

// >>> EQUALS <<<

//int Calculate(int a, int b, int operation) => operation switch
//{
//    0 => a + b,
//    1 => a - b,
//    2 => a * b,
//    3 => a / b,
//    _ => throw new NotImplementedException()
//};

#endregion

#region enum

// Status status = 2;       // ERROR
//Status status = Status.Finished;
//Console.WriteLine(status);
//Console.WriteLine((int)status);

//enum Status: byte
//{
//    Runnig = 2,
//    Pending = 4,
//    Finished = 8,
//    Error = 2,
//    Fatal = Error,
//}



//int Calculate(int a, int b, Operation operation) => operation switch
//{
//    Operation.Add => a + b,
//    Operation.Sub => a - b,
//    Operation.Mul => a * b,
//    Operation.Div => a / b,
//    _ => throw new NotImplementedException()
//};

//Console.WriteLine(Calculate(3, 4, Operation.Mul));

//enum Operation: byte
//{ 
//    Add, 
//    Sub,
//    Mul,
//    Div,
//}

#endregion



