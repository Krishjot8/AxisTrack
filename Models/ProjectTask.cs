namespace AxisTrack.Models
{
    public class ProjectTask
    {
        public int Id { get; set; }
        
        public string Title { get; set; }  = string.Empty;

        public string? Description { get; set; }

        public string? Category { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? DueDate { get; set; }


        public TaskStatus Status { get; set; }



        public int ProjectId { get; set; }

        public Project Project { get; set; } = null!;



   
    }

    public enum TaskStatus
    {
        Pending,
        InProgress,
        Completed,
        Canceled


    }
}
