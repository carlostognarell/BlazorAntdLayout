#pragma checksum "C:\Users\Carlos Tognarell\Downloads\BlazorAntDesignDemo\BlazorAntDesignDemo\BlazorAntDesignDemo\Pages\Buttons.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f1052e03628f3798e354576aa0853903c494085"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAntDesignDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Carlos Tognarell\Downloads\BlazorAntDesignDemo\BlazorAntDesignDemo\BlazorAntDesignDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carlos Tognarell\Downloads\BlazorAntDesignDemo\BlazorAntDesignDemo\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Carlos Tognarell\Downloads\BlazorAntDesignDemo\BlazorAntDesignDemo\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Carlos Tognarell\Downloads\BlazorAntDesignDemo\BlazorAntDesignDemo\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Carlos Tognarell\Downloads\BlazorAntDesignDemo\BlazorAntDesignDemo\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Carlos Tognarell\Downloads\BlazorAntDesignDemo\BlazorAntDesignDemo\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Carlos Tognarell\Downloads\BlazorAntDesignDemo\BlazorAntDesignDemo\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Carlos Tognarell\Downloads\BlazorAntDesignDemo\BlazorAntDesignDemo\BlazorAntDesignDemo\_Imports.razor"
using BlazorAntDesignDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Carlos Tognarell\Downloads\BlazorAntDesignDemo\BlazorAntDesignDemo\BlazorAntDesignDemo\_Imports.razor"
using BlazorAntDesignDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Carlos Tognarell\Downloads\BlazorAntDesignDemo\BlazorAntDesignDemo\BlazorAntDesignDemo\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/buttons")]
    public partial class Buttons : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    #button-block-demo > * {\r\n        margin-bottom: 12px;\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "button-block-demo");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<AntDesign.Button>(4);
            __builder.AddAttribute(5, "Type", "primary");
            __builder.AddAttribute(6, "Block", true);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(8, "Primary");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenComponent<AntDesign.Button>(10);
            __builder.AddAttribute(11, "Block", true);
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(13, "Default");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenComponent<AntDesign.Button>(15);
            __builder.AddAttribute(16, "Type", "dashed");
            __builder.AddAttribute(17, "Block", true);
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(19, "Dashed");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenComponent<AntDesign.Button>(21);
            __builder.AddAttribute(22, "Type", "link");
            __builder.AddAttribute(23, "Block", true);
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(25, "Link");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591