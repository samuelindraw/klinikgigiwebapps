#pragma checksum "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d2e39dcd1583d9c3c6f331a38924118febb5954"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KatBarang_Index), @"mvc.1.0.view", @"/Views/KatBarang/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/KatBarang/Index.cshtml", typeof(AspNetCore.Views_KatBarang_Index))]
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
#line 1 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\_ViewImports.cshtml"
using CloudDentist;

#line default
#line hidden
#line 2 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\_ViewImports.cshtml"
using CloudDentist.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d2e39dcd1583d9c3c6f331a38924118febb5954", @"/Views/KatBarang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3efe918c13658fae758fbc71970ee80ead3ba85", @"/Views/_ViewImports.cshtml")]
    public class Views_KatBarang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CloudDentist.Models.KatBarang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/sweetalert2/sweetalert2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/sweetalert2/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/jquery-validation/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 244, true);
            WriteLiteral("<script type=\"text/javascript\">\r\n        function Delete(Id) {\r\n            alertify.confirm(\'Data Kategori\',\'Apakah anda yakin untuk menghapus data ini ?!\', function (e) {\r\n                if (e) {\r\n                    window.location.href = \'");
            EndContext();
            BeginContext(384, 32, false);
#line 10 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
                                       Write(Url.Action("Delete","KatBarang"));

#line default
#line hidden
            EndContext();
            BeginContext(416, 184, true);
            WriteLiteral("/\' + Id;\r\n                }\r\n                else {\r\n                     alertify.error(\"You\'ve clicked Cancel\");\r\n                }\r\n            }, null);\r\n\r\n        }\r\n\r\n</script>\r\n");
            EndContext();
            BeginContext(643, 193, true);
            WriteLiteral("<!-- Dynamic Table Full Pagination -->\r\n<div class=\"block\">\r\n    <div class=\"block-header block-header-default\">\r\n        <h3 class=\"block-title\">Kategori Barang<small></small></h3>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 836, "\"", 884, 1);
#line 25 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
WriteAttributeValue("", 843, Url.Action("TambaheditData","KatBarang"), 843, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(885, 144, true);
            WriteLiteral(" class=\"btn btn-primary bottom-buffer\" id=\"btn-add-databarang\" style=\"float:right;\"><i class=\"fa fa-plus\"></i> Kategori Barang</a>\r\n    </div>\r\n");
            EndContext();
#line 27 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
     if (TempData["alert"] != null)
    {

#line default
#line hidden
            BeginContext(1073, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1081, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2e39dcd1583d9c3c6f331a38924118febb59547041", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1151, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1161, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2e39dcd1583d9c3c6f331a38924118febb59548229", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1235, 54, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"Hapus Data!!\", \"");
            EndContext();
            BeginContext(1290, 17, false);
#line 32 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
                             Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(1307, 33, true);
            WriteLiteral("\", \"error\");\r\n        </script>\r\n");
            EndContext();
#line 34 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1347, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 35 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
     if (TempData["success"] != null)
    {

#line default
#line hidden
            BeginContext(1393, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1401, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2e39dcd1583d9c3c6f331a38924118febb595410380", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1471, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1481, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2e39dcd1583d9c3c6f331a38924118febb595411569", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1555, 50, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"Berhasil\", \"");
            EndContext();
            BeginContext(1606, 17, false);
#line 40 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
                         Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(1623, 35, true);
            WriteLiteral("\", \"success\");\r\n        </script>\r\n");
            EndContext();
#line 42 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1665, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 43 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
     if (TempData["error"] != null)
    {

#line default
#line hidden
            BeginContext(1709, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1717, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2e39dcd1583d9c3c6f331a38924118febb595413713", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1787, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1797, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2e39dcd1583d9c3c6f331a38924118febb595414902", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1871, 47, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"ERROR\", \"");
            EndContext();
            BeginContext(1919, 17, false);
#line 48 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
                      Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(1936, 33, true);
            WriteLiteral("\", \"error\");\r\n        </script>\r\n");
            EndContext();
#line 50 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1976, 796, true);
            WriteLiteral(@"    <div class=""block-content block-content-full"">
        <!-- DataTables functionality is initialized with .js-dataTable-full-pagination class in js/pages/be_tables_datatables.min.js which was auto compiled from _es6/pages/be_tables_datatables.js -->
        <table class=""table table-bordered table-striped table-vcenter js-dataTable-full-pagination"">
            <thead>
                <tr>
                    <th>ID tenant</th>
                    <th>Nama Kategori</th>
                    <th class=""d-none d-sm-table-cell"" style=""width: 15%;"">Nama Tenant</th>
                    <th class=""text-center"" style=""width: 15%;"">EDIT</th>
                    <th class=""text-center"" style=""width: 15%;"">DELETE</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 64 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
                 foreach (var item in Model)
                   
                {

#line default
#line hidden
            BeginContext(2858, 64, true);
            WriteLiteral("                <tr>\r\n                    <td class=\"font-w600\">");
            EndContext();
            BeginContext(2923, 13, false);
#line 68 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
                                     Write(item.TenantID);

#line default
#line hidden
            EndContext();
            BeginContext(2936, 49, true);
            WriteLiteral("</td>\r\n                    <td class=\"font-w600\">");
            EndContext();
            BeginContext(2986, 17, false);
#line 69 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
                                     Write(item.NamaKategori);

#line default
#line hidden
            EndContext();
            BeginContext(3003, 62, true);
            WriteLiteral("</td>\r\n                    <td class=\"d-none d-sm-table-cell\">");
            EndContext();
            BeginContext(3066, 22, false);
#line 70 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
                                                  Write(item.Tenant.TenantName);

#line default
#line hidden
            EndContext();
            BeginContext(3088, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(3354, 83, true);
            WriteLiteral("                    <td class=\"d-none d-sm-table-cell\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3437, "\"", 3516, 1);
#line 74 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
WriteAttributeValue("", 3444, Url.Action("TambahEditData", "KatBarang", new { id = item.IdKategori }), 3444, 72, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3517, 184, true);
            WriteLiteral(" class=\"btn btn-alt-primary\"><i class=\"fa fa-pencil text-primary mr-5\">Edit</i></a>\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3701, "\"", 3735, 3);
            WriteAttributeValue("", 3711, "Delete(", 3711, 7, true);
#line 77 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
WriteAttributeValue("", 3718, item.IdKategori, 3718, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 3734, ")", 3734, 1, true);
            EndWriteAttribute();
            BeginContext(3736, 144, true);
            WriteLiteral(" class=\"btn btn-sm btn-secondary m-5\"><i class=\"fa fa-times text-danger mr-5\">Delete</i></a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 80 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\KatBarang\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3899, 64, true);
            WriteLiteral("\r\n            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3980, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3986, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2e39dcd1583d9c3c6f331a38924118febb595421226", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4070, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4076, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2e39dcd1583d9c3c6f331a38924118febb595422482", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4139, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CloudDentist.Models.KatBarang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
