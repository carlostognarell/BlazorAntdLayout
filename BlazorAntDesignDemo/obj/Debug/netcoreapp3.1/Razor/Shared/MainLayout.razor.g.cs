#pragma checksum "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75c538499d485ce03870cad6c7bb2dcb9da87e53"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAntDesignDemo.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using BlazorAntDesignDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using BlazorAntDesignDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<AntDesign.Layout>(0);
            __builder.AddAttribute(1, "Style", "height:100vh");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Sider>(4);
                __builder2.AddAttribute(5, "Collapsible", true);
                __builder2.AddAttribute(6, "Collapsed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Shared\MainLayout.razor"
                                  collapsed

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "NoTrigger", true);
                __builder2.AddAttribute(8, "OnCollapse", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 14 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Shared\MainLayout.razor"
                                                                  OnCollapse

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "\r\n        <div class=\"logo\" style=\"height:60px;\"></div>\r\n        ");
                    __builder3.OpenComponent<AntDesign.Menu>(11);
                    __builder3.AddAttribute(12, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.MenuTheme>(
#nullable restore
#line 16 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Shared\MainLayout.razor"
                     MenuTheme.Dark

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.MenuMode>(
#nullable restore
#line 16 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Shared\MainLayout.razor"
                                           MenuMode.Inline

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "DefaultSelectedKeys", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.String>>(
#nullable restore
#line 16 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Shared\MainLayout.razor"
                                                                                  new[]{"1"}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(16, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(17);
                        __builder4.AddAttribute(18, "Key", "1");
                        __builder4.AddAttribute(19, "RouterLink", "/");
                        __builder4.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(21, "\r\n                ");
                            __builder5.OpenComponent<AntDesign.Icon>(22);
                            __builder5.AddAttribute(23, "Type", "user");
                            __builder5.AddAttribute(24, "Theme", "outline");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(25, "\r\n                ");
                            __builder5.AddMarkupContent(26, "<span>Index</span>\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(27, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(28);
                        __builder4.AddAttribute(29, "Key", "2");
                        __builder4.AddAttribute(30, "RouterLink", "counter");
                        __builder4.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(32, "\r\n                ");
                            __builder5.OpenComponent<AntDesign.Icon>(33);
                            __builder5.AddAttribute(34, "Type", "plus");
                            __builder5.AddAttribute(35, "Theme", "outline");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(36, "\r\n                ");
                            __builder5.AddMarkupContent(37, "<span>Counter</span>\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(38, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(39);
                        __builder4.AddAttribute(40, "Key", "3");
                        __builder4.AddAttribute(41, "RouterLink", "antgrid");
                        __builder4.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(43, "\r\n                ");
                            __builder5.OpenComponent<AntDesign.Icon>(44);
                            __builder5.AddAttribute(45, "Type", "bars");
                            __builder5.AddAttribute(46, "Theme", "outline");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(47, "\r\n                ");
                            __builder5.AddMarkupContent(48, "<span>Fetch Data</span>\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(49, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(50);
                        __builder4.AddAttribute(51, "Key", "4");
                        __builder4.AddAttribute(52, "RouterLink", "buttons");
                        __builder4.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(54, "\r\n                ");
                            __builder5.OpenComponent<AntDesign.Icon>(55);
                            __builder5.AddAttribute(56, "Type", "forward");
                            __builder5.AddAttribute(57, "Theme", "outline");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(58, "\r\n                ");
                            __builder5.AddMarkupContent(59, "<span>Buttons</span>\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(60, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(61);
                        __builder4.AddAttribute(62, "Key", "5");
                        __builder4.AddAttribute(63, "RouterLink", "forms");
                        __builder4.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(65, "\r\n                ");
                            __builder5.OpenComponent<AntDesign.Icon>(66);
                            __builder5.AddAttribute(67, "Type", "form");
                            __builder5.AddAttribute(68, "Theme", "outline");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(69, "\r\n                ");
                            __builder5.AddMarkupContent(70, "<span>Forms</span>\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(71, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(72);
                        __builder4.AddAttribute(73, "Key", "6");
                        __builder4.AddAttribute(74, "RouterLink", "antd/antdmodal");
                        __builder4.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(76, "\r\n                ");
                            __builder5.OpenComponent<AntDesign.Icon>(77);
                            __builder5.AddAttribute(78, "Type", "form");
                            __builder5.AddAttribute(79, "Theme", "outline");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(80, "\r\n                ");
                            __builder5.AddMarkupContent(81, "<span>Modal</span>\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(82, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(83);
                        __builder4.AddAttribute(84, "Key", "7");
                        __builder4.AddAttribute(85, "RouterLink", "antd/antdautocomplete");
                        __builder4.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(87, "\r\n                ");
                            __builder5.OpenComponent<AntDesign.Icon>(88);
                            __builder5.AddAttribute(89, "Type", "form");
                            __builder5.AddAttribute(90, "Theme", "outline");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(91, "\r\n                ");
                            __builder5.AddMarkupContent(92, "<span>AutoComplete</span>\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(93, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(94);
                        __builder4.AddAttribute(95, "Key", "8");
                        __builder4.AddAttribute(96, "RouterLink", "antd/antddatepicker");
                        __builder4.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(98, "\r\n                ");
                            __builder5.OpenComponent<AntDesign.Icon>(99);
                            __builder5.AddAttribute(100, "Type", "calendar");
                            __builder5.AddAttribute(101, "Theme", "outline");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(102, "\r\n                ");
                            __builder5.AddMarkupContent(103, "<span>DatePicker</span>\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(104, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(106, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Layout>(107);
                __builder2.AddAttribute(108, "Class", "site-layout");
                __builder2.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(110, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.Header>(111);
                    __builder3.AddAttribute(112, "Class", "site-layout-background");
                    __builder3.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(114, "\r\n");
#nullable restore
#line 53 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Shared\MainLayout.razor"
             if (collapsed)
            {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(115, "                ");
                        __builder4.OpenComponent<AntDesign.Icon>(116);
                        __builder4.AddAttribute(117, "Type", "menu-unfold");
                        __builder4.AddAttribute(118, "Theme", "outline");
                        __builder4.AddAttribute(119, "Class", "trigger");
                        __builder4.AddAttribute(120, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Shared\MainLayout.razor"
                                                                                  toggle

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(121, "\r\n");
#nullable restore
#line 56 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Shared\MainLayout.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(122, "                ");
                        __builder4.OpenComponent<AntDesign.Icon>(123);
                        __builder4.AddAttribute(124, "Type", "menu-fold");
                        __builder4.AddAttribute(125, "Theme", "outline");
                        __builder4.AddAttribute(126, "Class", "trigger");
                        __builder4.AddAttribute(127, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Shared\MainLayout.razor"
                                                                                toggle

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(128, "\r\n");
#nullable restore
#line 60 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Shared\MainLayout.razor"
            }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(129, "        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(130, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.Content>(131);
                    __builder3.AddAttribute(132, "Style", " margin: 24px 16px 0;");
                    __builder3.AddAttribute(133, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(134, "\r\n            ");
                        __builder4.OpenElement(135, "div");
                        __builder4.AddAttribute(136, "class", "site-layout-background");
                        __builder4.AddAttribute(137, "style", "padding: 24px; min-height: 360px");
                        __builder4.AddMarkupContent(138, "\r\n                ");
                        __builder4.AddContent(139, 
#nullable restore
#line 64 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(140, "\r\n            ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(141, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(142, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(143, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(144, "\r\n\r\n");
            __builder.AddMarkupContent(145, @"<style>
    #components-layout-demo-custom-trigger .trigger {
        font-size: 18px;
        line-height: 64px;
        padding: 0 24px;
        cursor: pointer;
        transition: color 0.3s;
    }

        #components-layout-demo-custom-trigger .trigger:hover {
            color: #1890ff;
        }

    #components-layout-demo-custom-trigger .logo {
        height: 32px;
        background: rgba(255, 255, 255, 0.2);
        margin: 16px;
    }

    .site-layout .site-layout-background {
        background: #fff;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Shared\MainLayout.razor"
 
    bool collapsed;

    void toggle()
    {
        collapsed = !collapsed;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Carlos Tognarell\Documents\GitHub\BlazorAntdLayout\BlazorAntDesignDemo\Shared\MainLayout.razor"
      

    void OnCollapse(bool isCollapsed)
    {
        Console.WriteLine($"Collapsed: {isCollapsed}");
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
