using System.Numerics;

namespace Blazor.Components.Pages
{
	public partial class Factorial
	{
		int n;
		//int a;
		//int e;
		//int k;
		BigInteger f = 1;
		//BigInteger p = 1;
		//BigInteger fb = 1;
		void Calculate()
		{
			f = 1;
			for (int i = 1; i <= n; i++)
			{
				f *= i;
			}

			//p = 1;
			//for (int i = 1; i <= e; i++)
			//{
			//	p *= a;
			//}

			//BigInteger x = 0, y = 1, z = 0;
			//for (int i = 1; i < k; i++)
			//{
			//	z = x + y;
			//	x = y;
			//	y = z;
			//}
			//fb = x;
		}
	}
}
