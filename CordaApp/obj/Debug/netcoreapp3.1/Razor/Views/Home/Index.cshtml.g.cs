#pragma checksum "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca47381e25c3ab8ee9eea720f92701d7eb83448e"
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
#line 1 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\_ViewImports.cshtml"
using CordaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\_ViewImports.cshtml"
using CordaApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca47381e25c3ab8ee9eea720f92701d7eb83448e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd29131ae68aff54cebb2c1b6bc1e9749287b989", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString("disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        .customTd {
            background-color: transparent !important;
            border: none !important;
            color: #353944 !important;
            font-size: 18px !important;
            line-height: 35px;
            padding-left: 25px !important;
            border-radius: 18px;
        }
    </style>
");
            }
            );
            WriteLiteral(@"
<div class=""br-section-wrapper"" style=""background:transparent"">
    <div class=""row"">
        <div class=""col-lg-6"">

            <div class=""table-content pd-b-10"" style=""background-color: #ffffff;border-radius:30px;"">
                <div class=""row mg-x-0"" style=""height:30px;background-color: #ffffff;border-radius: 30px 30px 0 0;"">
                    <div class=""col-lg-6 pd-l-20 pd-y-10"" style=""font-size: 21px;font-weight:500;color:#C7C7C7"">FUNDS</div>
                    <div class=""col-lg-6 d-flex align-items-center pd-r-40"">
                        <button type=""button"" class=""btn btn-sm btn-default ml-auto"" style=""width:40px;background:rgba(182, 194, 214, 0.15) !important;border-radius: 10px;border:none"" id=""removeFund"">
                            <span class=""far fa-trash-alt fa-2x"" style=""color:rgba(53, 56, 68, 0.2);""></span>
                        </button>
                    </div>
                </div>
                <table class=""table table-borded tableCustom"" id=""table-list");
            WriteLiteral("\" style=\"padding-left: 20px;text-align: left;padding-right: 20px;\">\r\n                    <tbody id=\"fundTbody\">\r\n");
#nullable restore
#line 34 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
                         foreach (var item in ViewBag.fundList)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr style=\"background:rgba(232, 235, 240, 0.4)\">\r\n                                <td name=\"fundId\" class=\"d-none\">");
#nullable restore
#line 37 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
                                                            Write(item["fundid"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td name=\"fundOr\" class=\"d-none\">");
#nullable restore
#line 38 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
                                                            Write(item["fundorder"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td name=\"fundName\" class=\"d-none\">");
#nullable restore
#line 39 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
                                                              Write(item["fundname"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td name=\"fundDist\" class=\"d-none\">");
#nullable restore
#line 40 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
                                                              Write(item["distributionrate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td name=\"fundName\" class=\"col-lg-12 customTd fundName\" onclick=\"onColumnSelect(this)\">\r\n                                    ");
#nullable restore
#line 42 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
                               Write(item["fundname"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <span class=\"fas fa-arrows-alt fa-2x float-right mg-r-10\" style=\"color:rgba(53, 56, 68, 0.2);\"></span>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>

                <div class=""mg-x-20"" style=""background:rgba(232, 235, 240, 0.4);border-radius:18px"">

                    <div class=""form-group tx-left pd-l-25 pd-r-20 pd-t-10 pd-b-10"">
                        <label for=""exampleInputEmail1"" class=""mg-b-0"" style=""color:#0057FF;font-size:12px"">ADD A NEW FUND</label>

                        <div class=""form-row"">
                            <div class=""col-lg-5"">
                                <input type=""text"" class=""form-control pd-l-0"" style=""background:transparent;border:none;border-bottom: 1px solid rgba(0, 0, 0, 0.1);border-radius:0px"" id=""fundNameInp"" placeholder=""Rail Yard QOF LLC"">
                            </div>
                            <div class=""col-lg-6"">
                                <input type=""text"" class=""form-control pd-l-0"" style=""background:transparent;border:none;border-bottom: 1px solid rgba(0, 0, 0, 0.1);border-radius:0px"" id=""distRateInp"" placeholder=""Distr");
            WriteLiteral(@"ibution Rate"">
                            </div>
                            <div class=""col-lg-1 d-flex align-items-center"">
                                <button id=""addFund"" type=""button"" class=""btn btn-sm btn-default"" style=""width:40px;background:rgba(182, 194, 214, 0.15) !important;border-radius: 10px;border:none"">
                                    <span class=""fas fa-check fa-lg"" style=""color:#6FB86E""></span>
                                </button>
                            </div>
                        </div>



                    </div>

                </div>
            </div>


        </div>

        <div class=""col-lg-6"">

            <div class=""table-content pd-b-10"" style=""background-color: #ffffff;border-radius:30px;"">
                <div class=""row mg-x-0"" style=""height:30px;background-color: #ffffff;border-radius: 30px 30px 0 0;"">
                    <div class=""col-lg-6 pd-l-20 pd-y-10"" style=""font-size: 21px;font-weight:500;color:#C7C7C7;"">INVESTOR POOL<");
            WriteLiteral(@"/div>
                    <div class=""col-lg-6 d-flex align-items-center pd-r-40"">
                        <button type=""button"" class=""btn btn-sm btn-default ml-auto"" style=""width:40px;background:rgba(182, 194, 214, 0.15) !important;border-radius: 10px;border:none"" id=""removeInv"">
                            <span class=""far fa-trash-alt fa-2x"" style=""color:rgba(53, 56, 68, 0.2);""></span>
                        </button>
                    </div>
                </div>
                <table class=""table table-borded tableCustom"" id=""table-list"" style=""padding-left: 20px;text-align: left;padding-right: 20px;"">
                    <tbody id=""investorBody"">
");
#nullable restore
#line 92 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
                         foreach (var item in ViewBag.invList)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr style=\"background:rgba(232, 235, 240, 0.4)\">\r\n                                <td name=\"invId\" class=\"d-none\">");
#nullable restore
#line 95 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
                                                           Write(item["userid"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td name=\"invName\" class=\"col-lg-12 customTd\" onclick=\"onColumnSelect(this)\">");
#nullable restore
#line 96 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
                                                                                                        Write(item["investorname"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 98 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>

                <div class=""mg-x-20"" style=""background:rgba(232, 235, 240, 0.4);border-radius:18px"">

                    <div class=""form-group tx-left pd-l-25 pd-r-20 pd-t-10 pd-b-10"">
                        <label for=""exampleInputEmail1"" class=""mg-b-0"" style=""color:#0057FF;font-size:12px"">ADD A NEW INVESTOR</label>
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control pd-l-0"" style=""background:transparent;border:none;"" id=""invInp"" placeholder=""Simon Sais"">
                            <div class=""input-group-append"" style=""margin-left:-0px;padding-bottom:10px"">
                                <button id=""addInv"" type=""button"" class=""btn btn-sm btn-default"" style=""width:40px;background:rgba(182, 194, 214, 0.15) !important;border-radius: 10px;border:none"">
                                    <span class=""fas fa-check fa-lg"" style=""color:#6FB86E""></span>
                          ");
            WriteLiteral(@"      </button>
                            </div>
                        </div>
                        <div style=""border-bottom: 1px solid rgba(0, 0, 0, 0.1) !important;margin-top:-5px;margin-bottom:5px""></div>

                    </div>

                </div>
            </div>


        </div>

    </div>

    <div class=""row mg-t-20"">
        <div class=""col-lg-12"">

            <div class=""table-content pd-b-10"" style=""background-color: #ffffff;border-radius:30px;"">
                <div class=""row mg-x-0"" style=""height:30px;background-color: #ffffff;border-radius: 30px 30px 0 0"">
                    <div class=""col-lg-8 pd-l-20 pd-y-10"" id=""subsTitle"" style=""font-size: 21px;font-weight:500;color:#C7C7C7;"">SUBSCRIBERS OF CREOSAFE FUND (Total Investment Amount: )</div>
                    <div class=""col-lg-4 d-flex align-items-center pd-r-40"">
                        <button type=""button"" class=""btn btn-sm btn-default ml-auto"" style=""width:40px;background:rgba(182, 194, 214, 0.1");
            WriteLiteral(@"5) !important;border-radius: 10px;border:none"" id=""removeSubs"">
                            <span class=""far fa-trash-alt fa-2x"" style=""color:rgba(53, 56, 68, 0.2);""></span>
                        </button>
                    </div>
                    <input type=""hidden"" id=""subsFundId"" />
                    <input type=""hidden"" id=""subsFundName"" />
                </div>
                <table class=""table table-borded tableCustom"" id=""table-list"" style=""padding-left: 20px;text-align: left;padding-right: 20px;"">
                    <thead>
                        <tr class=""d-flex mg-r-10"">
                            <td class=""col-lg-2 pd-l-0-force pd-y-0-force tx-center"" style=""border:none;"">
                                <div class=""pd-y-10 tx-13"" style=""background:rgba(232, 235, 240, 0.4);border:none;border-radius:18px;color:#E0A100"">Name of Subscriber</div>
                            </td>
                            <td class=""col-lg-2 pd-y-0-force tx-center offset-lg-4"" style=""bo");
            WriteLiteral(@"rder:none;"">
                                <div class=""pd-y-10 tx-13"" style=""background:rgba(232, 235, 240, 0.4);border:none;border-radius:18px;color:#E0A100"">Investment Amount</div>
                            </td>
                    </thead>
                    <tbody id=""subsBody"">
                    </tbody>
                </table>

                <div class=""mg-x-20"" style=""background:rgba(232, 235, 240, 0.4);border-radius:18px"">

                    <div class=""form-group tx-left pd-l-25 pd-r-20 pd-t-10 pd-b-10"">
                        <label for=""exampleInputEmail1"" class=""mg-b-0"" style=""color:#0057FF;font-size:12px"">ADD A NEW SUBSCRIBER</label>

                        <div class=""form-row"">
                            <div class=""col-lg-5"">
                                <select class=""form-control"" style=""background:transparent;border:none;border-bottom: 1px solid rgba(0, 0, 0, 0.1);"" id=""subsName"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca47381e25c3ab8ee9eea720f92701d7eb83448e16691", async() => {
                WriteLiteral("Select Investor");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 163 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
                                     foreach (var item in ViewBag.invList)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca47381e25c3ab8ee9eea720f92701d7eb83448e18158", async() => {
#nullable restore
#line 165 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
                                                                   Write(item["investorname"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 165 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
                                           WriteLiteral(item["userid"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 166 "C:\Users\sncrh\Desktop\CordaApp\CordaApp\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </select>
                            </div>
                            <div class=""col-lg-6"">
                                <input type=""text"" class=""form-control pd-l-0"" style=""background:transparent;border:none;border-bottom: 1px solid rgba(0, 0, 0, 0.1);"" id=""subsAmountInp"" placeholder=""Investment Amount"">
                            </div>
                            <div class=""col-lg-1 d-flex align-items-center"">
                                <button id=""addSub"" type=""button"" class=""btn btn-sm btn-default"" style=""width:40px;background:rgba(182, 194, 214, 0.15) !important;border-radius: 10px;border:none"">
                                    <span class=""fas fa-check fa-lg"" style=""color:#6FB86E""></span>
                                </button>
                            </div>
                        </div>



                    </div>



                </div>
            </div>


        </div>

    </div>


</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>

        ""use strict"";

        $(document).ready(function () {

            // Fund Section
            $(""#addFund"").click(function () {
                var fundVal = $('#fundNameInp').val();
                var distVal = $('#distRateInp').val();

                $(""#fundTbody"").append(""<tr style='background:rgba(232, 235, 240, 0.4)'>"" +
                    ""<td name='fundId' class='d-none'>1</td>"" +
                    ""<td name='fundName' class='col-lg-12 customTd fundName'>"" + fundVal + ""<span class='fas fa-arrows-alt fa-2x float-right mg-r-10' style='color:rgba(53, 56, 68, 0.2)' onclick='onColumnSelect(this)'></span></td>"" +
                    ""</tr>"");

                $.ajax({
                    type: ""POST"",
                    url: '/Home/AddFund',
                    data: {
                        fundName: fundVal,
                        distRate: distVal
                    },
                    success: function (response) {
                        c");
                WriteLiteral(@"onsole.log(response);
                    }
                });
            });

            $(""#removeFund"").click(function () {
                var tr = $(""#fundTbody"").find("".activeRow"");
                var fundId = tr.find(""td:eq(0)"").text();

                $.ajax({
                    type: ""POST"",
                    url: '/Home/DeleteFund',
                    data: {
                        fundId: fundId
                    },
                    success: function (response) {
                        if (response.success) {
                            tr.remove();
                        }
                    }
                });
            });

            // Inv Section
            $(""#addInv"").click(function () {
                var invVal = $('#invInp').val();

                $(""#investorBody"").append(""<tr style='background:rgba(232, 235, 240, 0.4)'>"" +
                    ""<td name='invId' class='d-none'>1</td>"" +
                    ""<td name='invName' class='");
                WriteLiteral(@"col-lg-12 customTd' onclick='onColumnSelect(this)'>"" + invVal + ""</td>"" +
                    ""</tr>"");

                $.ajax({
                    type: ""POST"",
                    url: '/Home/AddInv',
                    data: {
                        invName: invVal
                    },
                    success: function (response) {
                        console.log(response);
                    }
                });

            });

            $(""#removeInv"").click(function () {
                var tr = $(""#investorBody"").find("".activeRow"");
                var invId = tr.find(""td:eq(0)"").text();

                $.ajax({
                    type: ""POST"",
                    url: '/Home/DeleteInv',
                    data: {
                        invId: invId
                    },
                    success: function (response) {
                        if (response.success) {
                            tr.remove();
                        }
              ");
                WriteLiteral(@"      }
                });
            });


            $(""#addSub"").click(function () {
                var invId = $('#subsName option:selected').val();
                var subsName = $('#subsName option:selected').text();
                var subsAmount = $('#subsAmountInp').val();
                var fundId = $('#subsFundId').val();
                var fundName = $('#subsFundName').val();

                $(""#subsBody"").append(""<tr class='d-flex mg-t-20 mg-r-20'>"" +
                    ""<td name='fundId' class='d-none'>"" + fundId + ""</td>"" +
                    ""<td name='userId' class='d-none'>"" + invId + ""</td>"" +
                    ""<td name='subsName' class='col-lg-6 customTd mg-r-20' style='background: rgba(232, 235, 240, 0.4)!important;' onclick='onColumnSelect(this)'>"" + subsName + ""</td>"" +
                    ""<td name='subsAmount' class='col-lg-6 customTd' style='background: rgba(232, 235, 240, 0.4)!important;'>$ "" + subsAmount + ""</td>"" +
                    ""</tr>"");

    ");
                WriteLiteral(@"            $.ajax({
                    type: ""POST"",
                    url: '/Home/AddSubscriber',
                    data: {
                        invId: invId,
                        fundId: fundId,
                        subsAmount: subsAmount,
                        fundName: fundName,
                        subsName: subsName
                    },
                    success: function (response) {
                        console.log(response);
                    }
                });

            });



        });

        $(""#removeSubs"").click(function () {
            var tr = $(""#subsBody"").find("".activeRow"");
            var fundId = tr.find(""td:eq(0)"").text();
            var invId = tr.find(""td:eq(1)"").text();

            $.ajax({
                type: ""POST"",
                url: '/Home/DeleteSubs',
                data: {
                    fundId: fundId,
                    invId: invId
                },
                success: function (respo");
                WriteLiteral(@"nse) {
                    if (response.success) {
                        tr.remove();
                    }
                }
            });
        });

        $("".fundName"").click(function () {
            var tr = $(this).parents('tr');
            var fundId = tr.find(""td:eq(0)"").text();

            $.ajax({
                type: ""POST"",
                url: '/Home/GetSubscribers',
                data: {
                    fundId: fundId
                },
                success: function (response) {
                    var subsList = $.parseJSON(response.list);
                    $(""#subsBody"").empty();

                    $.each(subsList, function (index, value) {
                        if (value.fundid != null) {
                            $('#subsTitle').text(""SUBSCRIBERS OF "" + value.fundname + "" (Total Investment Amount: "" + value.totalinvestmentamount + "")"");

                            $('#subsFundId').val(value.fundid);
                            $('#subs");
                WriteLiteral(@"FundName').val(value.fundname);

                            var trTop = "" "";
                            if (index != 0)
                                trTop = "" mg-t-20 "";
                            $(""#subsBody"").append(""<tr class='d-flex"" + trTop + ""mg-r-20'>"" +
                                ""<td name='fundId' class='d-none'>"" + value.fundid + ""</td>"" +
                                ""<td name='userId' class='d-none'>"" + value.userid + ""</td>"" +
                                ""<td name='subsName' class='col-lg-6 customTd mg-r-20' style='background: rgba(232, 235, 240, 0.4)!important;' onclick='onColumnSelect(this)'>"" + value.investorname + ""</td>"" +
                                ""<td name='subsAmount' class='col-lg-6 customTd' style='background: rgba(232, 235, 240, 0.4)!important;'>$ "" + value.investmentamount + ""</td>"" +
                                ""</tr>"");
                        }
                    });

                }
            });

        });

        function o");
                WriteLiteral(@"nColumnSelect(columnName) {
            var row = $(columnName).parents('tr');
            $(row).addClass('activeRow').siblings().removeClass('activeRow');
        }


    </script>

    <script>
        $(function () {

            $(""#fundTbody"").sortable({
                stop: function (event, ui) {

                    $('#fundTbody tr').each(function (orIndex) {
                        var fundId = $(this).find(""td"").eq(0).html();
                        var fundName = $(this).find(""td"").eq(2).html();
                        var fundDist = $(this).find(""td"").eq(3).html();

                        console.log(""Fund Id:"" + fundId + "" "" + ""Fund Name:"" + fundName + "" "" + ""Dist:"" + fundDist + "" "" + ""Order:"" + orIndex + 1);

                        $.ajax({
                            type: ""POST"",
                            url: '/Home/FundOrder',
                            data: {
                                fundId: fundId,
                                fundOr: (orIndex + ");
                WriteLiteral(@"1),
                                fundName: fundName,
                                fundDist: fundDist
                            },
                            success: function (response) {
                                console.log(response.success);
                            }
                        });


                    });

                    console.log(""New position: "" + ui.item.index());
                }
            });

            $(""#fundTbody"").disableSelection();



        });
    </script>


");
            }
            );
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
