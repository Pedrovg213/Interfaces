using Prototype02.Entities;

namespace Prototype02.Services {
   internal class ContractService {

      public IOnlinePaymentService OnlinePaymentService {
         get; private set;
      }


      public ContractService( IOnlinePaymentService _onlinePaymentService ) {

         OnlinePaymentService = _onlinePaymentService;

      }


      public void ProcessContract( Contract _contract , int _months ) {

         for ( int i = 1; i <= _months; i++ ) {

            DateTime dueDate = _contract.Date.AddMonths(i);
            double monthValue = _contract.TotalValue / _months;
            double amount = OnlinePaymentService.Interest(monthValue, i);

            _contract.InstallmentAdd( new Installment( dueDate , amount ) );

         }
      }
   }
}
