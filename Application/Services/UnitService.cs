using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.DTOs;
using Domain.Models;

namespace Application.Services
{
    public class UnitService : IUnitService
    {
        private readonly HttpClient _httpClient;
        public UnitService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Unit>> GetAllUnits()
        {
            try
            {
                var units = await _httpClient.GetFromJsonAsync<IEnumerable<UnitDto>>("api/Unit");

                return null;
            }
            catch
            {
                return null;
            }

        }
    }
}
