using System;

class AssignmentOperators {
static void Main(string[] args) {
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
a += b; 
Console.WriteLine("a += b: " + a); 
a -= b; 
Console.WriteLine("a -= b: " + a); 
a *= b; 
Console.WriteLine("a *= b: " + a); 
a /= b; 
Console.WriteLine("a /= b: " + a); 
a %= b; 
Console.WriteLine("a %= b: " + a); 
}
}