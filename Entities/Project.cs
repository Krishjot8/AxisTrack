using System.Collections;

namespace AxisTrack.Models
{
    public class Project
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Client {  get; set; }


        public string? Location { get; set; }


        public DateTime? StartDate { get; set; }


        public DateTime? EndDate { get; set; } 

        public ICollection<ProjectTask> Tasks { get; set; } = new List<ProjectTask>();
    }
}
