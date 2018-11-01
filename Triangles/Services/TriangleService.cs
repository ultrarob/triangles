using System.Windows;
using Triangles.Models;
using Triangles.Exceptions;

namespace Triangles.Services
{
   /// <summary>
   /// Service to provide additional info about a triangle. The triangles are right triangles 
   /// in a grid with rows A-F and columns 1-12. The triangles alternate as lower left and upper
   /// right halves of a square.
   /// </summary>
   public class TriangleService
   {
      // Length of non-hypotenuse sides
      private const int NON_HYPOTENUSE_LENGTH = 10;
      // Constants for validating row and column
      private const char MIN_ROW = 'a';
      private const char MAX_ROW = 'f';
      private const int MIN_COLUMN = 1;
      private const int MAX_COLUMN = 12;


      /// <summary>
      /// Given a row and column for a triangle, the coordinates of the vertices are calculated.
      /// </summary>
      /// <param name="row">The row for the triangle</param>
      /// <param name="column">The column for the triangle</param>
      /// <returns>
      /// A <code>Triangle</code> object for the specified row and column.
      /// </returns>
      /// <exception cref="Triangles.Exceptions.TriangleException">
      /// Thrown when an invalid row or column is supplied.
      /// </exception>
      public Triangle GetTriangle(char row, int column)
      {
         // First check that the row and column are valid
         // Rows must be A-F and we'll allow upper or lowercase
         // Columns must be 1-12
         char lowerRow = char.ToLower(row);
         if (lowerRow < MIN_ROW || lowerRow > MAX_ROW)
         {
            throw new TriangleException("Supplied row is invalid");
         }
         if (column < MIN_COLUMN || column > MAX_COLUMN)
         {
            throw new TriangleException("Supplied column is invalid");
         }

         // Although there are columns 1 through 12, they could be thought of as half as many columns with a
         // square with a lower left triangle and an upper right triangle. We'll calculate coordinates of a square
         // using zero based rows and columns
         int squareRow = (int)lowerRow - (int)MIN_ROW;
         int squareColumn = (column - MIN_COLUMN) / 2;

         Triangle triangle = new Triangle();
         triangle.Row = row;
         triangle.Column = column;
         // Calculate lower left corner vertex or upper right vertex based on odd or even
         // The odd or even is based on the original column and not the column of squares
         if (column % 2 == 0)
         {
            // upper right
            triangle.Vertex1 = new Point(squareColumn * NON_HYPOTENUSE_LENGTH + NON_HYPOTENUSE_LENGTH,
               squareRow * NON_HYPOTENUSE_LENGTH);
         }
         else
         {
            // lower left
            triangle.Vertex1 = new Point(squareColumn * NON_HYPOTENUSE_LENGTH,
               squareRow * NON_HYPOTENUSE_LENGTH + NON_HYPOTENUSE_LENGTH);
         }
         // upper left vertex
         triangle.Vertex2 = new Point(squareColumn * NON_HYPOTENUSE_LENGTH,
            squareRow * NON_HYPOTENUSE_LENGTH);
         // lower right vertex
         triangle.Vertex3 = new Point(squareColumn * NON_HYPOTENUSE_LENGTH + NON_HYPOTENUSE_LENGTH,
            squareRow * NON_HYPOTENUSE_LENGTH + NON_HYPOTENUSE_LENGTH);

         return triangle;
      }

      /// <summary>
      /// Given the vertices of a triangle, the row and column are calculated.
      /// </summary>
      /// <param name="vertex1">Vertex 1 for the triangle</param>
      /// <param name="vertex2">Vertex 2 for the triangle</param>
      /// <param name="vertex3">Vertex 3 for the triangle</param>
      /// <returns>
      /// A <code>Triangle</code> object for the specified vertices.
      /// </returns>
      /// <exception cref="Triangles.Exceptions.TriangleException">
      /// Thrown when an invalid vertex is supplied.
      /// </exception>
      public Triangle GetTriangle(Point vertex1, Point vertex2, Point vertex3)
      {
         // First do some validation on the vertices

         // Determine if the triangle is the lower left or upper right
         // triangle of a square and put the vertices into a known order.
         bool lowerLeftTriangle = OrderVertices(ref vertex1, ref vertex2, ref vertex3);

         // TODO:
         return null;
      }

      /// <summary>
      /// This method puts the vertices of a triangle in a known order and determines if the triangle is the lower
      /// left triangle of a square or the upper right triangle. For the lower left triangle, the vertices will be
      /// in the order of lower left vertex, upper left vertex and then lower right vertex.  For the upper right 
      /// triangle, the vertices will be in the order of upper right vertex, upper left vertex and then the lower right
      /// vertex.
      /// </summary>
      /// <returns>
      /// <code>true</code> if the vertices are for the lower left triangle and <code>false</code>
      /// if they are for the upper right triangle.
      /// </returns>
      private bool OrderVertices(ref Point vertex1, ref Point vertex2, ref Point vertex3)
      {
         // We need to determine if the triangle is the lower left or upper right
         // triangle of a square. First find the horizontal side. If the third vertex is
         // above the horizontal line, it's the lower left triangle. Otherwise it's the
         // right triangle
         Point horizontalVertex1;
         Point horizontalVertex2;
         Point verticalVertex;
         if (vertex1.Y == vertex2.Y)
         {
            horizontalVertex1 = vertex1;
            horizontalVertex2 = vertex2;
            verticalVertex = vertex3;
         }
         else if (vertex1.Y == vertex3.Y)
         {
            horizontalVertex1 = vertex1;
            horizontalVertex2 = vertex3;
            verticalVertex = vertex2;
         }
         else
         {
            horizontalVertex1 = vertex2;
            horizontalVertex2 = vertex3;
            verticalVertex = vertex1;
         }

         // Check for whether lower left or upper right triangle. 
         bool lowerLeftTriangle = true;
         if (horizontalVertex1.Y < verticalVertex.Y)
         {
            lowerLeftTriangle = false;
         }

         if (lowerLeftTriangle)
         {
            if (horizontalVertex1.X < horizontalVertex2.X)
            {
               vertex1 = horizontalVertex1;
               vertex3 = horizontalVertex2;
            }
            else
            {
               vertex1 = horizontalVertex2;
               vertex3 = horizontalVertex1;
            }
            vertex2 = verticalVertex;
         }
         else
         {
            if (horizontalVertex1.X > horizontalVertex2.X)
            {
               vertex1 = horizontalVertex1;
               vertex2 = horizontalVertex2;
            }
            else
            {
               vertex1 = horizontalVertex2;
               vertex2 = horizontalVertex1;
            }
            vertex3 = verticalVertex;
         }

         return lowerLeftTriangle;
      }
   }
}