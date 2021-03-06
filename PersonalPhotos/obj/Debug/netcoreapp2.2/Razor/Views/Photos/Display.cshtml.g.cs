#pragma checksum "/Users/francisco.mejias/Projects/PersonalPhotos-master/Code/PersonalPhotos/Views/Photos/Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ff2f72115709a55548d409841219df46b60c81f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Photos_Display), @"mvc.1.0.view", @"/Views/Photos/Display.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Photos/Display.cshtml", typeof(AspNetCore.Views_Photos_Display))]
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
#line 1 "/Users/francisco.mejias/Projects/PersonalPhotos-master/Code/PersonalPhotos/Views/_ViewImports.cshtml"
using PersonalPhotos;

#line default
#line hidden
#line 2 "/Users/francisco.mejias/Projects/PersonalPhotos-master/Code/PersonalPhotos/Views/_ViewImports.cshtml"
using PersonalPhotos.Models;

#line default
#line hidden
#line 1 "/Users/francisco.mejias/Projects/PersonalPhotos-master/Code/PersonalPhotos/Views/Photos/Display.cshtml"
using Core.Interfaces;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ff2f72115709a55548d409841219df46b60c81f", @"/Views/Photos/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc8679d1f5541ca7b2ef20a2d7cb0156e26f91b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Photos_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger glyphicon-plus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Photos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Upload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/francisco.mejias/Projects/PersonalPhotos-master/Code/PersonalPhotos/Views/Photos/Display.cshtml"
  
    ViewData["Title"] = "Photo Gallery";

#line default
#line hidden
            BeginContext(157, 115, true);
            WriteLiteral("\n<h2>Photo Gallery</h2>\n<div class=\"content\">\n    <div class=\"row\">\n        <div class=\"col-lg-12 h2\">\n            ");
            EndContext();
            BeginContext(272, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ff2f72115709a55548d409841219df46b60c81f4730", async() => {
                BeginContext(357, 10, true);
                WriteLiteral(" ADD PHOTO");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(371, 27, true);
            WriteLiteral("\n        </div>\n    </div>\n");
            EndContext();
#line 16 "/Users/francisco.mejias/Projects/PersonalPhotos-master/Code/PersonalPhotos/Views/Photos/Display.cshtml"
      
        const string root = "/PhotoStore";
        var key = _KeyGenerator.GetKey(Model);
        var photos = await _PhotoMetaData.GetUserPhotos(Model);

        while (photos.Count > 0)
        {

#line default
#line hidden
            BeginContext(603, 30, true);
            WriteLiteral("            <div class=\"row\">\n");
            EndContext();
#line 24 "/Users/francisco.mejias/Projects/PersonalPhotos-master/Code/PersonalPhotos/Views/Photos/Display.cshtml"
                  
                    var threePhotos = photos.Take(4);
                    foreach (var photo in threePhotos)
                    {

#line default
#line hidden
            BeginContext(783, 84, true);
            WriteLiteral("                        <div class=\"col-md-3\">\n                            <figure>\n");
            EndContext();
#line 30 "/Users/francisco.mejias/Projects/PersonalPhotos-master/Code/PersonalPhotos/Views/Photos/Display.cshtml"
                                  
                                    var source = $"{root}/{key}/{photo.FileName}";
                                

#line default
#line hidden
            BeginContext(1019, 36, true);
            WriteLiteral("                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1055, "\"", 1068, 1);
#line 33 "/Users/francisco.mejias/Projects/PersonalPhotos-master/Code/PersonalPhotos/Views/Photos/Display.cshtml"
WriteAttributeValue("", 1061, source, 1061, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1069, 69, true);
            WriteLiteral(" class=\"img-thumbnail\"/>\n                                <figcaption>");
            EndContext();
            BeginContext(1139, 17, false);
#line 34 "/Users/francisco.mejias/Projects/PersonalPhotos-master/Code/PersonalPhotos/Views/Photos/Display.cshtml"
                                       Write(photo.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1156, 83, true);
            WriteLiteral("</figcaption>\n                            </figure>\n                        </div>\n");
            EndContext();
#line 37 "/Users/francisco.mejias/Projects/PersonalPhotos-master/Code/PersonalPhotos/Views/Photos/Display.cshtml"
                    }
                    var toDelete = photos.Count >= 4 ? 4 : photos.Count;
                    photos.RemoveRange(0, toDelete);
                

#line default
#line hidden
            BeginContext(1405, 19, true);
            WriteLiteral("            </div>\n");
            EndContext();
#line 42 "/Users/francisco.mejias/Projects/PersonalPhotos-master/Code/PersonalPhotos/Views/Photos/Display.cshtml"
        }
    

#line default
#line hidden
            BeginContext(1440, 8, true);
            WriteLiteral("</div>\n\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPhotoMetaData _PhotoMetaData { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IKeyGenerator _KeyGenerator { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
