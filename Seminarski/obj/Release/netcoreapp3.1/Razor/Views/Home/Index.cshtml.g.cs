#pragma checksum "C:\Users\Hatidza\Desktop\Seminarski\Seminarski\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09c245423b1bc94b360f35f4def8637a3fbce540"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Hatidza\Desktop\Seminarski\Seminarski\Views\_ViewImports.cshtml"
using Seminarski;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hatidza\Desktop\Seminarski\Seminarski\Views\_ViewImports.cshtml"
using Seminarski.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09c245423b1bc94b360f35f4def8637a3fbce540", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29373fa5dcd9488fa73008eea85032f56686b21", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Hatidza\Desktop\Seminarski\Seminarski\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09c245423b1bc94b360f35f4def8637a3fbce5403270", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""2000"" data-pause=""hover"">
            <!-- Indicators -->
            <ol class=""carousel-indicators"">
                <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#myCarousel"" data-slide-to=""1""></li>
                <li data-target=""#myCarousel"" data-slide-to=""2""></li>
            </ol>
            <!-- Wrapper for slides -->
            <div class=""carousel-inner"" role=""listbox"">
                <div class=""item active"">
                    <div class=""carousel-content"">
                        <div style=""margin: 0 auto"">

                            <p >
                                <img src=""https://images.wallpaperscraft.com/image/single/stones_candles_aromatherapy_spa_water_bamboo_massage_67321_1600x900.jpg""
                                    style=""height:100%;max-height:100%;max-width:100%"" />
              ");
                WriteLiteral(@"              </p>
                        </div>
                    </div>
                </div>
                <div class=""item"">
                    <div class=""carousel-content"">
                        <div style=""margin: 0 auto"">

                            <p >
                                <img src=""https://image.dnevnik.hr/media/images/1920x1080/Mar2018/61479569-tb-make-up-beauty-studio-sminkanje.jpg"" 
                                     style=""height:100%;max-height:100%;max-width:100%""/>
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""item"">
                    <div class=""carousel-content"">
                        <div style=""margin: 0 auto"">

                            <p>
                                <img src=""https://wallpapercave.com/wp/wp6771310.jpg"" 
                                     style=""height:100%;max-height:100%;max-width:100%""/>
                            ");
                WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
            </div>
            <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
                <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
                <span class=""sr-only""> Previous</span>
            </a>
            <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
                <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </div>
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"" />
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css"" />
    <script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script>
    <script type=""text/j");
                WriteLiteral(@"avascript"" src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>
    <style type=""text/css"">
        body {
            background-color: #343a40;
        }
        .carousel-control {
            border-radius: 30px;
        }
        .carousel-inner {
            border-radius:30px;
            width: auto;
            height: 80%;
            max-height: 80% !important;
        }
        .carouselpicture {
            width: 100%;
            height: 80%;
            max-height: 80% !important;
        }
        .carousel-content {
            color: black;
            display: flex;
            text-align: center;
        }
    </style>
    <script type=""text/javascript"">
        $(document).ready(function () {
            $('.carousel').carousel();
        });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
