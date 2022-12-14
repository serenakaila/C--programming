/* Question 6
 Print this pattern using for statement:  
    *****
    ****
    ***
    **
    *
*/

using System;

class Program {
  public static void Main (string[] args) {
    for (int i = 1; i <= 5; i++) {
      for (int j = 5; j >= i; j--) {
        Console.Write("*");
      }
      Console.WriteLine();
    }
  }
}