#pragma checksum "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/EliminarCursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e118ef52033b5759f526e35fbdfd1c35cab82b6"
// <auto-generated/>
#pragma warning disable 1591
namespace p21_universidadv1.Pages.Curso
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using p21_universidadv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using p21_universidadv1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/EliminarCursos.razor"
using p21_universidadv1.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/EliminarCursos.razor"
using p21_universidadv1.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EliminarCursos/{Id}")]
    public partial class EliminarCursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Eliminar Curso</h3> \n<hr>\n");
            __builder.AddMarkupContent(1, "<h3>Estas seguro que desas Eliminar? </h3>\n\n ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/EliminarCursos.razor"
                      obj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "fieldset");
                __builder2.AddAttribute(10, "disabled", "true");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<label for=\"CursoID\" class=\"control-label\">Curso ID</label>\n                ");
                __Blazor.p21_universidadv1.Pages.Curso.EliminarCursos.TypeInference.CreateInputNumber_0(__builder2, 14, 15, "CursoID", 16, "form-control", 17, 
#nullable restore
#line 18 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/EliminarCursos.razor"
                                                                            obj.CursoId

#line default
#line hidden
#nullable disable
                , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.CursoId = __value, obj.CursoId)), 19, () => obj.CursoId);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n              ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label for=\"Titulo\" class=\"control-label\">Titulo</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "id", "Titulo");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/EliminarCursos.razor"
                                                                         obj.Titulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Titulo = __value, obj.Titulo))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Titulo));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label for=\"Creditos\" class=\"control-label\">Creditos</label>\n                ");
                __Blazor.p21_universidadv1.Pages.Curso.EliminarCursos.TypeInference.CreateInputNumber_1(__builder2, 34, 35, "Creditos", 36, "form-control", 37, 
#nullable restore
#line 26 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/EliminarCursos.razor"
                                                                             obj.Creditos

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Creditos = __value, obj.Creditos)), 39, () => obj.Creditos);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<label for=\"DepartamentoId\" class=\"control-label\">Departamento </label>\n                ");
                __Blazor.p21_universidadv1.Pages.Curso.EliminarCursos.TypeInference.CreateInputSelect_2(__builder2, 44, 45, "DepartamentoId", 46, "form-control", 47, 
#nullable restore
#line 30 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/EliminarCursos.razor"
                                                                                   obj.DepartamentoId

#line default
#line hidden
#nullable disable
                , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.DepartamentoId = __value, obj.DepartamentoId)), 49, () => obj.DepartamentoId, 50, (__builder3) => {
#nullable restore
#line 31 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/EliminarCursos.razor"
                     foreach (var i in @objins )
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(51, "option");
                    __builder3.AddAttribute(52, "value", 
#nullable restore
#line 33 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/EliminarCursos.razor"
                                        i.DepartamentoId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(53, 
#nullable restore
#line 33 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/EliminarCursos.razor"
                                                           i.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 34 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/EliminarCursos.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "    \n            ");
                __builder2.OpenElement(55, "button");
                __builder2.AddAttribute(56, "type", "submit");
                __builder2.AddAttribute(57, "class", "btn btn-danger");
                __builder2.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/EliminarCursos.razor"
                                                                     EliminarCurso

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(59, "Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\n            ");
                __builder2.OpenElement(61, "button");
                __builder2.AddAttribute(62, "type", "button");
                __builder2.AddAttribute(63, "class", "btn btn-primary");
                __builder2.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/EliminarCursos.razor"
                                                                     Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(65, "Cancelar");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/Curso/EliminarCursos.razor"
       
    [Parameter]
    public string Id {get;set;}
    Curso obj = new Curso();
    List<Departamento> objins;
    protected void EliminarCurso() {
        serv.Eliminar(obj);
        NavigationManager.NavigateTo("Cursos");
    }
    protected void Cancelar() {
       NavigationManager.NavigateTo("Cursos");
    }
    protected override void OnInitialized() {
         objins = sins.ObtenerTodo("");
         obj = serv.Obtener(int.Parse(Id));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioDepartamentos sins { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioCursos serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.p21_universidadv1.Pages.Curso.EliminarCursos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
