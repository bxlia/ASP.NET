using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Academy.Models
{
	public class Teacher : Human
	{
		[Key]
		[Column(TypeName = "smallint")]
		public short teacher_id { get; set; }

		[Required]
		public DateOnly work_since { get; set; }

		[Column(TypeName = "smallmoney")]
		public decimal rate { get; set; }

		//Calculated properties:
		public int experience 
		{
			get => (int)((DateTime.Now.Date - work_since.ToDateTime(new TimeOnly(0)).Date).Days/365.25);
		}
	}
}
