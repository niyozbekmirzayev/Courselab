﻿using Courselab.Data.DbContexts;
using Courselab.Data.IRepositories;
using Courselab.Data.Repositories;
using EduCenterWebAPI.Data.IRepositories;
using System;
using System.Threading.Tasks;

namespace EduCenterWebAPI.Data.Respositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CourselabDbContext context;

        public ICourseRepository Courses { get; private set; }

        public IUserRepository Users { get; private set; }

        public IRegistrationRepository Registrations { get; private set; }

        public UnitOfWork(CourselabDbContext context)
        {
            this.context = context;
            Courses = new CourseRepository(context);
            Users = new UserRepository(context);
            Registrations = new RegistrationRepository(context);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
