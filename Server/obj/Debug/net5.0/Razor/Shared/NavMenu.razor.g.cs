#pragma checksum "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5319be57dfcd36e02d1e7e652217ca15827b457"
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
#line 1 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Server.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<ul class=\"navbar-nav bg-gradient-primary sidebar sidebar-dark accordion\" id=\"accordionSidebar\" b-nl6y4qj04c><a class=\"sidebar-brand d-flex align-items-center justify-content-center\" href b-nl6y4qj04c><div class=\"sidebar-brand-icon rotate-n-15\" b-nl6y4qj04c><i class=\"fas fa-laugh-wink\" b-nl6y4qj04c></i></div>\r\n        <div class=\"sidebar-brand-text mx-3\" b-nl6y4qj04c>SaC</div></a>\r\n    <hr class=\"sidebar-divider my-0\" b-nl6y4qj04c>\r\n    <li class=\"nav-item\" b-nl6y4qj04c><a class=\"nav-link\" href Match=\"NavLinkMatch.All\" b-nl6y4qj04c><i class=\"fas fa-fw fa-tachometer-alt\" b-nl6y4qj04c></i>\r\n            <span b-nl6y4qj04c>Dashboard</span></a></li>\r\n    <hr class=\"sidebar-divider\" b-nl6y4qj04c>\r\n    <li class=\"nav-item\" b-nl6y4qj04c><a class=\"nav-link\" href=\"/productlist\" b-nl6y4qj04c><i class=\"fas fa-fw fa-tachometer-alt\" b-nl6y4qj04c></i>\r\n            <span b-nl6y4qj04c>Sản phẩm</span></a></li>\r\n    <hr class=\"sidebar-divider\" b-nl6y4qj04c>\r\n    <li class=\"nav-item\" b-nl6y4qj04c><a class=\"nav-link\" href=\"/orderlist\" b-nl6y4qj04c><i class=\"fas fa-fw fa-tachometer-alt\" b-nl6y4qj04c></i>\r\n            <span b-nl6y4qj04c>Đơn hàng</span></a></li>\r\n    <hr class=\"sidebar-divider\" b-nl6y4qj04c>\r\n    <li class=\"nav-item\" b-nl6y4qj04c><a class=\"nav-link\" href=\"/customerlist\" b-nl6y4qj04c><i class=\"fas fa-fw fa-tachometer-alt\" b-nl6y4qj04c></i>\r\n            <span b-nl6y4qj04c>Khách hàng</span></a></li>\r\n    <hr class=\"sidebar-divider\" b-nl6y4qj04c>\r\n    <li class=\"nav-item\" b-nl6y4qj04c><a class=\"nav-link\" href=\"/userlist\" b-nl6y4qj04c><i class=\"fas fa-fw fa-tachometer-alt\" b-nl6y4qj04c></i>\r\n            <span b-nl6y4qj04c>Quản lý</span></a></li>\r\n    <hr class=\"sidebar-divider\" b-nl6y4qj04c>\r\n    <li class=\"nav-item\" b-nl6y4qj04c><a class=\"nav-link\" href=\"/voucherlist\" b-nl6y4qj04c><i class=\"fas fa-fw fa-tachometer-alt\" b-nl6y4qj04c></i>\r\n            <span b-nl6y4qj04c>Phiếu giảm giá</span></a></li>\r\n    <hr class=\"sidebar-divider\" b-nl6y4qj04c>\r\n    <li class=\"nav-item\" b-nl6y4qj04c><a class=\"nav-link\" href b-nl6y4qj04c><i class=\"fas fa-fw fa-tachometer-alt\" b-nl6y4qj04c></i>\r\n            <span b-nl6y4qj04c>Thống kê</span></a></li>\r\n    <hr class=\"sidebar-divider\" b-nl6y4qj04c>\r\n    <li class=\"nav-item\" b-nl6y4qj04c><a class=\"nav-link\" href=\"/shipinfolist\" b-nl6y4qj04c><i class=\"fas fa-fw fa-tachometer-alt\" b-nl6y4qj04c></i>\r\n            <span b-nl6y4qj04c>Thông tin vận chuyển</span></a></li></ul>");
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
