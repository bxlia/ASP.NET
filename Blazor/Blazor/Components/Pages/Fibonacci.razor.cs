using System.Numerics;

namespace Blazor.Components.Pages
{
	public partial class Fibonacci
	{
		int k;
		BigInteger fb = 0;
		void Calculate()
		{
			BigInteger x = 0, y = 1, z = 0;
			for (int i = 1; i < k; i++)
			{
				z = x + y;
				x = y;
				y = z;
			}
			fb = x;
		}


	}
}