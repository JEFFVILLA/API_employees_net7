using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Dtos.Employeer;
using API.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Services.EmployeeService
{
    public class EmployeeServices : IEmployeeService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public EmployeeServices(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }


        public async Task<List<GetEmployeerDto>> CreateEmployee(Employeer newEmployeer)
        {
            var response = new ServiceResponse<List<GetEmployeerDto>>();
            // employeers.Add(_mapper.Map<Employeer>(newEmployeer));
            // response.Data = employeers.Select(x => _mapper.Map<GetEmployeerDto>(x)).ToList();
            return null;
        }

        public async Task<List<GetEmployeerDto>> GetAllEmployees(int userId)
        {
            var dbEmployees = await _context.Employeers.Where(c=> c.User!.Id == userId).ToListAsync();
            var employees = dbEmployees.Select(x => _mapper.Map<GetEmployeerDto>(x)).ToList();
            return employees;
        }

        public async Task<GetEmployeerDto> GetSingleEmployee(int id)
        {   
            var employeerDB = await _context.Employeers.FirstOrDefaultAsync(x => x.Id == id);
            var employee = _mapper.Map<GetEmployeerDto>(employeerDB);
            return employee;
            
        }

    }
}