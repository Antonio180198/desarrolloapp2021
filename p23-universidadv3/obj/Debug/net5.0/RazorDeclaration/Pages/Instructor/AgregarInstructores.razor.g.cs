// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace p21_universidadv1.Pages.Instructor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p23-universidadv3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p23-universidadv3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p23-universidadv3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p23-universidadv3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p23-universidadv3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p23-universidadv3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p23-universidadv3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p23-universidadv3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p23-universidadv3\_Imports.razor"
using p21_universidadv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p23-universidadv3\_Imports.razor"
using p21_universidadv1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p23-universidadv3\Pages\Instructor\AgregarInstructores.razor"
using p21_universidadv1.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p23-universidadv3\Pages\Instructor\AgregarInstructores.razor"
using p21_universidadv1.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AgregarInstructores")]
    public partial class AgregarInstructores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "c:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p23-universidadv3\Pages\Instructor\AgregarInstructores.razor"
       
    Instructor obj = new Instructor();
    protected void CrearInstructor() {
        serv.Insertar(obj);
        NavigationManager.NavigateTo("Instructores");
    }
    protected void Cancelar() {
       NavigationManager.NavigateTo("Instructores");
    }
    protected override void OnInitialized() {
        obj.FechaContratacion = DateTime.Today;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioInstructores serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
