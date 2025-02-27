using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1 {
	class Program {
		static double Calculate(double num1, string op, double num2) {
			double result = 0;
			switch (op) {
				case "+":
					result = num1 + num2;
					break;
				case "-":
					result = num1 - num2;
					break;
				case "*":
					result = num1 * num2;
					break;
				case "/":
					result = num1 / num2;
					break;
			}
			return result;
		}
		static void Main(string[] args) {
			double num1, num2;
			var inputList = Console.ReadLine().Split().ToArray();
			string op = inputList[1];
			bool isNum1 = double.TryParse(inputList[0], out num1);
			bool isOp = op == "+" || op == "-" || op == "*" || op == "/";
			bool isNum2 = double.TryParse(inputList[2], out num2);
			if (!isNum1 || !isOp || !isNum2 || op == "/" && num2 == 0) {
				Console.WriteLine("Invalid Input");
				return;
			}
			double result = Calculate(num1, op, num2);
			Console.WriteLine($"Result is {result}");
		}
	}
}
