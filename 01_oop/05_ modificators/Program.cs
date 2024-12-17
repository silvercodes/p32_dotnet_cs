// === Модификаторы доступа к члену типа
// private
// public
// protected
// private protected                //снаружи сборки: private       внутри сборки: protected
// internal                         //снаружи сборки: private       внутри сборки: public
// protected internal               //снаружи сборки: protected     внутри сборки: public

// === Модификаторы доступа для типа в целом
// internal
// public
// file

using ModLib;

Test t = new Test();
t.publicVal = 12;
// t.privateVal = 13;       // ERROR
// t.protectedVal = 14;     // ERROR

// t.privateProtectedVal = 15;      // ERROR
// t.internalVal = 16;              // ERROR
// t.protectedInternalVal = 17;     // ERROR


class Temp: Test
{
    void Render()
    {
        Console.WriteLine(this.protectedVal);
        // Console.WriteLine(this.privateProtectedVal);     // ERROR
        // Console.WriteLine(this.internalVal);             // ERROR
        Console.WriteLine(this.protectedInternalVal);
    }
}

