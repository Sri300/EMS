using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using EmployeeManagementSystem.model;

namespace EmployeeManagementSystem.service
{
    public class EmployeeActions
    {

        private const string RESOURCE_NAME = "users/";

        public EmployeeList getEmployees()
        {
            var url = Properties.Settings.Default.GoRestUrl + RESOURCE_NAME + Properties.Settings.Default.Path;
            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.Get<EmployeeList>(request);

            return response.Data;
        }

        public EmployeeList getEmployees(int page, string searchTerm)
        {
            var url = Properties.Settings.Default.GoRestUrl + RESOURCE_NAME + Properties.Settings.Default.Path;
           
            if (searchTerm != null && searchTerm.Length > 0)
            {
                url = url + "&name=" + searchTerm;
            }

            var client = new RestClient(url);

            var request = new RestRequest();

            var response = client.Get<EmployeeList>(request);

            return response.Data;
        }

        public bool deleteEmployee(int id)
        {
            var url = Properties.Settings.Default.GoRestUrl + RESOURCE_NAME + id + Properties.Settings.Default.Path;

            var client = new RestClient(url);

            var request = new RestRequest();

            var response = client.Delete<EmployeeList>(request);

            return response.IsSuccessful;
        }

        public Employee loadEmployee(int id)
        {
            var url = Properties.Settings.Default.GoRestUrl + RESOURCE_NAME + id + Properties.Settings.Default.Path;

            var client = new RestClient(url);

            var request = new RestRequest();

            var response = client.Get<EmployeeList>(request);

            return response.Data.data[0];
        }

        public bool updateEmployee(Employee employee)
        {
            string url = Properties.Settings.Default.GoRestUrl + RESOURCE_NAME + employee.id + Properties.Settings.Default.Path;

            var client = new RestClient(url);

            var request = new RestRequest().AddJsonBody(employee);

            if (employee.id > 0)
            {
                var response = client.Patch<EmployeeList>(request);
                return response.IsSuccessful;
            }

            return false;
        }

        public int createEmployee(Employee employee)
        {
            string url = Properties.Settings.Default.GoRestUrl + RESOURCE_NAME + Properties.Settings.Default.Path;

            var client = new RestClient(url);

            var request = new RestRequest().AddJsonBody(employee);
            var response = client.Post<EmployeeList>(request);

            if (response.IsSuccessful)
                return response.Data.data[0].id;
            else
                return -1;
        }
    }
}
