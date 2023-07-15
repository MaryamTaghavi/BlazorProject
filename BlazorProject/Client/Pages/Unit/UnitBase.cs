using Application.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorProject.Client.Pages.Unit
{
    public class UnitBase : ComponentBase
    {
        [Inject]
        public IUnitService UnitService { get; set; }

        public IEnumerable<Domain.Models.Unit> UnitList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            UnitList = await UnitService.GetAllUnits();
        }
    }
}
