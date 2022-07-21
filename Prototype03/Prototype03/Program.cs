using System;
using Prototype03.Entities;
using Prototype03.Enums;

namespace Prototype03 {
   internal class Program {
      static void Main( string[ ] args ) {

         IShape s01 = new Circle(){

            Radius = 2.0,
            Color = Color.White

         };
         IShape s02 = new Rectangle(){

            Width = 3.5,
            Height = 4.2,
            Color = Color.Black

         };

         Console.WriteLine(s01);
         Console.WriteLine(s02);
      }
   }
}