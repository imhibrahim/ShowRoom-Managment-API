using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowRoomManagmentAPI.DTOs;
using ShowRoomManagmentAPI.Repositories;

namespace ShowRoomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {

        private readonly IDepartment Service;
     

        public DepartmentController(IDepartment _service)
        {
            this.Service = _service;
        }



        [HttpGet("GetDepartments")]
        public async Task<string> GetDepartments()
        {
            var data = await Service.GetDepartments();
           var convertedData = JsonConvert.SerializeObject(data);
            return convertedData;
     
        
        
        }
        [HttpGet("AddDepartment")]
        public async Task<string> AddDepartment(DepartmentDTO departmentDTO)
        {
            return JsonConvert.SerializeObject(await Service.AddDepartment(departmentDTO));
        }
        [HttpGet("DeleteDepartment")]
        public async Task<string> DeleteDepartment(int id)
        {
            return JsonConvert.SerializeObject(await Service.DeleteDepartment(id));
        }
    }
}
