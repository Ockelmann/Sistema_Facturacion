#pragma checksum "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60fa41f73e89da0e993e5167775825acfb70f2a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reportes_ProductosFecha_Index), @"mvc.1.0.view", @"/Views/Reportes_ProductosFecha/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60fa41f73e89da0e993e5167775825acfb70f2a8", @"/Views/Reportes_ProductosFecha/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb984b33b38101686635d0abde4dbb6bc0daa815", @"/Views/_ViewImports.cshtml")]
    public class Views_Reportes_ProductosFecha_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\Index.cshtml"
  
    ViewData["Title"] = "Reportes";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Reportes:</h1>
<br />
<br />

<div class=""row"">
    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title"">Ventas por producto:</h5>
                <p class=""card-text"">
                    Muestra el monto total vendido de cada
                    producto(día por día).
                </p>
                ");
#nullable restore
#line 20 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\Index.cshtml"
           Write(Html.ActionLink("Ver Reporte", "ReporteVentasProducto", new { Codigo_Producto = 0 }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title"">Ventas por producto:</h5>
                <p class=""card-text"">
                    Muestra el monto total vendido en el rango de fechas(día por día).
                </p>
                ");
#nullable restore
#line 31 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\Index.cshtml"
           Write(Html.ActionLink("Ver Reporte", "ReporteVentasProductoFecha", new { fechaInicio = "1753/1/1 12:00:00", fechaFinal = "9999/12/31 11:59:59 " }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<br>
<div class=""row"">
    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title"">Ventas por cliente:</h5>
                <p class=""card-text"">
                    Muestra el monto total vendido de cada
                    Cliente(día por día).
                </p>
                ");
#nullable restore
#line 47 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\Index.cshtml"
           Write(Html.ActionLink("Ver Reporte", "ReporteVentasCliente", new { Codigo_Cliente = 0 }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title"">Ventas por cliente:</h5>
                <p class=""card-text"">
                    Muestra el monto total vendido  en el rango de fechas (día por día).
                </p>
                ");
#nullable restore
#line 58 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\Index.cshtml"
           Write(Html.ActionLink("Ver Reporte", "ReporteVentasClienteFecha", new { fechaInicio = "1753/1/1 12:00:00", fechaFinal = "9999/12/31 11:59:59 " }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<br>
<div class=""row"">
    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title"">Estadísticas de facturación:</h5>
                <p class=""card-text"">
                    Muestra día por día la cantidad de
                    facturas emitidas, el monto total facturado y la cantidad de productos
                    facturados
                </p>
                ");
#nullable restore
#line 75 "C:\Users\juceg\Desktop\Sistema_Facturacion\Sistema_Facturacion\Views\Reportes_ProductosFecha\Index.cshtml"
           Write(Html.ActionLink("Ver Reporte", "ReporteEstadisticaFacturacion", new { fechaInicio = "1753/1/1 12:00:00", fechaFinal = "9999/12/31 11:59:59 " }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591