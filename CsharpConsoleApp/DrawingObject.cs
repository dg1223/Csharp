// using System;

// public class DrawingObject
// {
//     public virtual void Draw()
//     {
//         Console.WriteLine("I'm just a generic drawing object.");
//     }
// }

// public class Line : DrawingObject
// {
//     public override void Draw()
//     {
//         Console.WriteLine("I am a Line.");
//     }
// }

// public class Circle : DrawingObject
// {
//     public override void Draw()
//     {
//         Console.WriteLine("I am a Circle.");
//     }
// }

// public class Square : DrawingObject
// {
//     public override void Draw()
//     {
//         Console.WriteLine("I am a Square.");
//     }
// }

// // Polymorphism
// public class DrawDemo
// {
//     public static void Main()
//     {
//         DrawingObject[] dObj = new DrawingObject[4];

//         dObj[0] = new Line();
//         dObj[1] = new Circle();
//         dObj[2] = new Square();
//         dObj[3] = new DrawingObject();

//         foreach (DrawingObject drawObj in dObj)
//         {
//             drawObj.Draw();
//         }

//         // return 0;
//     }
// }