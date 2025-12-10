// using System;

// public class Parent
// {
//     string parentString;

//     public Parent()
//     {
//         Console.WriteLine("Parent Constructor.");
//     }

//     public Parent(string myString)
//     {
//         parentString = myString;

//         Console.WriteLine(parentString);
//     }

//     public void print()
//     {
//         Console.WriteLine("I am a Parent class");
//     }
// }

// public class Child : Parent
// {
//     public Child(): base("From derived")
//     {
//         Console.WriteLine("Child constructor.");
//     }

//     // Create your own implementation of a method that exists in a base class
//     public new void print()
//     {
//         base.print();

//         Console.WriteLine("I am a Child class.");
//     }

//     public static void Main()
//     {
//         Child child = new Child();

//         // Call print() from Child class
//         child.print();

//         // Cast child as Parent
//         ((Parent)child).print();
//     }
// }