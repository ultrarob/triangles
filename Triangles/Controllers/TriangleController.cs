using System.Web.Http;
using Triangles.Models;
using Triangles.Services;

namespace Triangles.Controllers
{
   public class TriangleController : ApiController
   {
      private TriangleService triangleService;

      TriangleController()
      {
         triangleService = new TriangleService();
      }

      // GET api/triangle/A/1
      [Route("api/triangle/{row}/{column}")]
      public Triangle Get(char row, int column)
      {
         return triangleService.GetTriangle(row, column);
      }

      // POST api/values
      public void Post([FromBody]string value)
      {
      }

   }
}
