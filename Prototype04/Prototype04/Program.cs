using System;
using System.IO;
using System.Collections.Generic;

namespace Prototype04 {
   internal class Program {
      static void Main( string[ ] args ) {

         string filePath = @"C:\Users\pedro\Desktop\C# Estudo\Seção 14 - Interfaces\Interfaces\Prototype04\in.txt";

         try {
            using ( StreamReader streamReader = File.OpenText( filePath ) ) {

               List<string> list = new List<string>();

               while ( !streamReader.EndOfStream )
                  list.Add( streamReader.ReadLine() );

               list.Sort();
               foreach ( string str in list )
                  Console.WriteLine( str );
            }
         } catch ( IOException ioe ) {

            Console.WriteLine( "An error occurred." );
            Console.WriteLine( ioe.Message );

         }
      }
   }
}