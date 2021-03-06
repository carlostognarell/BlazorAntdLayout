#pragma checksum "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Pages\Antd\AntModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a914338d58eca0867cb03365eaa517c6b4c3839c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAntDesignDemo.Pages.Antd
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using BlazorAntDesignDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using BlazorAntDesignDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/antd/antdmodal")]
    public partial class AntModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<AntDesign.Button>(0);
            __builder.AddAttribute(1, "Type", "primary");
            __builder.AddAttribute(2, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Pages\Antd\AntModal.razor"
                                  ()=>{ _visible = true; }

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    Open Modal\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<AntDesign.Modal>(6);
            __builder.AddAttribute(7, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>(
#nullable restore
#line 6 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Pages\Antd\AntModal.razor"
               title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Pages\Antd\AntModal.razor"
                 _visible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnOk", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Pages\Antd\AntModal.razor"
              HandleOk

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Pages\Antd\AntModal.razor"
                  HandleCancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenElement(13, "p");
                __builder2.OpenComponent<BlazorAntDesignDemo.Pages.AntBlazorGrid>(14);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.AddMarkupContent(16, "<p>Some contents...</p>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Pages\Antd\AntModal.razor"
      
    string title = "BasicModal";
    bool _visible = false;

    private void HandleOk(MouseEventArgs e)
    {
        Console.WriteLine(e);
        _visible = false;
    }

    private void HandleCancel(MouseEventArgs e)
    {
        Console.WriteLine(e);
        _visible = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
