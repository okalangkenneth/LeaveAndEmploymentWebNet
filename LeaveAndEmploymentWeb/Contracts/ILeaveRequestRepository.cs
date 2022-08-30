using LeaveAndEmploymentWeb.Data;
using LeaveAndEmploymentWeb.Models;

namespace LeaveAndEmploymentWeb.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);

        Task <EmployeeLeaveRequestViewVM>GetMyLeaveDetails();

        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);

        Task<List<LeaveRequestVM>> GetAllAsync(string employeeId);

        Task<AdminRequestLeaveViewVM> GetAdminRequestLeaveList();

        Task ChangeApprovalStatus(int leaveRequestId,bool approved);

        Task CancelLeaveRequest(int leaveRequestId);
    }
}
