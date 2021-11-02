#pragma checksum "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac8a566fa906568a4ecf72a03c489fb1b20c33f3"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.Orders
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
#line 11 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
using Server.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
using Share.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/orderlist")]
    public partial class OrderList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"font-weight-bold text-center\">Danh sách đơn hàng</h1>");
#nullable restore
#line 8 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
 if (orders == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading ...</em></p>");
#nullable restore
#line 11 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-hover text-center");
            __builder.AddMarkupContent(4, @"<thead class=""thead-dark""><tr><th>Khách hàng</th>
                <th>Địa chỉ</th>
                <th>Ngày đặt</th>
                <th>Tổng tiền</th>
                <th>Trạng thái</th>
                <th>Ghi chú</th>
                <th></th></tr></thead>
        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 27 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
             foreach (var item in orders)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 30 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.Customer.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 31 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.Customer.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 32 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.OrderDate.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 33 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 34 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.OrderStatus.DisplayName()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 35 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.Notes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "class", "btn btn-info");
            __builder.AddAttribute(28, "href", "/orderdialog/" + (
#nullable restore
#line 37 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                                    item.OrderId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "Sửa");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "class", "btn");
            __builder.AddAttribute(33, "href", "/orderdetail/" + (
#nullable restore
#line 38 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                           item.OrderId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "Chi tiết");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
       
    public List<Order> orders;
    protected override void OnInitialized()
    {
        orders = _orderService.GetAllOrder();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IOrderSvc _orderService { get; set; }
    }
}
#pragma warning restore 1591
