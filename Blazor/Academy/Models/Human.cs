using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Human
	{
		[Required]
		[StringLength(50)]
		[DisplayName("Фамилия")]
		[RegularExpression(@"^[A-ZA-Я]+[a-za-я]*$")]
		public string last_name {  get; set; }

		[Required]
		[StringLength(50)]
		[DisplayName("Имя")]
		[RegularExpression(@"^[A-ZA-Я]+[a-za-я]*$")]
		public string first_name {  get; set; }

		[Required]
		[StringLength(50)]
		[DisplayName("Отчество")]
		[RegularExpression(@"^[A-ZA-Я]+[a-za-я]*$")]
		public string? middle_name {  get; set; }

		[Required]
		[Display(Name = "Дата рождения")]
		[Range(typeof(DateOnly), "1950-01-01", "2032-12-31")]
		public DateOnly birth_date {  get; set; }

		public string? email {  get; set; }
		public string? phone {  get; set; }
		public byte[]? photo {  get; set; }
	}
}
