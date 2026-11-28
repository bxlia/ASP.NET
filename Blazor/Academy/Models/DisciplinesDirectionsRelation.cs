using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	[PrimaryKey(nameof(direction), nameof(discipline))]
	public class DisciplinesDirectionsRelation
	{
		[Column("direction", TypeName = "tinyint")]
		[ForeignKey(nameof(Direction))]
		public int direction { get; set; }

		[Column("discipline", TypeName = "smallint")]
		[ForeignKey(nameof(Discipline))]
		public int discipline { get; set; }

		//Navigation properties:
		public Direction Direction { get; set; }
		public Discipline Discipline { get; set; }
	}
}
