using System.Web.Http;
using Triangles.Models;
using Triangles.Services;

namespace Triangles.Controllers
{
   /// <summary>
   /// Triangles API
   /// </summary>
   public class TriangleController : ApiController
   {
      private TriangleService triangleService;

      /// <summary>
      /// Default constructor for TriangleController
      /// </summary>
      public TriangleController()
      {
         triangleService = new TriangleService();
      }

      // GET api/triangle/A/1
      /// <summary>
      /// Given a row and a column for a triangle, the coordinates of the vertices are calculated.
      /// </summary>
      /// <param name="row">The row of the triangle</param>
      /// <param name="column">The column of the triangle</param>
      /// <returns>A Triangle object with the details of the triangle</returns>
      [Route("api/triangle/{row}/{column}")]
      public Triangle Get(char row, int column)
      {
         return triangleService.GetTriangle(row, column);
      }

      // POST api/triangle
      /// <summary>
      /// Gets the row and column of the triangle for the supplied vertices.
      /// </summary>
      /// <param name="vertices">The vertices of the triangle to find</param>
      /// <returns>A triangle object with the details of the triangle</returns>
      /// [Route("api/triangle
      public Triangle Post([FromBody]TriangleVertices vertices)
      {
         return triangleService.GetTriangle(vertices.Vertex1, vertices.Vertex2, vertices.Vertex3);
      }

   }
}
