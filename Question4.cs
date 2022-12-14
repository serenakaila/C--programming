/* Question 4 
  Print this pattern using for statement:
    1
    1 2
    1 2 3
    1 2 3 4
    1 2 3 4 5
*/
  
using System;

class Program {
  public static void Main (string[] args) {
    for (int i = 1; i <= 5; i++) {
      for (int j = 1; j <= i; j++) {
        Console.Write(j + " ");
      }
      Console.WriteLine("");
    }
  }
}