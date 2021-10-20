#pragma checksum "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "619493c2a981fae074bf8882ce4b11512f742dfb"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
using Share.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userlist")]
    public partial class UserList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Danh sách người dùng</h3>");
#nullable restore
#line 6 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
 if (users == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading ...</em></p>");
#nullable restore
#line 9 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<a class=\"btn btn-success p-10\" href=\"/userdialog/0\">Thêm</a>\r\n    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-bordered table-hover table-warning table-striped mt-3 text-center");
            __builder.AddMarkupContent(5, @"<thead class=""text-center badge-danger""><tr><th>Tài khoản</th>
                <th>Họ tên</th>
                <th>Email</th>
                <th>Ngày sinh</th>
                <th>Vai trò</th>
                <th>Trạng thái</th>
                <th></th></tr></thead>
        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 26 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
             foreach (var item in users)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 29 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                         item.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 30 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                         item.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 31 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                         item.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 32 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                         item.DoB.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 33 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                         item.Roles.DisplayName()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 35 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                     if (item.Status)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "<span>Hoạt động</span>");
#nullable restore
#line 38 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<span>Không hoạt động</span>");
#nullable restore
#line 42 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "class", "btn btn-info");
            __builder.AddAttribute(30, "href", "/userdialog/" + (
#nullable restore
#line 45 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                                                                   item.UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "Sửa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
       
    public List<User> users;
    protected override void OnInitialized()
    {
        users = _userService.GetAllUser();
    }
    private void Delete(int id)
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IUserSvc _userService { get; set; }
    }
}
#pragma warning restore 1591
