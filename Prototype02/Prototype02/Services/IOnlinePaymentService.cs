
namespace Prototype02.Services {
   internal interface IOnlinePaymentService {

      double PaymentFee( double _amount );
      double SimpleInterest( double _amount , int _month );
      double Interest( double _amount , int _month );

   }
}
