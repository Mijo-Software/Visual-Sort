using System;

namespace Visual_Sort
{
	internal enum SortAlgorithmTypes
	{
		BubbleSort
	};

	internal class SortAlgorithms
	{
		public void Shuffle<T>(Random rng, T[]  array)
		{
			if (rng == null)
			{
				throw new ArgumentNullException(paramName: nameof(rng));
			}

			if (array == null)
			{
				throw new ArgumentNullException(paramName: nameof(array));
			}

			int n = array.Length;
			while (n > 1)
			{
				int k = rng.Next(n--);
				T temp = array[n];
				array[n] = array[k];
				array[k] = temp;
			}
		}
	}
}
