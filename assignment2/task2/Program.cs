using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2 {
	class Program {
		static void BetterMethod(int[] a, out int max, out int min, out double ave, out int sum) {
			max = int.MinValue;
			min = int.MaxValue;
			ave = 0;
			sum = 0;
			foreach (int x in a) {
				max = Math.Max(max, x);
				min = Math.Min(min, x);
				sum += x;
			}
			ave = sum / a.Length;
		}
		static Dictionary<string, double> FindParam(int[] a) {
			Dictionary<string, double> param = new Dictionary<string, double>();
			param.Add("max", int.MinValue);
			param.Add("min", int.MaxValue);
			param.Add("sum", 0);
			param.Add("ave", 0);
			foreach (int x in a) {
				param["max"] = Math.Max(param["max"], x);
				param["min"] = Math.Min(param["min"], x);
				param["sum"] += x;
			}
			param["ave"] = param["sum"] / a.Length;
			return param;
		}
		static void Main (string[] args) {
			int n;
			bool res = int.TryParse(Console.ReadLine(), out n);
			if (res == false) {
				Console.WriteLine("Error Input");
				return;
			}
			int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
			//var param = FindParam(a);
			int max, min, sum;
			double ave;
			BetterMethod(a, out max, out min, out ave, out sum);
			Console.WriteLine($"max = {max}");
			Console.WriteLine($"min = {min}");
			Console.WriteLine($"ave = {ave}");
			Console.WriteLine($"sum = {sum}");
		}
	}
}
