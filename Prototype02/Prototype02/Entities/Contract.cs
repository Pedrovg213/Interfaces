
namespace Prototype02.Entities {
   internal class Contract {

      public int ID {
         get; private set;
      }
      public double TotalValue {
         get; private set;
      }
      public DateTime Date {
         get; private set;
      }
      public List<Installment> Installments {
         get; private set;
      } = new List<Installment>();


      public Contract( int _id , double _totalValue , DateTime _date ) {

         ID = _id;
         TotalValue = _totalValue;
         Date = _date;

      }


      public void InstallmentAdd( Installment _installment ) {

         Installments.Add( _installment );

      }
      public void InstallmentRemove( Installment _installment ) {

         Installments.Remove( _installment );

      }
   }
}
