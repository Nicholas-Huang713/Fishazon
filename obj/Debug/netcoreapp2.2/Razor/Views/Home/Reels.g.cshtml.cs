#pragma checksum "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Reels.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47f6352b22e631aa79d287682754ba6effd59079"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Reels), @"mvc.1.0.view", @"/Views/Home/Reels.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Reels.cshtml", typeof(AspNetCore.Views_Home_Reels))]
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
#line 1 "/Users/nickhuang/Documents/projects/Fishazon/Views/_ViewImports.cshtml"
using Fishazon;

#line default
#line hidden
#line 2 "/Users/nickhuang/Documents/projects/Fishazon/Views/_ViewImports.cshtml"
using Fishazon.Models;

#line default
#line hidden
#line 1 "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Reels.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f6352b22e631aa79d287682754ba6effd59079", @"/Views/Home/Reels.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3574e5b3a207d0990152d8097a6b357b05f4e304", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Reels : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Reels.cshtml"
  
    ViewData["Title"] = "Reels";

#line default
#line hidden
            BeginContext(71, 686, true);
            WriteLiteral(@"
<div class=""jumbotron reel-title text-white"">
    <h2 class=""mt-4"">Fishing Reels</h2>
    <h3 class=""mb-4"">We got what you need!</h3>
</div>
<div class=""dropdown"">
  <button class=""btn btn-secondary btn-sm dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
    Category
  </button>
  <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
    <a class=""dropdown-item"" href=""/allproducts"">All Products</a>
    <a class=""dropdown-item"" href=""/rods"">Rods</a>
    <a class=""dropdown-item disabled"" href=""#"">Reels</a>
    <a class=""dropdown-item"" href=""/lines"">Line</a>
  </div>
</div>
<div class=""row mt-3"">
");
            EndContext();
#line 22 "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Reels.cshtml"
      
        foreach(var reel in @ViewBag.AllReels)
        {

#line default
#line hidden
            BeginContext(821, 120, true);
            WriteLiteral("            <div class=\"col-sm-3\">\n                <div class=\"card\">\n                    <img class=\"card-img-top mt-3\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 941, "\"", 964, 2);
            WriteAttributeValue("", 947, "/images/", 947, 8, true);
#line 27 "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Reels.cshtml"
WriteAttributeValue("", 955, reel.Img, 955, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(965, 102, true);
            WriteLiteral(" alt=\"Reel\">\n                    <div class=\"card-body\">\n                        <p class=\"card-text\">");
            EndContext();
            BeginContext(1068, 9, false);
#line 29 "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Reels.cshtml"
                                        Write(reel.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1077, 68, true);
            WriteLiteral("</p>\n                        <p class=\"card-text font-weight-bold\">$");
            EndContext();
            BeginContext(1146, 10, false);
#line 30 "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Reels.cshtml"
                                                          Write(reel.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1156, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 31 "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Reels.cshtml"
                         if(Context.Session.GetInt32("id") == null)
                        {

#line default
#line hidden
            BeginContext(1255, 369, true);
            WriteLiteral(@"                            <a href=""/itemregistration"">
                                <button class=""btn btn-outline-dark"" data-toggle=""popover"" title=""Popover title"" data-content=""And here's some amazing content. It's very engaging. Right?"">
                                    Add to Cart
                                </button>
                            </a>
");
            EndContext();
#line 38 "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Reels.cshtml"
                        }
                        else 
                        {
                            

#line default
#line hidden
#line 41 "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Reels.cshtml"
                             if(@ViewBag.ProductNames.Contains(reel.Name))
                            {

#line default
#line hidden
            BeginContext(1811, 101, true);
            WriteLiteral("                                <button class=\"btn btn-light\" disabled>Item Already In Cart</button>\n");
            EndContext();
#line 44 "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Reels.cshtml"
                            }
                            else 
                            {

#line default
#line hidden
            BeginContext(2006, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2040, "\"", 2071, 2);
            WriteAttributeValue("", 2047, "/addcart/", 2047, 9, true);
#line 47 "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Reels.cshtml"
WriteAttributeValue("", 2056, reel.ProductId, 2056, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2072, 125, true);
            WriteLiteral(">\n                                    <button class=\"btn btn-dark\">Add to Cart</button>\n                                </a>\n");
            EndContext();
#line 50 "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Reels.cshtml"
                            }

#line default
#line hidden
#line 50 "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Reels.cshtml"
                             
                        }

#line default
#line hidden
            BeginContext(2253, 69, true);
            WriteLiteral("                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 55 "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Reels.cshtml"
        }
    

#line default
#line hidden
            BeginContext(2338, 11, true);
            WriteLiteral("    \n</div>");
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