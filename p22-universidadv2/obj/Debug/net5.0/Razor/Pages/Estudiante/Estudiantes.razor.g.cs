#pragma checksum "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f017713e073fbae48279aa8ed9342009d161cc17"
// <auto-generated/>
#pragma warning disable 1591
namespace p21_universidadv1.Pages.Estudiante
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\_Imports.razor"
using p21_universidadv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\_Imports.razor"
using p21_universidadv1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
using p21_universidadv1.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
using p21_universidadv1.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Estudiantes")]
    public partial class Estudiantes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Informacion de Estudiantes</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "AgregarEstudiantes");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<span class=\"oi oi-plus\">Agregar Nuevo</span>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 12 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
 if(obj is null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p>Cargando ...</p>");
#nullable restore
#line 14 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><th>Id</th>\r\n            <th>Apeido Paterno</th>\r\n            <th>Apeido Materno</th>\r\n            <th>Nombre</th>\r\n            <th>Email</th>\r\n            <th>Fecha Ingreso</th></thead>\r\n    \r\n    ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 26 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
         foreach (var i in obj)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 29 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
                     i.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 30 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
                     i.Apaterno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 31 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
                     i.Amaterno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 32 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
                     i.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 33 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
                     i.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 34 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
                     i.FechadeIngreso.ToString("yyy-MMM-dd")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "EditarEstudiantes/" + (
#nullable restore
#line 36 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
                                                                 i.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "<span class=\"oi oi-pencil\">Editar</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                     ");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "class", "nav-link");
            __builder.AddAttribute(38, "href", "ElimnarEstudiantes/" + (
#nullable restore
#line 39 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
                                                                   i.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "<span class=\"oi oi-pencil\">Eliminar</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\joanb\Documents\ING\9no\desarrollo de aplicacaciones web\programas\p22-universidadv2\Pages\Estudiante\Estudiantes.razor"
       
    List<Estudiante> obj;
 
    protected override void OnInitialized() {
        obj = serv.ObtenerTodo();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioEstudiantes serv { get; set; }
    }
}
#pragma warning restore 1591
