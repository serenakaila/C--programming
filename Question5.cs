/* Question 5
   Sum this series using while statement
      3 5 7 ….99 
*/

using System;

class Program {
  public static void Main (string[] args) {
    int i = 3;
    int sum = 0;
    while (i <= 99) {
      sum += i;
      i +=2;
    }
    Console.WriteLine("sum: " + sum);
  }
}