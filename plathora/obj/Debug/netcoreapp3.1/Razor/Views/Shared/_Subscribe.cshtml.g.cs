#pragma checksum "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Views\Shared\_Subscribe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f896fca32af36142a89251274c0d33ba58b8256"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Subscribe), @"mvc.1.0.view", @"/Views/Shared/_Subscribe.cshtml")]
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
#line 1 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Views\_ViewImports.cshtml"
using plathora;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Views\_ViewImports.cshtml"
using plathora.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f896fca32af36142a89251274c0d33ba58b8256", @"/Views/Shared/_Subscribe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"396188bb9b5a5b30811f4f1a58a7e68134b9e9d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Subscribe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<section class=""sptb border-top"">
    <div class=""container"">
        <div class=""section-title center-block text-center"">
            <h2>Subscribe To Our Newsletter</h2>
            <p>Mauris ut cursus nunc. Morbi eleifend, ligula at consectetur vehicula</p>
        </div>
        <div class=""row"">
            <div class=""col-lg-10 col-xl-8 col-md-12 mx-auto d-block text-center"">
                <div class=""input-group sub-input mt-0"">
                    <input id=""txttext"" type=""text"" class=""form-control input-lg "" placeholder=""Enter your Email"">
                    <div class=""input-group-append "">
                        <button id=""btnsubscribe"" type=""button"" class=""btn btn-secondary btn-lg br-tr-3 br-br-3 pl-5 pr-5"">
                            Subscribe
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>

</section>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f896fca32af36142a89251274c0d33ba58b82564597", async() => {
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
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n\r\n    $(document).ready(function () {\r\n        $(\"#btnsubscribe\").click(function () {\r\n\r\n            val1 = \"5\";\r\n            val2 = \"2\";\r\n             $.ajax({\r\n            type: \"POST\",\r\n                 url: \"");
#nullable restore
#line 37 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Views\Shared\_Subscribe.cshtml"
                  Write(Url.Action("Add","test1"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",

                 data: { email: $(""#txttext"").val()},
            dataType: ""text"",
            success: function (msg) {
                console.log(msg);
                $(""#txttext"").val("""");
                //alert($(""#txttext"").val());
                alert(""Save"");
            },
            error: function (req, status, error) {
                console.log(error);
            }
             });

                //alert($(""#lblScribeEmail"").val());
");
            WriteLiteral("\r\n            });\r\n    });\r\n</script>\r\n");
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
