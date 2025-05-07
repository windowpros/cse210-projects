using System;
using System.Linq.Expressions;



class Circle
{
    private double _radius;

    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            Console.WriteLine("ERROR, radius must > 0");
            return;
        }
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}


class Program
{

    static void Main(string[] args)
    {
       Circle myCircle = new Circle();
       myCircle.SetRadius(10);
       Console.WriteLine($"{myCircle.GetRadius()}");
       
       Circle myCircle2 = new Circle();
       myCircle.SetRadius(20);
       Console.WriteLine($"{myCircle.GetRadius()}");   

       Console.WriteLine($"{myCircle.GetArea()}");
       Console.WriteLine($"{myCircle2.GetArea()}");

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