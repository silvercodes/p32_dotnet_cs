
#region Generics

//User user1 = new()
//{
//    Id = 101,
//    Email = "vasia@mail.com",
//};

//User user2 = new()
//{
//    Id = "102",
//    Email = "petya@mail.com",
//};

////int id1 = (int)user1.Id;
//string id1 = (string)user1.Id;
//string id2 = (string)user2.Id;


//class User
//{
//    public object Id { get; set; }
//    public string Email { get; set; }
//}










//User<int> user1 = new User<int>()
//{
//    Id = 101,
//    Email = "vasia@mail.com",
//};

//User<string> user2 = new User<string>()
//{
//    Id = "102",
//    Email = "petya@mail.com",
//};

//int id1 = user1.Id;
//string id2 = (string)user2.Id;


//class User<T>
//{
//    public T Id { get; set; }
//    public string Email { get; set; }
//}






// 1.
//class Role<T>
//{
//    public T Id { get; set; }
//}

//class User<T>
//{
//    public T Id { get; set; }
//    public string Email { get; set; }
//    public Role<int> Role { get; set; }
//}


// 2.
//User<string> u = new User<string>();
//class Role<T>
//{
//    public T Id { get; set; }
//}

//class User<T>
//{
//    public T Id { get; set; }
//    public string Email { get; set; }
//    public Role<T> Role { get; set; }
//}


// 3.
//User<string, int> u = new User<string, int>();
//class Role<T>
//{
//    public T Id { get; set; }
//}

//class User<T, K>
//{
//    public T Id { get; set; }
//    public string Email { get; set; }
//    public Role<K> Role { get; set; }
//}




// 4.
//User<string, Role<string>> u = new User<string, Role<string>>();
//class Role<T>
//{
//    public T Id { get; set; }
//}

//class User<T, K>
//{
//    public T Id { get; set; }
//    public string Email { get; set; }
//    public K Role { get; set; }
//}





//Unit<int, Backpack<string, BackpackLevel>, Point<float>> u 
//    = new Unit<int, Backpack<string, BackpackLevel>, Point<float>>(
//        101, 
//        new Backpack<string, BackpackLevel>() { Id = "1", Level = BackpackLevel.Low }, 
//        new Point<float>() { X = 1, Y = 1 }
//    );

//enum BackpackLevel
//{
//    High,
//    Middle,
//    Low
//}
//class Point<T>
//{
//    public T X { get; set; }
//    public T Y { get; set; }
//}
//class Backpack<T, P>
//{
//    public T Id { get; set; }
//    public P Level { get; set; }
//}
//class Unit<T, B, P>
//{
//    public T Id { get; set; }
//    public B Backpack { get; set; }
//    public P Position { get; set; }
//    public Unit(T id, B backpack, P position)
//    {
//        Id = id;
//        Backpack = backpack;
//        Position = position;
//    }
//}



#endregion

#region Static

//User<int> a = new()
//{
//    Id = 101,
//    Email = "vasia@mail.com",
//};

//User<string> b = new User<string>()
//{
//    Id = "102",
//    Email = "petya@mail.com"
//};

//User<int>.minId = 100;
//User<string>.minId = "200";
//Console.WriteLine(User<int>.minId);

//class User<T>
//{
//    public static T minId;
//    public T Id { get; set; }
//    public string Email { get; set; }
//}

#endregion

#region Generic methods

//Storage.Save<Document>(new Document() { Content = "data" });
//Storage.Save<Document>(new PdfDocument() { Content = "data" });
//Storage.Save<string>((new PdfDocument() { Content = "data" }).ToString());

//class Document
//{
//    public string Content { get; set; }
//    public override string ToString()
//    {
//        return $"Content: {Content}";
//    }
//}
//class PdfDocument: Document
//{

//}
//class Storage
//{ 
//    //
//    //
//    //

//    public static void Save<T>(T doc)
//    {
//        Console.WriteLine($"Saved --> {doc}");
//    }
//}

#endregion

#region TASK_1

// Написать обобщённый контейнерный класс Container
// Хранить элементы в массиве
// Методы:
//      Добавление
//      Удаление
//      Получение по индексу
// Свойства
//      Длина хранилища (кол-во элементов)
//      bool Empty

#endregion

#region Generic methods constraints

//Renderer.Render("vasia");       // ERROR
//Renderer.Render(123);             // ERROR
//Renderer.Render<Unit>(new Unit(100));
//Renderer.Render<Unit>(new Archer(100));

//class Unit
//{
//    public int Hp { get; set; }
//    public Unit(int hp) => Hp = hp;
//}

//class Archer : Unit
//{
//    public Archer(int hp) : base(hp) { }
//}

//class Warrior : Unit
//{
//    public Warrior(int hp) : base(hp) { }
//}

//class Renderer
//{
//    public static void Render<T>(T item)
//        where T : Unit
//    {
//        Console.WriteLine(item.Hp);
//    }
//}

#endregion

#region Generic types constraints

// _1_
// concrete class
// OR
// class
// OR
// struct

// _2_
// concrete interface

// _3_
// new()

//class Renderer<T>
//    where T : _1_, _2_, _3_
//{

//}




//Storage<Document> storageA = new Storage<Document>();
//Storage<PdfDocument> storageB = new Storage<PdfDocument>();

//Compressor<PdfDocument, Storage<PdfDocument>> a = new Compressor<PdfDocument, Storage<PdfDocument>>();

//class Document
//{
//    public int Id { get; set; }
//    public Document() { }
//    public Document(int id) => Id = id;
//}

//class PdfDocument : Document
//{
//    public PdfDocument() { }
//    public PdfDocument(int id) :
//        base(id)
//    { }
//}

//class Storage<T>
//    // where T : class, new()
//    where T : Document, new()
//{
//    public void Execute()
//    {
//        T a = new T();
//    }
//}

//class Compressor<T, K>
//    where T : Document, new()
//    where K : Storage<T>
//{}

#endregion

#region Inheritance

class Role
{}
class Unit<T>
    where T: new()
{
    public T Id { get; set; }
    public Unit(T id) => Id = id;
}

// 1. Использование того же типа в наследнике
//class Archer<K> : Unit<K>
//    where K : new()
//{
//    public Archer(K id) :
//        base(id)
//    { }
//}
//Archer<int> a = new Archer<int>(101);
//Unit<int> b = new Archer<int>(102);


// 2. Необобщённый наследник
//class Archer: Unit<int>
//{
//    public Archer(int id) :
//        base(id)
//    { }
//}
//Archer a = new Archer(100);
//Unit<int> b = new Archer(101);


// 3. Типизация наследника отдельным типом
//class Archer<T, K> : Unit<K>
//    where K : new()
//{
//    public Archer(K val):
//        base(val)
//    {}
//}
//Archer<int, Role> a = new Archer<int, Role>(new Role());
//Unit<Role> b = new Archer<int, Role>(new Role());


// 4. Комбинация разных вариантов
//class Archer<T, K>: Unit<T>
//    where T : new()
//{
//    public Archer(T id) :
//        base(id)
//    { }
//}
//Archer<Role, int> a = new Archer<Role, int>(new Role());
//Unit<Role> b = new Archer<Role, int>(new Role());

#endregion

