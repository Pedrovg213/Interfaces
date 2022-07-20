
namespace Prototype01.Services {
   internal class BrazilTaxService : ITaxService {

      public double Tax( double amount ) {

         return amount <= 100 ?
            amount * .2 : amount * .15;

      }
   }
}
