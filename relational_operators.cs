using System;

class RelationalOperators {
static void Main(string[] args) {
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("a == b: " + (a == b)); 
Console.WriteLine("a != b: " + (a != b));
Console.WriteLine("a > b: " + (a > b)); 
Console.WriteLine("a <= b: " + (a <= b));
Console.WriteLine("a < b: " + (a < b)); 
Console.WriteLine("a >= b: " + (a >= b));  
}
}