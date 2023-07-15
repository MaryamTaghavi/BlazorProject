using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Interfaces
{
    public interface IUnitService
    {
        public Task<IEnumerable<Unit>> GetAllUnits();
    }
}
