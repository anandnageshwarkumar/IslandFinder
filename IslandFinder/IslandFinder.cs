using System;
using System.Collections.Generic;

namespace IslandFinder
{
	public class IslandFinder
	{
		public int TotalIslandCount { get; set; }

		public int CurrentIsland { get; set; }

		public int TotalCurrentIslandCount { get; set; }

		public List<string> CurrentIslandLocations { get; set; }

		public List<List<int>> Matrix { get; set; }

		public const int BareMinimunCountForIsland = 4;

		public void LoadMatrix(List<List<int>> matrix)
		{
			Matrix = matrix;
			TotalIslandCount = 0;
			CurrentIsland = 0;
			TotalCurrentIslandCount = 0;
		}

		public void FindAllIslands()
		{
			int r = Matrix.Count;
			int c = Matrix[0].Count;

			for (int i = 0; i < r; i++)
			{
				for (int j = 0; j < c; j++)
				{
					TotalCurrentIslandCount = 0;
					CurrentIsland = Matrix[i][j];
					CurrentIslandLocations = new List<string>();
					if (CurrentIsland != 0 && CurrentIsland != -1)
						CheckIslandCount(i, j);

					if (TotalCurrentIslandCount >= BareMinimunCountForIsland)
					{
						TotalIslandCount++;
						Console.Write("Island {0} size {1} formed by : {2} location : ", TotalIslandCount, TotalCurrentIslandCount, CurrentIsland);
						foreach (var pos in CurrentIslandLocations)
						{
							Console.Write("[" + pos + "] ");
						}
						Console.WriteLine();
					}
				}
			}

			Console.WriteLine("Number of Islands : {0}", TotalIslandCount);
		}

		private int CheckIslandCount(int x, int y)
		{
			if (x < 0 ||
				y < 0 ||
				x > Matrix.Count - 1 ||
				y > Matrix[0].Count - 1 ||
				Matrix[x][y] == -1)
				return 0;

			if (Matrix[x][y] == CurrentIsland || Matrix[x][y] == 0)
			{
				if (CheckAlreadyVerifiedPostion(x, y))
				{
					TotalCurrentIslandCount++;
					CurrentIslandLocations.Add(x.ToString() + " " + y.ToString());
				}

				if (Matrix[x][y] != 0)
					Matrix[x][y] = -1;
			}
			else
			{
				return TotalCurrentIslandCount;
			}

			if (x + 1 <= Matrix.Count - 1 && Matrix[x + 1][y] != -1 && CheckAlreadyVerifiedPostion(x + 1, y))
			{
				CheckIslandCount(x + 1, y);
			}

			if (x - 1 >= 0 && Matrix[x - 1][y] != -1 && CheckAlreadyVerifiedPostion(x - 1, y))
			{
				CheckIslandCount(x - 1, y);
			}

			if (y + 1 <= Matrix[0].Count - 1 && Matrix[x][y + 1] != -1 && CheckAlreadyVerifiedPostion(x, y + 1))
			{
				CheckIslandCount(x, y + 1);
			}

			if (y - 1 >= 0 && Matrix[x][y - 1] != -1 && CheckAlreadyVerifiedPostion(x, y - 1))
			{
				CheckIslandCount(x, y - 1);
			}

			return TotalCurrentIslandCount;
		}

		private bool CheckAlreadyVerifiedPostion(int x, int y)
		{
			return !CurrentIslandLocations.Contains(x.ToString() + " " + y.ToString());
		}
	}
}