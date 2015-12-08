using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using QuickGraph;
using QuickGraph.Algorithms;

namespace AlgoProject2
{
	public class Vertex
	{
		public Vertex()
		{
			name = " ";
		}

		public Vertex(string id)
		{
			name = id;
		}

		public string name;
	}

	[DebuggerDisplay("{Source}->{Target}")]
	public class Edge<TVertex> 
		: IEdge<TVertex>
	{
		private readonly TVertex source;
		private readonly TVertex target;
		public int weight;

		/// <summary>
		/// Initializes a new instance of the <see cref="Edge&lt;TVertex&gt;"/> class.
		/// </summary>
		/// <param name="source">The source.</param>
		/// <param name="target">The target.</param>
		public Edge(TVertex source, TVertex target,int weight)
		{
			Contract.Requires(source != null);
			Contract.Requires(target != null);
			Contract.Ensures(this.Source.Equals(source));
			Contract.Ensures(this.Target.Equals(target));

			this.source = source;
			this.target = target;
			this.weight = weight;
		}

		/// <summary>
		/// Gets the source vertex
		/// </summary>
		/// <value></value>
		public TVertex Source
		{
			get { return this.source; }
		}

		/// <summary>
		/// Gets the target vertex
		/// </summary>
		/// <value></value>
		public TVertex Target
		{
			get { return this.target; }
		}

		/// <summary>
		/// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
		/// </returns>
		public override string ToString()
		{
			return this.Source + "->" + this.Target;
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			var graph = new BidirectionalGraph<Vertex, Edge<Vertex>> (true);
			var v1 = new Vertex ("001");
			var v2 = new Vertex ("002");
			var e1 = new Edge<Vertex> (v1, v2, 3);

			graph.AddVerticesAndEdge (e1);


		}

		public static void shortestPathDistr()
		{
			
		}
	}
}
