#pragma checksum "D:\GIT\FUCT\SU21\PRN211\projectFolder\ThongTinYTe\Views\Case\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33a2aac8737697b1fbed20c4dfbfd105cc672761"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Case_Index), @"mvc.1.0.view", @"/Views/Case/Index.cshtml")]
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
#line 1 "D:\GIT\FUCT\SU21\PRN211\projectFolder\ThongTinYTe\Views\_ViewImports.cshtml"
using ThongTinYTe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GIT\FUCT\SU21\PRN211\projectFolder\ThongTinYTe\Views\_ViewImports.cshtml"
using ThongTinYTe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GIT\FUCT\SU21\PRN211\projectFolder\ThongTinYTe\Views\_ViewImports.cshtml"
using ThongTinYTe.CovidVnServices.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33a2aac8737697b1fbed20c4dfbfd105cc672761", @"/Views/Case/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"902612fe285b0341e1cfe6d531211bca4ed6a5b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Case_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CaseRecord>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\GIT\FUCT\SU21\PRN211\projectFolder\ThongTinYTe\Views\Case\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\GIT\FUCT\SU21\PRN211\projectFolder\ThongTinYTe\Views\Case\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 8 "D:\GIT\FUCT\SU21\PRN211\projectFolder\ThongTinYTe\Views\Case\Index.cshtml"
  Write(item.Patient);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "D:\GIT\FUCT\SU21\PRN211\projectFolder\ThongTinYTe\Views\Case\Index.cshtml"
                Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 9 "D:\GIT\FUCT\SU21\PRN211\projectFolder\ThongTinYTe\Views\Case\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CaseRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591
