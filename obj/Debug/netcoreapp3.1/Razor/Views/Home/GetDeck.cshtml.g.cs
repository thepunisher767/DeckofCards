#pragma checksum "C:\devbuild\DeckofCards\Views\Home\GetDeck.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "553b09fcb4f876f772511120b74b60d3ab57dd63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetDeck), @"mvc.1.0.view", @"/Views/Home/GetDeck.cshtml")]
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
#line 1 "C:\devbuild\DeckofCards\Views\_ViewImports.cshtml"
using DeckofCards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\devbuild\DeckofCards\Views\_ViewImports.cshtml"
using DeckofCards.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"553b09fcb4f876f772511120b74b60d3ab57dd63", @"/Views/Home/GetDeck.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"353dd6e4ec2e87cf32533d5d992c51df210bf175", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetDeck : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hand>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\devbuild\DeckofCards\Views\Home\GetDeck.cshtml"
  
    ViewData["Title"] = "GetDeck";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetDeck</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\devbuild\DeckofCards\Views\Home\GetDeck.cshtml"
 foreach (Card card in Model.cards)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6>");
#nullable restore
#line 10 "C:\devbuild\DeckofCards\Views\Home\GetDeck.cshtml"
   Write(card.value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 10 "C:\devbuild\DeckofCards\Views\Home\GetDeck.cshtml"
                 Write(card.suit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 161, "\"", 178, 1);
#nullable restore
#line 11 "C:\devbuild\DeckofCards\Views\Home\GetDeck.cshtml"
WriteAttributeValue("", 167, card.image, 167, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 12 "C:\devbuild\DeckofCards\Views\Home\GetDeck.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2></h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hand> Html { get; private set; }
    }
}
#pragma warning restore 1591
