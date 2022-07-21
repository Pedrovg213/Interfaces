
namespace Prototype02.Services {
   internal class PaypalService : IOnlinePaymentService {

      public double PaymentFee( double _amount ) {

         return ( _amount * .02 );

      }
      public double SimpleInterest( double _amount , int _mount ) {

         return ( _amount * _mount / 100 );

      }
      public double Interest( double _amount , int _mount ) {

         _amount += SimpleInterest( _amount , _mount );
         _amount += PaymentFee( _amount );

         return ( _amount );

      }
   }
}
