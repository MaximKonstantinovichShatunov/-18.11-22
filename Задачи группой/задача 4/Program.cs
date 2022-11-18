using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter Number");
    int a = int.Parse(Console.ReadLine()) % 10;
    Console.WriteLine(a);
  }
}

