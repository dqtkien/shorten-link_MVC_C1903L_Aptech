﻿using AutoMapper;
using Entities.DTO;
using Entities.Model;
using Entities.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ShortenLinkApi.Controllers
{
    [ApiController]
    [Route("api/employee")]

    public class EmployeeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{empId}", Name = "GetEmpById")]
        public IActionResult GetEmpById(Guid empId)
        {
            var empFromRepo = _employeeRepository.GetEmployeeById(empId);
            if (empFromRepo == null)
                return NotFound();

            return Ok(_mapper.Map<EmployeeDTO>(empFromRepo));
        }

        [HttpPost]
        public ActionResult<EmployeeDTO> CreateEmployee([FromBody] EmployeeCreatingDTO emp)
        {
            var empEntity = _mapper.Map<EmployeeModel>(emp);
            empEntity.Password = new PasswordHasher<object>().HashPassword(null, emp.Password);
            _employeeRepository.AddEmployee(Guid.Empty, empEntity);
            _employeeRepository.Save();

            var empToResponse = _mapper.Map<EmployeeDTO>(empEntity);
            return CreatedAtRoute("GetEmpById", new { empId = empToResponse.Id }, empToResponse);
        }
    }
}
