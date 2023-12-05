using System.ComponentModel.DataAnnotations.Schema;

namespace Human_Resources_Management_System.Models
{
    [Table("Project")]
    public class Project
    {
        public int Id { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectStartDate { get; set; }
        public string ProjectEndDate { get; set; }
        public string Details { get; set; }
        public string Summary { get; set; }
        public string Status { get; set; }
    }
}
