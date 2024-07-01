using System.Net.Http.Json;
using Toverland.Data.Models;

namespace Toverland.Data;

public class ApiService(HttpClient httpClient)
{
    public async Task<Facility?> GetFacility(int id)
    {
        try
        {
            return await httpClient.GetFromJsonAsync<Facility>($"Facility/{id}");
        } catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return null;
    }
    
    public async Task<List<Facility>> GetFacilities()
    {
        try
        {
            return await httpClient.GetFromJsonAsync<List<Facility>>("http://localhost:5114/api/Facility/");
        } catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return new List<Facility>();
    }
}