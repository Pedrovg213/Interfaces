using System;
using Prototype01.Entities;

namespace Prototype01.Services {
   internal class RentalService {

      private BrazilTaxService brazilTaxService = new BrazilTaxService();
      public double PricePerHour {
         get; private set;
      }
      public double PricePerDay {
         get; private set;
      }


      public RentalService( double _pricePerHour , double _pricePerDay ) {

         PricePerHour = _pricePerHour;
         PricePerDay = _pricePerDay;

      }


      public void ProcessInvoice( CarRental _carRental ) {

         TimeSpan duration = _carRental.Finish.Subtract(_carRental.Start);
         double basicPayment = duration.TotalHours <= 12 ?
            basicPayment = PricePerHour * Math.Ceiling( duration.TotalHours ) :
            basicPayment = PricePerDay * Math.Ceiling( duration.TotalDays );

         double tax = brazilTaxService.Tax(basicPayment);

         _carRental.Invoice = new Invoice( basicPayment , tax );

      }
   }
}
