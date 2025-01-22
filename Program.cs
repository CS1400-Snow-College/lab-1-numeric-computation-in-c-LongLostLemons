// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
int a = 18;
int b = 6;
int c = a * b;
Console.WriteLine(c);

int d = 5;
int e = 4;
int f = 2;
int g = (d + e) - 6 * f + (12 * 4) / 3 + 12;
Console.WriteLine(g);

int i = 7;
int j = 4;
int k = 3;
int l = (i + j) / k;
Console.WriteLine(l);

int m = 7;
int n = 4;
int o = 3;
int p = (m + n) / o;
int q = (m + n) % o;
Console.WriteLine($"quoteint: {p}");
Console.WriteLine($"remainder: {q}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An Example of overflow: {what}");

double r = 5;
double s = 4;
double t = 2;
double u = (r + s) / t;
Console.WriteLine(u);

double v = 19;
double w = 23;
double x = 8;
double y = (v + w) / x;
Console.WriteLine(y);

double max1 = double.MaxValue;
double min1 = double.MinValue;
Console.WriteLine($"The range of double is {min1} to {max1}");

double third = 1.0 / 3.0;
Console.WriteLine(third);

double fourth = 16.25 / 81.50;
Console.WriteLine(fourth);

decimal min2 = decimal.MinValue;
decimal max2 = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min2} to {max2}");

double a1 = 1.0;
double b1 = 3.0;
Console.WriteLine(a1 / b1);

decimal c1 = 1.0M;
decimal d1 = 3.0M;
Console.WriteLine(c1 / d1);

double e1 = 2.50;
double f1 = Math.PI;
double g1 = (e1 * e1) * f1;
Console.WriteLine(g1);