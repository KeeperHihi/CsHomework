using System;
using System.Linq;
using System.Collections.Generic;

namespace ListTask {

	public class Node<T> {
		public Node<T> Next { get; set; }
		public T Data { get; set; }

		public Node(T t) {
			Next = null;
			Data = t;
		}
	}

	public class List<T> {
		private Node<T> head;
		private Node<T> tail;
		
		public List() {
			head = tail = null;
		}

		public Node<T> Head {
			get => head;
		}
		public void Add(T t) {
			Node<T> newNode = new Node<T>(t);
			if (tail == null) {
				head = tail = newNode;
			} else {
				tail.Next = newNode;
				tail = newNode;
			}
		}
		public void ForEach(Action<T> action) {
			Node<T> p = head;
			while (p != null) {
				action(p.Data);
				p = p.Next;
			}
		}
	}

	public class Program {
		private const int INF = 1000000000;
		static void Main(string[] s) {
			List<int> list = new List<int>();
			var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
			Array.ForEach(inputs, x => list.Add(x)); 
			int max = -INF;
			int min = INF;
			int sum = 0;
			list.ForEach(x => max = Math.Max(max, x));
			list.ForEach(x => min = Math.Min(min, x));
			list.ForEach(x => sum += x);
			Console.WriteLine($"max = {max}");
			Console.WriteLine($"min = {min}");
			Console.WriteLine($"sum = {sum}");
		}
	}
}
