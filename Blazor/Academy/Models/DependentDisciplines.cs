using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	[PrimaryKey(nameof(discipline), nameof(dependent_discipline))]
	public class DependentDisciplines
	{
		[Column("discipline", TypeName = "smallint")]
		[ForeignKey(nameof(Discipline))]
		public short discipline {  get; set; }

		[Column("dependent_discipline", TypeName = "smallint")]
		[ForeignKey(nameof(DependentDiscipline))]
		public short dependent_discipline { get; set; }

		//Navigation properties:

		public Discipline Discipline { get; set; }
		public Discipline DependentDiscipline { get; set; }
	}
}
