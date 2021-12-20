#pragma checksum "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9f4fdc1471f314782cbf6bcd0f715e6988e174a"
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
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Toast.Services;

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
            __builder.AddAttribute(4, "class", "col-6 text-right mt-3 row");
            __builder.AddMarkupContent(5, "<br>\r\n        ");
            __builder.OpenElement(6, "select");
            __builder.AddAttribute(7, "name", "cars");
            __builder.AddAttribute(8, "class", "custom-select col-5 mr-2");
            __builder.AddAttribute(9, "value", 
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                                     SearchStatus

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                                                              SearchOrderStatus

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value");
            __builder.AddMarkupContent(13, "Chọn trạng thái");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", 
#nullable restore
#line 16 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                            OrderStatus.CurOrder

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "Mới đặt");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", 
#nullable restore
#line 17 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                            OrderStatus.Delivering

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, "Đang giao");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 18 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                            OrderStatus.Delivered

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "Đã giao");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, " \r\n        ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "text");
            __builder.AddAttribute(29, "class", "form-control col-4 mr-2");
            __builder.AddAttribute(30, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 20 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                                                               SearchInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "placeholder", "Nhập thông tin tìm kiếm...");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                                        SearchString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchString = __value, SearchString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-outline-primary form-control col-2");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                                             OnInitialized

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "Tìm kiếm");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n<br>\r\n<br>");
#nullable restore
#line 27 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
 if (orders == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(40, "<p><em>Loading ...</em></p>");
#nullable restore
#line 30 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "table");
            __builder.AddAttribute(42, "class", "table table-hover text-center");
            __builder.OpenElement(43, "thead");
            __builder.AddAttribute(44, "class", "thead-dark");
            __builder.OpenElement(45, "tr");
            __builder.OpenElement(46, "th");
            __builder.AddAttribute(47, "style", "cursor: pointer");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                        ()=>OrderSorting("Email")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(49, "Khách hàng");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "th");
            __builder.AddAttribute(52, "style", "cursor: pointer");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                        ()=>OrderSorting("Address")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(54, "Địa chỉ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "th");
            __builder.AddAttribute(57, "style", "cursor: pointer");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                        ()=>OrderSorting("OrderDate")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(59, "Ngày đặt");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "th");
            __builder.AddAttribute(62, "style", "cursor: pointer");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                        ()=>OrderSorting("Total")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "Tổng tiền");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "th");
            __builder.AddAttribute(67, "style", "cursor: pointer");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                        ()=>OrderSorting("OrderStatus")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(69, "Trạng thái");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.AddMarkupContent(71, "<th width=\"150px\">Ghi chú</th>\r\n                <th></th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n        ");
            __builder.OpenElement(73, "tbody");
#nullable restore
#line 46 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
             foreach (var item in orders)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(74, "tr");
            __builder.OpenElement(75, "td");
            __builder.AddContent(76, 
#nullable restore
#line 49 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.Customer.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "td");
            __builder.AddContent(79, 
#nullable restore
#line 50 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.Customer.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.OpenElement(81, "td");
            __builder.AddContent(82, 
#nullable restore
#line 51 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.OrderDate.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.OpenElement(84, "td");
            __builder.AddContent(85, 
#nullable restore
#line 52 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.OpenElement(87, "td");
            __builder.AddContent(88, 
#nullable restore
#line 53 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.OrderStatus.DisplayName()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.OpenElement(90, "td");
            __builder.AddContent(91, 
#nullable restore
#line 54 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         item.Notes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.OpenElement(93, "td");
#nullable restore
#line 56 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                         if (item.OrderStatus != OrderStatus.Delivered)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(94, "a");
            __builder.AddAttribute(95, "class", "btn btn-info m-1");
            __builder.AddAttribute(96, "href", "/orderdialog/" + (
#nullable restore
#line 58 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                                            item.OrderId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(97, "Sửa");
            __builder.CloseElement();
#nullable restore
#line 59 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                        }                        

#line default
#line hidden
#nullable disable
            __builder.OpenElement(98, "a");
            __builder.AddAttribute(99, "class", "btn btn-info m-1");
            __builder.AddAttribute(100, "href", "/orderdetail/" + (
#nullable restore
#line 60 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
                                                                        item.OrderId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(101, "Chi tiết");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 66 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
       
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
