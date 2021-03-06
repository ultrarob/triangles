﻿using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangles.Services;
using Triangles.Models;

namespace Triangles.Tests.Services
{
   [TestClass]
   public class TriangleServiceTest
   {
      readonly TriangleService triangleService = new TriangleService();

      [TestMethod]
      // A1
      public void RowAColumn1Coordinates()
      {
         Triangle triangle = triangleService.GetTriangle('A', 1);

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual('A', triangle.Row);
         Assert.AreEqual(1, triangle.Column);
         Assert.AreEqual(new Point(0, 10), triangle.Vertex1);
         Assert.AreEqual(new Point(0, 0), triangle.Vertex2);
         Assert.AreEqual(new Point(10, 10), triangle.Vertex3);
      }

      [TestMethod]
      // A2
      public void RowAColumn2Coordinates()
      {
         Triangle triangle = triangleService.GetTriangle('A', 2);

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual('A', triangle.Row);
         Assert.AreEqual(2, triangle.Column);
         Assert.AreEqual(new Point(10, 0), triangle.Vertex1);
         Assert.AreEqual(new Point(0, 0), triangle.Vertex2);
         Assert.AreEqual(new Point(10, 10), triangle.Vertex3);
      }

      [TestMethod]
      // A11
      public void RowAColumn11Coordinates()
      {
         Triangle triangle = triangleService.GetTriangle('A', 11);

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual('A', triangle.Row);
         Assert.AreEqual(11, triangle.Column);
         Assert.AreEqual(new Point(50, 10), triangle.Vertex1);
         Assert.AreEqual(new Point(50, 0), triangle.Vertex2);
         Assert.AreEqual(new Point(60, 10), triangle.Vertex3);
      }

      [TestMethod]
      // A12
      public void RowAColumn12Coordinates()
      {
         Triangle triangle = triangleService.GetTriangle('A', 12);

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual('A', triangle.Row);
         Assert.AreEqual(12, triangle.Column);
         Assert.AreEqual(new Point(60, 0), triangle.Vertex1);
         Assert.AreEqual(new Point(50, 0), triangle.Vertex2);
         Assert.AreEqual(new Point(60, 10), triangle.Vertex3);
      }

      [TestMethod]
      // B1
      public void RowBColumn1Coordinates()
      {
         Triangle triangle = triangleService.GetTriangle('B', 1);

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual('B', triangle.Row);
         Assert.AreEqual(1, triangle.Column);
         Assert.AreEqual(new Point(0, 20), triangle.Vertex1);
         Assert.AreEqual(new Point(0, 10), triangle.Vertex2);
         Assert.AreEqual(new Point(10, 20), triangle.Vertex3);
      }

      [TestMethod]
      // B2
      public void RowBColumn2Coordinates()
      {
         Triangle triangle = triangleService.GetTriangle('B', 2);

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual('B', triangle.Row);
         Assert.AreEqual(2, triangle.Column);
         Assert.AreEqual(new Point(10, 10), triangle.Vertex1);
         Assert.AreEqual(new Point(0, 10), triangle.Vertex2);
         Assert.AreEqual(new Point(10, 20), triangle.Vertex3);
      }

      [TestMethod]
      // F12
      public void RowFColumn12Coordinates()
      {
         Triangle triangle = triangleService.GetTriangle('F', 12);

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual('F', triangle.Row);
         Assert.AreEqual(12, triangle.Column);
         Assert.AreEqual(new Point(60, 50), triangle.Vertex1);
         Assert.AreEqual(new Point(50, 50), triangle.Vertex2);
         Assert.AreEqual(new Point(60, 60), triangle.Vertex3);
      }

      [TestMethod]
      // A1 from coordinates
      public void CoordinatesRowColumnA1()
      {
         Triangle triangle = triangleService.GetTriangle(new Point(10, 10), new Point(0, 10), new Point(0, 0));

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual(new Point(0, 10), triangle.Vertex1);
         Assert.AreEqual(new Point(0, 0), triangle.Vertex2);
         Assert.AreEqual(new Point(10, 10), triangle.Vertex3);
         Assert.AreEqual('A', triangle.Row);
         Assert.AreEqual(1, triangle.Column);
      }

      [TestMethod]
      // A2 from coordinates
      public void CoordinatesRowColumnA2()
      {
         Triangle triangle = triangleService.GetTriangle(new Point(10, 10), new Point(0, 0), new Point(10, 0));

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual(new Point(10, 0), triangle.Vertex1);
         Assert.AreEqual(new Point(0, 0), triangle.Vertex2);
         Assert.AreEqual(new Point(10, 10), triangle.Vertex3);
         Assert.AreEqual('A', triangle.Row);
         Assert.AreEqual(2, triangle.Column);
      }

      [TestMethod]
      // A11 from coordinates
      public void CoordinatesRowColumnA11()
      {
         Triangle triangle = triangleService.GetTriangle(new Point(50, 0), new Point(60, 10), new Point(50, 10));

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual(new Point(50, 10), triangle.Vertex1);
         Assert.AreEqual(new Point(50, 0), triangle.Vertex2);
         Assert.AreEqual(new Point(60, 10), triangle.Vertex3);
         Assert.AreEqual('A', triangle.Row);
         Assert.AreEqual(11, triangle.Column);
      }

      [TestMethod]
      // A12 from coordinates
      public void CoordinatesRowColumnA12()
      {
         Triangle triangle = triangleService.GetTriangle(new Point(50, 0), new Point(60, 0), new Point(60, 10));

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual(new Point(60, 0), triangle.Vertex1);
         Assert.AreEqual(new Point(50, 0), triangle.Vertex2);
         Assert.AreEqual(new Point(60, 10), triangle.Vertex3);
         Assert.AreEqual('A', triangle.Row);
         Assert.AreEqual(12, triangle.Column);
      }

      [TestMethod]
      // F1 from coordinates
      public void CoordinatesRowColumnF1()
      {
         Triangle triangle = triangleService.GetTriangle(new Point(0, 50), new Point(0, 60), new Point(10, 60));

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual(new Point(0, 60), triangle.Vertex1);
         Assert.AreEqual(new Point(0, 50), triangle.Vertex2);
         Assert.AreEqual(new Point(10, 60), triangle.Vertex3);
         Assert.AreEqual('F', triangle.Row);
         Assert.AreEqual(1, triangle.Column);
      }

      [TestMethod]
      // F2 from coordinates
      public void CoordinatesRowColumnF2()
      {
         Triangle triangle = triangleService.GetTriangle(new Point(10, 50), new Point(0, 50), new Point(10, 60));

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual(new Point(10, 50), triangle.Vertex1);
         Assert.AreEqual(new Point(0, 50), triangle.Vertex2);
         Assert.AreEqual(new Point(10, 60), triangle.Vertex3);
         Assert.AreEqual('F', triangle.Row);
         Assert.AreEqual(2, triangle.Column);
      }


      [TestMethod]
      // F11 from coordinates
      public void CoordinatesRowColumnF11()
      {
         Triangle triangle = triangleService.GetTriangle(new Point(50, 50), new Point(50, 60), new Point(60, 60));

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual(new Point(50, 60), triangle.Vertex1);
         Assert.AreEqual(new Point(50, 50), triangle.Vertex2);
         Assert.AreEqual(new Point(60, 60), triangle.Vertex3);
         Assert.AreEqual('F', triangle.Row);
         Assert.AreEqual(11, triangle.Column);
      }

      [TestMethod]
      // F12 from coordinates
      public void CoordinatesRowColumnF12()
      {
         Triangle triangle = triangleService.GetTriangle(new Point(60, 60), new Point(50, 50), new Point(60, 50));

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual(new Point(60, 50), triangle.Vertex1);
         Assert.AreEqual(new Point(50, 50), triangle.Vertex2);
         Assert.AreEqual(new Point(60, 60), triangle.Vertex3);
         Assert.AreEqual('F', triangle.Row);
         Assert.AreEqual(12, triangle.Column);
      }

      [TestMethod]
      // C5 from coordinates
      public void CoordinatesRowColumnC5()
      {
         Triangle triangle = triangleService.GetTriangle(new Point(20, 20), new Point(30, 30), new Point(20, 30));

         Assert.AreNotEqual(null, triangle);
         Assert.AreEqual(new Point(20, 30), triangle.Vertex1);
         Assert.AreEqual(new Point(20, 20), triangle.Vertex2);
         Assert.AreEqual(new Point(30, 30), triangle.Vertex3);
         Assert.AreEqual('C', triangle.Row);
         Assert.AreEqual(5, triangle.Column);
      }

      [TestMethod]
      public void OrderVerticesA1_1()
      {
         // I want to test the private method orderVertices since it's a critical part
         // of my algorithm. The handlling of the ref args doesn't seem clean but works.
         PrivateObject privateObject = new PrivateObject(triangleService);

         Point vertex1 = new Point(0, 0);
         Point vertex2 = new Point(0, 10);
         Point vertex3 = new Point(10, 10);
         object[] invokeArgs = new object[] { vertex1, vertex2, vertex3 };
         var lowerLeftTriangle = privateObject.Invoke("OrderVertices", invokeArgs);
         vertex1 = (Point)invokeArgs[0];
         vertex2 = (Point)invokeArgs[1];
         vertex3 = (Point)invokeArgs[2];

         Assert.AreEqual(lowerLeftTriangle, true);
         Assert.AreEqual(new Point(0, 10), vertex1);
         Assert.AreEqual(new Point(0, 0), vertex2);
         Assert.AreEqual(new Point(10, 10), vertex3);
      }

      [TestMethod]
      public void OrderVerticesA1_2()
      {
         // I want to test the private method orderVertices since it's a critical part
         // of my algorithm. The handlling of the ref args doesn't seem clean but works.
         PrivateObject privateObject = new PrivateObject(triangleService);

         Point vertex1 = new Point(10, 10);
         Point vertex2 = new Point(0, 0);
         Point vertex3 = new Point(0, 10);
         object[] invokeArgs = new object[] { vertex1, vertex2, vertex3 };
         var lowerLeftTriangle = privateObject.Invoke("OrderVertices", invokeArgs);
         vertex1 = (Point)invokeArgs[0];
         vertex2 = (Point)invokeArgs[1];
         vertex3 = (Point)invokeArgs[2];

         Assert.AreEqual(lowerLeftTriangle, true);
         Assert.AreEqual(new Point(0, 10), vertex1);
         Assert.AreEqual(new Point(0, 0), vertex2);
         Assert.AreEqual(new Point(10, 10), vertex3);
      }

      [TestMethod]
      public void OrderVerticesA1_3()
      {
         // I want to test the private method orderVertices since it's a critical part
         // of my algorithm. The handlling of the ref args doesn't seem clean but works.
         PrivateObject privateObject = new PrivateObject(triangleService);

         Point vertex1 = new Point(0, 10);
         Point vertex2 = new Point(10, 10);
         Point vertex3 = new Point(0, 0);
         object[] invokeArgs = new object[] { vertex1, vertex2, vertex3 };
         var lowerLeftTriangle = privateObject.Invoke("OrderVertices", invokeArgs);
         vertex1 = (Point)invokeArgs[0];
         vertex2 = (Point)invokeArgs[1];
         vertex3 = (Point)invokeArgs[2];

         Assert.AreEqual(lowerLeftTriangle, true);
         Assert.AreEqual(new Point(0, 10), vertex1);
         Assert.AreEqual(new Point(0, 0), vertex2);
         Assert.AreEqual(new Point(10, 10), vertex3);
      }

      [TestMethod]
      public void OrderVerticesA2_1()
      {
         // I want to test the private method orderVertices since it's a critical part
         // of my algorithm. The handlling of the ref args doesn't seem clean but works.
         PrivateObject privateObject = new PrivateObject(triangleService);

         Point vertex1 = new Point(0, 0);
         Point vertex2 = new Point(10, 0);
         Point vertex3 = new Point(10, 10);
         object[] invokeArgs = new object[] { vertex1, vertex2, vertex3 };
         var lowerLeftTriangle = privateObject.Invoke("OrderVertices", invokeArgs);
         vertex1 = (Point)invokeArgs[0];
         vertex2 = (Point)invokeArgs[1];
         vertex3 = (Point)invokeArgs[2];

         Assert.AreEqual(lowerLeftTriangle, false);
         Assert.AreEqual(new Point(10, 0), vertex1);
         Assert.AreEqual(new Point(0, 0), vertex2);
         Assert.AreEqual(new Point(10, 10), vertex3);
      }

      [TestMethod]
      public void OrderVerticesA2_2()
      {
         // I want to test the private method orderVertices since it's a critical part
         // of my algorithm. The handlling of the ref args doesn't seem clean but works.
         PrivateObject privateObject = new PrivateObject(triangleService);

         Point vertex1 = new Point(10, 0);
         Point vertex2 = new Point(0, 0);
         Point vertex3 = new Point(10, 10);
         object[] invokeArgs = new object[] { vertex1, vertex2, vertex3 };
         var lowerLeftTriangle = privateObject.Invoke("OrderVertices", invokeArgs);
         vertex1 = (Point)invokeArgs[0];
         vertex2 = (Point)invokeArgs[1];
         vertex3 = (Point)invokeArgs[2];

         Assert.AreEqual(lowerLeftTriangle, false);
         Assert.AreEqual(new Point(10, 0), vertex1);
         Assert.AreEqual(new Point(0, 0), vertex2);
         Assert.AreEqual(new Point(10, 10), vertex3);
      }

      [TestMethod]
      public void OrderVerticesA2_3()
      {
         // I want to test the private method orderVertices since it's a critical part
         // of my algorithm. The handlling of the ref args doesn't seem clean but works.
         PrivateObject privateObject = new PrivateObject(triangleService);

         Point vertex1 = new Point(10, 10);
         Point vertex2 = new Point(10, 0);
         Point vertex3 = new Point(0, 0);
         object[] invokeArgs = new object[] { vertex1, vertex2, vertex3 };
         var lowerLeftTriangle = privateObject.Invoke("OrderVertices", invokeArgs);
         vertex1 = (Point)invokeArgs[0];
         vertex2 = (Point)invokeArgs[1];
         vertex3 = (Point)invokeArgs[2];

         Assert.AreEqual(lowerLeftTriangle, false);
         Assert.AreEqual(new Point(10, 0), vertex1);
         Assert.AreEqual(new Point(0, 0), vertex2);
         Assert.AreEqual(new Point(10, 10), vertex3);
      }
   }
}