using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorProject.Server.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UnitController : ControllerBase
    {
        private readonly IUnitService _unitService;

        public UnitController(IUnitService unitService)
        {
            _unitService = unitService;
        }

        [HttpGet]
        public async Task<IEnumerable<Unit>> Get()
        {
            return await _unitService.GetAllUnits();
        }
    }
}
