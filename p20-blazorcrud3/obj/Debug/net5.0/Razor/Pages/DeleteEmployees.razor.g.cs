#pragma checksum "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\Pages\DeleteEmployees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a849203d318d60153e20f5d236d9146e734f8af"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\Pages\DeleteEmployees.razor"
using p20_blazorcrud.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DeleteEmployees/{Id}")]
    public partial class DeleteEmployees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Delete Employee</h3>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<h3>Are you sure want to delete this?</h3>\r\n");
            __builder.OpenElement(2, "form");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-8");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "<label formname=\"Name\" class=\"control-label\">Id: </label>\r\n                ");
            __builder.OpenElement(10, "label");
            __builder.AddAttribute(11, "formname", "Name");
            __builder.AddAttribute(12, "class", "control-label");
            __builder.AddContent(13, 
#nullable restore
#line 14 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\Pages\DeleteEmployees.razor"
                                                               obj.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label formname=\"Name\" class=\"control-label\">Name: </label>\r\n                ");
            __builder.OpenElement(18, "label");
            __builder.AddAttribute(19, "formname", "Name");
            __builder.AddAttribute(20, "class", "control-label");
            __builder.AddContent(21, 
#nullable restore
#line 18 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\Pages\DeleteEmployees.razor"
                                                               obj.EmployeeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n              ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group");
            __builder.AddMarkupContent(25, "<label formname=\"Name\" class=\"control-label\">Gender: </label>\r\n                ");
            __builder.OpenElement(26, "label");
            __builder.AddAttribute(27, "formname", "Name");
            __builder.AddAttribute(28, "class", "control-label");
            __builder.AddContent(29, 
#nullable restore
#line 22 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\Pages\DeleteEmployees.razor"
                                                               obj.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n              ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "<label formname=\"Name\" class=\"control-label\">Designation: </label>\r\n                ");
            __builder.OpenElement(34, "label");
            __builder.AddAttribute(35, "formname", "Name");
            __builder.AddAttribute(36, "class", "control-label");
            __builder.AddContent(37, 
#nullable restore
#line 26 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\Pages\DeleteEmployees.razor"
                                                               obj.Designation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n              ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group");
            __builder.AddMarkupContent(41, "<label formname=\"Name\" class=\"control-label\">City: </label>\r\n                ");
            __builder.OpenElement(42, "label");
            __builder.AddAttribute(43, "formname", "Name");
            __builder.AddAttribute(44, "class", "control-label");
            __builder.AddContent(45, 
#nullable restore
#line 30 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\Pages\DeleteEmployees.razor"
                                                               obj.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "row");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-md-4");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "form-group");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "btn btn-danger");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\Pages\DeleteEmployees.razor"
                                                                   DeleteEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "type", "button");
            __builder.AddAttribute(61, "class", "btn btn-primary");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\Pages\DeleteEmployees.razor"
                                                                    Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud3\Pages\DeleteEmployees.razor"
       
    [Parameter]
    public string Id {get; set;}

    Employee obj = new Employee();

    protected override void OnInitialized() {
        obj = employeeService.GetEmployee(int.Parse(Id));
    }

    protected void DeleteEmployee() {
        employeeService.DeleteEmployee(obj);
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
