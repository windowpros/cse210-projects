using System;
using System.IO.Compression;
using System.Linq.Expressions;

class Program
{

   static void TestByRef(ref int x, ref string n)
   {
      x++;
      n += "Plus Betty";
      Console.WriteLine($"In Main: {x}, {n}");
   }

   static void TestByOut(out int a)
   {
      a = 1010101;
      Console.WriteLine($"My number = {a}");
   }
   static void Main(string[] args)
   {

      Console.WriteLine("YeeHawww");

      int z = 10;
      string name = "Bob";

      TestByRef(ref z, ref name);
      Console.WriteLine($"In Main: {z}, {name}");

      int c;

      TestByOut(out c);
      Console.WriteLine($"My number = {c}");

      // int duration = 9;
      // DateTime currentTime = DateTime.Now;
      // DateTime endTime = currentTime.AddSeconds(10);
      // int sleepTime = 250;
      // int count = duration;

      // string animationString = "(^_^)(-_-)";


      // while (DateTime.Now < endTime)
      // {
      //    Console.Write(animationString[0..5]);
      //    Thread.Sleep(sleepTime);
      //    Console.Write("\b\b\b\b\b");
      //    Console.Write(animationString[5..]);
      //    Thread.Sleep(sleepTime);
      //    Console.Write("\b\b\b\b\b");

      // }

      // while (DateTime.Now < endTime)
      // {
      //    Console.Write(count--);
      //    Thread.Sleep(1000);
      //    // if (count >= 10)
      //    //    Console.WriteLine("\n\n");
      //    Console.Write("\b");

      // }

      // while (DateTime.Now < endTime)
      //    {
      //       Console.Write("+");
      //       Thread.Sleep(sleepTime);
      //       Console.Write("\b");
      //       Console.Write("-");
      //       Thread.Sleep(sleepTime);
      //       Console.Write("\b");
      //    }

      //  Circle myCircle = new Circle(10);
      //    myCircle.SetRadius(10);
      //  Console.WriteLine($"{myCircle.GetRadius()}");

      //    Circle myCircle2 = new Circle();
      //    myCircle2.SetRadius(20);
      //    Console.WriteLine($"{myCircle2.GetRadius()}");   

      //    Console.WriteLine($"{myCircle.GetArea()}");
      //    Console.WriteLine($"{myCircle2.GetArea()}");

      //  Cylinder myCylinder = new Cylinder(100,8);
      //    myCylinder.SetHeight(10);
      //    myCylinder.SetCircle(myCircle);

      //    Cylinder myCylinder2 = new Cylinder();
      //    myCylinder2.SetHeight(10);
      //    myCylinder2.SetCircle(myCircle2);

      //  Console.WriteLine($"{myCylinder.GetVolume()}");
      //    Console.WriteLine($"{myCylinder2.GetVolume()}");

      // Console.WriteLine("Hello World!");
   }

   //     // static double AddNumbers(double a, double b)
   //     // {
   //     //     return a + b;
   //     // }
   //     // static void Main(string[] args)
   //     // {
   //     //     double total = AddNumbers(127.66, 234426.87);
   //     //     Console.WriteLine(total);


   //         // Console.WriteLine("Hello Sandbox World!");

   //         // Console.WriteLine("Input your first name: ");
   //         // string firstname = Console.ReadLine();
   //         // Console.WriteLine($"Your first name is: {firstname}");

   //         // Console.WriteLine("Input your last name: ");
   //         // string lastname = Console.ReadLine();
   //         // Console.WriteLine($"Your full name is: {lastname}, {firstname} {lastname}");


   //         // int x = 10;
   //         // if (x == 10)

   //         // {
   //         //     Console.WriteLine("X is 10");
   //         // }
   //         // Console.WriteLine("How are you?");

   //         // Console.WriteLine("Hey, how are you?");


   //         // for(int i = 0; i < 20; i++)
   //         // {
   //         //     Console.WriteLine($"Hello Bob {i}");
   //         // }

   //         // int x = 0;
   //         // int y = x++;
   //         // Console.WriteLine(x);
   //         // Console.WriteLine(y);


   //         // List<int> myNumbers = new List<int>();
   //         // myNumbers.Add(99);
   //         // myNumbers.Add(55);
   //         // // myNumbers.Append(-150);
   //         // myNumbers.Add(240);

   //         // foreach(int i in myNumbers)
   //         // {
   //         //     Console.WriteLine(i);
   //         // }

   //     // }
}