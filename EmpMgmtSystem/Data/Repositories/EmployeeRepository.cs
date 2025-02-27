﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EmpMgmtSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpMgmtSystem.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAllAsync() => await _context.Employees.ToListAsync();
        public async Task<Employee> GetByIdAsync(int id) => await _context.Employees.FindAsync(id);
        public async Task AddAsync(Employee employee) { await _context.Employees.AddAsync(employee); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Employee employee) { _context.Employees.Update(employee); await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var emp = await _context.Employees.FindAsync(id); if (emp != null) _context.Employees.Remove(emp); await _context.SaveChangesAsync(); }
    }
}
