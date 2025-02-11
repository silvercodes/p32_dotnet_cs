
#region Intro
//interface ILogger
//{
//    void Log(string message);
//    void Save();
//}
//abstract class FileLogger: ILogger
//{
//    public void Log(string message)
//    {}
//    public abstract void Save();
//}

//interface ILogger { }
//interface IShape { }
//interface IMoveable { }
//interface IRenderable { }


// Возможные члены интерфейса
// 1. Methods;
// 2. Properties;
// 3. Events
// 4. indexators
// 5. static (const)


//interface ILogger
//{
//    public const double PI = 3.14;
//    public static int count = 0;
//    public void Log(string message);
//    public string Path { get; set; }
//}


//interface IRendarable
//{
//    public static int count = 0;

//    public void Render()
//    {
//        Console.WriteLine("Render()");
//    }
//    public int Ratio { get => 0; }
//    public int Count 
//    {
//        get => count;
//        set => count = value;
//    }
//}

#endregion

#region Examples_1

////Unit a = new Unit();
////a.Render();
////IRenderable b = new Unit();
////b.Render();


//Mesh a = new Mesh();
//// a.Write();              // ERROR
//IRenderable b = a;
//b.Write();

//interface IRenderable
//{
//    public void Render();
//    public void Write()
//    {
//        Console.WriteLine("IRenderable.Write()");
//    }
//    public void Cache()
//    {

//    }
//}

//class Unit : IRenderable
//{
//    public void Render()
//    {
//        Console.WriteLine("Unit.Render()");
//    }
//    public void Write()
//    {
//        Console.WriteLine("Unit.Write()");
//    }
//}

//class Mesh : IRenderable
//{
//    public void Render()
//    {
//        Console.WriteLine("Mesh.Render()");
//    }
//}

#endregion

#region Multiple implementation

//Db db = new Db();

//IWritable a = db;
//a.Write();
//ILoggable b = db;
//b.Log("data");

//if (b is Db cdb)
//    cdb.Save();

//if (db is ILoggable)
//    db.Log("data");

//interface IWritable
//{
//    public void Write();
//}

//interface ILoggable
//{
//    public void Log(string message);
//}

//class Db : IWritable, ILoggable
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"{message} --> log.txt");
//    }

//    public void Write()
//    {
//        Console.WriteLine("Db.Write()");
//    }
//    public void Save()
//    {
//        Console.WriteLine("Db.Save()");
//    }
//}

#endregion

#region Explicit realization (явная реализация)

//Db a = new Db();
//// a.Write();              // ERROR

//IWritable b = a;
//b.Write();
//ISaver c = a;
//c.Write();


//interface IWritable
//{
//    public void Write();
//}
//interface ISaver
//{
//    public void Write();
//}

//class Db: IWritable, ISaver
//{
//    // Неявная релизация (общая реализация). Одна на несколько интерфейсов
//    public void Write()
//    {
//        Console.WriteLine("Common implementation");
//    }

//    // Явная рализация (Каждая для своего интерфейса)
//    // 1. Явные реализации не являются членами класса
//    // 2. Явные реализации не могут иметь модификатора доступа
//    void IWritable.Write()
//    {
//        Console.WriteLine("Db.IWritable.Write()");
//    }

//    void ISaver.Write()
//    {
//        Console.WriteLine("Db.ISaver.Write()");
//    }
//}

//class FileManager: IWritable
//{
//    void IWritable.Write()
//    {
//        Console.WriteLine("FileManager.IWritable.Write()");
//    }
//}

#endregion

#region Examples_2 !!!

//IRenderable a = new Unit();
//a.Render();
//a.Move();
//a.Update();

//interface IRenderable
//{
//    public void Render();
//    public void Move();
//    public void Update();
//}

//abstract class Shape: IRenderable
//{
//    public abstract void Render();
//    public virtual void Move()
//    {
//        Console.WriteLine("Shape.Move()");
//    }
//    public void Update()
//    {
//        Console.WriteLine("Shape.Update()");
//    }
//}

//class Unit : Shape
//{
//    public override void Render()
//    {
//        Console.WriteLine("Unit.Render()");
//    }
//    public override void Move()
//    {
//        Console.WriteLine("Unit.Move()");
//    }
//    public new void Update()
//    {
//        Console.WriteLine("Unit.Update()");
//    }
//}

#endregion

#region Examples_3
// Повторная реализация интерфейса классом-наследником

//Unit a = new Unit();
//a.Render();                     // 2

//Shape b = new Unit();
//b.Render();                     // 1

//IRenderable c = new Unit();
//c.Render();                     // 2

//interface IRenderable
//{
//    public void Render();
//}

//class Shape: IRenderable
//{
//    public void Render() => Console.WriteLine("Shape.Render()");        // 1
//}

//class Unit: Shape, IRenderable
//{
//    public new void Render() => Console.WriteLine("Unit.Render()");     // 2
//}



// Пример с явной реализацией

//Unit a = new Unit();
//a.Render();                     // 2

//Shape b = new Unit();
//b.Render();                     // 1

//IRenderable c = new Unit();
//c.Render();                     // 3

//interface IRenderable
//{
//    void Render();
//}

//class Shape : IRenderable
//{
//    public void Render() => Console.WriteLine("Shape.Render()");                            // 1
//}

//class Unit : Shape, IRenderable
//{
//    public new void Render() => Console.WriteLine("Unit.Render()");                         // 2
//    void IRenderable.Render() => Console.WriteLine("Explicit Unit.Renderable.Render()");    // 3
//}

#endregion

#region Inheritance

////IWritable a = new FileManager();
////// b.Save();            // ERROR
////a.Write();
////ISaver b = new FileManager();
////b.Save();
////b.Write();

//IWritable a = new FileManager();
//if (a is FileManager fm)
//    fm.Write();


//interface IWritable
//{
//    public void Write();
//}
//interface ISaver: IWritable
//{
//    public void Save();
//}

//class FileManager : ISaver
//{
//    public void Save()
//    {
//        throw new NotImplementedException();
//    }

//    public void Write()
//    {
//        throw new NotImplementedException();
//    }
//}




//FileManager fm = new FileManager();

//IWritable a = fm;
//a.Write();
//ISaver b = fm;
//b.Write();


//interface IWritable
//{
//    public void Write()
//    {
//        Console.WriteLine("default IWritable.Write()");
//    }
//}
//interface ISaver : IWritable
//{
//    public new void Write()
//    {
//        Console.WriteLine("default ISaver.Write()");
//    }
//    public void Save()
//    {
//        Console.WriteLine("default ISaver.Save()");
//    }
//}

//class FileManager : ISaver
//{
//    //public void Save()
//    //{
//    //    throw new NotImplementedException();
//    //}

//    public void Write()
//    {
//        Console.WriteLine("FileManager.Write()");
//    }
//    void IWritable.Write()
//    {
//        Console.WriteLine("EXPLICIT FileManager.Write()");
//    }
//}





//DbSaver db = new DbSaver();

//IWriter a = db;
//a.Write();              // 7
//// a.Save();            // ERROR

//ISaver b = db;
//b.Write();              // 5
//b.Save();               // 6

//Saver c = db;
//c.Write();              // 5
//c.Save();               // 6

//DbSaver d = db;
//d.Write();              // 5
//d.Save();               // 6

//interface IWriter
//{
//    public void Write() => Console.WriteLine("DEFAULT IWriter.Write()");        // 1
//}
//interface ISaver: IWriter
//{
//    public new void Write() => Console.WriteLine("DEFAULT ISaver.Write()");     // 2
//    public void Save() => Console.WriteLine("DEFAULT ISaver.Save()");           // 3
//}

//abstract class Saver: ISaver
//{
//    public abstract void Write();
//    public virtual void Save() => Console.WriteLine("Saver.Save()");            // 4
//}
//class DbSaver : Saver, IWriter
//{
//    public override void Write() => Console.WriteLine("DbSaver.Write()");       // 5
//    public override void Save() => Console.WriteLine("DbSaver.Save()");         // 6
//    void IWriter.Write() => Console.WriteLine("IWriter EXPLICIT DbSaver.Write()"); // 7
//}

#endregion

#region Generic interfaces

////User<int> user = new User<int>();
////IAuth<int> b = user;

//Admin admin = new Admin();
//User<int> a = admin;
//IAuth<int> b = admin;

//interface IAuth<T>
//{
//    public T Id { get; }
//}

//class User<T>: IAuth<T>
//{
//    public T Id { get; }
//}

//class Client : IAuth<string>
//{
//    public string Id { get; }
//}

//class Admin: User<int>
//{

//}

#endregion

#region Interfaces as constraints

//FileManager<Document> fm = new FileManager<Document>();
//fm.Run(new Document("/usr/var/logs.txt"));

//interface IWritable
//{
//    public void Write();
//}
//interface ISavable
//{
//    public string? Path { get; }
//}
//class Document: IWritable, ISavable
//{
//    public string? Path { get; }
//    public Document(string? path) => Path = path;
//    public void Write() => Console.WriteLine($"Docuent.Write() using {Path}");
//}

////

//class FileManager<T>
//    where T : class, IWritable, ISavable
//{
//    public void Run(T obj)
//    {
//        Console.WriteLine(obj.Path);
//        obj.Write();
//    }
//}

#endregion

#region IComparable

//List<User> users = new List<User>()
//{ 
//    new User(101, "aaa@mail.com", 45),
//    new User(102, "bbb@mail.com", 21),
//    new User(103, "ccc@mail.com", 32),
//    new User(104, "ddd@mail.com", 20),
//};

//users.Sort();

//foreach(User user in users)
//    Console.WriteLine(user);



//class User: IComparable<User>
//{
//    public int Id { get; set; }
//    public string Email { get; set; }
//    public int Age { get; set; }
//    public User(int id, string email, int age)
//    {
//        Id = id;
//        Email = email;
//        Age = age;
//    }

//    public override string ToString()
//    {
//        return $"id: {Id}, email: {Email}, age: {Age}";
//    }

//    public int CompareTo(User? obj)
//    {
//        //if (obj is User u)
//        //{
//        //    return Age - u.Age;
//        //}

//        //throw new ArgumentException();


//        if (obj is null)
//            throw new ArgumentNullException(nameof(obj));

//        return Age - obj.Age;
//    }
//}

#endregion

#region IComparer

List<User> users = new List<User>()
{
    new User(101, "aaa@mail.com", 45),
    new User(102, "bbb@mail.com", 21),
    new User(103, "ccc@mail.com", 32),
    new User(104, "ddd@mail.com", 20),
};

users.Sort(new UserIdComparer(SortDirection.Desc));

foreach (User user in users)
    Console.WriteLine(user);


class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public User(int id, string email, int age)
    {
        Id = id;
        Email = email;
        Age = age;
    }

    public override string ToString()
    {
        return $"id: {Id}, email: {Email}, age: {Age}";
    }
}

class UserAgeComparer : IComparer<User>
{
    public int Compare(User? x, User? y)
    {
        if (x is null || y is null)
            throw new ArgumentNullException(nameof(x));

        return x.Age - y.Age;
    }
}

enum SortDirection
{
    Asc,
    Desc,
}
class UserIdComparer : IComparer<User>
{
    private SortDirection sortDirection;
    public UserIdComparer(SortDirection sortDirection)
    {
        this.sortDirection = sortDirection;
    }

    public int Compare(User? x, User? y)
    {
        if (x is null || y is null)
            throw new ArgumentNullException(nameof(x));

        return sortDirection == SortDirection.Asc ? x.Id - y.Id : y.Id - x.Id;
    }
}

#endregion
