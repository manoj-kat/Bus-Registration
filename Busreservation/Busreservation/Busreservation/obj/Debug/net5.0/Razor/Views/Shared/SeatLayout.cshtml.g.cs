#pragma checksum "D:\busreg\Busreservation\Busreservation\Views\Shared\SeatLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8868b3413c7932a455c4ceae2badb148eed91143"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SeatLayout), @"mvc.1.0.view", @"/Views/Shared/SeatLayout.cshtml")]
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
#line 1 "D:\busreg\Busreservation\Busreservation\Views\_ViewImports.cshtml"
using Busreservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\busreg\Busreservation\Busreservation\Views\_ViewImports.cshtml"
using Busreservation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8868b3413c7932a455c4ceae2badb148eed91143", @"/Views/Shared/SeatLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"804b027051a5a34f0bc6c1c2dc8d15a142af673c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SeatLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Next"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8868b3413c7932a455c4ceae2badb148eed911436377", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Seat Layout</title>\r\n    <link rel=\"stylesheet\" href=\"/css/styles.css\">\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8868b3413c7932a455c4ceae2badb148eed911437614", async() => {
                WriteLiteral(@"
    <div class=""seat-container"">
        <h2>Seat Layout</h2>
    </div>
    <ul class=""showcase"">
        <li>
            <div class=""seat""></div>
            <input type=""checkbox"" onClick=""this.checked=!this.checked;"">
            <h3>Avaible</h3>
        </li>
        <li>
            <div class=""seat occupied""></div>
            <h3>X&ensp;</h3>
            <h3> Occupied</h3>
        </li>
        <li>
            <div class=""seat selected""></div>
            <input type=""checkbox"" name=""selected"" value=""seat"" checked>
            <h3>Selected</h3>
        </li>
    </ul>

    <div class=""container"">
        <div class=""screen"">
            <img class=""steering"" src=""/lib/images/steering-wheel.png"">
        </div>

        <div class=""row"">
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">1A</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""2A"">
            ");
                WriteLiteral(@"    <label for=""2A"">2A</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""3A"">
                <label for=""3A"">3A</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""4A"">
                <label for=""4A"">4A</label>
            </div>
        </div>
        <div class=""row"">
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">1B</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""2B"">
                <label for=""2B"">2B</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""3B"">
                <label for=""3B"">3B</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""4B"">
                <label for=""4B"">4B</label>
            </div>
        </div>
        <div class=""row"">
            <div");
                WriteLiteral(@" class=""seat"">
                <input type=""checkbox"" id=""1C"">
                <label for=""1C"">1C</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""2C"">
                <label for=""2C"">2C</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""3C"">
                <label for=""3C"">3C</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""4C"">
                <label for=""4C"">4C</label>
            </div>
        </div>
        <div class=""row"">
            <div class=""seat"">
                <input type=""checkbox"" id=""1D"">
                <label for=""1D"">1D</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""2D"">
                <label for=""1A"">2D</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">3D</label>
  ");
                WriteLiteral(@"          </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">4D</label>
            </div>
        </div>
        <div class=""row"">
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">1E</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">2E</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">3E</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">4E</label>
            </div>
        </div>
        <div class=""row"">
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">1F</label>
            </div>
            <div class=""seat"">
                <i");
                WriteLiteral(@"nput type=""checkbox"" id=""1A"">
                <label for=""1A"">2F</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">3F</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">4F</label>
            </div>
        </div>
        <div class=""row"">
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">1F</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">2F</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">3F</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">4F</label>
            </div>
        </div>
");
                WriteLiteral(@"        <div class=""row"">
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">1G</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">2G</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">3G</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">4G</label>
            </div>
        </div>
        <div class=""row"">
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">1H</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">2H</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
   ");
                WriteLiteral(@"             <label for=""1A"">3H</label>
            </div>
            <div class=""seat"">
                <input type=""checkbox"" id=""1A"">
                <label for=""1A"">4H</label>
            </div>
        </div>
    </div>

    <div class=""containe"">
        <main role=""main"" class=""pb-3"">
            ");
#nullable restore
#line 203 "D:\busreg\Busreservation\Busreservation\Views\Shared\SeatLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n\r\n    <div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8868b3413c7932a455c4ceae2badb148eed9114315165", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8868b3413c7932a455c4ceae2badb148eed9114316855", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8868b3413c7932a455c4ceae2badb148eed9114317955", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8868b3413c7932a455c4ceae2badb148eed9114319055", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 213 "D:\busreg\Busreservation\Busreservation\Views\Shared\SeatLayout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 214 "D:\busreg\Busreservation\Busreservation\Views\Shared\SeatLayout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!--<p class=\"text\">You have selected <span id=\"count\">0</span>\r\n        seats for a price of $<span id=\"total\">0</span>\r\n    </p>-->\r\n\r\n    <script src=\"script.js\"></script>\r\n");
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
