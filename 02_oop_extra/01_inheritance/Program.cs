
#region Inheritance

Admin a = new Admin(23, "Kostev");
a.Email = "vasia@mail.com";




class User
{
    private string email = String.Empty;
    public string Email { get => email; set => email = value; }
    public int Age { get; set; }
    public User(int age): this("no_email", age)
    {}
    public User(string email, int age)
    {
        Email = email;
        Age = age;
    }
    public void Show() => Console.WriteLine($"Email: {Email}, age: {Age}");
}

class Admin: User
{
    public string Nickname { get; set; }
    public Admin(int age, string nickname): 
        base(age)
    {
        Nickname = nickname;
    }
}



#endregion
