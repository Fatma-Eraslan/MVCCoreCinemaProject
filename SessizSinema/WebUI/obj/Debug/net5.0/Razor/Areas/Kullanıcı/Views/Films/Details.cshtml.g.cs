#pragma checksum "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "000456b4451e3f83f46fafc9f79c582d043924c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Kullanıcı_Views_Films_Details), @"mvc.1.0.view", @"/Areas/Kullanıcı/Views/Films/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"000456b4451e3f83f46fafc9f79c582d043924c2", @"/Areas/Kullanıcı/Views/Films/Details.cshtml")]
    public class Areas_Kullanıcı_Views_Films_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebUI.Models.DataBase.Entities.Film>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Film</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fiyat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fiyat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VizyonaGirisTarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.VizyonaGirisTarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VizyonDanKalkisTarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.VizyonDanKalkisTarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FilmOzet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.FilmOzet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FilmSuresi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.FilmSuresi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FilmYönetmeni));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.FilmYönetmeni));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FilmPosterFotografYolu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.FilmPosterFotografYolu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1975, "\"", 1999, 1);
#nullable restore
#line 64 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Kullanıcı\Views\Films\Details.cshtml"
WriteAttributeValue("", 1990, Model.Id, 1990, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebUI.Models.DataBase.Entities.Film> Html { get; private set; }
    }
}
#pragma warning restore 1591
