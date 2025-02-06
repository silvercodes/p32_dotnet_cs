
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

//class Shape: IRenderable
//{
//    public void Render() => Console.WriteLine("Shape.Render()");                            // 1
//}

//class Unit : Shape, IRenderable
//{
//    public new void Render() => Console.WriteLine("Unit.Render()");                         // 2
//    void IRenderable.Render() => Console.WriteLine("Explicit Unit.Renderable.Render()");    // 3
//}

#endregion