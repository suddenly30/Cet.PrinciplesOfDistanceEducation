#pragma checksum "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5638c27ccba6a2b25d50c050a2b5e0bd389d8fb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Video_Watch), @"mvc.1.0.view", @"/Views/Video/Watch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Video/Watch.cshtml", typeof(AspNetCore.Views_Video_Watch))]
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
#line 3 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
using Cet.PrinciplesOfDistanceEducation.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5638c27ccba6a2b25d50c050a2b5e0bd389d8fb3", @"/Views/Video/Watch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6ee8b2b58927bef2bf9ced226a503063f6eccc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Video_Watch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bundle<WatchVideoModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "video", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_VideoFeed.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(114, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
  
    var user = userService.GetCurrentUser(User);
    if (user != null)
    {
        Model.User = new UserViewModel
        {
            UserName = user.UserName,
            FirstName = user.FirstName,
            LastName = user.LastName,
            AvatarUrl = user.AvatarUrl,
            Email = user.Email,
            UserRoles = userService.GetUserRoles(user.UserName).ToList()
        };
    }

#line default
#line hidden
            BeginContext(540, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
 if (Model.PageModel.Video != null)
{

#line default
#line hidden
            BeginContext(582, 698, true);
            WriteLiteral(@"<link href=""https://vjs.zencdn.net/7.1.0/video-js.css"" rel=""stylesheet"">
<script src=""https://vjs.zencdn.net/ie8/ie8-version/videojs-ie8.min.js""></script>
<div id=""alertable"" style=""margin:0 30px;""></div>
<div id=""columns"">
    <div id=""first"" class=""col-md-8"">
        <div id=""first-inner"">
            <div id=""player"">
                <div id=""player-container-outer"">
                    <div id=""player-container-inner"">
                        <div id=""player-container"" role=""complementary"">
                            <div class=""html5-player"">

                                <video tabindex=""-1"" id=""my-video"" class=""video-js video html5-main-video"" controls preload=""auto""");
            EndContext();
            BeginWriteAttribute("poster", "\r\n                                       poster=\"", 1280, "\"", 1364, 1);
#line 38 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
WriteAttributeValue("", 1329, Model.PageModel.Video.ThumbnailUrl, 1329, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1365, 62, true);
            WriteLiteral(" data-setup=\"{}\">\r\n                                    <source");
            EndContext();
            BeginWriteAttribute("src", "  src=\"", 1427, "\"", 1465, 1);
#line 39 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
WriteAttributeValue("", 1434, Model.PageModel.Video.VideoUrl, 1434, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1466, 815, true);
            WriteLiteral(@" type=""video/mp4"" />
                                    <p class=""vjs-no-js"">
                                        To view this video please enable JavaScript, and consider upgrading to a web browser that
                                        <a href=""https://videojs.com/html5-video-support/"" target=""_blank"">supports HTML5 video</a>
                                    </p>
                                </video>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div id=""info"">
                <div id=""info-contents"">
                    <div id=""container"" class=""video-info"">
                        <h1 class=""title video-info"">
                            <span class=""title video-info"">");
            EndContext();
            BeginContext(2282, 27, false);
#line 54 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
                                                      Write(Model.PageModel.Video.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2309, 153, true);
            WriteLiteral("</span>\r\n                        </h1>\r\n                        <div id=\"info\" class=\"video-info\">\r\n                            <span class=\"view-count\">");
            EndContext();
            BeginContext(2463, 31, false);
#line 57 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
                                                Write(Model.PageModel.Video.ViewCount);

#line default
#line hidden
            EndContext();
            BeginContext(2494, 75, true);
            WriteLiteral(" Views</span>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 60 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
                     if (Model.User != null && Model.User.IsAuthorized)
                    {

#line default
#line hidden
            BeginContext(2665, 223, true);
            WriteLiteral("                        <div id=\"container-buttons\" class=\"video-buttons\">\r\n                            <a class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#removeModal\">Remove Video</a>\r\n                            ");
            EndContext();
            BeginContext(2888, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c80d678700d24aca992f1bf09d76e9e5", async() => {
                BeginContext(3000, 10, true);
                WriteLiteral("Edit Video");
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
#line 64 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
                                                                             WriteLiteral(Model.PageModel.Video.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["video"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-video", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["video"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3014, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
            BeginContext(3074, 1398, true);
            WriteLiteral(@"                        <!-- Modal -->
                        <div class=""modal fade"" id=""removeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""removeModalLabel"" aria-hidden=""true"">
                            <div class=""modal-dialog"" role=""document"">
                                <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"" id=""removeModalLabel"">Remove Video</h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal-body"">
                                    Are you sure that you'd like to remove this video?
                                </div>
                                <div class=""modal-footer"">
                 ");
            WriteLiteral(@"                   <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                    <button type=""button"" class=""btn btn-danger"" id=""remove-video"">Remove Video</button>
                                </div>
                                </div>
                            </div>
                        </div>
");
            EndContext();
            BeginContext(4474, 54, true);
            WriteLiteral("                        <div class=\"clearfix\"></div>\r\n");
            EndContext();
#line 89 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
                    }

#line default
#line hidden
            BeginContext(4551, 602, true);
            WriteLiteral(@"                </div>
            </div>
            <div id=""meta"">
                <div id=""meta-contents"">
                    <div id=""video-secondary-info-renderer"" class=""video-secondary-info"">
                        <div id=""container"">
                            <div id=""top-row"" class=""video-secondary-info"">
                                <div id=""video-owner"" class=""video-secondary-info"">
                                    <a class=""video-owner"">
                                        <div id=""avatar"" class=""video-owner"">
                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5153, "\"", 5202, 1);
#line 100 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
WriteAttributeValue("", 5159, Model.PageModel.Video.CreateUser.AvatarUrl, 5159, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5203, 408, true);
            WriteLiteral(@" class=""img-circle"" />
                                        </div>
                                    </a>
                                    <div id=""upload-info"" class=""video-owner"">
                                        <div id=""owner-container"" class=""video-owner"">
                                            <div id=""owner-name"">
                                                <a href="""">");
            EndContext();
            BeginContext(5612, 41, false);
#line 106 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
                                                      Write(Model.PageModel.Video.CreateUser.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(5653, 199, true);
            WriteLiteral("</a>\r\n                                            </div>\r\n                                        </div>\r\n                                        <span class=\"date video-secondary-info\">Published on ");
            EndContext();
            BeginContext(5853, 58, false);
#line 109 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
                                                                                        Write(Model.PageModel.Video.CreatedDate.ToString("MMM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(5911, 345, true);
            WriteLiteral(@"</span>
                                    </div>
                                </div>                
                            </div>
                            <div class=""video-secondary-info video-detail-info"">
                                    <div>
                                        <span><strong>Group Name:</strong> ");
            EndContext();
            BeginContext(6257, 31, false);
#line 115 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
                                                                      Write(Model.PageModel.Video.GroupName);

#line default
#line hidden
            EndContext();
            BeginContext(6288, 135, true);
            WriteLiteral("</span>\r\n                                    </div>\r\n                                    <div>\r\n                                       ");
            EndContext();
            BeginContext(6424, 44, false);
#line 118 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
                                  Write(Html.Raw(@Model.PageModel.Video.Description));

#line default
#line hidden
            EndContext();
            BeginContext(6468, 255, true);
            WriteLiteral("\r\n                                    </div>\r\n                            </div> \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div id=\"second\" class=\"col-md-4\">\r\n");
            EndContext();
#line 128 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
          
            var feedModel = new VideoFeedViewModel();
            feedModel.Videos = Model.PageModel.VideosFromTheSameYear;
            feedModel.Title = "Recommended Videos";
            feedModel.IsFlex = true;
        

#line default
#line hidden
            BeginContext(6963, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(6971, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ba966f6355c24b5ea7904a080eff3eb1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 134 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = feedModel;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7040, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(7064, 63, true);
            WriteLiteral("<script src=\"https://vjs.zencdn.net/7.1.0/video.js\"></script>\r\n");
            EndContext();
#line 140 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
 if (Model.User != null && Model.User.IsAuthorized)
{

#line default
#line hidden
            BeginContext(7185, 142, true);
            WriteLiteral("    <script>\r\n        $(\'#remove-video\').on(\'click\', function() {\r\n            $.ajax({\r\n                url: \'/cet441demo/video/remove?video=");
            EndContext();
            BeginContext(7328, 24, false);
#line 145 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
                                                Write(Model.PageModel.Video.Id);

#line default
#line hidden
            EndContext();
            BeginContext(7352, 1122, true);
            WriteLiteral(@"',
                type: 'DELETE'
            })
            .done(function() {
                $('#columns').html('');
                $('#alertable').html(`
                                    <div id=""remove-success"" style=""display:none;"" class=""alert alert-success"">
                                        <strong>Successful!</strong> Video is removed successfully. <a href=""/cet441demo/"" class=""alert-link"">Go to homepage.</a>
                                        </div>`);
                $('#remove-success').slideDown();
            })
            .fail(function() {
                $('#alertable').html(`
                                <div id=""remove-error"" style=""display:none;"" class=""alert alert-danger"">
                                    <strong>Error!</strong> Something went wrong while removing the video.
                                    </div>`);
                $('#remove-error').slideDown();
            })
            .always(function() {
                $('.modal-backdro");
            WriteLiteral("p\').remove();\r\n                $(\'body\').css(\'\');\r\n            });\r\n\r\n        });\r\n    </script>\r\n");
            EndContext();
#line 170 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
}

#line default
#line hidden
#line 170 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
 

}
else 
{

#line default
#line hidden
            BeginContext(8492, 90, true);
            WriteLiteral("    <div class=\"alert alert-warning\" style=\"margin: 0 30px;\">    \r\n        No such video. ");
            EndContext();
            BeginContext(8582, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7ebb70a4018482795e5dd3187d5d6d7", async() => {
                BeginContext(8645, 15, true);
                WriteLiteral("Go to homepage.");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8664, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 178 "D:\Süleyman\dotnetcore\Cet444Project\Cet.PrinciplesOfDistanceEducation\Cet.PrinciplesOfDistanceEducation\Views\Video\Watch.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICetUser userService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bundle<WatchVideoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
