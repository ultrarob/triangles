using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangles.Models;
using Triangles.Controllers;

namespace Triangles.Tests.Controllers
{
   // Test class to do a basic sanity test on the TriangleController. The testing of the calculations
   // takes place in TriangleServiceTest.
   [TestClass]
   public class TriangleControllerTest
   {
      [TestMethod]
      public void Get()
      {
         TriangleController controller = new TriangleController();

         // Act
         Triangle triangle = controller.Get('A', 1);

         // Assert
         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual('A', triangle.Row);
         Assert.AreEqual(1, triangle.Column);
         Assert.AreEqual(new Point(0, 10), triangle.Vertex1);
         Assert.AreEqual(new Point(0, 0), triangle.Vertex2);
         Assert.AreEqual(new Point(10, 10), triangle.Vertex3);
      }

      [TestMethod]
      public void Post()
      {
         TriangleController controller = new TriangleController();

         // Act
         string json = "{\"Vertex1\": \"0,10\",\"Vertex2\": \"0,0\",\"Vertex3\": \"10,10\"}";

         TriangleVertices vertices = Newtonsoft.Json.JsonConvert.DeserializeObject<TriangleVertices>(json);
         Triangle triangle = controller.Post(vertices);

         // Assert
         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual('A', triangle.Row);
         Assert.AreEqual(1, triangle.Column);
         Assert.AreEqual(new Point(0, 10), triangle.Vertex1);
         Assert.AreEqual(new Point(0, 0), triangle.Vertex2);
         Assert.AreEqual(new Point(10, 10), triangle.Vertex3);
      }
   }
}
