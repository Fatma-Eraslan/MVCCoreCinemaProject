#pragma checksum "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f81db660dfe6c4c3327e8b0bef8706e35c22a0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Kullanıcı_Views_Films_Index), @"mvc.1.0.view", @"/Areas/Kullanıcı/Views/Films/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f81db660dfe6c4c3327e8b0bef8706e35c22a0e", @"/Areas/Kullanıcı/Views/Films/Index.cshtml")]
    public class Areas_Kullanıcı_Views_Films_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebUI.Models.DataBase.Entities.Film>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Vizyondakiler";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Vizyondakiler</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fiyat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VizyonaGirisTarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VizyonDanKalkisTarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FilmOzet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FilmSuresi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FilmYönetmeni));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FilmPosterFotografYolu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fiyat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.VizyonaGirisTarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.VizyonDanKalkisTarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FilmOzet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FilmSuresi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FilmYönetmeni));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FilmPosterFotografYolu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2184, "\"", 2207, 1);
#nullable restore
#line 69 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
WriteAttributeValue("", 2199, item.Id, 2199, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 72 "C:\Users\FATOŞ\Desktop\sinema\GitHub\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebUI.Models.DataBase.Entities.Film>> Html { get; private set; }
    }
}
#pragma warning restore 1591
