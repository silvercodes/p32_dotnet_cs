namespace _00_class;

internal class Unit
{
    public string title;
    public Clane clane;
    public Unit(string title, Clane clane)
    {
        this.title = title;
        this.clane = clane;
    }

    public void Deconstruct(out string title, out Clane clane)
    {
        title = this.title;
        clane = this.clane;
    }
}
