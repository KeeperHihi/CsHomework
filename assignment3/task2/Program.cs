using System;
using System.Collections.Generic;
using Shapes;

// 存在的问题：
// 类型最好使用 enum 而不是字符串！
// shapes, Random 都应该放到 Factory 里面作为内部变量
// 应该区分按类型生成以及随机生成两种生产模式

namespace Task2 {
	class Factory {
		public static Shape Produce(string type, List<double> Edges) {
			if (Edges == null) {
				throw new InvalidOperationException("Edges is null");
			}
			// Other Validation Checker

			Shape shape = null;
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
			return shape;
		}
	}

	class Solver {
		static private string[] shapes = {"Triangle", "Rectangle", "Square"};
		static (string, List<double>) RandomShape() {
			Random random = new Random();
			string type = shapes[random.Next(0, 3)];
			int size;
			switch (type) {
				case "Triangle":
					size = 3;
					break;
				case "Rectangle":
					size = 2;
					break;
				case "Square":
					size = 1;
					break;
				default:
					size = 0;
					break;
			}
			List<double> Edges = new List<double>();
			for (int i = 0; i < size; i++) {
				Edges.Add(random.NextDouble() * 100);
			}
			Console.WriteLine($"{type}: {string.Join(" ", Edges)}");
			return (type, Edges);	
		}

		static double RandomArea() {
			var info = RandomShape();
			Shape shape = Factory.Produce(info.Item1, info.Item2);
			return shape.GetArea();
		}

		static void Main(string[] args) {
			double sumArea = 0;
			for (int i = 0; i < 10; i++) {
				double area = RandomArea();
				sumArea += area;
			}
			Console.WriteLine($"sumArea is {sumArea}");
		}
	}
}
