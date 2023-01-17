//Write a program to add the elements of an array that stores integer values having length 6.

using System;

class Program {
  public static void Main (string[] args) {


     int []  num = {3,5,6,7,8,9};

    int sum=0;

    Console.WriteLine("Enter An Array of 6 Values");
    for (int i=0; i<6; i++)

    { 

     //num[i]=Convert.ToInt32(Console.ReadLine());
     sum+=num[i];

    }
    
    // Console.WriteLine(num[i]); 
    
   Console.WriteLine("Sum is {0}", sum);

}
  }