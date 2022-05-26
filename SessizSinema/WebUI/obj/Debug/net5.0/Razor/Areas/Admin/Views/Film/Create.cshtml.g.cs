#pragma checksum "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Admin\Views\Film\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d482dc40a466e13c39a2711d50f93cfc902bad9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Film_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Film/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d482dc40a466e13c39a2711d50f93cfc902bad9", @"/Areas/Admin/Views/Film/Create.cshtml")]
    public class Areas_Admin_Views_Film_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebUI.Areas.Admin.Models.FilmVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Admin\Views\Film\Create.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Film</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Film.Ad"" class=""control-label""></label>
                <input asp-for=""Film.Ad"" class=""form-control"" />
                <span asp-validation-for=""Ad"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Film.Fiyat"" class=""control-label""></label>
                <input asp-for=""Film.Fiyat"" class=""form-control"" />
                <span asp-validation-for=""Fiyat"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Film.VizyonaGirisTarih"" class=""control-label""></label>
                <input asp-for=""Film.VizyonaGirisTarih"" class=""form-control"" />
                <span asp-validation-for=""VizyonaGirisTar");
            WriteLiteral(@"ih"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Film.VizyonDanKalkisTarih"" class=""control-label""></label>
                <input asp-for=""Film.VizyonDanKalkisTarih"" class=""form-control"" />
                <span asp-validation-for=""Film.VizyonDanKalkisTarih"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Film.FilmOzet"" class=""control-label""></label>
                <input asp-for=""Film.FilmOzet"" class=""form-control"" />
                <span asp-validation-for=""FilmOzet"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Film.FilmSuresi"" class=""control-label""></label>
                <input asp-for=""Film.FilmSuresi"" class=""form-control"" />
                <span asp-validation-for=""FilmSuresi"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                ");
            WriteLiteral(@"<label asp-for=""Film.FilmYönetmeni"" class=""control-label""></label>
                <input asp-for=""Film.FilmYönetmeni"" class=""form-control"" />
                <span asp-validation-for=""FilmYönetmeni"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Film.FilmPosterFotografYolu"" class=""control-label""></label>
                <input asp-for=""Film.FilmPosterFotografYolu"" class=""form-control"" />
                <span asp-validation-for=""Film.FilmPosterFotografYolu"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Film Türü</label>
                <select asp-for=""FilmCategori.KategoriAdi"" class=""form-control"">
");
#nullable restore
#line 59 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Admin\Views\Film\Create.cshtml"
                      
                        foreach (FilmCategori item in Model.FilmCategorileri)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 3116, "\"", 3132, 1);
#nullable restore
#line 62 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Admin\Views\Film\Create.cshtml"
WriteAttributeValue("", 3124, item.Id, 3124, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 62 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Admin\Views\Film\Create.cshtml"
                                                Write(item.KategoriAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 63 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Admin\Views\Film\Create.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Film Türü</label>\r\n                <select asp-for=\"Seans.Saati\" class=\"form-control\">\r\n");
#nullable restore
#line 70 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Admin\Views\Film\Create.cshtml"
                      
                        foreach (Seans item in Model.Seanslar)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 3580, "\"", 3596, 1);
#nullable restore
#line 73 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Admin\Views\Film\Create.cshtml"
WriteAttributeValue("", 3588, item.Id, 3588, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 73 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Admin\Views\Film\Create.cshtml"
                                                Write(item.Saati);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 74 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Admin\Views\Film\Create.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
            </div>
            <div class=""form-group"">
                <label asp-for=""Film.FilmPoster"" class=""control-label"">Resim seç</label>
                <input asp-for=""Film.FilmPoster"" type=""file"" accept="".png, .jpg, .jpeg"" class=""form-control"" />
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>
");
#nullable restore
#line 92 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Admin\Views\Film\Create.cshtml"
 if (TempData["Message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 95 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Admin\Views\Film\Create.cshtml"
   Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 97 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Admin\Views\Film\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 99 "C:\Users\FATOŞ\Desktop\SessizSinema\WebUI\Areas\Admin\Views\Film\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebUI.Areas.Admin.Models.FilmVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
