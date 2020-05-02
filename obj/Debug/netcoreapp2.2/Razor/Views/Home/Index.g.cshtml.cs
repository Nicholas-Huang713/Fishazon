#pragma checksum "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "469baa87100728449e8be3f2bf81df4a8db8fa1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"469baa87100728449e8be3f2bf81df4a8db8fa1e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3574e5b3a207d0990152d8097a6b357b05f4e304", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/nickhuang/Documents/projects/Fishazon/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(40, 3614, true);
            WriteLiteral(@"
<div class=""text-center"">
    <div class=""home-title bg-dark"">
            <h2 class=""text-white"">THE PLACE FOR ALL YOUR FISHING NEEDS</h2>
        </div>
    <div class=""carousel-container"">
         <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
            </ol>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <img class=""w-100 carousel-img"" src=""/images/hometitle1.jpg"" alt=""First slide"">
                    <div class=""carousel-caption d-none d-md-block"">
                    <h1>All In One!</h1>
                    <p>This is your one stop shop for all your fishing needs</p>
       ");
            WriteLiteral(@"         </div>
            </div>
            <div class=""carousel-item"">
                 <img class=""w-100 carousel-img"" src=""/images/hometitle2.jpg"" alt=""Second slide"">
            </div>
            <div class=""carousel-item"">
                 <img class=""w-100 carousel-img"" src=""/images/hometitle3.jpg"" alt=""Third slide"">
            </div>
            </div>
            <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </div>
    <div class=""category-container mt-3"">
        <div class=""row"">
            ");
            WriteLiteral(@"<div class=""col-sm-4"">
                <div class=""card home-card"">
                    <a href=""/rods"" ><img class=""card-img-top category-img"" src=""/images/rods.jpg"" alt=""Card image cap""></a>
                    <div class=""card-body"">
                        <h5>Fishing Rods</h5>
                        <p class=""card-text"">Check out our selection of the best rods for all types of fishing. We would love to help!</p>
                    </div>
                </div>
            </div>
            <div class=""col-sm-4"">
                <div class=""card home-card"">
                    <a href=""/reels""><img class=""card-img-top category-img"" src=""/images/reel2.jpg"" alt=""Card image cap""></a>
                    <div class=""card-body"">
                        <h5>Fishing Reels</h5>
                        <p class=""card-text"">Whether you like ocean fishing or fly fishing, we have something that will suit your needs.</p>
                    </div>
                </div>
            </div>
        ");
            WriteLiteral(@"    <div class=""col-sm-4"">
                <div class=""card home-card"">
                    <a href=""/lines""><img class=""card-img-top category-img"" src=""/images/line.jpg"" alt=""Card image cap""></a>
                    <div class=""card-body"">
                        <h5>Fishing Line</h5>
                        <p class=""card-text"">Find the fishing line that suits your needs. (Monofilament, Flourocarbon, Fly Fishing)</p>
                    </div>
                </div>
            </div>
        </div>
    </div> 
</div>


");
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
