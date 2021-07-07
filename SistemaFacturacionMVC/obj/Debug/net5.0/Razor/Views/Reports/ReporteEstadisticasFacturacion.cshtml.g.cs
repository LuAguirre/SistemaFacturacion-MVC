#pragma checksum "C:\Users\louma\OneDrive\Escritorio\pSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Reports\ReporteEstadisticasFacturacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1037b3e82a3d55cfdd21c6fa93e01c561bfa677"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_ReporteEstadisticasFacturacion), @"mvc.1.0.view", @"/Views/Reports/ReporteEstadisticasFacturacion.cshtml")]
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
#line 1 "C:\Users\louma\OneDrive\Escritorio\pSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\_ViewImports.cshtml"
using SistemaFacturacionMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\louma\OneDrive\Escritorio\pSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\_ViewImports.cshtml"
using SistemaFacturacionMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1037b3e82a3d55cfdd21c6fa93e01c561bfa677", @"/Views/Reports/ReporteEstadisticasFacturacion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a2b6071b9396d0011302dcd8ac330b2263574bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_ReporteEstadisticasFacturacion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaFacturacionMVC.Models.estadisticasFactura>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\louma\OneDrive\Escritorio\pSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Reports\ReporteEstadisticasFacturacion.cshtml"
  
    ViewData["Title"] = "ReporteEstadisticasFacturacion";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    function mostrarDatos() {
        var fecha_inicio = document.getElementById(""fecha-inicio"").value;
        var fecha_final = document.getElementById(""fecha-final"").value;

        if (fecha_inicio != """" && fecha_final != """") {
            var url = """);
#nullable restore
#line 14 "C:\Users\louma\OneDrive\Escritorio\pSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Reports\ReporteEstadisticasFacturacion.cshtml"
                  Write(Url.Action("ReporteEstadisticasFacturacion", "Reports", new { fechaInicio = "param-fecha1", fechaFinal = "param-fecha2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
            url = url.replace(""param-fecha1"", fecha_inicio).replace(""param-fecha2"", fecha_final);
            url = url.replace(""amp;"", """");
            $(""#result"").load(url);
            window.location.href = url;
        }
    }
</script>

<h1>Reporte de Estadisticas de Facturacion</h1>

<div class=""form-group"">
    <input type=""date"" id=""fecha-inicio"" onchange=""mostrarDatos()"" class=""form-control"" />
</div>

<div class=""form-group"">
    <input type=""date"" id=""fecha-final"" onchange=""mostrarDatos()"" class=""form-control"" />
</div>

<div class=""table-responsive"">
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr style=""text-align:center;"">
                <th>
                    ");
#nullable restore
#line 38 "C:\Users\louma\OneDrive\Escritorio\pSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Reports\ReporteEstadisticasFacturacion.cshtml"
               Write(Html.DisplayNameFor(model => model.Total_facturas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 41 "C:\Users\louma\OneDrive\Escritorio\pSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Reports\ReporteEstadisticasFacturacion.cshtml"
               Write(Html.DisplayNameFor(model => model.monto_facturado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 44 "C:\Users\louma\OneDrive\Escritorio\pSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Reports\ReporteEstadisticasFacturacion.cshtml"
               Write(Html.DisplayNameFor(model => model.total_Productos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 47 "C:\Users\louma\OneDrive\Escritorio\pSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Reports\ReporteEstadisticasFacturacion.cshtml"
               Write(Html.DisplayNameFor(model => model.dateInvoice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 52 "C:\Users\louma\OneDrive\Escritorio\pSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Reports\ReporteEstadisticasFacturacion.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"text-align:center;\">\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\Users\louma\OneDrive\Escritorio\pSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Reports\ReporteEstadisticasFacturacion.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Total_facturas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Users\louma\OneDrive\Escritorio\pSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Reports\ReporteEstadisticasFacturacion.cshtml"
                   Write(Html.DisplayFor(modelItem => item.monto_facturado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\louma\OneDrive\Escritorio\pSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Reports\ReporteEstadisticasFacturacion.cshtml"
                   Write(Html.DisplayFor(modelItem => item.total_Productos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\louma\OneDrive\Escritorio\pSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Reports\ReporteEstadisticasFacturacion.cshtml"
                   Write(Html.DisplayFor(modelItem => item.dateInvoice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 68 "C:\Users\louma\OneDrive\Escritorio\pSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Reports\ReporteEstadisticasFacturacion.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaFacturacionMVC.Models.estadisticasFactura>> Html { get; private set; }
    }
}
#pragma warning restore 1591
