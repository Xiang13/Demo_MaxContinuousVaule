using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MaxContinuousVaule
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 陣列裡只會有0, 3, 找出連續 3 的總和
			int[] list = new int[] { 0, 3, 3, 0, 0, 3, 3, 3 };
			int[] list1 = new int[] { 0, 3, 3, 0, 0, 3, 0, 3 ,0, 3 };
			int[] list2 = new int[] { 0, 3, 0, 0 };

			int maxSum = 0; // 紀錄目前最大總和的值
			int sum = 0;  // 紀錄連續總和的值

			for (int i = 0; i < list.Length; i++)
			{
				int item = list[i];  // 找出目前項目的值
				if (item == 0)  // 如果目前的值等於0, 則繼續執行這個迴圈
				{
					sum = 0;  
					continue;
				}
				sum += item;  // 加目前項目的值

				if (sum > maxSum)  // 如果 sum 小於 maxSum 代表目前項目的值不連續
				{
					maxSum = sum;
				}
			}
			Console.WriteLine(maxSum);
		}
	}
}
