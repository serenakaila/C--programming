using System;

class Program {
  public static void Main (string[] args) {
    int num1, num2;


    Console.WriteLine("Enter first number");
      num1= Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Enter second number");
      num2= Convert.ToInt32(Console.ReadLine());
    
      //name=Console.ReadLine();
      //Console.WriteLine ("{0}{1}{2}",str1,str3,str2);
        Console.WriteLine("Numbers are {0} and {1}",num1,num2);
      // Name is : Serena

     if (num1>num2){
       Console.WriteLine (" {0} is greater than {1}", num1,num2);
     }
    else{
       Console.WriteLine (" {0} is greater than {1}", num2,num1);
     }
     
    
      //Console.WriteLine ("Prints on");
      //  Console.WriteLine ("New Line");

        //Console.WriteLine("Prints on");
        //Console.Write("Same line");
    
    
  }
}
