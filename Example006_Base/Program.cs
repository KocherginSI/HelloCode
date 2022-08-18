int a = new Random() .Next(1, 10);
int b = new Random() .Next(1, 10);
int c = new Random() .Next(1, 10);
int d = new Random() .Next(1, 10);
int e = new Random() .Next(1, 10);
int max = a;

Console.Write("a -- ");
Console.WriteLine(a);
Console.Write("b -- ");
Console.WriteLine(b);
Console.Write("c -- ");
Console.WriteLine(c);
Console.Write("d -- ");
Console.WriteLine(d);
Console.Write("e -- ");
Console.WriteLine(e);
Console.Write("max -- ");
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine(max);

