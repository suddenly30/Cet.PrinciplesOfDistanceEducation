#pragma checksum "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "851383002044dd63eb38d2b179a5d3c9c39530da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__VideoFeed), @"mvc.1.0.view", @"/Views/Shared/_VideoFeed.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_VideoFeed.cshtml", typeof(AspNetCore.Views_Shared__VideoFeed))]
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
#line 1 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\_ViewImports.cshtml"
using Cet.PrinciplesOfDistanceEducation;

#line default
#line hidden
#line 2 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\_ViewImports.cshtml"
using Cet.PrinciplesOfDistanceEducation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"851383002044dd63eb38d2b179a5d3c9c39530da", @"/Views/Shared/_VideoFeed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6ee8b2b58927bef2bf9ced226a503063f6eccc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__VideoFeed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VideoFeedViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "watch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "video", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
 if (Model.Videos != null && Model.Videos.Length > 0)
{

#line default
#line hidden
            BeginContext(87, 174, true);
            WriteLiteral("    <div id=\"video-content-container\">\r\n        <div class=\"subheader\">\r\n            <div id=\"title-container\">\r\n                <h2 class=\"list-title\">\r\n                    ");
            EndContext();
            BeginContext(262, 11, false);
#line 9 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(273, 129, true);
            WriteLiteral("\r\n                </h2>\r\n            </div>\r\n        </div>\r\n        <div id=\"contents\">\r\n            <div class=\"video-items\">\r\n");
            EndContext();
#line 15 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
                 foreach (var video in Model.Videos)
                {

#line default
#line hidden
            BeginContext(475, 24, true);
            WriteLiteral("                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 499, "\"", 513, 1);
#line 17 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
WriteAttributeValue("", 504, video.Id, 504, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 514, "\"", 595, 2);
            WriteAttributeValue("", 522, "video-item", 522, 10, true);
#line 17 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
WriteAttributeValue("", 532, Model.IsFlex == true ? " flex-item-container" : string.Empty, 532, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(596, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(623, 1376, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7e6c8655dbf4fe2be0135bad235c8dc", async() => {
                BeginContext(773, 98, true);
                WriteLiteral("\r\n                            <div class=\"video-item-thumb\">\r\n                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 871, "\"", 896, 1);
#line 20 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
WriteAttributeValue("", 877, video.ThumbnailUrl, 877, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(897, 109, true);
                WriteLiteral(" />\r\n                                <div class=\"video-duration\">\r\n                                    <span>");
                EndContext();
                BeginContext(1007, 14, false);
#line 22 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
                                     Write(video.Duration);

#line default
#line hidden
                EndContext();
                BeginContext(1021, 246, true);
                WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"video-item-details\">\r\n                                <h3 class=\"video-item-title\">\r\n                                    ");
                EndContext();
                BeginContext(1268, 11, false);
#line 27 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
                               Write(video.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1279, 187, true);
                WriteLiteral("\r\n                                </h3>\r\n                                <div class=\"video-item-createuser-line\">\r\n                                    <span class=\"video-item-createuser\">");
                EndContext();
                BeginContext(1467, 25, false);
#line 30 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
                                                                   Write(video.CreateUser.FullName);

#line default
#line hidden
                EndContext();
                BeginContext(1492, 158, true);
                WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"video-item-metadata\">\r\n                                    <span>");
                EndContext();
                BeginContext(1651, 15, false);
#line 33 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
                                     Write(video.ViewCount);

#line default
#line hidden
                EndContext();
                BeginContext(1666, 15, true);
                WriteLiteral(" views</span>\r\n");
                EndContext();
#line 34 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
                                     if (!Model.IsFlex)
                                    {

#line default
#line hidden
                BeginContext(1777, 46, true);
                WriteLiteral("                                        <span>");
                EndContext();
                BeginContext(1824, 23, false);
#line 36 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
                                         Write(video.CreatedDateString);

#line default
#line hidden
                EndContext();
                BeginContext(1847, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 37 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
                                    }

#line default
#line hidden
                BeginContext(1895, 100, true);
                WriteLiteral("                                </div>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-video", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
                                                                          WriteLiteral(video.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["video"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-video", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["video"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 703, "video-item-link", 703, 15, true);
#line 18 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
AddHtmlAttributeValue("", 718, Model.IsFlex == true ? " flex-item" : string.Empty, 718, 53, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1999, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 42 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
                }

#line default
#line hidden
            BeginContext(2048, 94, true);
            WriteLiteral("                <div class=\"clearfix\"></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 47 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Shared\_VideoFeed.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoFeedViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
