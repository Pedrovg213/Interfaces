using Prototype03.Enums;

namespace Prototype03.Entities {
   internal abstract class AbstractShape : IShape {

      public Color Color {
         get; set;
      }


      public abstract double Area( );
   }
}
