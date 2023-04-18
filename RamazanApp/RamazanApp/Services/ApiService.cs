using Newtonsoft.Json;
using RamazanApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RamazanApp.Services
{
    public class ApiService
    {
        private const string ApiUrl = "https://localhost:44378/api";
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<Cities>> GetCitiesAsync()
        {
            //var citiesUrl = $"{ApiUrl}/Cities";
            var respose = await _httpClient.GetAsync($"{ApiUrl}/Cities");
            var jsonString = await respose.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<List<Cities>>(jsonString);
            System.Diagnostics.Debug.WriteLine($"Found {data.Count} cities.");
            return data;       
        }

        public async Task<List<Dates>> GetDatesAsync()
        {
            var datesUrl = $"{ApiUrl}/Dates";
            var resposeDate = await _httpClient.GetAsync(datesUrl);
            var jsonStringDate = await resposeDate.Content.ReadAsStringAsync();
            var dataDate = JsonConvert.DeserializeObject<List<Dates>>(jsonStringDate);
            System.Diagnostics.Debug.WriteLine($"Found {dataDate.Count} dates.");
            return dataDate;
        }

       public async Task<List<Times>> GetTimesAsync(int cityId,int dateId)
        {
             

            var resposeTime = await _httpClient.GetAsync($"{ApiUrl}/Times?cityId={cityId}&dateId={dateId}");
            var jsonStringTime = await resposeTime.Content.ReadAsStringAsync();
            var dataTime = JsonConvert.DeserializeObject<List<Times>>(jsonStringTime);
            return dataTime;
        }
    }
}
