#pragma checksum "C:\Users\BoomBakar\source\repos\WebApplication4\Views\Message\MailDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "665a4892719e50b941250ad9e3f43c21ecbd3982"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_MailDetail), @"mvc.1.0.view", @"/Views/Message/MailDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"665a4892719e50b941250ad9e3f43c21ecbd3982", @"/Views/Message/MailDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"766a7fcb2e58901fc156bee11d008cca91b33ffc", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_MailDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Inbox.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Compose", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\BoomBakar\source\repos\WebApplication4\Views\Message\MailDetail.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("InboxFiles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "665a4892719e50b941250ad9e3f43c21ecbd39824529", async() => {
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
                WriteLiteral(@"
    <link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"" />
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
");
                WriteLiteral("    <link href=\"//netdna.bootstrapcdn.com/bootstrap/3.0.3/css/bootstrap.min.css\" rel=\"stylesheet\" id=\"bootstrap-css\">\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("InboxHeader", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <!--header-->
        <div class=""row"" id=""header"">
            <div class=""col"" id=""header-left"">
                <span class=""material-icons""> menu </span>
                <img src=""https://i.pinimg.com/originals/ae/47/fa/ae47fa9a8fd263aa364018517020552d.png""");
                BeginWriteAttribute("alt", "\r\n                     alt=\"", 927, "\"", 955, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
            </div>
            <div class=""col"" id=""header-middle"">
                <span class=""material-icons""> search </span>
                <!--toSEARCH INPUT FLIED-->
                <input type=""text"" placeholder=""Search mail"" />
                <span class=""material-icons""> arrow_drop_down </span>
            </div>
            <div class=""col"" id=""header-right"">
                <span class=""material-icons""> apps </span>
                <span class=""material-icons""> notifications </span>
                <span class=""material-icons""> account_circle </span>
            </div>
        </div>

");
            }
            );
            WriteLiteral(@"<!--header ends-->
<!--main body-->

<div class=""row"" id=""main-body"">

    <div class=""col-sm-6 col-md-3"">
        <!-- Sidebar Starts -->
        <div class=""container"">
            <div class=""row"">
                <div class=""col"" id=""sidebar"">
                    <!--inbox-->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "665a4892719e50b941250ad9e3f43c21ecbd39827951", async() => {
                WriteLiteral("\r\n                        <button class=\"sidebar__compose\">\r\n                            <span class=\"material-icons\"> add </span>Compose\r\n                        </button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""col"" id=""sidebarOption"" style=""background-color: #f5dad9"" ;>
                        <span class=""material-icons"" href=""#""> inbox </span>
                        <a href=""/Home/Inbox""><h3>Inbox</h3></a>
                    </div>

                    <div class=""col"" id=""sidebarOption"">
                        <!--starred-->
                        <span class=""material-icons""> star </span>
                        <h3>Starred</h3>
                    </div>

                    <div class=""col"" id=""sidebarOption"">
                        <!--snozz-->
                        <span class=""material-icons""> access_time </span>
                        <h3>Snoozed</h3>
                    </div>


                    <div class=""col"" id=""sidebarOption"">
                        <!--sent-->

                        <span class=""material-icons""> near_me </span>
                        <a href=""/Home/Sent""><h3>Sent</h3></a>
                    </div>

         ");
            WriteLiteral(@"           <div class=""col"" id=""sidebarOption"">
                        <span class=""material-icons""> note </span>
                        <h3>Drafts</h3>
                    </div>

                    <div class=""col"" id=""sidebar__footer"">
                        <div class=""col"" id=""sidebar__footerIcons"">
                            <span class=""material-icons""> person </span>
                            <span class=""material-icons""> duo </span>
                            <span class=""material-icons""> phone </span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--sidebar ends-->
    </div> <!--sidebar col ends-->

    <div class=""col-sm-6 col-md-9"">
        <div class=""row"">
            <div class=""col"" id=""emailList"">
                <!-- Settings Starts -->
                <div class=""col"" id=""emailList__settings"">
                    <div class=""col"" id=""emailList__settingsLeft"">
                      ");
            WriteLiteral(@"  <input type=""checkbox"" />
                        <span class=""material-icons""> arrow_drop_down </span>
                        <span class=""material-icons""> redo </span>
                        <span class=""material-icons""> more_vert </span>
                    </div>
                    <div id=""emailList__settingsRight"">
                        <span class=""material-icons""> chevron_left </span>
                        <span class=""material-icons""> chevron_right </span>
                        <span class=""material-icons""> keyboard_hide </span>
                        <span class=""material-icons""> settings </span>
                    </div>
                </div>
                <!-- Settings Ends -->
            </div>
        </div>
        <div id=""maildet"">
            <p class=""h3"">You Got a New Subscriber</p><br />
            <h4 style=""margin-bottom:-6px"" ;>
                Youtube
                <small class=""text-muted"">&lt;youtube@gmail.com&gt;</small>
            </h4>
  ");
            WriteLiteral(@"          <small class=""text-muted"">to me</small><br /><br />
            <div id=""mailbody"">
                <p>
                    Congratulations, You just got a new Subscriber on your youtube channel.<br />Keep growing and contributing to the community.
                    <br /><br />Regards,<br />Youtube Community
                </p><br /><br /><br />

                <button id=""rep"" type=""button"" class=""button def""><span class=""material-icons"">reply</span>&nbsp;Reply</button>
                
                <br />
                <div id=""reply""></div>
            </div>

        </div>




    </div>
</div>

");
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