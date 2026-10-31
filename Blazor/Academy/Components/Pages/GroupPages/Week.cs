namespace Academy.Components.Pages.GroupPages
{
	public class Week
	{
		public static readonly string[] DAYNAMES = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

		private readonly int days;

		public Week(int days)
		{
			this.days = days;
		}

		public bool HasDay(int dayIndex) =>
			dayIndex >= 0 && dayIndex < DAYNAMES.Length && (days & (1 << dayIndex)) != 0;

		public override string ToString()
		{
			List<string> result = new List<string>();
			for (int i = 0; i < DAYNAMES.Length; i++)
			{
				if (HasDay(i))
				{
					result.Add(DAYNAMES[i]);
				}
			}
			return result.Count == 0 ? "—" : string.Join(", ", result);
		}
	}
}
