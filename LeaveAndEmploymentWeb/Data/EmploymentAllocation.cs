using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveAndEmploymentWeb.Data
{
    public class EmploymentAllocation :BaseEntity
    {
        

        [ForeignKey("EmploymentTypeId")]
        public EmploymentType EmploymentType { get; set; }
        public int EmploymentTypeId { get; set; }

        public string EmployeeId { get; set; }

        
    }
}
