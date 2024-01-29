using Microsoft.EntityFrameworkCore;
using ShowRoomManagmentAPI.Data;
using ShowRoomManagmentAPI.DTOs;
using ShowRoomManagmentAPI.Repositories;

namespace ShowRoomManagmentAPI.Models
{
    public class DepartmentModel : IDepartment
    {
        private readonly ApplicationDbContext db_Context;


        public DepartmentModel(ApplicationDbContext dbContext)
        {
            this.db_Context = dbContext; 
             
        }

        public object db_context { get; private set; }

        public async Task<ResponseDTO> AddDepartment(DepartmentDTO departmentDTO)
        {
            var response = new ResponseDTO();

            try
            {
                var department = new Department() {
                    Name = departmentDTO.Name,
               Description = departmentDTO.Description
                };
               await db_Context.Departments.AddAsync(department);
                await db_Context.SaveChangesAsync();
                response.Response = "Department Created succfully";

            }
            catch(Exception ex)
            {
                response.ErrorMassage = ex.Message;
            }

            return response;
        }

        public async Task<ResponseDTO> DeleteDepartment(int Id)
        {
            var response = new ResponseDTO();

            try
            {
                var data = await db_Context.Departments.Where(x => x.Id == Id).FirstOrDefaultAsync();
                if(data != null)
                {
                    db_Context.Departments.Remove(data);
                    await db_Context.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                response.ErrorMassage = ex.Message;

            }
            return response;
      
        }

        public async Task<ResponseDTO> GetDepartments()
        {
            var response = new ResponseDTO();

            try{

                 response.Response = await db_Context.Departments.ToListAsync();


            }
            catch(Exception Ex)
            {
                response.ErrorMassage = Ex.Message;

            }

            return response;
        }







    }
}
