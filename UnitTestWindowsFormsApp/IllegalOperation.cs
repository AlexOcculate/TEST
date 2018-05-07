using System;
using System.Linq;
using System.Runtime.Serialization;

namespace UnitTestWindowsFormsApp
{
   [Serializable]
   public class IllegalOperation : Exception
   {
      public IllegalOperation()
      {
      }

      public IllegalOperation( string message ) : base( message )
      {
      }

      public IllegalOperation( string message, Exception innerException ) : base( message, innerException )
      {
      }

      protected IllegalOperation( SerializationInfo info, StreamingContext context ) : base( info, context )
      {
      }
   }
}
