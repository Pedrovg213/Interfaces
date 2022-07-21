using System.Globalization;
using Prototype02.Entities;
using Prototype02.Services;

namespace Prototype02 {
   internal class Program {
      static void Main( string[ ] args ) {

         // Inputs
         Console.WriteLine( "Enter contract data:" );
         // Number Id
         Console.Write( "Number: " );
         int id = int.Parse( Console.ReadLine() );
         // Contract date
         Console.Write( "Date (dd/mm/yyyy): " );
         DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture );
         // Contract value
         Console.Write( "Contract value: $" );
         double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         // Installments number
         Console.Write( "Enter number of installments: " );
         int installmentsNum = int.Parse(Console.ReadLine());
         Console.WriteLine();

         // Instantiation
         Contract contract = new Contract(id, contractValue, contractDate);
         ContractService contractService = new ContractService(new PaypalService());

         // Process informations
         contractService.ProcessContract( contract , installmentsNum );

         // Output
         Console.WriteLine( "INSTALLMENTS:" );
         foreach ( Installment inst in contract.Installments )
            Console.WriteLine( inst );

      }
   }
}