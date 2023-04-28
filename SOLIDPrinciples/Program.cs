// See https://aka.ms/new-console-template for more information
using SOLIDPrinciples;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;



public class Demo
{
    static void Main(string[] args)
    {
        
        SRPDemo();
        OCPDemo();
        OCPExample();
        LSPExample();
        LSPExample2();
        ISPDemo();
        DIPDemo();

        Console.ReadKey();
    }

    

    private static void SRPDemo()
    {
        var j = new Journal();
        j.AddEntry("played cricket");
        j.AddEntry("watch ipl");
        WriteLine(j);

        //var p = new Persistence();
        //var filename = @"c:\temp\journal.txt";
        //p.SaveToFile(j, filename);
        //Process.Start(filename);
    }
    private static void LSPExample()
    {
        Console.WriteLine("*** LSP ***");

        Rectangle rc = new Rectangle(2, 3);
        WriteLine($"{rc} has area {Area(rc)}");

        // should be able to substitute a base type for a subtype
        /*Square*/
        Rectangle sq = new Square();
        sq.Width = 4;
        WriteLine($"{sq} has area {Area(sq)}");
    }
    static public int Area(Rectangle r) => r.Width * r.Height;

    private static void LSPExample2()
    {
        //Apple apple = new Orange();  //child class object in the Parent class Reference variable
        //Console.WriteLine(apple.GetColor()); //Getting Orange color, 
        //That means once the child object is replaced i.e. Apple storing the Orange object, the behavior is also changed. This is against the LSP Principle
        //The Liskov Substitution Principle states that even if the child object is replaced with the parent, the behavior should not be changed

        IFruit fruit = new Orange();
        Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
        fruit = new Apple();
        Console.WriteLine($"Color of Apple: {fruit.GetColor()}");
    }

    private static void OCPExample()
    {
        ICricketer cricketer = new Fielder();
        var fieldersCount = cricketer.GetPlayers(15);
        Console.WriteLine($"Fielders Count among 15 is {fieldersCount}");

    }
    

    private static void OCPDemo()
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);

        Product[] products = { apple, tree, house };

        var pf = new ProductFilter();
        WriteLine("Green products (old):");
        foreach (var p in pf.FilterByColor(products, Color.Green))
            WriteLine($" - {p.Name} is green");

        // ^^ BEFORE

        // vv AFTER
        var bf = new BetterFilter();
        WriteLine("Green products (new):");
        foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            WriteLine($" - {p.Name} is green");

        WriteLine("Large products");
        foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
            WriteLine($" - {p.Name} is large");

        WriteLine("Large blue items");
        foreach (var p in bf.Filter(products,
          new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large)))
        )
        {
            WriteLine($" - {p.Name} is big and blue");
        }
    }

    private static void ISPDemo()
    {
        Console.WriteLine("*** ISP ***");

        //Using HPLaserJetPrinter we can access all Printer Services
        HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
        hPLaserJetPrinter.Print("Printing");
        hPLaserJetPrinter.Scan("Scanning");
        hPLaserJetPrinter.Fax("Faxing");
        hPLaserJetPrinter.PrintDuplex("PrintDuplex");
        //Using LiquidInkjetPrinter we can only Access Print and Scan Printer Services
        LiquidInkjetPrinter liquidInkjetPrinter = new LiquidInkjetPrinter();
        liquidInkjetPrinter.Print("Printing");
        liquidInkjetPrinter.Scan("Scanning");
        
    }

    public static void DIPDemo()
    {

    }

}

//Single Responsibility Principle (SRP) - class or module should have only one responsibility or reason to change
//a class should have only one job to do, and it should do it well.
//create classes with a single responsibility or job to do, leading to code that is easier to maintain, test, and modify over time.


//Open-Closed Principle (OCP)
//a software entity(classes, modules, functions, etc.)  should be designed in a way that new functionality can be added to it without changing its existing code.
//design software entities in a way that they can be extended with new functionality without changing their existing code



//Liskov Substitution Principle (LSP)
//program is using a base class, it should be able to use any of its derived classes without knowing it.
//any object of a derived class should be able to replace an object of its base class without affecting the correctness of the program.
//The LSP is important because it ensures that derived classes can be used as substitutes for their base classes, without introducing errors or unexpected behavior


//Interface Segregation Principle is a design principle that encourages developers to create interfaces that are specific to the needs of the client,
//rather than forcing the client to implement unnecessary functionality



//Dependency Inversion Principle - high-level modules should not depend on low-level modules
//Instead, both should depend on abstractions. Abstractions should not depend on details, but details should depend on abstractions







