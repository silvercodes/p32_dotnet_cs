// Значимые типы
// 1. Все целочисленные
// 2. Все типы с плавающей запятой
// 3. bool
// 4. char
// 5. enum
// 6. Любая struct
// ...

// Ссылочные типы
// 1. Классы
//      object
//      string
//      ...
// 2. Интерфейсы
// 3. Делегаты





//Unit a = new Unit();
//Unit b = a;

//struct Point
//{
//    public int x;
//    public int y;
//}
//class Backpack
//{
//    public string color;
//}
//class Unit
//{
//    public Point position;
//    public Backpack backpack;
//}





Unit a = new Unit();
Unit b = a;

a.mesh.id = 17;
Console.WriteLine(b.mesh.id);

Unit c = a with { mesh = new Mesh() };
Console.WriteLine(c.mesh.id);

class Mesh
{
    public int id;
}
struct Point
{
    public int x;
    public int y;
}
struct Unit
{
    public int hp;
    public Point position;
    public Mesh mesh;
    public Unit()
    {
        mesh = new Mesh();
    }
}