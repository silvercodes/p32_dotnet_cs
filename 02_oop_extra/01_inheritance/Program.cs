
#region Inheritance
// Ограничения
// 1. Только одиночное наследование
// 2. Модификатор доступа наследника - такой же или более строгий
// 3. Можно запретить наследоваться от класса (sealed)
// 4. Запрещено наследовать от статического класса


//Admin a = new Admin(23, "Kostev");
//a.Email = "vasia@mail.com";


//class User
//{
//    private string email = String.Empty;
//    public string Email { get => email; set => email = value; }
//    public int Age { get; set; }
//    public User(int age): this("no_email", age)
//    {}
//    public User(string email, int age)
//    {
//        Email = email;
//        Age = age;
//    }
//    public void Show() => Console.WriteLine($"Email: {Email}, age: {Age}");
//}

//class Admin: User
//{
//    public string Nickname { get; set; }
//    public Admin(int age, string nickname): 
//        base(age)
//    {
//        Nickname = nickname;
//    }
//}

#endregion

#region Type casting

// ---- upcasting (восходящее преобразование, "упаковка объекта")

//Warrior warrior = new Warrior(100, 150);
//warrior.Hp = 120;
//warrior.Force = 200;

//Unit unit = warrior;            // <-- upcasting
//unit.Hp = 120;
//// unit.Force = 200;            // ERROR

//object obj = warrior;           // <-- upcasting
//// obj.Hp = 120;                // ERROR
//// obj.Force = 200;             // ERROR



// ---- downcasting (нисходящее преобразование, "распаковка объекта")
//Archer archer = new Archer(100, 20);
//Unit unit = archer;

//Archer archer2 = (Archer)unit;      // <-- downcasting
//Warrior warrior2 = (Warrior)unit;   // ERROR (runtime)

//object obj = new Archer(100, 30);
//Unit unit = (Unit)obj;                // <-- downcasting
//Archer archer = (Archer)obj;          // <-- downcasting
//Warrior warrior = (Warrior)obj;       // ERROR (runtime)



// ---- as / is

//Unit unit = new Archer(100, 12);

//Archer a = (Archer)unit;            // Возможен EXCEPTION !!!
//Archer? b = unit as Archer;         // EXCEPTION не выбрасывается, но возможен null

////if (b is not null)
////    b.Render();

////b?.Render();

//if (unit is Archer)
//{
//    Archer archer1 = (Archer)unit;
//    archer1.ArrowsCount = 40;
//}
//// >>> EQUALS <<<
//if (unit is Archer archer2)
//{
//    archer2.ArrowsCount = 40;
//}


//class Unit
//{
//    public int Hp { get; set; }
//    public Unit(int hp)
//    {
//        Hp = hp;
//    }
//    public void Render() => Console.WriteLine($"Hp: {Hp}");
//}

//class Archer : Unit
//{
//    public int ArrowsCount { get; set; } = 0;
//    public Archer(int hp, int arrowsCount):
//        base(hp)
//    {
//        ArrowsCount = arrowsCount;
//    }
//}

//class Warrior : Unit
//{
//    public int Force { get; set; } = 0;
//    public Warrior(int hp, int force) :
//        base(hp)
//    {
//        Force = force;
//    }
//}

#endregion

#region virtual / override

//Student student = new Student(101);
//student.Render();

//User user = new Student(102);
//((Student)user).Render();
//user.Render();



//User a = new User(104);
//a.Age = 23;
//User user = new Student(103);
//user.Age = 18;


//class User
//{
//    public int Id { get; set; }
//    public virtual int Age { get; set; }

//    public User(int id)
//    {
//        Id = id;
//    }
//    public virtual void Render() => Console.WriteLine($"Render from User: {Id}");
//}

//class Student: User
//{
//    // public override int Age { get; set; }           // FU FU FU
//    public override int Age
//    {
//        get
//        {
//            Console.WriteLine("GetAge() from Student");
//            return base.Age;
//        }
//        set
//        {
//            Console.WriteLine("SetAge() from Student");
//            base.Age = value;
//        }
//    }
//    public Student(int id) :
//        base(id)
//    { }

//    public override void Render() => Console.WriteLine($"Render from Student: {Id}");
//}

#endregion

#region Hiding

//Admin admin = new Admin(101, "vasia@mail.com");
//admin.Render();

//User user = new Admin(102, "vasia@mail.com");
//user.Render();

//Console.WriteLine(User.maxAge);
//Console.WriteLine(Admin.maxAge);

//Admin admin = new Admin(101, "vasia@mail.com");
//User user = new Admin(102, "vasia@mail.com");

//admin.Email = "dima@mail.com";
//user.Email = "dima@mail.com";

//class User
//{
//    public int Id { get; set; }
//    public readonly static int maxAge = 18;
//    public const double PI = 3.14;
//    public string Email { get; set; } = "no_email";
//    public User(int id, string email)
//    {
//        Id = id;
//        Email = email;
//    }
//    public void Render()
//    {
//        Console.WriteLine($"User: {Email}");
//    }
//}
//class Admin: User
//{
//    public readonly static new int maxAge = 21;
//    public new const double PI = 3.1415;
//    public Admin(int id, string email):
//        base(id, email)
//    { }
//    // public new string Email { get; set; }            // :-(((
//    public new string Email
//    {
//        get => $"admin: {base.Email}";
//        set
//        {
//            Console.WriteLine("Admin setEmail()...");
//            base.Email = value;
//        }
//    }

//    public new void Render()
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine($"Admin Render(): {maxAge}");
//        Console.ResetColor();
//    }
//}

#endregion
