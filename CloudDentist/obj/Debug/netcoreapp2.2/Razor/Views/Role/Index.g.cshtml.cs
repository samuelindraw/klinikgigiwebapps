#pragma checksum "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd3fedfac6f67775bb2345e5d104f7c849ec7c01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Index), @"mvc.1.0.view", @"/Views/Role/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Role/Index.cshtml", typeof(AspNetCore.Views_Role_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd3fedfac6f67775bb2345e5d104f7c849ec7c01", @"/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3efe918c13658fae758fbc71970ee80ead3ba85", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CloudDentist.Models.UserRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("css-main"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/codebase.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/sweetalert2/sweetalert2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/sweetalert2/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/jquery-validation/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(138, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(140, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dd3fedfac6f67775bb2345e5d104f7c849ec7c016049", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(214, 264, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    function Delete(Id, roleID) {
            
            alertify.confirm('Data Kategori','Apakah anda yakin untuk menghapus data ini ?!', function (e) {
                if (e) {
                    window.location.href = '");
            EndContext();
            BeginContext(479, 27, false);
#line 13 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
                                       Write(Url.Action("Delete","Role"));

#line default
#line hidden
            EndContext();
            BeginContext(506, 387, true);
            WriteLiteral(@"/' + Id,roleID;
                }
                else {
                     alertify.error(""You've clicked Cancel"");
                }
            }, null);

        }

</script>
<!-- Dynamic Table Full Pagination -->
<div class=""block"">
    <div class=""block-header block-header-default"">
        <h3 class=""block-title"">List Role <small>Add Role</small></h3>
        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 893, "\"", 936, 1);
#line 27 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
WriteAttributeValue("", 900, Url.Action("TambaheditData","Role"), 900, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(937, 133, true);
            WriteLiteral(" class=\"btn btn-primary bottom-buffer\" id=\"btn-add-role\" style=\"float:right;\"><i class=\"fa fa-plus\"></i>Tambah Role</a>\r\n    </div>\r\n");
            EndContext();
#line 29 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
     if (TempData["alert"] != null)
    {

#line default
#line hidden
            BeginContext(1114, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1122, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3fedfac6f67775bb2345e5d104f7c849ec7c019249", async() => {
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
            BeginContext(1192, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1202, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3fedfac6f67775bb2345e5d104f7c849ec7c0110437", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1276, 54, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"Hapus Data!!\", \"");
            EndContext();
            BeginContext(1331, 17, false);
#line 34 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
                             Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(1348, 33, true);
            WriteLiteral("\", \"error\");\r\n        </script>\r\n");
            EndContext();
#line 36 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1388, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 37 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
     if (TempData["success"] != null)
    {

#line default
#line hidden
            BeginContext(1434, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1442, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3fedfac6f67775bb2345e5d104f7c849ec7c0112574", async() => {
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
            BeginContext(1512, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1522, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3fedfac6f67775bb2345e5d104f7c849ec7c0113763", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1596, 50, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"Berhasil\", \"");
            EndContext();
            BeginContext(1647, 17, false);
#line 42 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
                         Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(1664, 35, true);
            WriteLiteral("\", \"success\");\r\n        </script>\r\n");
            EndContext();
#line 44 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1706, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 45 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
     if (TempData["error"] != null)
    {

#line default
#line hidden
            BeginContext(1750, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1758, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3fedfac6f67775bb2345e5d104f7c849ec7c0115892", async() => {
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
            BeginContext(1828, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1838, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3fedfac6f67775bb2345e5d104f7c849ec7c0117081", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1912, 47, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"ERROR\", \"");
            EndContext();
            BeginContext(1960, 17, false);
#line 50 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
                      Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(1977, 33, true);
            WriteLiteral("\", \"error\");\r\n        </script>\r\n");
            EndContext();
#line 52 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2017, 717, true);
            WriteLiteral(@"    <div class=""block-content block-content-full"">
        <!-- DataTables functionality is initialized with .js-dataTable-full-pagination class in js/pages/be_tables_datatables.min.js which was auto compiled from _es6/pages/be_tables_datatables.js -->
        <table class=""table table-bordered table-striped table-vcenter js-dataTable-full-pagination"">
            <thead>
                <tr>
                    <th>Role ID</th>
                    <th>RoleName</th>
                    <th class=""d-none d-sm-table-cell"" style=""width: 15%;"">Edit Role</th>
                    <th class=""text-center"" style=""width: 15%;"">Delete Role</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 65 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2799, 72, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"font-w600\">");
            EndContext();
            BeginContext(2872, 11, false);
#line 68 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
                                         Write(item.roleID);

#line default
#line hidden
            EndContext();
            BeginContext(2883, 53, true);
            WriteLiteral("</td>\r\n                        <td class=\"font-w600\">");
            EndContext();
            BeginContext(2937, 13, false);
#line 69 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
                                         Write(item.RoleName);

#line default
#line hidden
            EndContext();
            BeginContext(2950, 85, true);
            WriteLiteral("</td>\r\n                        <td class=\"font-w600\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3035, "\"", 3113, 1);
#line 71 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
WriteAttributeValue("", 3042, Url.Action("TambahEditData", "Role", new { roleName = item.RoleName }), 3042, 71, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3114, 196, true);
            WriteLiteral(" class=\"btn btn-alt-primary\"><i class=\"fa fa-pencil text-primary mr-5\">Edit</i></a>\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3310, "\"", 3367, 6);
            WriteAttributeValue("", 3320, "Delete(\'", 3320, 8, true);
#line 74 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
WriteAttributeValue("", 3328, item.RoleName, 3328, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 3342, "\',roleID", 3342, 8, true);
            WriteAttributeValue(" ", 3350, "=\'", 3351, 3, true);
#line 74 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
WriteAttributeValue("", 3353, item.roleID, 3353, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 3365, "\')", 3365, 2, true);
            EndWriteAttribute();
            BeginContext(3368, 152, true);
            WriteLiteral(" class=\"btn btn-sm btn-secondary m-5\"><i class=\"fa fa-times text-danger mr-5\">Delete</i></a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 77 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Role\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3539, 64, true);
            WriteLiteral("\r\n            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3620, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3626, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3fedfac6f67775bb2345e5d104f7c849ec7c0123067", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3710, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3716, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3fedfac6f67775bb2345e5d104f7c849ec7c0124323", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3779, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(3784, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CloudDentist.Models.UserRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591