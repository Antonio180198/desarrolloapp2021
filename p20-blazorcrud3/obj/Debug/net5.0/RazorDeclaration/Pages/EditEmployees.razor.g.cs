// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace p20_blazorcrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\_Imports.razor"
using p20_blazorcrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\_Imports.razor"
using p20_blazorcrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\Pages\EditEmployees.razor"
using p20_blazorcrud.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditEmployees/{Id}")]
    public partial class EditEmployees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\Pages\EditEmployees.razor"
       
    [Parameter]
    public string Id {get; set;}

    Employee obj = new Employee();

    protected override void OnInitialized() {
        obj = employeeService.GetEmployee(int.Parse(Id));
    }

    protected void UpdateEmployee() {
        employeeService.UpdateEmployee(obj);
        NavigationManager.NavigateTo("Employees");
    }
    protected void Cancel() {
        NavigationManager.NavigateTo("Employees");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService employeeService { get; set; }
    }
}
#pragma warning restore 1591
