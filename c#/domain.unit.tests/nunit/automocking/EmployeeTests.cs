// -----------------------------------------------------------------------
// <copyright file="EmployeeTests.cs">
// Copyright (c) 2013.
// </copyright>
// -----------------------------------------------------------------------
namespace domain.unit.tests.nunit.automocking
{
    using NUnit.Framework;

    using Rhino.Mocks;

    using domain.Model;
    using domain.Services;
    using domain.unit.tests.utils;

    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void when_an_employee_instance_is_saved_calls_the_employee_service()
        {
            var subject = AutoMockingExtentions.Subject<Employee>();

            subject.ClassUnderTest.Save();

            subject.Get<IService<Employee>>().AssertWasCalled(call => call.Save(subject.ClassUnderTest));
        }
    }
}