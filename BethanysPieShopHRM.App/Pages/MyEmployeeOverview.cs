using BethanysPieShopHRM.App.Components;
using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class MyEmployeeOverview
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        public AddEmployeeDialog AddEmployeeDialog { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            //InitializeCountries();
            //InitializeJobCategories();
            //InitializeEmployees();


            //return base.OnInitializedAsync();
        }
        public void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }

        public async void AddEmployeeDialog_OnDialogClose()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            StateHasChanged();
        }

        public IEnumerable<Employee> Employees { get; set; }

        
    }
}
