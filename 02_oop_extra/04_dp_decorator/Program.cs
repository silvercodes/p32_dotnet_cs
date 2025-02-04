

//IRenderable tb = new TextBox(150, 60);
//// tb.Render();

//IRenderable dec1 = new BorderDecorator(tb, 5);
//dec1.Render();


//IRenderable tb = new BorderDecorator(new ScrollDecorator(new TextBox(150, 60)), 10);
//tb.Render();


//abstract class IRenderable
//{
//    public abstract void Render();
//}
//class TextBox: IRenderable
//{
//    public int W { get; set; }
//    public int H { get; set; }
//    public TextBox(int w, int h)
//    {
//        W = w;
//        H = h;
//    }
//    public override void Render()
//    {
//        Console.WriteLine($"TextBox: w: {W}, h: {H}");
//    }
//}

//class Decorator : IRenderable
//{
//    private IRenderable Item { get; set; }
//    public Decorator(IRenderable item)
//    {
//        Item = item;
//    }
//    public override void Render()
//    {
//        Item.Render();
//    }
//}
//class BorderDecorator : Decorator
//{
//    private int thikness;
//    public BorderDecorator(IRenderable item, int thikness) :
//        base(item)
//    {
//        this.thikness = thikness;
//    }
//    public override void Render()
//    {
//        base.Render();
//        Console.WriteLine($"Border {thikness} px");             // <-- декорирование
//    }
//}
//class ColoredDecorator : Decorator
//{
//    public ColoredDecorator(IRenderable item) :
//        base(item)
//    { }
//    public override void Render()
//    {
//        base.Render();
//        Console.WriteLine("Colored");
//    }
//}
//class ScrollDecorator : Decorator
//{
//    public ScrollDecorator(IRenderable item) :
//        base(item)
//    { }
//    public override void Render()
//    {
//        base.Render();
//        Console.WriteLine("Scrolled");
//    }
//}



#region TASK
// Написать мини-приложение для пиццерии на основе паттерна Decorator
// 1. Пицца может 3-х разных размеров
// 2. Пицца имеет название
// 3. Возможные ингридиенты: помидоры, сыр, грибы, сырный бортик ...
// Функционал: 
//			создать любую пиццу из ингридиентов, 
//			узнать стоимость пиццы
//			напечатать чек (состав + стоимость)






#endregion



