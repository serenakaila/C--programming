//Program to make a calculator
using System;

class Program {
  public static void Main (string[] args) {

    /* int a;b; //declaration
    a=71; b=10; //initialization */
  int a,b;
  Console.WriteLine("Enter two numbers");
  a=Convert.ToInt32(Console.ReadLine());
  b=Convert.ToInt32(Console.ReadLine());   

  Console.WriteLine ("Enter the option");
  string exp=Console.ReadLine();

  //Console.WriteLine ("Hello World")
    
  switch(exp)
    {
    case "+": Console.WriteLine("Addition={0}",(a+b));
      break;

    case"-": Console.WriteLine("Subtraction={0}",(a-b));
      break;

    case"*": Console.WriteLine("Multiply={0}",(a*b));
      break;

    case "/": Console.WriteLine("Divide={0}",(a/b));
      break;

    case "%": Console.WriteLine("Modulo={0}",(a%b));
      break;


    default: Console.WriteLine("some other choices");
  break;
      
  
    }
//come out of the switch case

  }
}