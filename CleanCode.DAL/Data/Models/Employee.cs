using CleanCode.DAL.Validators;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanCode.DAL.Data.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        //[JsonIgnore]
        public string address { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal salary { get; set; }
        [DateInPast]
        [Column(TypeName ="date")]
        public DateTime DOB { get; set; }

        [ForeignKey("dept")]
        public int did { get; set; }

        public virtual Department dept { get; set; }
    }
}
