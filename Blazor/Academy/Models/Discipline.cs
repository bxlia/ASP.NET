using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Discipline
	{
		[Key]
		[Column(TypeName = "smallint")]
		public short discipline_id { get; set; }

		[Required]
		public string discipline_name { get; set; }

		[Required]
		[Column("number_of_lessons")]
		public byte number_of_lessons { get; set; }

		//Navigation properties:
		public ObservableCollection<TeachersDisciplinesRelation> TDR { get; } = new ObservableCollection<TeachersDisciplinesRelation>();

		[InverseProperty("Discipline")]
		public ObservableCollection<DependentDisciplines> DependentDisciplines { get; } = new ObservableCollection<DependentDisciplines>();
	}
}
