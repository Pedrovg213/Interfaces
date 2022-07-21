using System.Globalization;

namespace Prototype03.Entities {
   internal class Circle : AbstractShape {

      public double Radius {
         get; set;
      }


      public override double Area( ) {

         return ( Math.PI * Math.Pow( Radius , 2 ) );

      }
      override public string ToString( ) {

         return ( $"Circle color: {Color}, " +
            $"Radius: {Radius.ToString( "F2" , CultureInfo.InvariantCulture )}, " +
            $"Area: {Area().ToString( "F2" , CultureInfo.InvariantCulture )}" );

      }
   }
}
