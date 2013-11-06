// -----------------------------------------------------------------------
// <copyright file="EmployeeTests.cs">
// Copyright (c) 2013.
// </copyright>
// -----------------------------------------------------------------------
namespace domain.unit.tests.nunit
{
    using NUnit.Framework;

    using Rhino.Mocks;

    using domain.Model;
    using domain.Services;

    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void when_an_employee_instance_is_saved_calls_the_employee_service()
        {
            var service = MockRepository.GenerateMock<IService<Employee>>();            
            var subject = new Employee(service);

            subject.Save();

            service.AssertWasCalled(call => call.Save(subject));
        }
    }
}