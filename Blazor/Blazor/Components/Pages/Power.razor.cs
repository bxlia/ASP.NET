using System.Numerics;

namespace Blazor.Components.Pages
{
	public partial class Power
	{
		int a;
		int e;
		BigInteger p = 1;
		void Calculate()
		{
			p = 1;
			for (int i = 1; i <= e; i++)
			{
				p *= a;
			}
		}
	}
}
