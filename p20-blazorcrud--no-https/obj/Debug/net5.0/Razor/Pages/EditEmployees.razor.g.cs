#pragma checksum "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\Pages\EditEmployees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17c395a5098158208c949c6f6bd046d45b7769f3"
// <auto-generated/>
#pragma warning disable 1591
namespace p20_blazorcrud__no_https.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\_Imports.razor"
using p20_blazorcrud__no_https;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\_Imports.razor"
using p20_blazorcrud__no_https.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\Pages\EditEmployees.razor"
using p20_blazorcrud__no_https.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditEmployees")]
    public partial class EditEmployees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Employee</h3>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label formname=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "formname", "Name");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\Pages\EditEmployees.razor"
                                                                    obj.EmployeeName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.EmployeeName = __value, obj.EmployeeName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.OpenElement(17, "select");
            __builder.AddAttribute(18, "class", "from-control");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\Pages\EditEmployees.razor"
                                obj.Gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Gender = __value, obj.Gender));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value");
            __builder.AddContent(23, "Select Gender");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", "Male");
            __builder.AddContent(27, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", "Female");
            __builder.AddContent(31, "Female");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group");
            __builder.AddMarkupContent(35, "<label formname=\"Designation\" class=\"control-lavel\">Designation</label>\r\n                ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "formname", "Designation");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\Pages\EditEmployees.razor"
                                                                           obj.Designation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Designation = __value, obj.Designation));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.AddMarkupContent(44, "<label formname=\"City\" class=\"control-lavel\">City</label>\r\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "formname", "City");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\Pages\EditEmployees.razor"
                                                                    obj.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.City = __value, obj.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col-md-4");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "from-group");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "button");
            __builder.AddAttribute(59, "class", "btn btn-primary");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\Pages\EditEmployees.razor"
                                                                   UpdateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "button");
            __builder.AddAttribute(65, "class", "btn btn-primary");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\Pages\EditEmployees.razor"
                                                                   Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p20-blazorcrud--no-https\Pages\EditEmployees.razor"
       

    [Parameter]
    public string Id {get; set;}

    Employee obj=new Employee();

    protected override void OnInitialized(){
        obj=employeeService.GetEmployee(int.Parse(Id));
    }

    protected void UpdateEmployee(){
        employeeService.UpdateEmployee(obj);
        NavigationManager.NavigateTo("Employees");

    }
    protected void Cancel(){
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
