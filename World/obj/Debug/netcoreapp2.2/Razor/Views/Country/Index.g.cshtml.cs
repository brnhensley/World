#pragma checksum "/Users/Guest/Desktop/World.Solutions/World/Views/Country/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee8e678052199f71c9bbddd87ce62a3c5aa14a9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Country_Index), @"mvc.1.0.view", @"/Views/Country/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Country/Index.cshtml", typeof(AspNetCore.Views_Country_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee8e678052199f71c9bbddd87ce62a3c5aa14a9d", @"/Views/Country/Index.cshtml")]
    public class Views_Country_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 29, true);
            WriteLiteral("<h1>The World App</h1>\n\n<ul>\n");
            EndContext();
#line 4 "/Users/Guest/Desktop/World.Solutions/World/Views/Country/Index.cshtml"
 foreach (var country in Model)
{

#line default
#line hidden
            BeginContext(63, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(70, 12, false);
#line 6 "/Users/Guest/Desktop/World.Solutions/World/Views/Country/Index.cshtml"
 Write(country.Name);

#line default
#line hidden
            EndContext();
            BeginContext(82, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/World.Solutions/World/Views/Country/Index.cshtml"
}

#line default
#line hidden
            BeginContext(90, 6, true);
            WriteLiteral("</ul>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
