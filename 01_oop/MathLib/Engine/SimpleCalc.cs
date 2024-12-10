namespace MathLib.Engine;

public class SimpleCalc
{
    public int Execute(int a, int b, Operation op) => op switch
    { 
        Operation.Add => a + b,
        Operation.Sub => a - b,
        Operation.Mul => a * b,
        Operation.Div => a / b,

        _ => throw new NotImplementedException()
    };
}
