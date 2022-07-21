using System;
using System.IO;
using System.Collections.Generic;
using Prototype04.Entitites;

namespace Prototype04 {
   internal class Program {
      static void Main( string[ ] args ) {

         string filePath = @"C:\Users\pedro\Desktop\C# Estudo\Seção 14 - Interfaces\Interfaces\Prototype04\in.txt";

         try {
            using ( StreamReader streamReader = File.OpenText( filePath ) ) {

               List<Employee> list = new List<Employee>();

               while ( !streamReader.EndOfStream )
                  list.Add( new Employee( streamReader.ReadLine() ));

               list.Sort();
               foreach ( Employee emp in list )
                  Console.WriteLine( emp );
            }
         } catch ( IOException ioe ) {

            Console.WriteLine( "An error occurred." );
            Console.WriteLine( ioe.Message );

         }
      }
   }
}