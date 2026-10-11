using System.Numerics;

namespace Blazor.Components.Pages
{
	public partial class Transfer
	{
		int n;
		string bin = "";
		string hex = "";

		void Calculate()
		{
			bin = ToBase(n, 2);
			hex = ToBase(n, 16);
		}

		string ToBase(int a, int b)
		{
			string digits = "0123456789ABCDEF";
			string result = "";

			while (a > 0)
			{
				result = digits[a % b] + result;
				a /= b;
			}
			return result == "" ? "0" : result; ;
		}
	}
}
