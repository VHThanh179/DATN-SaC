#pragma checksum "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef04c192199486902a56c2afae30eacf64a50f26"
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
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
using Share.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/orderdetail/{id}")]
    public partial class OrderDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    dl {
        border: 3px double #ccc;
        padding: 0.5em;
        display: flex;
        flex-flow: row wrap;
        border: solid #333;
    }

    dt {
        flex-basis: 20%;
        padding: 2px 4px;
        background: #333;
        text-align: right;
        color: #fff;
        float: left;
        clear: left;
    }

        dt::after {
            content: "":"";
        }

    dd {
        flex-basis: 70%;
        flex-grow: 1;
        margin: 0;
        padding: 2px 4px;
        border-bottom: 1px solid #333;
        padding: 0 0 0.5em 0;
    }
</style>
");
            __builder.AddMarkupContent(1, "<h3>Chi tiết đơn hàng</h3>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "<hr>\r\n    ");
            __builder.OpenElement(4, "dl");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "<dt class=\"col-sm-2\">Khách hàng</dt>\r\n        ");
            __builder.OpenElement(7, "dd");
            __builder.AddAttribute(8, "class", "col-sm-10");
            __builder.AddContent(9, 
#nullable restore
#line 48 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
             order.Customer.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n        ");
            __builder.AddMarkupContent(11, "<dt class=\"col-sm-2\">Email</dt>\r\n        ");
            __builder.OpenElement(12, "dd");
            __builder.AddAttribute(13, "class", "col-sm-10");
            __builder.AddContent(14, 
#nullable restore
#line 53 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
             order.Customer.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n        ");
            __builder.AddMarkupContent(16, "<dt class=\"col-sm-2\">Địa chỉ</dt>\r\n        ");
            __builder.OpenElement(17, "dd");
            __builder.AddAttribute(18, "class", "col-sm-10");
            __builder.AddContent(19, 
#nullable restore
#line 58 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
             order.Customer.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n        ");
            __builder.AddMarkupContent(21, "<dt class=\"col-sm-2\">Ngày đặt</dt>\r\n        ");
            __builder.OpenElement(22, "dd");
            __builder.AddAttribute(23, "class", "col-sm-10");
            __builder.AddContent(24, 
#nullable restore
#line 63 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
             order.OrderDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n        ");
            __builder.AddMarkupContent(26, "<dt class=\"col-sm-2\">Tổng tiền</dt>\r\n        ");
            __builder.OpenElement(27, "dd");
            __builder.AddAttribute(28, "class", "col-sm-10");
            __builder.AddContent(29, 
#nullable restore
#line 68 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
             order.Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n        ");
            __builder.AddMarkupContent(31, "<dt class=\"col-sm-2\">Trạng thái đơn hàng</dt>\r\n        ");
            __builder.OpenElement(32, "dd");
            __builder.AddAttribute(33, "class", "col-sm-10");
            __builder.AddContent(34, 
#nullable restore
#line 73 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
             order.OrderStatus.DisplayName()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n        ");
            __builder.AddMarkupContent(36, "<dt class=\"col-sm-2\">Ghi chú</dt>\r\n        ");
            __builder.OpenElement(37, "dd");
            __builder.AddAttribute(38, "class", "col-sm-10");
            __builder.AddContent(39, 
#nullable restore
#line 78 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
             order.Notes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "table");
            __builder.AddAttribute(42, "class", "table table-bordered table-hover table-primary table-striped text-center ");
            __builder.AddMarkupContent(43, "<thead class=\"badge-primary\"><tr><th>Món ăn</th>\r\n                <th>Hình</th>\r\n                <th>Số lượng</th>\r\n                <th>Thành tiền</th>\r\n                <th>Ghi chú</th></tr></thead>\r\n        ");
            __builder.OpenElement(44, "tbody");
#nullable restore
#line 92 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
             foreach (var item in order.OrderDetails)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "tr");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 95 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
                         item.Product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "td");
            __builder.OpenElement(50, "img");
            __builder.AddAttribute(51, "src", "images/Product/" + (
#nullable restore
#line 96 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
                                                  item.Product.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "style", "width:150px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 97 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
                         item.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 98 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
                         item.TotalAmount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 99 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
                         item.Notes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 101 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.OpenElement(63, "div");
            __builder.OpenElement(64, "a");
            __builder.AddAttribute(65, "class", "btn btn-info");
            __builder.AddAttribute(66, "href", "/orderdialog/" + (
#nullable restore
#line 105 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
                                                    order.OrderId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(67, "Sửa");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, " |\r\n        ");
            __builder.AddMarkupContent(69, "<a class=\"btn\" href=\"/orderlist\">Danh sách</a>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Orders\OrderDetail.razor"
       
    [Parameter]
    public string id { get; set; }
    private string Tieude = "";
    public Order order;
    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            navigation.NavigateTo("orderlist", true);
        }
        else
        {
            order = _orderService.GetOrder(int.Parse(id));
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IOrderSvc _orderService { get; set; }
    }
}
#pragma warning restore 1591
