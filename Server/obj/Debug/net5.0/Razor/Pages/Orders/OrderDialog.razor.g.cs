#pragma checksum "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb49f9cf7195b521cbfc427ba2b68cea0b024270"
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
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/orderdialog/{id}")]
    public partial class OrderDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-xl-8 mx-auto");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card card-signin flex-row shadow-lg card-signup");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.AddMarkupContent(10, "<h2 class=\"card-title text-center font-weight-bold text-uppercase\">Chỉnh sửa đơn hàng</h2>\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-12");
            __builder.OpenElement(13, "form");
            __builder.AddAttribute(14, "asp-action", "Edit");
            __builder.AddAttribute(15, "class", "form-signin");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(16);
            __builder.AddAttribute(17, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
                                              order

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
                                                                     SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(20);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                                ");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "type", "hidden");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
                                                            order.OrderId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => order.OrderId = __value, order.OrderId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                                ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-label-group mt-3 row");
                __builder2.AddMarkupContent(29, "<label class=\"control-lable col-5\">Khách hàng</label>\r\n                                    ");
                __builder2.OpenElement(30, "span");
                __builder2.AddAttribute(31, "class", "font-weight-bold col-7");
                __builder2.AddContent(32, 
#nullable restore
#line 25 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
                                                                          order.Customer.FullName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                                    ");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "style", "display:none");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
                                                  order.CustomerId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => order.CustomerId = __value, order.CustomerId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n                                ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-label-group mt-3 row");
                __builder2.AddMarkupContent(42, "<label class=\"control-lable col-5\">Email</label>\r\n                                    ");
                __builder2.OpenElement(43, "span");
                __builder2.AddAttribute(44, "class", "font-weight-bold col-7");
                __builder2.AddContent(45, 
#nullable restore
#line 31 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
                                                                          order.Customer.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n                                ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-label-group mt-3 row");
                __builder2.AddMarkupContent(49, "<label class=\"control-lable col-5\">Địa chỉ</label>\r\n                                    ");
                __builder2.OpenElement(50, "span");
                __builder2.AddAttribute(51, "class", "font-weight-bold col-7");
                __builder2.AddContent(52, 
#nullable restore
#line 36 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
                                                                          order.Customer.Address

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n\r\n                                ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-label-group mt-3 row");
                __builder2.AddMarkupContent(56, "<label class=\"control-lable col-5\">Ngày đặt</label>\r\n                                    ");
                __builder2.OpenElement(57, "span");
                __builder2.AddAttribute(58, "class", "font-weight-bold col-7");
                __builder2.AddContent(59, 
#nullable restore
#line 41 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
                                                                          order.OrderDate.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n                                ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-label-group mt-3 row");
                __builder2.AddMarkupContent(63, "<label class=\"control-lable col-5\">Tổng tiền</label>\r\n                                    ");
                __builder2.OpenElement(64, "span");
                __builder2.AddAttribute(65, "class", "font-weight-bold col-7");
                __builder2.AddContent(66, 
#nullable restore
#line 46 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
                                                                          order.Total

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n\r\n                                ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "form-label-group mt-3 row");
                __builder2.AddMarkupContent(70, "<label class=\"control-lable col-5\">Trạng thái</label>\r\n                                    ");
                __Blazor.Server.Pages.Orders.OrderDialog.TypeInference.CreateInputSelect_0(__builder2, 71, 72, "form-control col-5", 73, 
#nullable restore
#line 51 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
                                                               order.OrderStatus

#line default
#line hidden
#nullable disable
                , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => order.OrderStatus = __value, order.OrderStatus)), 75, () => order.OrderStatus, 76, (__builder3) => {
                    __builder3.OpenElement(77, "option");
                    __builder3.AddAttribute(78, "value", 
#nullable restore
#line 52 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
                                                        OrderStatus.CurOrder

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(79, "Mới đặt");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(80, "\r\n                                        ");
                    __builder3.OpenElement(81, "option");
                    __builder3.AddAttribute(82, "value", 
#nullable restore
#line 53 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
                                                        OrderStatus.Delivering

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(83, "Đang giao");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(84, "\r\n                                        ");
                    __builder3.OpenElement(85, "option");
                    __builder3.AddAttribute(86, "value", 
#nullable restore
#line 54 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
                                                        OrderStatus.Delivered

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(87, "Đã giao");
                    __builder3.CloseElement();
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n\r\n                                ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-label-group mt-3 row");
                __builder2.AddMarkupContent(91, "<label class=\"control-lable col-5\">Ghi chú</label>\r\n                                    ");
                __builder2.OpenElement(92, "textarea");
                __builder2.AddAttribute(93, "class", "form-control col-5");
                __builder2.AddAttribute(94, "rows", "3");
                __builder2.AddAttribute(95, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
                                                     order.Notes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => order.Notes = __value, order.Notes));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n\r\n                                ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "form-label-group mt-4");
                __builder2.AddMarkupContent(100, "<button type=\"submit\" class=\"btn btn-info\">Lưu</button>\r\n                                    ");
                __builder2.OpenElement(101, "input");
                __builder2.AddAttribute(102, "type", "button");
                __builder2.AddAttribute(103, "class", "btn btn-primary");
                __builder2.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
                                                                                            Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(105, "value", "Thoát");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
       
    [Parameter]
    public string id { get; set; }
    private ToastParameters _toastParameters;
    private Share.Models.Order order { get; set; }

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
    private void SubmitForm()
    {
        _toastParameters = new ToastParameters();
        int ret = _orderService.EditOrder(order.OrderId, order);
        if (ret != 0)
        {
            _toastParameters.Add(nameof(Notification.Title), "Chỉnh sửa đơn hàng thành công!");
            _toastParameters.Add(nameof(Notification.IsSuccess), true);
            toastService.ShowToast<Notification>(_toastParameters);
        }
        else
        {
            _toastParameters.Add(nameof(Notification.Title), "Chỉnh sửa đơn hàng thất bại!");
            _toastParameters.Add(nameof(Notification.IsSuccess), false);
            toastService.ShowToast<Notification>(_toastParameters);
        }
        navigation.NavigateTo("Orderlist");
    }
    public void Cancel()
    {
        navigation.NavigateTo("OrderList", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IOrderSvc _orderService { get; set; }
    }
}
namespace __Blazor.Server.Pages.Orders.OrderDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
