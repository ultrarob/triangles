using System;

namespace Triangles.Exceptions
{
   /// <summary>
   /// Exception class for errors with Triangles
   /// </summary>
   [Serializable]
   public class TriangleException : Exception
   {
      /// <summary>
      /// Default constructor
      /// </summary>
      public TriangleException()
      {
      }

      /// <summary>
      /// Constructor that sets the message for the exception
      /// </summary>
      /// <param name="message"></param>
      public TriangleException(string message)
      : base(message)
      {
      }

      /// <summary>
      /// Constructor that sets the message for the exception and the inner exception
      /// </summary>
      /// <param name="message"></param>
      /// <param name="innerException"></param>
      public TriangleException(string message, Exception innerException)
      : base(message, innerException)
      {
      }
   }
}