namespace ModLib;

public class Test2: Test
{
    void Method()
    {
        Console.WriteLine(this.privateProtectedVal);
        Console.WriteLine(this.internalVal);
        Console.WriteLine(this.protectedInternalVal);
    }
}
