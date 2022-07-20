using System;
using Prototype01.Entities;

namespace Prototype01.Services {
   internal class RentalService {

      private ITaxService TaxService;
      public double PricePerHour {
         get; private set;
      }
      public double PricePerDay {
         get; private set;
      }


      public RentalService( double _pricePerHour , double _pricePerDay , ITaxService _taxService ) {

         PricePerHour = _pricePerHour;
         PricePerDay = _pricePerDay;
         TaxService = _taxService;

      }


      public void ProcessInvoice( CarRental _carRental ) {

         TimeSpan duration = _carRental.Finish.Subtract(_carRental.Start);
         double basicPayment = duration.TotalHours <= 12 ?
            basicPayment = PricePerHour * Math.Ceiling( duration.TotalHours ) :
            basicPayment = PricePerDay * Math.Ceiling( duration.TotalDays );

         double tax = TaxService.Tax(basicPayment);

         _carRental.Invoice = new Invoice( basicPayment , tax );

      }
   }
}
