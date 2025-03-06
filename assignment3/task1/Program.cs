using System;
using System.Linq;
using System.Collections.Generic;

namespace Shape {
	class Shape {
		protected double[] Edges;	
		public Shape() { }
		public Shape(double[] Edges) {
			this.Edges = Edges;
		}
		public virtual double GetArea() {
			return 0.0;
		}
		public void init(double[] Edges) {
			this.Edges = Edges;
		}
	}

	class Triangle: Shape {
		public Triangle(double[] Edges): base(Edges) { }
		public override double GetArea() {
			if (Edges == null || Edges.Length != 3) {
				return -1;
			}
			// Need More Check To Ensure that the Triangle is legal
			double a = Edges[0], b = Edges[1], c = Edges[2];
			double s = (a + b + c) / 2;
			double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
			return area;
		}
	}

	class Rectangle: Shape {
		public Rectangle(double[] Edges): base(Edges) { }
		public override double GetArea() {
			if (Edges == null || Edges.Length != 2) {
				return -1;
			}
			double area = Edges[0] * Edges[1];
			return area;
		}
	}

	class Square: Rectangle {
		public Square(double[] Edges): base(Edges) { }
		public override double GetArea() {
			if (Edges == null || Edges.Length != 1) {
				return -1;
			}
			double area = Edges[0] * Edges[0];
			return area;
		}
	}

}

namespace Solver {
	using Shape;
	class Solver {
		static void Main(string[] args) {
			string type = Console.ReadLine();
			List<double> Edges = new List<double>();
			Edges = Console.ReadLine().Split().Select(double.Parse).ToList();
			Shape shape = null; // 无论如何必须初始化，否则后面调用报错
			switch (type) {
				case "Triangle":
					shape = new Triangle(Edges.ToArray());
					break;
				case "Rectangle":
					shape = new Rectangle(Edges.ToArray());
					break;
				case "Square":
					shape = new Square(Edges.ToArray());
					break;
				default:
					Console.WriteLine("Illegal Type!");
					break;
			}
			if (shape == null) {
				return;	
			}
			double area = shape.GetArea();
			Console.WriteLine($"Area = {area}");
		}
	}
}
