using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      double firstnum;
      double secondnum;
      double answer;
      string ops;
	
	    Console.Title = "Calculator Made By Dr Scep";

      Console.WriteLine("Calculator (Made by Dr Scep)");

      Console.WriteLine("Enter the first number.");

      firstnum = Double.Parse(Console.ReadLine());

      Console.WriteLine("Select your Operator: (+, -, *, /)");

      ops = Console.ReadLine();

      Console.WriteLine("Enter the second number.");

      secondnum = Double.Parse(Console.ReadLine());

    if (ops == "+")
    {
      answer = firstnum + secondnum;
      Console.Write(answer);
    }

    if (ops == "-")
    {
      answer = firstnum - secondnum;
      Console.Write(answer);
    }

    if (ops == "*")
    {
      answer = firstnum * secondnum;
      Console.Write(answer);
    }

    if (ops == "/")
    {
      answer = firstnum / secondnum;
      Console.Write(answer);
    }

      Console.Read();
    }
  }
}
