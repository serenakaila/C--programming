using System;

class Program {
  public static void Main (string[] args) {
    
    int n=5; //initialization
      for (int i=n; i>=1; i--) //outer loop
      {
      for (int j=i; j>=1;j--) //inner loop
      {
      Console.Write("*");
      }
      Console.WriteLine();
    }

  
  }
}
