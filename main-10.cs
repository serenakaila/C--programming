using System;

class Program {
  public static void Main (string[] args) {
  string user1, user2;
    
    Console.WriteLine("choose from rock, paper and scissors for user 1");
    user1=Console.ReadLine();
    
    Console.WriteLine("choose from rock, paper and scissors for user 2");
    user2=Console.ReadLine();

    
    if(user1=="rock")
    {
      
      if(user2=="paper")
      {
        Console.WriteLine("user 2 wins");
      }
       if(user2=="rock")
      {
        Console.WriteLine("tie");
      }
       if(user2=="scissors")
      {
        Console.WriteLine("user 1 wins");
     }
   }
    else if(user1=="paper")
      
    {
      if(user2=="paper")
      {
        Console.WriteLine("tie");
      }
       if(user2=="rock")
      {
        Console.WriteLine("user 1 wins");
      }
       if(user2=="scissors")
      {
        Console.WriteLine("user 2 wins");
  }
    }
    
    else if(user1=="scissors")
      
    {
      if(user2=="paper")
      {
        Console.WriteLine("user 1 wins");
      }
       if(user2=="rock")
      {
        Console.WriteLine("user 2 wins");
      }
       if(user2=="scissors")
      {
        Console.WriteLine("tie");
  }
    }






      
  }
}