

User a = new User();
a.id = 101;
a.email = "vasia@mail.com";
a.Render();

class User
{
    public int id;
    public string email;

    public void Render() => Console.WriteLine($"id: {this.id}, email: {this.email}");
}

