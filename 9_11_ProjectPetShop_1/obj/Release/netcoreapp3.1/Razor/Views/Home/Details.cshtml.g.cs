#pragma checksum "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c12c35ad8722b184f2432b8c0ef376be30c73e6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c12c35ad8722b184f2432b8c0ef376be30c73e6d", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_9_11_ProjectPetShop_1.Models.Comments>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("AddAComment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h4>Details of ");
#nullable restore
#line 6 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
              Write(ViewBag.Animale.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
    <table class=""table table-dark"">
        <tr>
            <td>Name:</td>
            <td>Picture Name:</td>
            <td>Age:</td>
            <td>Description:</td>
            <td>Category:</td>
            <td>Comments:</td>
        </tr>
        <tr>
            <td>");
#nullable restore
#line 17 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
           Write(ViewBag.Animale.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            ");
#nullable restore
#line 18 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
       Write(Url.Action("RetrieveImage", new { id = @ViewBag.Animale.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td><img");
            BeginWriteAttribute("alt", " alt=\"", 550, "\"", 577, 1);
#nullable restore
#line 19 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
WriteAttributeValue("", 556, ViewBag.Animale.Name, 556, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 578, "\"", 662, 2);
            WriteAttributeValue("", 584, "data:image/jpg;base64,", 584, 22, true);
#nullable restore
#line 19 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
WriteAttributeValue("", 606, Convert.ToBase64String(ViewBag.Animale.Image.ImageData), 606, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
           Write(ViewBag.Animale.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
           Write(ViewBag.Animale.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
           Write(ViewBag.Animale.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c12c35ad8722b184f2432b8c0ef376be30c73e6d7023", async() => {
                WriteLiteral("\r\n                    <div>\r\n                        ");
#nullable restore
#line 27 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
                   Write(Html.LabelFor(model => model.Comment));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 29 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
                     foreach (var Comment in @ViewBag.Animale.Comments)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div>");
#nullable restore
#line 31 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
                         Write(ViewBag.Caunter++);

#line default
#line hidden
#nullable disable
                WriteLiteral(") ");
#nullable restore
#line 31 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
                                              Write(Comment.Comment);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 32 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div>\r\n");
                WriteLiteral("                    ");
#nullable restore
#line 35 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
               Write(Html.EditorFor(model => model.Comment));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\r\n                </div>\r\n                    <input type=\"hidden\" name=\"animaleId\" id=\"animaleId\"");
                BeginWriteAttribute("value", " value=\"", 1522, "\"", 1549, 1);
#nullable restore
#line 39 "C:\Users\sagib\Documents\wrokProject2\AmirClass\ProjectPetShop\9_11_ProjectPetShop_7\9_11_ProjectPetShop_1\Views\Home\Details.cshtml"
WriteAttributeValue("", 1530, ViewBag.Animale.Id, 1530, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"submit\" value=\"Add\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n            </td>\r\n        </tr>\r\n\r\n    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_9_11_ProjectPetShop_1.Models.Comments> Html { get; private set; }
    }
}
#pragma warning restore 1591
