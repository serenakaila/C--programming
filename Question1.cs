/* Question 1: 
   Input 100 random numbers and count the odd and even numbers using for statement.
*/

using System;

class Program {
  public static void Main (string[] args) {
    int i;
    int numEven= 0;
    int numOdd = 0;
    Random rnd = new Random();
    
    for (i = 0; i < 100; i++){
      int number = rnd.Next();
      if (number % 2 == 0) {
        numEven++;
      } else {
        numOdd++;
      }
    }
    
    Console.WriteLine("Number of even numbers: " + numEven);
    Console.WriteLine("Number of odd numbers: " + numOdd);
  }
}