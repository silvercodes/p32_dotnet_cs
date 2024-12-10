namespace _04_libraries;

internal class User
{
    public int id;
    public string email;
    public int age;

    public void Render()
    {
        Console.WriteLine($"{id}, {email}, {age}");
    }
}
