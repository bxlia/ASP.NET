using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Academy.Models
{
	public class Lesson
	{
		[Key]
		public long lesson_id { get; set; }

		[Required]
		[ForeignKey(nameof(Group))]
		public int group {  get; set; }

		[Required]
		[Column(TypeName = "smallint")]
		[ForeignKey(nameof(Discipline))]
		public short discipline { get; set; }

		[Required]
		[Column(TypeName = "smallint")]
		[ForeignKey(nameof(Teacher))]
		public short teacher { get; set; }

		[Required]
		public DateOnly date { get; set; }

		[Required]
		public TimeOnly time { get; set; }

		public bool spent { get; set; }

		//Navigation properties
		[JsonIgnore]
		public Group Group { get; set; }
		[JsonIgnore]
		public Discipline Discipline { get; set; }
		[JsonIgnore]
		public Teacher Teacher { get; set; }
	}
}
