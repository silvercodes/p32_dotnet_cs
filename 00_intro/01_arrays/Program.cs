
#region Одномерные массивы

//int[] a;

//int[] b = new int[2];

//int[] c = new int[4] { 4, 6, 7, 8 };

//int[] d = new int[] { 4, 6, 7, 8 };

//int[] e = new [] { 4, 6, 7, 8 };

//int[] f = { 4, 6, 7, 8 };

//int[] g = [ 4, 6, 7, 8 ];

//int[] h = [];

//Console.WriteLine(f[1]);
//f[1] = 100;

// Console.WriteLine(f.Length);

//Console.WriteLine(f[f.Length - 1]);
//// EQUALS
//Console.WriteLine(f[^1]);

//for (int i = 0; i < f.Length; ++i)
//    Console.Write($"{f[i]} ");

//foreach(int item in f)
//    Console.Write($"{item} ");

#endregion

#region n-мерные массивы

int[,] a;

int[,] b = new int[2, 3];

int[,] c = new int[2, 3] { { 3, 4, 5 }, { 6, 7, 8 } };

int[,] d = new int[,] { { 3, 4, 5 }, { 6, 7, 8 } };

int[,] e = new [,] { { 3, 4, 5 }, { 6, 7, 8 } };

int[,] f = { { 3, 4, 5 }, { 6, 7, 8 } };

int rows = f.GetUpperBound(0) + 1;
int cols = f.GetUpperBound(1) + 1;

for (int i = 0; i < rows; ++i)
{
    for (int j = 0; j < cols; ++j)
        Console.Write($"{f[i,j]} ");

    Console.WriteLine();
}

#endregion








