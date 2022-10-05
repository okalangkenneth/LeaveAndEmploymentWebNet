using System.ComponentModel.DataAnnotations;

namespace LeaveAndEmploymentWeb.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Display(Name= "Number Of Days")]
        [Required]
        [Range(1,50, ErrorMessage = "Invalid Number Entered")]
        public int NumberOfdays { get; set; }
        [Required]
        [Display(Name = "Allocation Period")]
        public int Period { get; set; }
        public LeaveTypeVM  LeaveType { get; set; }

    }
}