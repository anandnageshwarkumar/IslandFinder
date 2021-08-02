using System;

namespace IslandFinder
{
	public class Program
	{
		public static void Main()
		{
			/*
			 * 1. IslandFinder class has methods FindAllIslands() to get the total islands in a matrix
			   2. CheckIslandCount method is internally called
			   3. Algorithm performs a recursive call horizontally and vertically to check if there are
			   adjacent same elements present also considering zero
			   4. The positions that already verified for a particular island is marked -1
			   in order to avoid duplicate count {Except position zero}
			   
			   TotalIslandCount  -> Total islands in a matrix
			   CurrentIsland -> current island value being checked
			   TotalCurrentIslandCount -> thw total count for CurrentIsland
			   CurrentIslandLocations -> List that stores locations of CurrentIsland
			   BareMinimunCountForIsland -> Limit to qualify is that is a island

			 */
			var islandfinder = new IslandFinder();

			islandfinder.LoadMatrix(TestSamples.SampleTest1());
			islandfinder.FindAllIslands();
			Console.WriteLine();

			islandfinder.LoadMatrix(TestSamples.SampleTest2());
			islandfinder.FindAllIslands();
			Console.WriteLine();

			islandfinder.LoadMatrix(TestSamples.SampleTest3());
			islandfinder.FindAllIslands();
			Console.WriteLine();

			islandfinder.LoadMatrix(TestSamples.SampleTest4());
			islandfinder.FindAllIslands();
			Console.WriteLine();

			islandfinder.LoadMatrix(TestSamples.SampleTest5());
			islandfinder.FindAllIslands();
			Console.WriteLine();

			islandfinder.LoadMatrix(TestSamples.SampleTest6());
			islandfinder.FindAllIslands();
			Console.WriteLine();

			Console.ReadKey();
		}
	}
}