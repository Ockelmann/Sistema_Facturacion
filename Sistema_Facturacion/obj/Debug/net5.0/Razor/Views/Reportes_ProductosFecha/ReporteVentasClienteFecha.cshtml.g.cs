#pragma checksum "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\ReporteVentasClienteFecha.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40d34b3d37d49f3cfce88442c5bb296fa18f719a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reportes_ProductosFecha_ReporteVentasClienteFecha), @"mvc.1.0.view", @"/Views/Reportes_ProductosFecha/ReporteVentasClienteFecha.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\_ViewImports.cshtml"
using Sistema_Facturacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\_ViewImports.cshtml"
using Sistema_Facturacion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40d34b3d37d49f3cfce88442c5bb296fa18f719a", @"/Views/Reportes_ProductosFecha/ReporteVentasClienteFecha.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb984b33b38101686635d0abde4dbb6bc0daa815", @"/Views/_ViewImports.cshtml")]
    public class Views_Reportes_ProductosFecha_ReporteVentasClienteFecha : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sistema_Facturacion.Models.Reporte_Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\ReporteVentasClienteFecha.cshtml"
  
    ViewData["Title"] = "Reporte Producto";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    function ShowSelected() {
        var fechaini = document.getElementById(""fechainicio"").value;
        var fechafin = document.getElementById(""fechafinal"").value;

        if (fechaini != """" && fechafin != """") {

            
            var url = """);
#nullable restore
#line 16 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\ReporteVentasClienteFecha.cshtml"
                  Write(Url.Action("ReporteVentasClienteFecha", "Reportes_ProductosFecha", new { FechaInicio = "param-fecha1", FechaFinal = "param-fecha2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
            url = url.replace(""param-fecha1"", fechaini).replace(""param-fecha2"", fechafin);
            url = url.replace(""amp;"", """");
            $(""#result"").load(url);
            window.location.href = url;
        }

    }
</script>

<h1>Reporte Productos</h1>


<div class=""form-group"">
    <input type=""date"" id=""fechainicio"" onchange=""ShowSelected()"" class=""form-control"" />

</div>

<div class=""form-group"">
    <input type=""date"" id=""fechafinal"" onchange=""ShowSelected()"" class=""form-control"" />
</div>





<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 46 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\ReporteVentasClienteFecha.cshtml"
           Write(Html.DisplayNameFor(model => model.Dia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\ReporteVentasClienteFecha.cshtml"
           Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\ReporteVentasClienteFecha.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\ReporteVentasClienteFecha.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\ReporteVentasClienteFecha.cshtml"
           Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 63 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\ReporteVentasClienteFecha.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\ReporteVentasClienteFecha.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\ReporteVentasClienteFecha.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\ReporteVentasClienteFecha.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\ReporteVentasClienteFecha.cshtml"
               Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\ReporteVentasClienteFecha.cshtml"
               Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 82 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\ReporteVentasClienteFecha.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sistema_Facturacion.Models.Reporte_Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591