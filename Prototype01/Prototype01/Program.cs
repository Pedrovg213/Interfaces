using System.Globalization;
using Prototype01.Entities;
using Prototype01.Services;

namespace Prototype01 {
   internal class Program {
      static void Main( string[ ] args ) {

         // Inputs
         Console.WriteLine( "Enter rental data:" );
         // Car model
         Console.Write( "Car model: " );
         string carModel = Console.ReadLine();
         // Start
         Console.Write( "Pickup (dd/MM/yyyy hh:mm): " );
         DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
         // Finish
         Console.Write( "Return (dd/MM/yyyy hh:mm): " );
         DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
         // Price per hour
         Console.Write( "Enter price per hour: $" );
         double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         // Price per day
         Console.Write( "Enter price per day: $" );
         double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         Console.WriteLine();

         // Instantiation
         CarRental carRental = new CarRental(start, finish, carModel);
         RentalService rentalService = new RentalService(pricePerHour, pricePerDay);

         rentalService.ProcessInvoice( carRental );

         Console.WriteLine( "INVOICE:" );
         Console.WriteLine( carRental.Invoice );
      }
   }
}