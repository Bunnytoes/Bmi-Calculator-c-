using System;
using System.Diagnostics;
using System.Linq;
using System.IO;

class MainClass {
  public static void Main (string[] args) {
   
Console.ForegroundColor = ConsoleColor.DarkYellow;


Console.WriteLine("Note: Please don't use if you are pregnant, or a pro football player");


Console.ForegroundColor = ConsoleColor.Cyan;


System.Threading.Thread.Sleep(4000);

Console.WriteLine("Welcome to my Bmi calculator!");

System.Threading.Thread.Sleep(3500);
  
   Console.ForegroundColor = ConsoleColor.DarkRed;

   Console.WriteLine("1. Bmi in metric system 2. Bmi in standard");



  int Bmi1 = Convert.ToInt32(Console.ReadLine());
 
   
   if (Bmi1 > 2 || Bmi1<1)
{
  Console.WriteLine("Error");
}

   if (Bmi1 == 1)
   { 
   Console.ForegroundColor = ConsoleColor.Cyan;
     Console.WriteLine ("enter weight in kilograms");
    int kilos = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.DarkRed;


 Console.WriteLine("Enter height in meters");
 int meters = Convert.ToInt32(Console.ReadLine());
 double meters2= meters * meters;
 double final = kilos / meters2;
 
Console.ForegroundColor = ConsoleColor.DarkYellow;

 Console.WriteLine("Here are the statistics:");
 Console.WriteLine("Your Bmi is " + final);
  
   
   Console.ForegroundColor = ConsoleColor.Cyan;
   if (final < 18.5 )
    {
       Console.WriteLine ("That means you're underweight :("); 
    
    System.Threading.Thread.Sleep(3000);

  

  Console.WriteLine("Press any key to close");
  Console.ReadKey();
    }
    
       if (final > 18.5 && final < 25 )
    {
       Console.WriteLine ("That means you have a normal weight :)");
    
    System.Threading.Thread.Sleep(3000);

  

  Console.WriteLine("Press any key to close");
  Console.ReadKey();
    }
    
    if (final > 25  && final < 30)
    {
       Console.WriteLine ("That means you're overweight, sorry :(");
    System.Threading.Thread.Sleep(3000);

  

  Console.WriteLine("Press any key to close");
  Console.ReadKey();
    
    }
   
   if (final > 29)
  {
    Console.WriteLine("Sorry, that means you are Obese :(");
  System.Threading.Thread.Sleep(3000);

  

  Console.WriteLine("Press any key to close");
  Console.ReadKey();
  
  }
   
   
   }
  
 
 
 else if (Bmi1 == 2)
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("enter weight in pounds");
    int lb = Convert.ToInt32(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("enter height in inches");
    int inches = Convert.ToInt32(Console.ReadLine());
    double inches2 = inches * inches;

double final2 = lb / inches2 * 703;

Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.WriteLine("Here are the statistics:");
Console.WriteLine("Your Bmi is " + final2);
  
 
 Console.ForegroundColor = ConsoleColor.Cyan;
 if (final2 < 18.5 )
    {
       Console.WriteLine ("That means you're underweight :("); 
    System.Threading.Thread.Sleep(3000);

  

  Console.Write("Press any key to close");
            Console.ReadKey();
    
    }
    
       if (final2 > 18.5 && final2 < 25 )
    {
       Console.WriteLine ("That means you have a normal weight :)");
    System.Threading.Thread.Sleep(3000);

  

  Console.WriteLine("Press any key to close");
  Console.ReadKey();
    
    }
    
    if (final2 > 25 && final2 < 30 )
    {
       Console.WriteLine ("That means you're overweight, sorry :(");
    System.Threading.Thread.Sleep(3000);

  

  Console.WriteLine("Press any key to close");
  Console.ReadKey();
    
    }
 
  if (final2 > 29)
  {
    Console.WriteLine("Sorry, that means you are Obese :(");
  
  System.Threading.Thread.Sleep(3000);

  

  Console.WriteLine("Press any key to close");
  Console.ReadKey();
  
  }
  
  
  
  }

}
 


 



}
  
   
  
      
