using System.Globalization;

namespace Prototype02.Entities {
   internal class Installment {

      public DateTime DueDate {
         get; private set;
      }
      public double Amount {
         get; private set;
      }


      public Installment( DateTime _dueDate , double _amount ) {

         DueDate = _dueDate;
         Amount = _amount;

      }

      public override string ToString( ) {

         return
            ( $"{DueDate.ToString( "dd/MM/yyyy" )} - {Amount.ToString( "F2" , CultureInfo.InvariantCulture )}" );

      }
   }
}
