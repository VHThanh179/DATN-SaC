#pragma checksum "D:\DATN\Project\SaCBackpack\Client\Pages\OrderDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "905091db96dee2de3862bbf27ac492d779625d69"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class OrderDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Chi tiết đơn hàng</h3>\r\n");
            __builder.AddMarkupContent(1, @"<div><hr>
    <dl class=""row""><dt class=""col-sm-2"">Ngày đặt</dt>
        <dd class=""col-sm-10"">
            20/10/2021
        </dd>

        <dt class=""col-sm-2"">Tổng tiền</dt>
        <dd class=""col-sm-10"">
            200000
        </dd>

        <dt class=""col-sm-2"">Trạng thái</dt>
        <dd class=""col-sm-10"">
            Đã giao
        </dd>

        <dt class=""col-sm-2"">Ghi chú</dt>
        <dd class=""col-sm-10"">
            ABC
        </dd>
        <dt class=""col-sm-2"">Địa chỉ</dt>
        <dd class=""col-sm-10"">
            SG
        </dd></dl>
    <table class=""table""><thead><tr><th>Sản phẩm</th>
                <th>Hình</th>
                <th>Số lượng</th>
                <th>Thành tiền</th>
                <th>Ghi chú</th></tr></thead>
        <tbody><tr><td>
                            Balo
                        </td>
                        <td></td>
                        <td>
                           50
                        </td>
                        <td>
                            69696969
                        </td>
                        <td>
                            DEF
                        </td></tr></tbody></table></div>
");
            __builder.AddMarkupContent(2, "<div><a class=\"btn btn-info\" href=\"/\">Trang chủ</a> |\r\n    <a class=\"btn\" href=\"/History\">Danh sách</a></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
