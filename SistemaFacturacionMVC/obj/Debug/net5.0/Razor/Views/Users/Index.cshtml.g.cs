#pragma checksum "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a202ff1b9ca977d8c03f2b2d6fa2ad517b690b6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a202ff1b9ca977d8c03f2b2d6fa2ad517b690b6f", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a2b6071b9396d0011302dcd8ac330b2263574bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaFacturacionMVC.Models.userT>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary d-block m-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Usuarios del Sistema</h1>\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
     if (TempData["menssage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n                    ");
#nullable restore
#line 12 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
               Write(TempData["menssage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                </div>\r\n");
#nullable restore
#line 17 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <h3>Lista de Usuarios</h3>\r\n        </div>\r\n        <div class=\"col-sm-6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a202ff1b9ca977d8c03f2b2d6fa2ad517b690b6f7100", async() => {
                WriteLiteral(" Agregar Usuario ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 28 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
         if(Model.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <table class=\"table table-dark\">\r\n                 <thead>\r\n                     <tr>\r\n                         <td>");
#nullable restore
#line 33 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                        Write(Html.DisplayNameFor(m => m.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                         <td>");
#nullable restore
#line 34 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                        Write(Html.DisplayNameFor(m => m.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                         <td>");
#nullable restore
#line 35 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                        Write(Html.DisplayNameFor(m => m.lastame));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                         <td>");
#nullable restore
#line 36 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                        Write(Html.DisplayNameFor(m => m.rol));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                         <td>");
#nullable restore
#line 37 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                        Write(Html.DisplayNameFor(m => m.username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                         <td>");
#nullable restore
#line 38 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                        Write(Html.DisplayNameFor(m => m.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                     </tr>\r\n                 </thead>\r\n                 <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                      foreach (userT element in Model)
                     {

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <tr>\r\n                             <td>");
#nullable restore
#line 46 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                            Write(element.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                             <td>");
#nullable restore
#line 47 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                            Write(element.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                             <td>");
#nullable restore
#line 48 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                            Write(element.lastame);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                             <td>");
#nullable restore
#line 49 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                            Write(element.rol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                             <td>");
#nullable restore
#line 50 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                            Write(element.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                             <td type=\"password\">");
#nullable restore
#line 51 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                                            Write(element.password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                             <td>\r\n                                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a202ff1b9ca977d8c03f2b2d6fa2ad517b690b6f13363", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                                                                               WriteLiteral(element.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a202ff1b9ca977d8c03f2b2d6fa2ad517b690b6f15907", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                                                                                 WriteLiteral(element.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                             </td>\r\n                         </tr>\r\n");
#nullable restore
#line 58 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                 </tbody>\r\n\r\n             </table>\r\n");
#nullable restore
#line 62 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"

            }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>No hay información aún</h2>\r\n");
#nullable restore
#line 65 "C:\Users\louma\OneDrive\Escritorio\PSF\SistemaFacturacion-MVC\SistemaFacturacionMVC\Views\Users\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaFacturacionMVC.Models.userT>> Html { get; private set; }
    }
}
#pragma warning restore 1591
