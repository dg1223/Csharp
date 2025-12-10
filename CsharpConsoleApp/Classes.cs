// using System;

// class OutputClass
// {
//     string myString;

//     // Constructor
//     public OutputClass(string inputString)
//     {
//         myString = inputString;
//     }

//     // Instance method
//     public void printString()
//     {
//         Console.WriteLine("{0}", myString);
//     }

//     // Destructor
//     ~OutputClass()
//     {
//         // Cleanup resources
//     }
// }

// class ExampleClass
// {
//     public static void Main()
//     {
//         // Instance of OutputClass
//         OutputClass outCl = new OutputClass("This is printed by the Constructor.");

//         // OutputClass' printString method assigns argument to myString through the Constructor.
//         outCl.printString();
//     }

// }