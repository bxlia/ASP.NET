using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	[PrimaryKey(nameof(teacher), nameof(discipline))]
	public class TeachersDisciplinesRelation
	{
		[Column("teacher", TypeName = "smallint")]
		[ForeignKey(nameof(Teacher))]
		public short teacher {  get; set; }

		[Column("discipline", TypeName = "smallint")]
		[ForeignKey(nameof(Discipline))]
		public short discipline { get; set; }

		//Navigation properties:

		public Teacher Teacher { get; set; }
		public Discipline Discipline { get; set; }
	}
}
