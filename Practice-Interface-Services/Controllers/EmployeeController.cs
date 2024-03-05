using System;
using Practice_Interface_Services.Helpers.Responses;
using Practice_Interface_Services.Models;
using Practice_Interface_Services.Services;
using Practice_Interface_Services.Services.Interfaces;

namespace Practice_Interface_Services.Controllers
{
	public class EmployeeController
	{
		private readonly EmployeeService _employeeService;

		public EmployeeController()
		{
			_employeeService = new();
        }

		public void GetAll()
		{
			var person = _employeeService.GetAll();
			foreach (var item in person)
			{
				Console.WriteLine($"Name:{item.Name} Surname:{item.Surname} Age:{item.Age} Email:{item.Email} Address:{item.Address} Birthday:{item.Birthday.ToString("MM/dd/yyyy")}");
			}
		}

		public void GetById()
		{
			Console.WriteLine("Enter Id");
			int.TryParse(Console.ReadLine(), out int a);
			if (true)
			{
				var result = _employeeService.GetById(_employeeService.GetAll(), a);
				if (result.ErrorMessage == null)
				{
                    Console.WriteLine($"Name:{result.Employee.Name} Surname:{result.Employee.Surname} Age:{result.Employee.Age} Email:{result.Employee.Email} Address:{result.Employee.Address} Birthday:{result.Employee.Birthday.ToString("MM/dd/yyyy")}");
                }
				else
				{
					Console.WriteLine(result.ErrorMessage);
				}
			}
		}

		public void SearchMethod()
		{
			Console.WriteLine("Search:");
			string text = Console.ReadLine();

		  var result =  _employeeService.SearchMethod(_employeeService.GetAll(), text);
			if (result.ErrorMessage == null)
			{
				foreach (var item in result.Employees)
				{
					Console.WriteLine($"Name:{item.Name} Surname:{item.Surname} Age:{item.Age} ");
				}
			}
			else
			{
				Console.WriteLine(result.ErrorMessage);
			}
		}
	}
}

