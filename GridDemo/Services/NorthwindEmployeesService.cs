using System.Net.Http.Json;
using GridDemo.Models.NorthwindEmployees;

namespace GridDemo.NorthwindEmployees
{
    public class NorthwindEmployeesService: INorthwindEmployeesService
    {
        private readonly HttpClient _http;

        public NorthwindEmployeesService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<EmployeeString<>f__AnonymousType9>> GetEmployeeString<>f__AnonymousType9()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://northwindcloud.azurewebsites.net/api/employees", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<EmployeeString<>f__AnonymousType9>>().ConfigureAwait(false);
            }

            return new List<EmployeeString<>f__AnonymousType9>();
        }

        public async Task<List<Employee_Titles>> GetEmployee_Titles()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://northwindcloud.azurewebsites.net/api/employee_titles", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<Employee_Titles>>().ConfigureAwait(false);
            }

            return new List<Employee_Titles>();
        }
    }
}