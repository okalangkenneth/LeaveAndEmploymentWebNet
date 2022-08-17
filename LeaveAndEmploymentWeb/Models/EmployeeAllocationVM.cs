using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveAndEmploymentWeb.Models
{
    public class EmployeeAllocationVM : EmployeeListVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }

    }
}
