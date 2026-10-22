using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
	public class Movie
	{
		public int Id {  get; set; }
		[Required(ErrorMessage = "Кино без названия, как самурай без меча")]
		[StringLength(50, MinimumLength = 2)]
		public string Title { get; set; }

		[Range(typeof(DateOnly), "1888-10-14", "2029-12-31")]
		[DisplayFormat(DataFormatString = "{0:yyyy.MM.dd}", ApplyFormatInEditMode = true)]//не работает в Blazor
		public DateOnly ReleaseDate { get; set; }

		public string URL { get; set; }
		public string Poster { get; set; }

	}
}
