namespace CleanCode.DAL.Data.Models
{
    public class Department
    {

        public int id { get; set; }
        public string name { get; set; }
        public string loc { get; set; }

        //    [JsonIgnore]
        public virtual List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
