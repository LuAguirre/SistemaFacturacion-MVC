#pragma checksum "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\invoices\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c88cc687c0b6a0182cc79dbe280e6bd82ca8f98d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_invoices_Delete), @"mvc.1.0.view", @"/Views/invoices/Delete.cshtml")]
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
#line 1 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\_ViewImports.cshtml"
using SistemaFacturacionMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\_ViewImports.cshtml"
using SistemaFacturacionMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88cc687c0b6a0182cc79dbe280e6bd82ca8f98d", @"/Views/invoices/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a2b6071b9396d0011302dcd8ac330b2263574bf", @"/Views/_ViewImports.cshtml")]
    public class Views_invoices_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaFacturacionMVC.Models.invoice>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\invoices\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Eliminar Factura</h1>\r\n<br />\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c88cc687c0b6a0182cc79dbe280e6bd82ca8f98d4006", async() => {
                WriteLiteral("\r\n    <table>\r\n\r\n        <tr>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\invoices\Delete.cshtml"
           Write(Html.DisplayNameFor(m => m.id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 16 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\invoices\Delete.cshtml"
           Write(Html.DisplayFor(m => m.id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\invoices\Delete.cshtml"
           Write(Html.DisplayNameFor(m => m.Client));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 22 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\invoices\Delete.cshtml"
           Write(Html.DisplayFor(m => m.Client.name));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 22 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\invoices\Delete.cshtml"
                                                Write(Html.DisplayFor(m => m.Client.lastname));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\invoices\Delete.cshtml"
           Write(Html.DisplayNameFor(m => m.total));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\invoices\Delete.cshtml"
           Write(Html.DisplayFor(m => m.total));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\invoices\Delete.cshtml"
           Write(Html.DisplayNameFor(m => m.dateInvoice));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\invoices\Delete.cshtml"
           Write(Html.DisplayFor(m => m.dateInvoice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\invoices\Delete.cshtml"
           Write(Html.DisplayNameFor(m => m.status));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\invoices\Delete.cshtml"
           Write(Html.DisplayFor(m => m.status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1183, "\"", 1258, 1);
#nullable restore
#line 45 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\invoices\Delete.cshtml"
WriteAttributeValue("", 1190, Url.Action("ConfirmacionEliminar","invoices",new { id = Model.id }), 1190, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <input type=\"button\" value=\"Eliminar Factura\" class=\"btn btn-danger\" /></a>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaFacturacionMVC.Models.invoice> Html { get; private set; }
    }
}
#pragma warning restore 1591
