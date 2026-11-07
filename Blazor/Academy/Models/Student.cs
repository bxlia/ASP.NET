using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Academy.Models
{
	public class Student:Human
	{
		[Key]
		public int stud_id { get; set; }

		[ForeignKey(nameof(Group))]
		public int group {  get; set; }	

		//Navigation properties
		[JsonIgnore]
		public Group Group { get; set; }
	}
}
