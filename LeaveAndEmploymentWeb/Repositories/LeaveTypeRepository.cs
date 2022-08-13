using LeaveAndEmploymentWeb.Contracts;
using LeaveAndEmploymentWeb.Data;

namespace LeaveAndEmploymentWeb.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
