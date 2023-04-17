using System;
using lab5.Proxy.Interfaces;

namespace lab5.Proxy.Classes
{
	public class SmartTextReader : ISmartTextReader
	{
		private string[,] arr = { };
		public string[,] Read(string path)
		{
			using (StreamReader sr = new StreamReader(path))
			{
				int i = 0;
				while (!sr.EndOfStream)
				{
					string? line = sr.ReadLine();
					if(line!=null){
						arr = (string[,])ResizeArray(arr, new int[] { i + 1, 1 });
						arr[i, 0] = line;
						i++;	
					}
				}
			}
			
			return arr;
		}

		private static Array ResizeArray(Array arr, int[] newSizes)
		{
			if (newSizes.Length != arr.Rank)
				throw new ArgumentException("arr must have the same number of dimensions " +
											"as there are elements in newSizes", "newSizes");

			var temp = Array.CreateInstance(arr.GetType().GetElementType(), newSizes);
			int length = arr.Length <= temp.Length ? arr.Length : temp.Length;
			Array.ConstrainedCopy(arr, 0, temp, 0, length);
			return temp;
		}
	}
}
