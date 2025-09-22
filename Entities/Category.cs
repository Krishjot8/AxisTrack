namespace AxisTrack.Models
{
    public class Category               // Categories for Project tasks such as Permits Foundation Framing and Electrical
    {

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;


        public ICollection<ProjectTask> Tasks { get; set; } = new List<ProjectTask>();
    }
}
