using System;

namespace Prototype01.Entities {
   internal class CarRental {

      public DateTime Start {
         get; set;
      }
      public DateTime Finish {
         get; set;
      }
      public Vehicle Vehicle {
         get; set;
      }
      public Invoice Invoice {
         get; set;
      }


      public CarRental( DateTime _start , DateTime _finish ) {

         Start = _start;
         Finish = _finish;

      }
      public CarRental( DateTime _start , DateTime _finish , Vehicle _vehicle ) :
         this( _start , _finish ) {

         Vehicle = _vehicle;

      }
      public CarRental( DateTime _start , DateTime _finish , string _vehicle ) :
         this( _start , _finish ) {

         Vehicle = new Vehicle( _vehicle );

      }

   }
}
