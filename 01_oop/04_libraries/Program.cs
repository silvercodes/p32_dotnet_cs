using _04_libraries;
using FileProcessor;
using FileProcessor.Core;
using MathLib.Engine;
using Newtonsoft.Json;

DataWriter dw = new DataWriter();
dw.Debug();

Kernel kernel = new Kernel();
kernel.Debug();

SimpleCalc calc = new SimpleCalc();
Console.WriteLine(calc.Execute(2, 7, Operation.Mul));
Console.WriteLine();


//User user = new User()
//{ 
//    id = 101,
//    email = "vasia@mail.com",
//    age = 23,
//};

//string json = JsonConvert.SerializeObject(user);
//Console.WriteLine(json);



string json = @"{""id"":101,""email"":""vasia@mail.com"",""age"":23}";
User user = JsonConvert.DeserializeObject<User>(json);
user.Render();


