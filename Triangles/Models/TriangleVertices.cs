using System.Windows;

namespace Triangles.Models
{
   /// <summary>
   /// Class used to receive triangle vertices for the API.
   /// </summary>
   public class TriangleVertices
   {
      /// <summary>
      /// Vertex 1 for the triangle
      /// </summary>
      public Point Vertex1 { get; set; }
      /// <summary>
      /// Vertex 2 for the triangle
      /// </summary>
      public Point Vertex2 { get; set; }
      /// <summary>
      /// Vertex 3 for the triangle
      /// </summary>
      public Point Vertex3 { get; set; }
   }
}