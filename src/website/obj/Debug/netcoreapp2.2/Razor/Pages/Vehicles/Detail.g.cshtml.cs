#pragma checksum "H:\Projects\github\vehicles_aspnet_core_2.2\src\website\Pages\Vehicles\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74a580505876dd3cabb869c54d37ac00dced9821"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Vehicles_Detail), @"mvc.1.0.razor-page", @"/Pages/Vehicles/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Vehicles/Detail.cshtml", typeof(AspNetCore.Pages_Vehicles_Detail), @"{id:int}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74a580505876dd3cabb869c54d37ac00dced9821", @"/Pages/Vehicles/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vehicles_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "H:\Projects\github\vehicles_aspnet_core_2.2\src\website\Pages\Vehicles\Detail.cshtml"
  
    ViewData["Title"] += " Details";

#line default
#line hidden
            BeginContext(111, 66, true);
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div id=\"messages\"></div>\r\n    ");
            EndContext();
            BeginContext(177, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74a580505876dd3cabb869c54d37ac00dced98213585", async() => {
                BeginContext(228, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 8 "H:\Projects\github\vehicles_aspnet_core_2.2\src\website\Pages\Vehicles\Detail.cshtml"
                         WriteLiteral(Model.VehicleId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(236, 114, true);
            WriteLiteral("\r\n    <div id=\"makeField\" class=\"row\">\r\n        <div class=\"col-md-1\">Make:</div>\r\n        <div class=\"col-md-11\">");
            EndContext();
            BeginContext(351, 10, false);
#line 11 "H:\Projects\github\vehicles_aspnet_core_2.2\src\website\Pages\Vehicles\Detail.cshtml"
                          Write(Model.Make);

#line default
#line hidden
            EndContext();
            BeginContext(361, 134, true);
            WriteLiteral("</div>\r\n    </div>\r\n    <div id=\"modelField\" class=\"row\">\r\n        <div class=\"col-md-1\">Model:</div>\r\n        <div class=\"col-md-11\">");
            EndContext();
            BeginContext(496, 11, false);
#line 15 "H:\Projects\github\vehicles_aspnet_core_2.2\src\website\Pages\Vehicles\Detail.cshtml"
                          Write(Model.Model);

#line default
#line hidden
            EndContext();
            BeginContext(507, 132, true);
            WriteLiteral("</div>\r\n    </div>\r\n    <div id=\"yearField\" class=\"row\">\r\n        <div class=\"col-md-1\">Year:</div>\r\n        <div class=\"col-md-11\">");
            EndContext();
            BeginContext(640, 10, false);
#line 19 "H:\Projects\github\vehicles_aspnet_core_2.2\src\website\Pages\Vehicles\Detail.cshtml"
                          Write(Model.Year);

#line default
#line hidden
            EndContext();
            BeginContext(650, 130, true);
            WriteLiteral("</div>\r\n    </div>\r\n    <div id=\"vinField\" class=\"row\">\r\n        <div class=\"col-md-1\">VIN:</div>\r\n        <div class=\"col-md-11\">");
            EndContext();
            BeginContext(781, 9, false);
#line 23 "H:\Projects\github\vehicles_aspnet_core_2.2\src\website\Pages\Vehicles\Detail.cshtml"
                          Write(Model.Vin);

#line default
#line hidden
            EndContext();
            BeginContext(790, 146, true);
            WriteLiteral("</div>\r\n    </div>\r\n    <div id=\"descriptionField\" class=\"row\">\r\n        <div class=\"col-md-1\">Description:</div>\r\n        <div class=\"col-md-11\">");
            EndContext();
            BeginContext(937, 17, false);
#line 27 "H:\Projects\github\vehicles_aspnet_core_2.2\src\website\Pages\Vehicles\Detail.cshtml"
                          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(954, 28, true);
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(999, 171, true);
                WriteLiteral("\r\n    <script>\r\n    $(document).ready(function () {\r\n        page.initialize();\r\n    });\r\n\r\n    var page = {\r\n        initialize: function () {\r\n            var message = ");
                EndContext();
                BeginContext(1171, 39, false);
#line 38 "H:\Projects\github\vehicles_aspnet_core_2.2\src\website\Pages\Vehicles\Detail.cshtml"
                     Write(Html.Raw(Json.Serialize(Model.Message)));

#line default
#line hidden
                EndContext();
                BeginContext(1210, 664, true);
                WriteLiteral(@";

            if (message.text.length > 0) {
                page.showMessage(message.type, message.text);
            }
        },
        showMessage: function (type, message) {
            var alertType = 'danger';

            if (type == 'error' || type == 0) {
                alertType = 'danger';
            } else if (type == 'info' || type == 1) {
                alertType = 'primary';
            } else if (type == 'success' || type == 2)
                alertType = 'success';

            $('#messages').append($('<div class=""alert alert-' + alertType + '"" role=""alert"">' + message + '</div>'));
        }
    };
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vehicles.Web.Pages.Vehicles.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Vehicles.Web.Pages.Vehicles.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Vehicles.Web.Pages.Vehicles.DetailModel>)PageContext?.ViewData;
        public Vehicles.Web.Pages.Vehicles.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
