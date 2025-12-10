// using System;

// class IfSelect
// {
//     public static void Main()
//     {
//         string myInput;
//         int myInt;

//         Console.Write("Enter a number: ");
//         myInput = Console.ReadLine();
//         myInt = Int32.Parse(myInput);

//         if (myInt < 0 || myInt == 0)
//         {
//             Console.WriteLine("Your number is {0} is less that or equal to 0.", myInt);
//         }
//         else if (myInt > 0 && myInt <= 10)
//         {
//             Console.WriteLine("Your number {0} is in the range from 1 to 10.", myInt);
//         }
//         else if (myInt > 10 && myInt <= 20)
//         {
//             Console.WriteLine("Your number {0} is in the range from 10 to 20.", myInt);
//         }
//         else
//         {
//             Console.WriteLine("Your number {0} is greater than 20.", myInt);
//         }
//     }
// }