using System;

class Program {
  public static void Main (string[] args) {
    
    string login; //Declaration
    string password; //Declaration

     Console.WriteLine ("Enter login");
    
    Console.WriteLine ("Enter password");
    
    login=Console.ReadLine();
    password=Console.ReadLine();


    if (login== "grade10" && password== "12345" ) {
  Console.WriteLine ("Username and Password is correct");
}
    else{
      Console.WriteLine("Wrong Username and Password");

          }
    
   

    


  
    
  
  }
}