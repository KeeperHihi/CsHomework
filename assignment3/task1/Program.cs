using System;
using System.Linq;
using System.Collections.Generic;
using Shapes;

namespace Task1 {
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
