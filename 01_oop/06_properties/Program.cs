
#region Intro

//Unit a = new Unit();
//Console.WriteLine(a.Hp);
//a.Hp = 150;

//Console.WriteLine(a.Title);
//// a.Title = "vasia";               // ERROR

//// Console.WriteLine(a.Level);      // ERROR
//a.Level = 7;

//Console.WriteLine(a.Info);

//class Unit
//{
//    private int hp;
//    private string title;
//    private int level;

//    public int Hp                       // полное свойство (стандартное)
//    {
//        get
//        {
//            Console.WriteLine("get_hp");
//            return hp;
//        }
//        set
//        {
//            Console.WriteLine("set_hp");
//            hp = value;
//        }
//    }

//    //public string Title                 // Св-во только для чтения
//    //{
//    //    get
//    //    {
//    //        return title;
//    //    }
//    //}
//    // >>> EQUALS <<<
//    //public string Title               // Св-во только для чтения
//    //{
//    //    get => title;
//    //}
//    // >>> EQUALS <<<
//    public string Title => title;       // Св-во только для чтения

//    public int Level                    // Св-во только для чтения
//    {
//        set
//        {
//            level = value;
//        }
//    }

//    public string Info                  // вычисляемое св-во
//    {
//        get
//        {
//            return $"hp: {hp}, title: {title}";
//        }
//    }
//}

#endregion

#region Modificators

//Console.WriteLine();
//class Unit
//{
//    private string title = string.Empty;
//    public Unit(string title) => this.title = title;

//    // :-)
//    public string Title
//    {
//        get => title;
//        private set => title = value;
//    }

//    // :-(
//    //public string Title
//    //{
//    //    private set => title = value;
//    //}

//    // :-(
//    //public string Title
//    //{
//    //    public get => title;
//    //    private set => title = value;
//    //}

//    // :-(
//    //protected string Title
//    //{
//    //    get => title;
//    //    public set => title = value;
//    //}

//}

#endregion

#region Auto-properties

//Console.WriteLine();
//class Unit
//{
//    public int Hp { get; set; }         // <-- автосвойство
//    // >>> EQUALS <<<
//    //private int hp_backing;
//    //public int Hp
//    //{
//    //    get => hp_backing;
//    //    set => hp_backing = value;
//    //}

//    public string Email { get; set; } = "no_email";
//    public string Title { get; private set; }
//    public int Level { get; }

//}

#endregion

#region init (одноразовый сеттер)

//User a = new()
//{
//    Email = "vasia@Mail.com",               // case 2
//};
//// a.Email = "petya@Mail.com"; // ERROR

//class User
//{
//    private string nickname;
//    public string Nickname
//    {
//        get => nickname;
//        init
//        {
//            nickname = value;
//            Email = "dima@Mail.com";                    // case 4   :-(
//        }
//    }
//    public string Email { get; init; } = "no_email";    // case 3

//    public User()
//    { }
//    public User(string email)
//    {
//        Email = email;                      // case 1
//    }
//}

#endregion

#region required

//User a = new User("vasia@mail.com")
//{
//    level = 7,
//    Id = 101,
//};

//class User
//{
//    public required int level;
//    public required int Id { get; set; }
//    public string Email { get; set; }

//    public User(string email)
//    {
//        Email = email;
//    }

//}

#endregion
