#pragma checksum "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "11f2b3771288d985da0621153db2184cae72d93ec2f299eab781f02a4f455fbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\_ViewImports.cshtml"
using BookingWepApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\_ViewImports.cshtml"
using BookingWepApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"11f2b3771288d985da0621153db2184cae72d93ec2f299eab781f02a4f455fbb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6aa62b8d253375c65c3aff1feaa1f2a6ac4f956697b7ccba1417d951e2638025", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookingWepApp.Models.HotelsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SearchPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HotelDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HotelPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-lg btn-success float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: rgb(35,110,170)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "11f2b3771288d985da0621153db2184cae72d93ec2f299eab781f02a4f455fbb5313", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 5 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
 if (Model.Hotels.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>No hotels found</h2>\n");
#nullable restore
#line 8 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"d-flex big-container\">\n        <div class=\"container  p-0 m-0\">\n");
#nullable restore
#line 13 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
             foreach (var item in Model.Hotels)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card-deck"">
                    <div class=""card mt-4"">
                        <div class=""card-body pb-0 pt-0 d-flex"">
                            <div class=""text-center"">
                                <img class=""hotel-image""");
            BeginWriteAttribute("src", " src=", 553, "", 586, 1);
#nullable restore
#line 19 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 558, Url.Content(@item.ImageUrl), 558, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                            </div>\n                            <div class=\"ml-3 w-100\">\n                                <div>\n                                    <h2 class=\"hotel-name text-break\">   ");
#nullable restore
#line 23 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h2>\n                                </div>\n                                <div>\n                                    <p>\n                                        ");
#nullable restore
#line 27 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
                                   Write(item.Stars);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - star\r\n                                    </p>\n                                </div>\n                                <div>\n                                    <p>\n                                        Address: ");
#nullable restore
#line 32 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
                                            Write(item.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 32 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
                                                           Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 32 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
                                                                          Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 32 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
                                                                                      Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </p>\n                                    <p>\n                                        Distance from city center: ");
#nullable restore
#line 35 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
                                                              Write(item.DistanceFromCenter);

#line default
#line hidden
#nullable disable
            WriteLiteral(" km.\n                                    </p>\n                                </div>\n                                <div class=\"card-text text-justify\">\n                                    <p>");
#nullable restore
#line 39 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                </div>\n                                <div class=\"card-text\">\n                                    <p>WEB URL: <a");
            BeginWriteAttribute("href", " href=\"", 1779, "\"", 1799, 1);
#nullable restore
#line 42 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1786, item.Website, 1786, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
                                                                   Write(item.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\n                                </div>\n                            </div>\n                        </div>\n                        <div class=\"card-footer pt-0 pl-0 border-top-0 bg-white\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11f2b3771288d985da0621153db2184cae72d93ec2f299eab781f02a4f455fbb12143", async() => {
                WriteLiteral("Book the room in hotel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 51 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n");
#nullable restore
#line 54 "C:\Users\Nick\Documents\NBD_Project\NBD_Project\BookingWepApp\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookingWepApp.Models.HotelsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
