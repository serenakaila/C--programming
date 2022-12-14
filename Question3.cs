/* Question 3
   Output this series using do while statement:
      1 2 4 8 16 ….. 1024
*/

using System;

class Program {
  public static void Main (string[] args) {
    int x = 1;
    do 
    {
      Console.WriteLine(x);
      x = x * 2;
    }
    while (x<=1024);  
  }
}