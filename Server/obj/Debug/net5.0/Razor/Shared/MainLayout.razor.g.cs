#pragma checksum "D:\DATN-SaC\Server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3d0a25c7c453efee7cc63d7c9cc25161d59b623"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DATN-SaC\Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DATN-SaC\Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DATN-SaC\Server\_Imports.razor"
using Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DATN-SaC\Server\_Imports.razor"
using Server.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "b-kkt30o18ti");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "id", "wrapper");
            __builder.AddAttribute(4, "b-kkt30o18ti");
            __builder.OpenComponent<Server.Shared.NavMenu>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "id", "content-wrapper");
            __builder.AddAttribute(9, "class", "d-flex flex-column");
            __builder.AddAttribute(10, "b-kkt30o18ti");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "id", "content");
            __builder.AddAttribute(13, "b-kkt30o18ti");
            __builder.OpenElement(14, "nav");
            __builder.AddAttribute(15, "class", "navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow");
            __builder.AddAttribute(16, "b-kkt30o18ti");
            __builder.AddMarkupContent(17, @"<form class=""d-none d-sm-inline-block form-inline mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search"" b-kkt30o18ti><div class=""input-group"" b-kkt30o18ti><input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for..."" aria-label=""Search"" aria-describedby=""basic-addon2"" b-kkt30o18ti>
                                <div class=""input-group-append"" b-kkt30o18ti><button class=""btn btn-primary"" type=""button"" b-kkt30o18ti><i class=""fas fa-search fa-sm"" b-kkt30o18ti></i></button></div></div></form>
                        ");
            __builder.OpenElement(18, "ul");
            __builder.AddAttribute(19, "class", "navbar-nav ml-auto");
            __builder.AddAttribute(20, "b-kkt30o18ti");
            __builder.AddMarkupContent(21, @"<li class=""nav-item dropdown no-arrow d-sm-none"" b-kkt30o18ti><a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" b-kkt30o18ti><i class=""fas fa-search fa-fw"" b-kkt30o18ti></i></a>
                                
                                <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in"" aria-labelledby=""searchDropdown"" b-kkt30o18ti><form class=""form-inline mr-auto w-100 navbar-search"" b-kkt30o18ti><div class=""input-group"" b-kkt30o18ti><input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for..."" aria-label=""Search"" aria-describedby=""basic-addon2"" b-kkt30o18ti>
                                            <div class=""input-group-append"" b-kkt30o18ti><button class=""btn btn-primary"" type=""button"" b-kkt30o18ti><i class=""fas fa-search fa-sm"" b-kkt30o18ti></i></button></div></div></form></div></li>

                            
                            ");
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "class", "nav-item dropdown no-arrow");
            __builder.AddAttribute(24, "b-kkt30o18ti");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "class", "nav-link dropdown-toggle");
            __builder.AddAttribute(27, "href", "#");
            __builder.AddAttribute(28, "id", "userDropdown");
            __builder.AddAttribute(29, "role", "button");
            __builder.AddAttribute(30, "data-toggle", "dropdown");
            __builder.AddAttribute(31, "aria-haspopup", "true");
            __builder.AddAttribute(32, "aria-expanded", "false");
            __builder.AddAttribute(33, "b-kkt30o18ti");
            __builder.OpenElement(34, "span");
            __builder.AddAttribute(35, "class", "mr-2 d-none d-lg-inline text-gray-600 small");
            __builder.AddAttribute(36, "b-kkt30o18ti");
            __builder.AddContent(37, 
#nullable restore
#line 53 "D:\DATN-SaC\Server\Shared\MainLayout.razor"
                                                                                               AuthStat.Result.User.Identity.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                    <img class=\"img-profile rounded-circle\" src=\"img/undraw_profile.svg\" b-kkt30o18ti>");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                                \r\n                                ");
            __builder.AddMarkupContent(40, @"<div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""userDropdown"" b-kkt30o18ti><a class=""dropdown-item"" href=""#"" b-kkt30o18ti><i class=""fas fa-user fa-sm fa-fw mr-2 text-gray-400"" b-kkt30o18ti></i>
                                        Profile
                                    </a>
                                    <a class=""dropdown-item"" href=""#"" b-kkt30o18ti><i class=""fas fa-cogs fa-sm fa-fw mr-2 text-gray-400"" b-kkt30o18ti></i>
                                        Settings
                                    </a>
                                    <a class=""dropdown-item"" href=""#"" b-kkt30o18ti><i class=""fas fa-list fa-sm fa-fw mr-2 text-gray-400"" b-kkt30o18ti></i>
                                        Activity Log
                                    </a>
                                    <div class=""dropdown-divider"" b-kkt30o18ti></div>
                                    <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"" b-kkt30o18ti><i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400"" b-kkt30o18ti></i>
                                        Logout
                                    </a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "container-fluid");
            __builder.AddAttribute(44, "b-kkt30o18ti");
            __builder.AddContent(45, 
#nullable restore
#line 82 "D:\DATN-SaC\Server\Shared\MainLayout.razor"
                         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.AddMarkupContent(47, "<a class=\"scroll-to-top rounded\" href=\"#page-top\" b-kkt30o18ti><i class=\"fas fa-angle-up\" b-kkt30o18ti></i></a>\r\n        \r\n        ");
            __builder.AddMarkupContent(48, @"<div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" b-kkt30o18ti><div class=""modal-dialog"" role=""document"" b-kkt30o18ti><div class=""modal-content"" b-kkt30o18ti><div class=""modal-header"" b-kkt30o18ti><h5 class=""modal-title"" id=""exampleModalLabel"" b-kkt30o18ti>Ready to Leave?</h5>
                        <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"" b-kkt30o18ti><span aria-hidden=""true"" b-kkt30o18ti>×</span></button></div>
                    <div class=""modal-body"" b-kkt30o18ti>Select ""Logout"" below if you are ready to end your current session.</div>
                    <div class=""modal-footer"" b-kkt30o18ti><button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"" b-kkt30o18ti>Cancel</button>
                        <a class=""btn btn-primary"" href=""/logout?returnUrl=/"" b-kkt30o18ti>Logout</a></div></div></div></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "D:\DATN-SaC\Server\Shared\MainLayout.razor"
      
    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }
    protected async override Task OnInitializedAsync()
    {
        base.OnInitialized();
        var user = (await AuthStat).User;
        if (!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo($"Login?returnUrl={Uri.EscapeDataString(NavigationManager.Uri)}");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
