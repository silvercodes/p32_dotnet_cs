
#region Method overloading
// Имя перегрузки такое же
// Другое кол-во обязательных параметров
// Другой порядок типов параметров
// Другие типы параметров
// Другие модификаторы параметров (ref / in ....)

//class Temp
//{
//    public void Execute(int a, int b)
//    { }
//    // public int Execute(int a, int b) => 3;  // ERROR
//    public void Execute(int a, int b, int c)
//    { }
//    public void Execute(int a, double b)
//    { }
//    public void Execute(double a, int b)
//    { }
//    public void Execute(ref int a, int b)
//    { }
//}

#endregion

#region static

//User a = new();
//User b = new();
//a.Render();
//b.Render();
//Console.WriteLine(User.MaxId);

//Console.WriteLine(Tool.Add(3, 4));
//// Tool a = new();          // ERROR

//class User
//{
//    public static int maxId = 0;
//    public int id;
//    // static ctor
//    static User()
//    {
//        User.maxId = 0;
//    }
//    public User()
//    {
//        id = ++User.maxId;
//    }
//    public static void ResetMaxId() => User.maxId = 0;
//    public static int MaxId
//    {
//        get => User.maxId;
//        private set => User.maxId = value;
//    }

//    public static int Count { get; set; }
//    public void Render()
//    {
//        Console.WriteLine($"id: {id}");
//    }
//}

//static class Tool
//{
//    public static int Add(int a, int b) => a + b;
//    //public void Render()
//    //{ }
//}

#endregion

#region const / readonly fields / readonly struct

//User a = new User("no_name");
//// a.DefaultRole = "admin";             // ERROR
//Console.WriteLine(User.DefaultRole);
//// User.DefaultRole = "admin";          // ERROR

//Console.WriteLine(a.DefaultName);
//// a.DefaultName = "Vasia";             // ERROR

//class User
//{
//    // ~ static (не является частью состояния объекта)
//    public const string DefaultRole = "guest";

//    // ~ является частью состояния объекта
//    public readonly string DefaultName = "no_name";     // case 1
//    public User(string defaultName)
//    {
//        DefaultName = defaultName;                      // case 2
//    }
//}

//readonly struct Shape
//{
//    public readonly int id;
//    public int Size { get; }
//    public string Title { get; init; }
//    public Shape(int size, string title) 
//    { 
//        Size = size;
//        Title = title;
//    }
//}

#endregion
