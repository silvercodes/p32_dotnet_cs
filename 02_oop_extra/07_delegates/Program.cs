#region Intro
//ExecDel a;
//a = Process;
//a += User.Render;

//a();

//a.GetInvocationList();


//void Process()
//{
//    Console.WriteLine("Process");
//}

//class User
//{
//    public static void Render() => Console.WriteLine("User.Render()");
//}

//delegate void ExecDel();

// ExecDel --> MulticastDelegate --> Delegate --> object



//void SendEmail(string content) => Console.WriteLine($"Email: {content}");
//void SendTelegram(string content) => Console.WriteLine($"Telegram: {content}");
//void SendSms(string content) => Console.WriteLine($"Sms: {content}");

//NotifyHandler h1 = SendEmail;
//NotifyHandler h2 = SendTelegram;
//NotifyHandler h3 = SendSms;

//// h1("Vasia");
//// h3 += SendEmail;
////h3("Vasia");

//NotifyHandler h4 = h1 + h2 + h3;
////h4("Vasia");
////h4 -= SendTelegram;
////h4 -= SendEmail;
////h4("Vasia");

//if (h1 is not null)
//    h1("Petya");

//h1?.Invoke("Petya");        // :-)


//delegate void NotifyHandler(string content);
#endregion

#region Generic delegates

//string Process(int a, int b) => $"a + b = {a + b}";

//Operation<string, int> op = Process;
//Console.WriteLine(op?.Invoke(3, 4));


//delegate T Operation<T, P>(P a, P b);

#endregion

#region Practice "Observer"

//Account acc = new Account(1000);

//acc.RegisterSuccessHandler(TelegramNotifier.Notify);

//acc.RegisterErrorHandler(TelegramNotifier.Notify);
//acc.RegisterErrorHandler(SmsNotifier.Notify);
//acc.RegisterErrorHandler(EmailNotifier.Notify);

//acc.Add(500);
//acc.Withdraw(2000);


//class TelegramNotifier
//{
//    public static void Notify(string message) => Console.WriteLine($"Telegram: {message}");
//}
//class EmailNotifier
//{
//    public static void Notify(string message) => Console.WriteLine($"Email: {message}");
//}
//class SmsNotifier
//{
//    public static void Notify(string message) => Console.WriteLine($"Sms: {message}");
//}
//class Account
//{
//    public delegate void NotifyHandler(string message);

//    private NotifyHandler successHandler;
//    private NotifyHandler errorHandler;

//    private int sum;

//    public void RegisterSuccessHandler(NotifyHandler handler) => successHandler += handler;
//    public void RegisterErrorHandler(NotifyHandler handler) => errorHandler += handler;

//    public Account(int sum) => this.sum = sum;

//    public void Add(int sum)
//    {
//        this.sum += sum;

//        successHandler?.Invoke($"Added: {sum}");
//    }

//    public void Withdraw(int sum)
//    {
//        if (sum > this.sum)
//            errorHandler?.Invoke("Invalid sum");
//        else
//        {
//            this.sum -= sum;
//            successHandler?.Invoke($"Withdrawen: {sum}");
//        }
//    }
//}

#endregion

#region Anonymus methods

//Handler handler = delegate (string content)
//{
//    Console.WriteLine(content);
//};

//handler("vasia");
//handler?.Invoke("Petya");

//delegate void Handler(string content);




//void Render(string content, Handler handler)
//{
//    handler.Invoke(content);
//}

//void LinuxRenderer(string content)
//{
//    Console.WriteLine($"Linux: {content}");
//}

//Render("Vasia", LinuxRenderer);
//Render("Petya", delegate (string content)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine(content);
//    Console.ResetColor();
//});

//delegate void Handler(string content);




//int factor = 5;
//Calc calc = delegate (int a, int b)
//{
//    return (a + b) * 5;
//};

//Console.WriteLine(calc(3, 4));

//delegate int Calc(int a, int b);

#endregion

#region Lambda expressions

//Handler a = Execute;
//// EQUALS
//Handler a1 = new Handler(Execute);

//Handler b = delegate ()
//{
//    Console.WriteLine("Anonymus method");
//};

//Handler c = () => Console.WriteLine("Lambda");

//Handler d = () =>
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("Lambda_2");
//    Console.ResetColor();
//};

//var e = () => Console.WriteLine("With var");

//a();
//a1();
//b();
//c();
//d();
//e();

//void Execute() => Console.WriteLine("Execute()");

//delegate void Handler();


// ---------------- lambdas parameters -----------------

//CalcHandler a = (int a, int b) =>
//{
//    return a + b;
//};
//// EQUALS
//CalcHandler a1 = (int a, int b) => a + b;       // :-)
//// EQUALS
//CalcHandler a2 = (a, b) => a + b;               // :-)))


//RenderHandler b = (string content) => Console.WriteLine(content);
//// EQUALS
//RenderHandler b1 = (content) => Console.WriteLine(content);         // :-)
//// EQUALS
//RenderHandler b2 = c => Console.WriteLine(c);                       // :-)))


//delegate int CalcHandler(int a, int b);
//delegate void RenderHandler(string contetnt);

#endregion

#region Practice 1
// TASK
// Написать метод для условного суммирования целочисленного массива

//int[] arr = { 3, 6, 7, 8, 2, 2, 4, 5, 7 };

//int Sum(int[] arr, Pridicate predicate)
//{
//    int res = 0;
//    foreach (int n in arr)
//        if (predicate(n))
//            res += n;

//    return res;
//}

//Console.WriteLine(Sum(arr, n => n % 2 == 0));
//Console.WriteLine(Sum(arr, n => n > 0));
//Console.WriteLine(Sum(arr, n => n > 10));


//delegate bool Pridicate(int n);

#endregion

#region Practice 2
// TASK
// Написать метод для поиска пользователя (-ей) по разным критериям
// * Сделать на generic

//List<User> users = new List<User>()
//{
//    new User(101, "vasia@mail.com", 23),
//    new User(107, "petya@mail.com", 16),
//    new User(115, "dima@mail.com", 15),
//    new User(120, "kolya@mail.com", 23),
//    new User(150, "vova@mail.com", 20),
//};

//List<User> Find(List<User> users, Predicate<User> predicate)
//{
//    List<User> result = new List<User>();

//    foreach(User u in users)
//        if (predicate(u))
//            result.Add(u);

//    return result;
//}

//// List<User> resA = Find(users, u => u.Age < 18);
//List<User> resA = Find(users, u => u.Id > 115);
//foreach(User u in resA)
//    Console.WriteLine(u);


//delegate bool Predicate<T>(T item);

//class User
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
//        return $"{Id} {Email} {Age}";
//    }
//}

#endregion

#region Practice 3
// TASK
// Написать метод для валидации email'а
// Метод принимает 2 колбэка (1 - для успешной валидации, 2 - для ошибки)
// Логика валидации определяется за пределами метода


//EmailValidator validator = new EmailValidator();
//validator.Validate(
//    "vasia@mail.com",
//    email => Console.WriteLine($"Email {email} is valid"),
//    email => Console.WriteLine($"Email {email} is invalid"),
//    email => email.Contains('@')
//);

//class EmailValidator
//{
//    public void Validate(string email, Callback success, Callback error, Predicate predicate)
//    {
//        if (predicate(email))
//            success(email);
//        else
//            error(email);
//    }
//}

//delegate void Callback(string email);
//delegate bool Predicate(string email);

#endregion

#region Imbedded delegates

//// Action / Action<...>

//Action a = () => Console.WriteLine();

//Action<int, string> b = (n, s) => Console.WriteLine($"{n}, {s}");

//// Predicate<T>

//Predicate<int> c = n => n > 0;

//// Func<...>

//Func<int, int, string> d = (a, b) => $"{a} + {b} = {a + b}";
//Console.WriteLine(d(3, 4));

//Func<int, bool> e = n => n > 0;
//// EQUALS
//Predicate<int> f = n => n > 0;

#endregion

#region Event

//Server server = new Server();
//server.ClientConnected += name => Console.WriteLine($"{name} connected!!!");
//server.ClientDisconnected += name => Console.WriteLine($"{name} disconnected!!!");

//server.Connect();
//server.Disconnect();

//class Server
//{
//    private Action<string>? clientDisconnected;
//    public event Action<string>? ClientConnected;
//    public event Action<string>? ClientDisconnected
//    {
//        add
//        {
//            Console.WriteLine($"{value?.Method.Name} added...");
//            clientDisconnected += value;
//        }
//        remove
//        {
//            Console.WriteLine($"{value?.Method.Name} removed...");
//            clientDisconnected -= value;
//        }
//    }

//    public void Connect()
//    {
//        //
//        //
//        //
//        ClientConnected?.Invoke("Vasia");
//    }
//    public void Disconnect()
//    {
//        //
//        //
//        clientDisconnected?.Invoke("Vasia");
//    }
//}

#endregion
