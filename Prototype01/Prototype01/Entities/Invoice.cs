using System.Globalization;

namespace Prototype01.Entities {
   internal class Invoice {

      public double BasicPayment {
         get; set;
      }
      public double Tax {
         get; set;
      }
      public double TotalPayment {
         get {
            return ( BasicPayment + Tax );
         }
      }


      public Invoice( double _basicPayment , double _tax ) {

         BasicPayment = _basicPayment;
         Tax = _tax;

      }


      public override string ToString( ) {

         return ( $"Basic payment: {BasicPayment.ToString( "F2" , CultureInfo.InvariantCulture )} \n" +
            $"Tax: ${Tax.ToString( "F2" , CultureInfo.InvariantCulture )} \n" +
            $"Total payment: {TotalPayment.ToString( "F2" , CultureInfo.InvariantCulture )}" );

      }
   }
}
