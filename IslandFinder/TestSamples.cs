using System.Collections.Generic;

namespace IslandFinder
{
	public static class TestSamples
	{
		public static List<List<int>> SampleTest1()
		{
			List<List<int>> matrix = new List<List<int>>()
			{
				new List<int>(){3,1,1,7,7,9,3,1},
				new List<int>(){4,1,1,7,8,6,1,9},
				new List<int>(){1,7,3,5,6,1,8,9},
				new List<int>(){1,4,7,5,1,5,6,8},
				new List<int>(){1,8,8,1,6,6,3,4},
				new List<int>(){1,2,7,7,2,2,2,3},
				new List<int>(){2,6,5,3,3,0,2,7},
				new List<int>(){1,2,3,4,4,4,8,9}
			};

			return matrix;
		}

		public static List<List<int>> SampleTest2()
		{
			List<List<int>> matrix = new List<List<int>>()
			{
				new List<int>(){1,1,1,2,2},
				new List<int>(){8,8,3,4,8},
				new List<int>(){1,8,3,0,6},
				new List<int>(){1,8,3,1,1},
				new List<int>(){1,8,8,3,6}
			};

			return matrix;
		}

		public static List<List<int>> SampleTest3()
		{
			List<List<int>> matrix = new List<List<int>>()
			{
				new List<int>(){1,2,2,5,6,7},
				new List<int>(){1,0,2,8,7,5},
				new List<int>(){1,3,3,4,3,2},
				new List<int>(){5,8,3,4,3,2},
			};

			return matrix;
		}

		public static List<List<int>> SampleTest4()
		{
			List<List<int>> matrix = new List<List<int>>()
			{
				new List<int>(){4,1,1,3},
				new List<int>(){1,4,3,1},
				new List<int>(){1,3,4,1},
				new List<int>(){3,1,1,4},
			};

			return matrix;
		}

		public static List<List<int>> SampleTest5()
		{
			List<List<int>> matrix = new List<List<int>>()
			{
				new List<int>(){1,1},
				new List<int>(){0,0}
			};

			return matrix;
		}

		public static List<List<int>> SampleTest6()
		{
			List<List<int>> matrix = new List<List<int>>()
			{
				new List<int>(){9,2,9,5},
				new List<int>(){7,6,0,7},
				new List<int>(){9,0,8,0},
				new List<int>(){4,5,0,9},
			};

			return matrix;
		}
	}
}