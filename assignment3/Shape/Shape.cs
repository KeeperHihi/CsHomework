using System;
using System.Linq;
using System.Collections.Generic;

namespace Shapes;

public class Shape {
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

public class Triangle: Shape {
	public Triangle(double[] Edges): base(Edges) { }
	public override double GetArea() {
		if (Edges == null || Edges.Length != 3) {
			return -1;
		}
		// Need More Check To Ensure that the Triangle is legal
		double a = Edges[0], b = Edges[1], c = Edges[2];
		if (a + b <= c || a + c <= b || b + c <= a) return 0.0;
		double s = (a + b + c) / 2;
		double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
		return area;
	}
}

public class Rectangle: Shape {
	public Rectangle(double[] Edges): base(Edges) { }
	public override double GetArea() {
		if (Edges == null || Edges.Length != 2) {
			return -1;
		}
		double area = Edges[0] * Edges[1];
		return area;
	}
}

public class Square: Rectangle {
	public Square(double[] Edges): base(Edges) { }
	public override double GetArea() {
		if (Edges == null || Edges.Length != 1) {
			return -1;
		}
		double area = Edges[0] * Edges[0];
		return area;
	}
}

