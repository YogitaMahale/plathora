#pragma checksum "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecfc32fcdfc032954ea48ab66468ba26ae8480b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Reportdetails_collectionReport), @"mvc.1.0.view", @"/Areas/Admin/Views/Reportdetails/collectionReport.cshtml")]
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
#line 1 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\_ViewImports.cshtml"
using plathora;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\_ViewImports.cshtml"
using plathora.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecfc32fcdfc032954ea48ab66468ba26ae8480b4", @"/Areas/Admin/Views/Reportdetails/collectionReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"396188bb9b5a5b30811f4f1a58a7e68134b9e9d4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Reportdetails_collectionReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<plathora.pagination.collectionreport_affilatePagination<collectionreport_affilateViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "deliveryboyid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deliveryboyid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "collectionReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
  
    ViewBag.Title = "Collection Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12 grid-margin"">
        <div class=""card"">


            <div class=""card-body"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfc32fcdfc032954ea48ab66468ba26ae8480b46767", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        <li class=\"breadcrumb-item active\" aria-current=\"page\">Collection Details</li>\r\n                    </ol>\r\n                </nav><br />\r\n");
#nullable restore
#line 20 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                 using (Html.BeginForm("collectionReport", "Reportdetails", FormMethod.Post))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""form-group col-md-1"">
                            <label>From Date</label>
                        </div>
                        <div class=""form-group col-md-2"">
                            <div class=""input-group date"" data-provide=""datepicker"">
");
            WriteLiteral("                                <input type=\"text\" id=\"datepicker1\" autocomplete=\"off\" class=\"form-control datepicker\"");
            BeginWriteAttribute("value", " value=\"", 1341, "\"", 1363, 1);
#nullable restore
#line 30 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
WriteAttributeValue("", 1349, ViewBag.from1, 1349, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"from1\">\r\n\r\n                                <div class=\"input-group-addon\">\r\n                                    <span class=\"glyphicon glyphicon-th\"></span>\r\n                                </div>\r\n                            </div>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("                        </div>\r\n                        <div class=\"form-group col-md-1\">\r\n                            <label>To Date</label>\r\n                        </div>\r\n                        <div class=\"form-group col-md-2\">\r\n");
            WriteLiteral("                            <input type=\"text\" id=\"datepicker2\" autocomplete=\"off\" class=\"form-control datepicker\"");
            BeginWriteAttribute("value", " value=\"", 2587, "\"", 2607, 1);
#nullable restore
#line 50 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
WriteAttributeValue("", 2595, ViewBag.to1, 2595, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"to1\">\r\n");
            WriteLiteral(@"                        </div>

                        <div class=""form-group col-md-1"">
                            <label>Select Affilate</label>
                        </div>
                        <div class=""form-group col-md-2"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfc32fcdfc032954ea48ab66468ba26ae8480b411131", async() => {
                WriteLiteral("\r\n\r\n\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfc32fcdfc032954ea48ab66468ba26ae8480b411432", async() => {
                    WriteLiteral("--- Select  ---");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 59 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.affilatelist, "Id", "name"));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"                        </div>



                    </div>
                    <div class=""row"" style=""text-align:center;"">
                        <div class=""form-group col-md-4"">
                        </div>
                        <div class=""form-group col-md-4"">
                            <input type=""submit"" name=""search"" value=""Search"" class=""btn btn-primary"" />
                            <input style=""display:none;"" type=""submit"" name=""ExcelFileDownload"" value=""Excel Download"" class=""btn btn-primary"" />
                        </div>
                        <div class=""form-group col-md-4"">
                        </div>
                    </div>
");
#nullable restore
#line 80 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                  
                    decimal amount = 0;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md-12 table-responsive-md\">\r\n");
            WriteLiteral("                        <b>  <h4>");
#nullable restore
#line 87 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                            Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4> </b>\r\n                        <table class=\"table table-bordered tblShow\">\r\n                            <thead>\r\n                                <tr>\r\n");
            WriteLiteral(@"
                                    <th>Name</th>
                                    <th>PhoneNumber</th>
                                    <th>Date</th>
                                    <th>Package Amount</th>
                                    <th>GST Amount</th>
                                    <th>Total</th>
");
            WriteLiteral("                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 105 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                                 foreach (var item in Model)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td> ");
#nullable restore
#line 109 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                                        Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("       </td>\r\n                                        <td>");
#nullable restore
#line 110 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                                       Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td> ");
#nullable restore
#line 111 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                                        Write(item.createddate);

#line default
#line hidden
#nullable disable
            WriteLiteral("       </td>\r\n                                        <td>");
#nullable restore
#line 112 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                                       Write(item.pkgamount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td> ");
#nullable restore
#line 113 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                                        Write(item.gstamt);

#line default
#line hidden
#nullable disable
            WriteLiteral("       </td>\r\n                                        <td>");
#nullable restore
#line 114 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                                       Write(item.PaymentAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 118 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n");
#nullable restore
#line 122 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                                 foreach (var item in Model)
                                {
                                    amount += item.PaymentAmount;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <tr>\r\n");
            WriteLiteral(@"
                                <th> </th>
                                <th> </th>
                                <th> </th>
                                <th> </th>
                                <th></th>
                                <th>");
#nullable restore
#line 137 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                               Write(amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
            WriteLiteral("                            </tr>\r\n\r\n                        </table><br />\r\n");
#nullable restore
#line 143 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                          
                            var disablePrevious = !Model.IsPreviousAvailable ? "disabled" : "";
                            var disableNext = !Model.IsNextAvailable ? "disabled" : "";
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfc32fcdfc032954ea48ab66468ba26ae8480b421627", async() => {
                WriteLiteral("\r\n                            Previous\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                                      WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 150 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                                WriteLiteral(ViewBag.from1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["from1"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-from1", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["from1"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 151 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                              WriteLiteral(ViewBag.to1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["to1"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-to1", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["to1"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 152 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                                        WriteLiteral(ViewBag.deliveryboyid1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["deliveryboyid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-deliveryboyid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["deliveryboyid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7831, "btn", 7831, 3, true);
            AddHtmlAttributeValue(" ", 7834, "btn-primary", 7835, 12, true);
#nullable restore
#line 153 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
AddHtmlAttributeValue(" ", 7846, disablePrevious, 7847, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfc32fcdfc032954ea48ab66468ba26ae8480b427069", async() => {
                WriteLiteral("\r\n                            Next\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 157 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                                      WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 158 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                                WriteLiteral(ViewBag.from1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["from1"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-from1", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["from1"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 159 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                              WriteLiteral(ViewBag.to1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["to1"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-to1", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["to1"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 160 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
                                        WriteLiteral(ViewBag.deliveryboyid1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["deliveryboyid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-deliveryboyid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["deliveryboyid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8297, "btn", 8297, 3, true);
            AddHtmlAttributeValue(" ", 8300, "btn-primary", 8301, 12, true);
#nullable restore
#line 161 "E:\yogita 6.8.19\asp.net core\Final backup 4.9.20\plathoraNewDomain\15.12.20\plathora\plathora\plathora\Areas\Admin\Views\Reportdetails\collectionReport.cshtml"
AddHtmlAttributeValue(" ", 8312, disableNext, 8313, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfc32fcdfc032954ea48ab66468ba26ae8480b432603", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"<script>
    $(function () {
        //$(""#datepicker1"").datepicker({
        //    autoclose: true,
        //        format: 'dd/mm/yyyy'
        //});
        //$(""#datepicker2"").datepicker({
        //    autoclose: true,
        //    format: 'dd/mm/yyyy'
        //});
        $("".datepicker"").datepicker({
            autoclose: true,
            dateFormat: 'dd/mm/yy'
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<plathora.pagination.collectionreport_affilatePagination<collectionreport_affilateViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
