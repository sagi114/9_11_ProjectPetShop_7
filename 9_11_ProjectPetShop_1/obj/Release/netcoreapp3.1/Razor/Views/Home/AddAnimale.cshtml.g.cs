#pragma checksum "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\AddAnimale.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5e42d39ccab64c2ffc4edefaa597336f5d9695a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddAnimale), @"mvc.1.0.view", @"/Views/Home/AddAnimale.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5e42d39ccab64c2ffc4edefaa597336f5d9695a", @"/Views/Home/AddAnimale.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddAnimale : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_9_11_ProjectPetShop_1.Models.Animals>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\AddAnimale.cshtml"
  
    ViewData["Title"] = "AddAnimale";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"FormClass\">\r\n        <h4>Add Animale</h4>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5e42d39ccab64c2ffc4edefaa597336f5d9695a5096", async() => {
                WriteLiteral("\r\n        <label for=\"Catagories\">Choose a catagory:</label>\r\n        <select class=\"dropdown-el\" name=\"CategoryId\" id=\"CategoryId\">\r\n");
#nullable restore
#line 13 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\AddAnimale.cshtml"
             foreach (var catagoryItem in ViewBag.CatagortList)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5e42d39ccab64c2ffc4edefaa597336f5d9695a5846", async() => {
#nullable restore
#line 15 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\AddAnimale.cshtml"
                                            Write(catagoryItem.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\AddAnimale.cshtml"
                   WriteLiteral(catagoryItem.Id);

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
#line 16 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\AddAnimale.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n");
#nullable restore
#line 18 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\AddAnimale.cshtml"
         if (ViewBag.isValid == false)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n                <strong>You didnt input the information please try again!!!!!</strong><br /> ");
#nullable restore
#line 21 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\AddAnimale.cshtml"
                                                                                        Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\AddAnimale.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n            ");
#nullable restore
#line 28 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\AddAnimale.cshtml"
       Write(Html.LabelFor(a => a.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 31 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\AddAnimale.cshtml"
       Write(Html.EditorFor(a => a.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 34 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\AddAnimale.cshtml"
       Write(Html.LabelFor(a => a.Age));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5e42d39ccab64c2ffc4edefaa597336f5d9695a10535", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 37 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\AddAnimale.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Age);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 41 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\AddAnimale.cshtml"
       Write(Html.LabelFor(a => a.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 44 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\AddAnimale.cshtml"
       Write(Html.EditorFor(a => a.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <input type=\"file\" id=\"file1\"\r\n               name=\"file1\"\r\n               multiple=\"multiple\" />\r\n        <button type=\"submit\">Insert</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_9_11_ProjectPetShop_1.Models.Animals> Html { get; private set; }
    }
}
#pragma warning restore 1591
