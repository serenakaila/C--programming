/* Question 2:
   Input 100 random integer numbers (positive and negative) and sum the positive and negative numbers using while statement.
*/

using System;

class Program {
  public static void Main (string[] args) {
    int i = 0;
    int sumPositive = 0;
    int sumNegative = 0;
    Random rnd = new Random();
    
    while (i<100){
      int number = rnd.Next(-100,100);
      if (number < 0) {
        sumNegative += number;
      } else {
        sumPositive += number;
      }
      i++;
    }
    
    Console.WriteLine("Sum of positve  numbers: " + sumPositive);
    Console.WriteLine("Sum of negative numbers: " + sumNegative);
  }
}