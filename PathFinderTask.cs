using System;
using System.Collections.Generic;
using System.Drawing;

namespace RoutePlanning
{
	public static class PathFinderTask
	{
		public static int[] FindBestCheckpointsOrder(Point[] checkpoints)
		{
			var bestOrder = FindPath(checkpoints, new int[checkpoints.Length], 0, 0);
			return bestOrder;
		}

		private static int[] FindPath(Point[] checkpoints, int[] path, double lengthPath, int startIndex)
		{
			return new int[] {};
		}
	}
}