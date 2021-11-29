#pragma checksum "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6630350e7bae5a70db4717f6ecb8255d1d751f92"
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
#line 12 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Modal.Services;

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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "<h1 class=\"col-6 font-weight-bold text-left\">\r\n        Danh sách đơn hàng\r\n    </h1>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-6 text-right");
            __builder.AddMarkupContent(5, "<br>\r\n        ");
            __builder.OpenElement(6, "select");
            __builder.AddAttribute(7, "value", 
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                        SearchStatus

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                 SearchOrderStatus

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(9, "option");
            __builder.AddAttribute(10, "value");
            __builder.AddMarkupContent(11, "Chọn trạng thái");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 16 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                            OrderStatus.CurOrder

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "Mới đặt");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", 
#nullable restore
#line 17 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                            OrderStatus.Delivering

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "Đang giao");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", 
#nullable restore
#line 18 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                            OrderStatus.Delivered

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, "Đã giao");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 20 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                               SearchInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "placeholder", "Nhập thông tin tìm kiếm...");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                        SearchString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchString = __value, SearchString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-outline-primary");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                          OnInitialized

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "Danh sách");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n<br>\r\n<br>");
#nullable restore
#line 28 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
 if (orders == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "<p><em>Loading ...</em></p>");
#nullable restore
#line 31 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "table");
            __builder.AddAttribute(39, "class", "table table-hover text-center");
            __builder.OpenElement(40, "thead");
            __builder.AddAttribute(41, "class", "thead-dark");
            __builder.OpenElement(42, "tr");
            __builder.OpenElement(43, "th");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                ()=>OrderSorting("Email")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(45, "Khách hàng");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "th");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                ()=>OrderSorting("Address")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(49, "Địa chỉ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "th");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                ()=>OrderSorting("OrderDate")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "Ngày đặt");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "th");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                ()=>OrderSorting("Total")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(57, "Tổng tiền");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "th");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                ()=>OrderSorting("OrderStatus")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(61, "Trạng thái");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.AddMarkupContent(63, "<th>Ghi chú</th>\r\n                <th></th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.OpenElement(65, "tbody");
#nullable restore
#line 47 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
             foreach (var item in orders)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "tr");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 50 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.Customer.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.OpenElement(70, "td");
            __builder.AddContent(71, 
#nullable restore
#line 51 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.Customer.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.OpenElement(73, "td");
            __builder.AddContent(74, 
#nullable restore
#line 52 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.OrderDate.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                    ");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, 
#nullable restore
#line 53 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.OpenElement(79, "td");
            __builder.AddContent(80, 
#nullable restore
#line 54 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.OrderStatus.DisplayName()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.OpenElement(82, "td");
            __builder.AddContent(83, 
#nullable restore
#line 55 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.Notes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.OpenElement(85, "td");
#nullable restore
#line 57 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         if (item.OrderStatus != OrderStatus.Delivered)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(86, "a");
            __builder.AddAttribute(87, "class", "btn btn-info");
            __builder.AddAttribute(88, "href", "/orderdialog/" + (
#nullable restore
#line 59 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                                        item.OrderId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(89, "Sửa");
            __builder.CloseElement();
#nullable restore
#line 60 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                        }                        

#line default
#line hidden
#nullable disable
            __builder.OpenElement(90, "a");
            __builder.AddAttribute(91, "class", "btn");
            __builder.AddAttribute(92, "href", "/orderdetail/" + (
#nullable restore
#line 61 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                           item.OrderId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(93, "Chi tiết");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
       
    public string SearchString { get; set; }
    public string SearchStatus { get; set; }
    int ids = 0;
    public List<Order> orders;

    protected void SearchInfo(ChangeEventArgs args)
    {
        SearchString = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchString))
        {
            orders = _orderService.GetAllOrder().Where(x => x.Customer.Email.ToUpper().Contains(SearchString.ToUpper())
            || (x.Customer.Address != null && x.Customer.Address.ToUpper().Contains(SearchString.ToUpper()))
            || x.Total.ToString().Contains(SearchString) || x.OrderDate.ToString().Contains(SearchString)).ToList();
        }
        else
        {
            orders = _orderService.GetAllOrder();
        }
    }

    protected void SearchOrderStatus(ChangeEventArgs args)
    {
        SearchStatus = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchStatus))
        {
            orders = _orderService.GetAllOrder().Where(x => x.OrderStatus.ToString() == SearchStatus).ToList();
        }
        else
        {
            orders = _orderService.GetAllOrder();
        }
    }

    protected void OrderSorting(string SortColumn)
    {
        orders = _orderService.GetAllOrder();
        if (ids == 0)
        {
            ids = 1;
            switch (SortColumn)
            {
                case "Email":
                    orders = orders.OrderBy(x => x.Customer.Email).ToList();
                    break;
                case "Address":
                    orders = orders.OrderBy(x => x.Customer.Address).ToList();
                    break;
                case "OrderDate":
                    orders = orders.OrderBy(x => x.OrderDate).ToList();
                    break;
                case "Total":
                    orders = orders.OrderBy(x => x.Total).ToList();
                    break;
                case "OrderStatus":
                    orders = orders.OrderBy(x => x.OrderStatus).ToList();
                    break;
            }
        }
        else
        {
            ids = 0;

            switch (SortColumn)
            {
                case "Email":
                    orders = orders.OrderByDescending(x => x.Customer.Email).ToList();
                    break;
                case "Address":
                    orders = orders.OrderByDescending(x => x.Customer.Address).ToList();
                    break;
                case "OrderDate":
                    orders = orders.OrderByDescending(x => x.OrderDate).ToList();
                    break;
                case "Total":
                    orders = orders.OrderByDescending(x => x.Total).ToList();
                    break;
                case "OrderStatus":
                    orders = orders.OrderByDescending(x => x.OrderStatus).ToList();
                    break;
            }
        }
    }

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
