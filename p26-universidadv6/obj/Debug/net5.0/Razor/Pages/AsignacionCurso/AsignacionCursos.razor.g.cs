#pragma checksum "/Users/castr/Downloads/programas/p26-universidadv6/Pages/AsignacionCurso/AsignacionCursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b764d6079318eb81f0e7f0b10bfc4809da6d2644"
// <auto-generated/>
#pragma warning disable 1591
namespace p21_universidadv1.Pages.AsignacionCurso
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using p21_universidadv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using p21_universidadv1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/AsignacionCurso/AsignacionCursos.razor"
using p21_universidadv1.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/AsignacionCurso/AsignacionCursos.razor"
using p21_universidadv1.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AsignacionCursos")]
    public partial class AsignacionCursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Informacion de Oficina Asignada</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "AgregarAsignacionCursos");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<span class=\"oi oi-plus\">Agregar Nuevo</span>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 12 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/AsignacionCurso/AsignacionCursos.razor"
 if(obj is null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p>Cargando ...</p>");
#nullable restore
#line 14 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/AsignacionCurso/AsignacionCursos.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><th>Instructor</th>\n            <th>Curso</th></thead>\n    \n    ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 22 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/AsignacionCurso/AsignacionCursos.razor"
         foreach (var i in obj)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 25 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/AsignacionCurso/AsignacionCursos.razor"
                     i.Instructor.NombreCompleto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 26 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/AsignacionCurso/AsignacionCursos.razor"
                     i.Curso.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                ");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "class", "nav-link");
            __builder.AddAttribute(21, "href", "EditarAsignacionCursos/" + (
#nullable restore
#line 28 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/AsignacionCurso/AsignacionCursos.razor"
                                                                      i.CursoId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 28 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/AsignacionCurso/AsignacionCursos.razor"
                                                                                 i.InstructorId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "<span class=\"oi oi-pencil\">Editar</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                     ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "class", "nav-link");
            __builder.AddAttribute(26, "href", "EliminarAsignacionCursos/" + (
#nullable restore
#line 31 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/AsignacionCurso/AsignacionCursos.razor"
                                                                         i.CursoId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 31 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/AsignacionCurso/AsignacionCursos.razor"
                                                                                    i.InstructorId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "<span class=\"oi oi-pencil\">Eliminar</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/AsignacionCurso/AsignacionCursos.razor"
        } 

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/AsignacionCurso/AsignacionCursos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/AsignacionCurso/AsignacionCursos.razor"
       
    List<AsignacionCurso> obj;
 
    protected override void OnInitialized() {
        obj = serv.ObtenerTodo();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioAsignacionCursos serv { get; set; }
    }
}
#pragma warning restore 1591