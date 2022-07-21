using System.Globalization;

namespace Prototype04.Entitites {
   internal class Employee : IComparable {

      public string Name {
         get; set;
      }
      public double Salary {
         get; set;
      }


      public Employee( string csvEmployee ) {

         string[] vect = csvEmployee.Split(',');

         Name = vect[ 0 ];
         Salary = double.Parse( vect[ 1 ] , CultureInfo.InvariantCulture );

      }
      public int CompareTo( object? obj ) {

         if ( !( obj is Employee ) )
            throw new ArgumentException( "Comparing error: argument is not an employee." );

         Employee otherEmployee = obj as Employee;

         return ( otherEmployee.Salary.CompareTo( Salary ) );

      }
      public override string ToString( ) {

         return ( $"{Name}, {Salary.ToString( "F2" , CultureInfo.InvariantCulture )}" );

      }
   }
}
