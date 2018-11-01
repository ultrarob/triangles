using System;

namespace Triangles.Exceptions
{ 

   // Exception class for errors with Triangles
   [Serializable]
   public class TriangleException : Exception
   {
      public TriangleException()
      {
      }

      public TriangleException(string message)
      : base(message)
      {
      }

      public TriangleException(string message, Exception innerException)
      : base(message, innerException)
      {
      }
   }
}