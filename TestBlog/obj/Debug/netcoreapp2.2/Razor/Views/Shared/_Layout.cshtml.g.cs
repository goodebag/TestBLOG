#pragma checksum "C:\Users\Mr-Goodebag\source\repos\TestBlog\TestBlog\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "348c68284c16d493e1062b0d916d575ade3dcb98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\Mr-Goodebag\source\repos\TestBlog\TestBlog\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Mr-Goodebag\source\repos\TestBlog\TestBlog\Views\_ViewImports.cshtml"
using TestBlog;

#line default
#line hidden
#line 3 "C:\Users\Mr-Goodebag\source\repos\TestBlog\TestBlog\Views\_ViewImports.cshtml"
using TestBlog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"348c68284c16d493e1062b0d916d575ade3dcb98", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"200570f8329e9a7563849a8645097947e8216aec", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/twitter-bootstrap/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/twitter-bootstrap/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOutAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminLogIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminSignUP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetPostByHeadline", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(145, 28, true);
            WriteLiteral("\r\n\r\n<html class=\"no-js\">\r\n\r\n");
            EndContext();
            BeginContext(173, 609, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348c68284c16d493e1062b0d916d575ade3dcb987983", async() => {
                BeginContext(179, 447, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <title> NewsLane : Home of Infomation</title>
    <meta name=""description"" content="""">
    <meta name=""viewport"" content=""width=device-width"">

    <!-- xxx Favicons xxx -->
    <!-- xxx Base Stylesheet xxx -->
    <script src=""js/modernizr-2.6.2.min.js""></script>

    <link rel=""stylesheet"" media=""screen"" href=""/css/base.css"" />
    ");
                EndContext();
                BeginContext(626, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348c68284c16d493e1062b0d916d575ade3dcb988832", async() => {
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
                BeginContext(689, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(695, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "348c68284c16d493e1062b0d916d575ade3dcb9810085", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                BeginContext(769, 6, true);
                WriteLiteral("\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(782, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(786, 7189, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348c68284c16d493e1062b0d916d575ade3dcb9812227", async() => {
                BeginContext(792, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(798, 284, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348c68284c16d493e1062b0d916d575ade3dcb9812614", async() => {
                    BeginContext(817, 258, true);
                    WriteLiteral(@"

        <!-- xxx Loader Start xxx -->
        <div id=""pageloader"">
            <div class=""loader-item"">
                <img src=""/images/preloader.gif"" alt='loader' />
                <div>Loading...</div>
            </div>
        </div>
    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1082, 3290, true);
                WriteLiteral(@"
    <!-- xxx End xxx -->
    <!-- xxx Header Start xxx -->
    <header>
        <div class=""top-bar"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-sm-6"">
                        A Bright Sunny Day Or Some Line Of Text
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""social-icons"">
                            <ul>
                                <li><a href=""#"" data-toggle=""tooltip"" title="""" data-original-title=""Twitter""><i class=""fa fa-twitter""></i></a></li>
                                <li><a href=""#"" data-toggle=""tooltip"" title="""" data-original-title=""Facebook""><i class=""fa fa-facebook""></i></a></li>
                                <li><a href=""#"" data-toggle=""tooltip"" title="""" data-original-title=""Pinterest""><i class=""fa fa-pinterest""></i></a></li>
                                <li><a href=""#"" data-toggle=""tooltip"" title="""" data-original-title=""Google Plus""><i class=""f");
                WriteLiteral(@"a fa-google-plus""></i></a></li>
                                <li>
                                    <div class=""box-search"">
                                        <input class=""search-input"" type=""search"" placeholder=""Search"" />
                                        <div class=""icon""></div>
                                    </div>
                                    <a href=""#"" class=""icon""><i class=""fa fa-search""></i></a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div id=""nav-wrap"">
            <div class=""container"">
                <div id=""menuzord"" class=""menuzord red pull-left"">
                    <a href=""javascript:void(0)"" class=""menuzord-brand""><img src=""/images/logo.png"" alt=""Ruaha Logo""></a>
                    <ul class=""menuzord-menu"">
                        <li><a href=""/"">Home</a></li>
                        <");
                WriteLiteral(@"li>
                            <a href=""#"">news</a>
                            <ul class=""dropdown"">
                                <li><a href=""/home/GetPostByDiscription/2"">Sports</a></li>
                                <li><a href=""/home/GetPostByDiscription/1"">Entertainment</a></li>
                                <li><a href=""/home/GetPostByDiscription/3"">Travels</a></li>
                                <li><a href=""/home/GetPostByDiscription/4"">LifeStyle</a></li>
                                <li><a href=""/home/GetPostByDiscription/5"">Jobs</a></li>
                                <li><a href=""/home/GetPostByDiscription/6"">Movies</a></li>
                                <li><a href=""/home/GetPostByDiscription/7"">Music</a></li>
                            </ul>
                        </li>
                        <li>
                            <a href=""#"">Contact Us</a>
                            <ul class=""dropdown"">
                                <li><a href="""">Egbule.goodluck@");
                WriteLiteral("gmail</a></li>\r\n                            </ul>\r\n                        </li>\r\n\r\n                        <li>\r\n                            <a href=\"#\">Admin</a>\r\n                            <ul class=\"dropdown\">\r\n\r\n");
                EndContext();
#line 95 "C:\Users\Mr-Goodebag\source\repos\TestBlog\TestBlog\Views\Shared\_Layout.cshtml"
                                 if (signINmanager.IsSignedIn(User))
                                {

#line default
#line hidden
                BeginContext(4477, 40, true);
                WriteLiteral("                                    <li>");
                EndContext();
                BeginContext(4517, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348c68284c16d493e1062b0d916d575ade3dcb9818137", async() => {
                    BeginContext(4568, 8, true);
                    WriteLiteral("LogOut: ");
                    EndContext();
                    BeginContext(4577, 18, false);
#line 97 "C:\Users\Mr-Goodebag\source\repos\TestBlog\TestBlog\Views\Shared\_Layout.cshtml"
                                                                                              Write(User.Identity.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4599, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 98 "C:\Users\Mr-Goodebag\source\repos\TestBlog\TestBlog\Views\Shared\_Layout.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(4714, 40, true);
                WriteLiteral("                                    <li>");
                EndContext();
                BeginContext(4754, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348c68284c16d493e1062b0d916d575ade3dcb9820535", async() => {
                    BeginContext(4804, 5, true);
                    WriteLiteral("Login");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4813, 47, true);
                WriteLiteral("</li>\r\n                                    <li>");
                EndContext();
                BeginContext(4860, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348c68284c16d493e1062b0d916d575ade3dcb9822255", async() => {
                    BeginContext(4911, 6, true);
                    WriteLiteral("SignUp");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4921, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 103 "C:\Users\Mr-Goodebag\source\repos\TestBlog\TestBlog\Views\Shared\_Layout.cshtml"
                                }

#line default
#line hidden
                BeginContext(4963, 66, true);
                WriteLiteral("                            </ul>\r\n                        </li>\r\n");
                EndContext();
#line 106 "C:\Users\Mr-Goodebag\source\repos\TestBlog\TestBlog\Views\Shared\_Layout.cshtml"
                         if (signINmanager.IsSignedIn(User))
                        {

#line default
#line hidden
                BeginContext(5118, 32, true);
                WriteLiteral("                            <li>");
                EndContext();
                BeginContext(5150, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348c68284c16d493e1062b0d916d575ade3dcb9824635", async() => {
                    BeginContext(5195, 9, true);
                    WriteLiteral("Post News");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5208, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 109 "C:\Users\Mr-Goodebag\source\repos\TestBlog\TestBlog\Views\Shared\_Layout.cshtml"
                        }

#line default
#line hidden
                BeginContext(5242, 163, true);
                WriteLiteral("                        <li>\r\n                            <a>\r\n                                <div class=\"search-container\">\r\n                                    ");
                EndContext();
                BeginContext(5405, 311, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348c68284c16d493e1062b0d916d575ade3dcb9826755", async() => {
                    BeginContext(5478, 231, true);
                    WriteLiteral("\r\n                                        <input type=\"text\" placeholder=\"Headline of the news..\" name=\"HeadLine\">\r\n                                        <button type=\"submit\">Submit</button>\r\n                                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5716, 388, true);
                WriteLiteral(@"
                                </div>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>

        <div class=""clearfix""></div>

    </header>

    <!-- xxx Header End xxx -->


    <div class=""col-sm-12""style=""float:unset"">
            <main role=""main"" "">
                ");
                EndContext();
                BeginContext(6105, 12, false);
#line 134 "C:\Users\Mr-Goodebag\source\repos\TestBlog\TestBlog\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(6117, 37, true);
                WriteLiteral("\r\n            </main>\r\n    </div>\r\n\r\n");
                EndContext();
#line 138 "C:\Users\Mr-Goodebag\source\repos\TestBlog\TestBlog\Views\Shared\_Layout.cshtml"
     if (IsSectionDefined("Scripts"))
    {

#line default
#line hidden
                BeginContext(6201, 41, false);
#line 140 "C:\Users\Mr-Goodebag\source\repos\TestBlog\TestBlog\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
#line 140 "C:\Users\Mr-Goodebag\source\repos\TestBlog\TestBlog\Views\Shared\_Layout.cshtml"
                                          }

#line default
#line hidden
                BeginContext(6245, 1723, true);
                WriteLiteral(@"    <!-- xxx Footer End xxx -->
    <!-- xxx Back To Top xxx -->
    <div id=""back-top"">
        <a class=""/img-circle"" href=""#top"">
            <i class=""fa fa-angle-up""></i>
        </a>
    </div>
    <footer>
        <div class=""footer-inner menuzord red "" style=""left: 0;
                                      bottom: 0;
                                      width: 100%;
                                      background-color: red;
                                      color: white;"">
            <div class=""copyright"">
                <p class=""text-center"">© 2020 - All Rights Reserved.|&copy 2020 - NewsLane INC </p>
            </div>
        </div>
    </footer>




    <!-- xxx End xxx -->
    <!-- xxx Footer xxx -->
    <!-- xxx Footer End xxx -->
    <!-- xxx Style Switcher (Only For Demo) xxx -->
    <!-- JQuery Plugins-->
    <script type=""text/javascript"" src=""/js/jquery-min.js""></script>
    <script type=""text/javascript"" src=""/js/bootstrap.min.js""></script>
    <scrip");
                WriteLiteral(@"t type='text/javascript' src=""/js/menuzord.js""></script>
    <script type=""text/javascript"" src=""/js/jquery.cookie.js""></script>
    <script type=""text/javascript"" src=""/js/owl.carousel.min.js""></script>
    <script type='text/javascript' src=""/js/jflickrfeed.min.js""></script>
    <script type='text/javascript' src=""/js/jquery.fancybox.js""></script>
    <script type='text/javascript' src=""/js/jquery.validate.min.js""></script>
    <script type='text/javascript' src=""/twitter/jquery.tweet.js""></script>

    <!-- JQuery Map Plugin -->

    <script type=""text/javascript"" src=""/js/jquery.gmap.min.js""></script>

    <script type='text/javascript' src=""/js/site-custom.js""></script>

");
                EndContext();
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
            EndContext();
            BeginContext(7975, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser > signINmanager { get; private set; }
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
