using EmployeeManagementSystem.service;
using EmployeeManagementSystem.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestCreateEmployee()
		{
			EmployeeActions action = new EmployeeActions();
			Employee mockEmployee = getMockEmployee();
			int id = action.createEmployee(mockEmployee);
			Employee employeeCreated = action.loadEmployee(id);
			Console.WriteLine(employeeCreated.toString());
			Assert.AreEqual(mockEmployee.email, employeeCreated.email);

		}

		[TestMethod]
		public void TestDeleteEmployee()
		{
			EmployeeActions action = new EmployeeActions();
			Employee mockEmployee = getMockEmployee();
			int id = action.createEmployee(mockEmployee);
			action.deleteEmployee(id);
			Employee employeeCreated = action.loadEmployee(id);
			Assert.AreEqual(employeeCreated.id, 0);

		}

		[TestMethod]
		public void TestUpdateEmployee()
		{
			EmployeeActions action = new EmployeeActions();
			Employee mockEmployee = getMockEmployee();
			int id = action.createEmployee(mockEmployee);
			Employee updatedEmployee = mockEmployee;
			updatedEmployee.name = "test_user_2";
			updatedEmployee.id = id;
			action.updateEmployee(updatedEmployee);
			Employee employeeCreated = action.loadEmployee(id);
			Assert.AreEqual( "test_user_2", employeeCreated.name);

		}

		Employee getMockEmployee() {
			Employee emp = new Employee();
			emp.status = "active";
			emp.gender = "male";
			var random = new Random();
			int randomnumber = random.Next();
			emp.email = "test+"+randomnumber+"@b.com";
			emp.name = "test user";
			return emp;

		}


	}
}
