using System.Windows;

namespace Triangles.Models
{
   /// <summary>
   /// Class to represent a triangle in the grid
   /// </summary>
   public class Triangle
   {
      /// <summary>
      /// Row of the triangle
      /// </summary>
      public char Row { get; set; }
      /// <summary>
      /// Column of the triangle
      /// </summary>
      public int Column { get; set; }
      /// <summary>
      /// Vertex 1 of the triangle
      /// </summary>
      public Point Vertex1 { get; set; }
      /// <summary>
      /// Vertex 2 of the triangle
      /// </summary>
      public Point Vertex2 { get; set; }
      /// <summary>
      /// Vertex 3 of the triangle
      /// </summary>
      public Point Vertex3 { get; set; }
   }
}