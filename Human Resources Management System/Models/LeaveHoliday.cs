using System.ComponentModel.DataAnnotations.Schema;

namespace Human_Resources_Management_System.Models
{
    [Table("LeaveHoliday")]
    public class LeaveHoliday
    {
        public int Id { get; set; }
        public string HolidayName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Days {  get; set; }
        public string Year {  get; set; }
    }
}
