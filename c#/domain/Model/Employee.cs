// -----------------------------------------------------------------------
// <copyright file="Employee.cs">
// Copyright (c) 2013.
// </copyright>
// -----------------------------------------------------------------------
namespace domain.Model
{
    using domain.Services;

    public class Employee
    {
        private readonly IService<Employee> service;

        public Employee(IService<Employee> service)
        {
            this.service = service;
        }

        public void Save()
        {
            this.service.Save(this);
        }
    }
}