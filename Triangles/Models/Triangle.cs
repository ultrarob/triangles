using System.Windows;

namespace Triangles.Models
{
    public class Triangle
    {
        public char Row { get; set; }
        public int Column { get; set; }
        public Point Vertex1 { get; set; }
        public Point Vertex2 { get; set; }
        public Point Vertex3 { get; set; }
    }
}