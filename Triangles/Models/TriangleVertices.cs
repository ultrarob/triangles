using System.Windows;

namespace Triangles.Models
{
   /// <summary>
   /// Class used to receive triangle vertices for the API.
   /// </summary>
   public class TriangleVertices
   {
      public Point Vertex1 { get; set; }
      public Point Vertex2 { get; set; }
      public Point Vertex3 { get; set; }
   }
}