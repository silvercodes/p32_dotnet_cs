
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

class User
{
    public static int maxId = 0;
    public int id;
    public User()
    {
        id = ++User.maxId;
    }
    public static void ResetMaxId() => User.maxId = 0;

}

#endregion


