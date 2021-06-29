﻿using CodeTheWay.Web.Ui.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Repositories
{
    public class StudentsRepository : IStudentsRepository
    {
        private AppDbContext AppDbContext;

        public StudentsRepository(AppDbContext dbContext) 
        {
            this.AppDbContext = dbContext;
        }

        public async Task<Student> Create(Student student)
        {
            var result = await this.AppDbContext.AddAsync(student);
            await this.AppDbContext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<List<Student>> GetStudents()
        {
            return await this.AppDbContext.Students.ToListAsync();
        }
    }
}
