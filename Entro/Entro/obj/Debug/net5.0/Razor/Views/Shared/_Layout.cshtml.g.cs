#pragma checksum "C:\Users\TUF DASH\source\repos\Entro\Entro\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3345a0187c978471827505c36a2cf355095ca3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\TUF DASH\source\repos\Entro\Entro\Views\_ViewImports.cshtml"
using Entro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TUF DASH\source\repos\Entro\Entro\Views\_ViewImports.cshtml"
using Entro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3345a0187c978471827505c36a2cf355095ca3f", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"978389c083d6e6e33e5cabaca45dcd92b1d82ecb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact_bg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("news"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-layout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-layout contineer_page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3345a0187c978471827505c36a2cf355095ca3f4920", async() => {
                WriteLiteral(@"
    <!-- basic -->
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <!-- mobile metas -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""viewport"" content=""initial-scale=1, maximum-scale=1"">
    <!-- site metas -->
    <title>Entro</title>
    <meta name=""keywords""");
                BeginWriteAttribute("content", " content=\"", 400, "\"", 410, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 442, "\"", 452, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 479, "\"", 489, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <!-- fevicon -->
    <link rel=""icon"" href=""images/fevicon.png"" type=""image/gif"" />
    <!-- bootstrap css -->
    <link rel=""stylesheet"" href=""css/bootstrap.min.css"">
    <!-- style css -->
    <link rel=""stylesheet"" href=""css/style.css"">
    <!-- Responsive-->
    <link rel=""stylesheet"" href=""css/responsive.css"">
    <!-- Scrollbar Custom CSS -->
    <link rel=""stylesheet"" href=""css/jquery.mCustomScrollbar.min.css"">
    <!-- Tweaks for older IEs-->
    <link rel=""stylesheet"" href=""https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.css"" media=""screen"">
    <!--[if lt IE 9]>
    <script src=""https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js""></script>
    <script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script><![endif]-->
");
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
            WriteLiteral("\r\n<!-- body -->\r\n\r\n");
#nullable restore
#line 35 "C:\Users\TUF DASH\source\repos\Entro\Entro\Views\Shared\_Layout.cshtml"
 if (ViewBag.Controller == "Home")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3345a0187c978471827505c36a2cf355095ca3f7984", async() => {
                WriteLiteral("\r\n        <!-- loader  -->\r\n        <div class=\"loader_bg\">\r\n            <div class=\"loader\"><img src=\"images/loading.gif\" alt=\"#\" /></div>\r\n        </div>\r\n        ");
#nullable restore
#line 42 "C:\Users\TUF DASH\source\repos\Entro\Entro\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <!--  footer -->\r\n        <footr>\r\n            <div class=\"footer \">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-12\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3345a0187c978471827505c36a2cf355095ca3f8896", async() => {
                    WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <div class=""titlepage"">
                                            <h2>Contact us</h2>
                                        </div>
                                        <div class=""col-md-12"">
                                            <input class=""contactus"" placeholder=""Your Name"" type=""text"" name=""Your Name"">
                                        </div>
                                        <div class=""col-md-12"">
                                            <input class=""contactus"" placeholder=""Your Email"" type=""text"" name=""Your Email"">
                                        </div>
                                        <div class=""col-md-12"">
                                            <input class=""contactus"" placeholder=""Your Phone"" type=""text"" name=""Your Phone"">
                                        </div>
                 ");
                    WriteLiteral(@"                       <div class=""col-md-12"">
                                            <textarea class=""textarea"" placeholder=""Message"" type=""text"" name=""Message""></textarea>
                                        </div>
                                        <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12"">
                                            <button class=""send"">Send</button>
                                        </div>
                                    </div>
                                </div>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"col-md-12 border_top\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3345a0187c978471827505c36a2cf355095ca3f12083", async() => {
                    WriteLiteral(@"
                                <h3>Newsletter</h3>
                                <input class=""newslatter"" placeholder=""ENTER YOUR MAIL"" type=""text"" name="" ENTER YOUR MAIL"">
                                <button class=""submit"">Subscribe</button>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 "">
                            <div class=""row"">
                                <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 "">
                                    <div class=""address"">
                                        <ul class=""loca"">
                                            <li>
                                                <a href=""#""><img src=""icon/loc.png"" alt=""#"" /></a>Locations

                                            <li>

                                                <a href=""#""><img src=""icon/call.png"" alt=""#"" /></a>+12586954775
                                            </li>
                                            <li>
                                                <a href=""#""><img src=""icon/email.png"" alt=""#"" /></a>demo@gmail.com
                                            </li>
                                        </ul>


            ");
                WriteLiteral(@"                        </div>
                                </div>
                                <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 "">
                                    <ul class=""social_link"">
                                        <li><a href=""#""><i class=""fa fa-facebook"" aria-hidden=""true""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-twitter"" aria-hidden=""true""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-linkedin-square"" aria-hidden=""true""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-instagram"" aria-hidden=""true""></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>

                    </div>

                </div>
                <div class=""container"">
                    <div class=""copyright"">

                        <p>Copyright");
                WriteLiteral(@" 2019 All Right Reserved By <a href=""https://html.design/"">Free  html Templates</a></p>
                    </div>
                </div>
            </div>
        </footr>
        <!-- end footer -->
        <!-- Javascript files-->
        <script src=""js/jquery.min.js""></script>
        <script src=""js/popper.min.js""></script>
        <script src=""js/bootstrap.bundle.min.js""></script>
        <script src=""js/jquery-3.0.0.min.js""></script>
        <script src=""js/plugin.js""></script>
        <!-- sidebar -->
        <script src=""js/jquery.mCustomScrollbar.concat.min.js""></script>
        <script src=""js/custom.js""></script>
        <script src=""https:cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.js""></script>




    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 141 "C:\Users\TUF DASH\source\repos\Entro\Entro\Views\Shared\_Layout.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3345a0187c978471827505c36a2cf355095ca3f17715", async() => {
                WriteLiteral("\r\n        <!-- loader  -->\r\n        <div class=\"loader_bg\">\r\n            <div class=\"loader\"><img src=\"images/loading.gif\" alt=\"#\" /></div>\r\n        </div>\r\n        ");
#nullable restore
#line 150 "C:\Users\TUF DASH\source\repos\Entro\Entro\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <!--  footer -->\r\n        <footr>\r\n            <div class=\"footer \">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-12\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3345a0187c978471827505c36a2cf355095ca3f18629", async() => {
                    WriteLiteral("\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 161 "C:\Users\TUF DASH\source\repos\Entro\Entro\Views\Shared\_Layout.cshtml"
                                         if (ViewBag.Name != "Contact")
                                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                        <div class=\"titlepage\">\r\n                                            <h2>Contact us</h2>\r\n                                        </div>\r\n");
#nullable restore
#line 166 "C:\Users\TUF DASH\source\repos\Entro\Entro\Views\Shared\_Layout.cshtml"
                                        }                                        

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                                        <div class=""col-md-12"">
                                            <input class=""contactus"" placeholder=""Your Name"" type=""text"" name=""Your Name"">
                                        </div>
                                        <div class=""col-md-12"">
                                            <input class=""contactus"" placeholder=""Your Email"" type=""text"" name=""Your Email"">
                                        </div>
                                        <div class=""col-md-12"">
                                            <input class=""contactus"" placeholder=""Your Phone"" type=""text"" name=""Your Phone"">
                                        </div>
                                        <div class=""col-md-12"">
                                            <textarea class=""textarea"" placeholder=""Message"" type=""text"" name=""Message""></textarea>
                                        </div>
                                        <div class=""col-xl-12 c");
                    WriteLiteral(@"ol-lg-12 col-md-12 col-sm-12"">
                                            <button class=""send"">Send</button>
                                        </div>
                                    </div>
                                </div>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"col-md-12 border_top\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3345a0187c978471827505c36a2cf355095ca3f22412", async() => {
                    WriteLiteral(@"
                                <h3>Newsletter</h3>
                                <input class=""newslatter"" placeholder=""ENTER YOUR MAIL"" type=""text"" name="" ENTER YOUR MAIL"">
                                <button class=""submit"">Subscribe</button>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 "">
                            <div class=""row"">
                                <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 "">
                                    <div class=""address"">
                                        <ul class=""loca"">
                                            <li>
                                                <a href=""#""><img src=""icon/loc.png"" alt=""#"" /></a>Locations

                                            <li>

                                                <a href=""#""><img src=""icon/call.png"" alt=""#"" /></a>+1231243434
                                            </li>
                                            <li>
                                                <a href=""#""><img src=""icon/email.png"" alt=""#"" /></a>demo@gmail.com
                                            </li>
                                        </ul>


             ");
                WriteLiteral(@"                       </div>
                                </div>
                                <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 "">
                                    <ul class=""social_link"">
                                        <li><a href=""#""><i class=""fa fa-facebook"" aria-hidden=""true""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-twitter"" aria-hidden=""true""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-linkedin"" aria-hidden=""true""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-instagram"" aria-hidden=""true""></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>

                    </div>

                </div>
                <div class=""container"">
                    <div class=""copyright"">

                        <p>Copyright 2019 Al");
                WriteLiteral(@"l Right Reserved By <a href=""https://html.design/"">Free  html Templates</a></p>
                    </div>
                </div>
            </div>
        </footr>
        <!-- end footer -->
        <!-- Javascript files-->
        <script src=""js/jquery.min.js""></script>
        <script src=""js/popper.min.js""></script>
        <script src=""js/bootstrap.bundle.min.js""></script>
        <script src=""js/jquery-3.0.0.min.js""></script>
        <script src=""js/plugin.js""></script>
        <!-- sidebar -->
        <script src=""js/jquery.mCustomScrollbar.concat.min.js""></script>
        <script src=""js/custom.js""></script>
        <script src=""https:cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.js""></script>




    ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 252 "C:\Users\TUF DASH\source\repos\Entro\Entro\Views\Shared\_Layout.cshtml"
}

#line default
#line hidden
#nullable disable
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