using ShowRoomManagmentAPI.DTOs;

namespace ShowRoomManagmentAPI.Repositories
{
    public interface IDepartment
    {
        public Task<ResponseDTO> GetDepartments();

        public Task<ResponseDTO> AddDepartment(DepartmentDTO departmentDTO);
        public Task<ResponseDTO> DeleteDepartment(int Id);


    }
}
