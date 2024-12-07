

//Point a = new Point();
//a.Render();
//a.x = 2;
//a.y = 2;
//a.Render();
//Point b = new Point(12, 12);
//b.Render();
//Point c = new Point(120);
//c.Render();
//Point d = new Point()
//{
//    x = 15,
//    y = -30,
//};

//Mesh m = new Mesh(12, "Three");
//m.Render();



Point a = new Point(1, 1);
Point b = a;
b.Render();

Point c = a with { y = -5 };
c.Render();


struct Point
{
    public int x = -1;
    public int y = -1;
    public Point()
    { }
    public Point(int x)
    {
        this.x = x;
    }
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Render() => Console.WriteLine($"x: {x}, y: {y}");
}

struct Mesh(int id, string title)
{
    public void Render() => Console.WriteLine($"{id} {title}");
}
