using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.Employeer;
using API.Models;

namespace API.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<List<GetEmployeerDto>> GetAllEmployees(int userId);

        Task<GetEmployeerDto> GetSingleEmployee(int id);

        Task<List<GetEmployeerDto>> CreateEmployee(Employeer newEmployeer);
    }
}