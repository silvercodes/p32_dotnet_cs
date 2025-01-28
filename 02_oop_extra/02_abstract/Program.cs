
//              C++                                         C#
// Чистая виртуальная функция (абстрактная ф-ция)       Абстрактный метод (является виртуальным)
// Абстрактный класс                                    Абстрактный класс
// Интерфейсный класс                                   Интерфейс

// Абстрактными могут быть:
// 1. Методы
// 2. Свойства
// 3. События
// 4. Индексаторы

#region Intro

//abstract class Unit
//{
//    public int Id { get; set; }                     // Автосвойство (get(); set(); private field)
//    public virtual int HP { get; set; }             // Автосвойство (virtual get(); virtual set(); private field)
//    public abstract string? Name { get; set; }      // НЕ автосвойство (abstract get(); abstract set())

//    public void Attack() => Console.WriteLine("Unit.Attack()");
//    public virtual void Move() => Console.WriteLine("Unit.Move()");
//    public abstract void Defence();
//}

//class Archer: Unit
//{
//    public new int Id
//    {
//        get => base.Id;
//        set => base.Id = value;
//    }
//    public override int HP 
//    { 
//        get => base.HP; 
//        set => base.HP = value; 
//    }
//    public override string? Name { get; set; }

//    public new void Attack() => Console.WriteLine("Archer.Attack()");
//    public override void Move() => Console.WriteLine("Archer.Move()");
//    public override void Defence() => Console.WriteLine("Archer.Defence()");
//}

#endregion

#region Object virtual methods

//User a = new()
//{ Id = 101, Email = "vasia@mail.com" };

//Console.WriteLine(a);


//class User
//{
//    public int Id { get; set; }
//    public string? Email { get; set; }
//    public override string ToString()
//    {
//        return $"id: {Id}, email: {Email}";
//    }
//    public override int GetHashCode()
//    {
//        // return Id;
//        return Email.GetHashCode();
//    }
//    public override bool Equals(object? obj)
//    {
//        if (obj is User u)
//            return Id == u.Id;

//        return false;
//    }
//}

#endregion
