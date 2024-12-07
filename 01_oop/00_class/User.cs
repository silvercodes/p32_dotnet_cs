namespace _00_class;

#region Base using
//class User
//{
//    public int id;
//    public string email;
//    public User(int id, string email)
//    {
//        this.email = email;
//        this.id = id;
//    }
//    public User(int id)
//    {
//        this.id = id;
//        this.email = "no_email";
//    }
//    public User(string email)
//    {
//        this.id = 0;
//        this.email = email;
//    }
//    public void Render() => Console.WriteLine($"id: {this.id}, email: {this.email}");
//}
#endregion

#region Ctor delegation

//class User
//{
//    public int id;
//    public string email;
//    public string nickname;
//    public User(int id, string email)
//    {
//        this.email = email;
//        this.id = id;
//    }
//    public User(int id) :
//        this(id, "no_email")
//    { }
//    public User(string email) :
//        this(0, email)
//    { }
//    public void Render() => Console.WriteLine($"id: {this.id}, email: {this.email}");
//}

#endregion

#region Primary ctor (Первичный конструктор)

//class User
//{
//    private int id;
//    private string email;
//    public User(int id, string email)
//    {
//        this.email = email;
//        this.id = id;
//    }
//    public User(int id) :
//        this(id, "no_email")
//    { }
//    public User(string email) :
//        this(0, email)
//    { }
//    public void Render() => Console.WriteLine($"id: {this.id}, email: {this.email}");
//}

// >>> EQUALS <<<

//class User(int id, string email)
//{
//    public User(int id) :
//        this(id, "no_email")
//    { }
//    public User(string email) :
//        this(0, email)
//    { }
//    public void Render() => Console.WriteLine($"id: {id}, email: {email}");
//}

#endregion

