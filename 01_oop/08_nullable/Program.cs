

#region Reference types

// string a = null;
// int b = null;

//void Exec(string str)
//{
//    Console.WriteLine(str.ToUpper());
//}

//# nullable disable
//string a = null;
//# nullable restore

//string b = "vasia";
//string? c = null;

//Exec(b);
//Exec(a);


//void Exec(string? str)
//{
//    if (str !=  null)
//        Console.WriteLine(str.ToUpper());
//}

//string b = "vasia";
//string? c = null;

//Exec(b);
//Exec(c);



// ===== null-forgiving operator =====
//string? email = null;

//string Normalize(string value)
//{
//    return value.ToLower();
//}

////if (email != null)
////    Normalize(email);

//Normalize(email!);

//class User
//{
//    public string Email { get; set; } = null!;
//    //public User()
//    //{
//    //    Email = "no_email";
//    //}
//}

#endregion

#region Value types

//int a = 12;
//int? b = null;

//Nullable<int> c = null;
//// int Value = 0;
//// bool HasValue = false;
//c = 3;
//// int Value = 3;
//// bool HasValue = true;


//int? age = null;

//int a = (int)age;
//int b = age.Value;


//int? a = 34;
//int? b = a;


//int? a = 23;
//// int b = a + 5;       //ERROR
//int? c = a + 5;
//int d = (int)a + 5;
//int e = a.Value + 5;

//int a = 34;
//int? b = a;

//long? a = 23;
//int? b = (int?)a;

#endregion

#region Null guard

//void Render(string? content)
//{
//    if (content == null)
//        return;

//    if (content is null)
//        return;

//    if (content is not null)
//        Console.WriteLine(content.ToLower());

//    if (content is string)
//        Console.WriteLine(content.ToLower());

//    Console.WriteLine(content.ToLower());
//}

#endregion

#region Null-union operator

//Console.Write("Enter your eamil: ");
//string? input = Console.ReadLine();

//// string email = input is not null ? input : "no_email";
//// >>> EQUALS <<<
//string email = input ?? "no_email";

//int? val = 23;
//int age = val ?? 18;

//string? email = null;
//email ??= "no_email";       // email = email ?? "no_email";

#endregion

#region Условный null

void Execute(User? user)
{
    //if (user is not null && user.Role is not null)
    //    user.Role.Render();
    // >>> EQUALS <<<
    user?.Role?.Render();
}

class Role
{
    public string? Title { get; set; } = null;
    public void Render() => Console.WriteLine($"title: {Title}");
}

class User
{
    public Role? Role { get; set; } = null;
}

#endregion