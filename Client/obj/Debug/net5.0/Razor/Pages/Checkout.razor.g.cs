#pragma checksum "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Checkout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2f68915aa53e2f98849cb981d882a6aec1ccbfc"
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
#line 1 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Checkout.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Checkout.razor"
using Share.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkout")]
    public partial class Checkout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .my-custom-scrollbar {\r\n        position: relative;\r\n        height: 400px;\r\n        overflow: auto;\r\n    }\r\n\r\n    .table-wrapper-scroll-y {\r\n        display: block;\r\n    }\r\n\r\n    .payment-info {\r\n        background: blue;\r\n        padding: 10px;\r\n        border-radius: 6px;\r\n        color: #fff;\r\n        font-weight: bold\r\n    }\r\n\r\n    .product-details {\r\n        padding: 10px\r\n    }\r\n\r\n    body {\r\n        background: #eee\r\n    }\r\n\r\n    .cart {\r\n        background: #fff\r\n    }\r\n\r\n    .p-about {\r\n        font-size: 12px\r\n    }\r\n\r\n    .table-shadow {\r\n        -webkit-box-shadow: 5px 5px 15px -2px rgba(0, 0, 0, 0.42);\r\n        box-shadow: 5px 5px 15px -2px rgba(0, 0, 0, 0.42)\r\n    }\r\n\r\n    .type {\r\n        font-weight: 400;\r\n        font-size: 10px\r\n    }\r\n\r\n    label.radio {\r\n        cursor: pointer\r\n    }\r\n\r\n        label.radio input {\r\n            position: absolute;\r\n            top: 0;\r\n            left: 0;\r\n            visibility: hidden;\r\n            pointer-events: none\r\n        }\r\n\r\n        label.radio span {\r\n            padding: 1px 12px;\r\n            border: 2px solid #ada9a9;\r\n            display: inline-block;\r\n            color: #8f37aa;\r\n            border-radius: 3px;\r\n            text-transform: uppercase;\r\n            font-size: 11px;\r\n            font-weight: 300\r\n        }\r\n\r\n        label.radio input:checked + span {\r\n            border-color: #fff;\r\n            background-color: blue;\r\n            color: #fff\r\n        }\r\n\r\n    .credit-inputs {\r\n        background: rgb(102, 102, 221);\r\n        color: #fff !important;\r\n        border-color: rgb(102, 102, 221)\r\n    }\r\n\r\n        .credit-inputs::placeholder {\r\n            color: #fff;\r\n            font-size: 13px\r\n        }\r\n\r\n    .credit-card-label {\r\n        font-size: 9px;\r\n        font-weight: 300\r\n    }\r\n\r\n    .form-control.credit-inputs:focus {\r\n        background: rgb(102, 102, 221);\r\n        border: rgb(102, 102, 221)\r\n    }\r\n\r\n    .line {\r\n        border-bottom: 1px solid rgb(102, 102, 221)\r\n    }\r\n\r\n    .information span {\r\n        font-size: 12px;\r\n        font-weight: 500\r\n    }\r\n\r\n    .information {\r\n        margin-bottom: 5px\r\n    }\r\n\r\n    .items {\r\n        -webkit-box-shadow: 5px 5px 4px -1px rgba(0, 0, 0, 0.25);\r\n        box-shadow: 5px 5px 4px -1px rgba(0, 0, 0, 0.08)\r\n    }\r\n\r\n    .spec {\r\n        font-size: 11px\r\n    }\r\n\r\n    .button:focus {\r\n        outline: none;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(1);
            __builder.AddAttribute(2, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 131 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Checkout.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 131 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Checkout.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "container p-3 rounded cart");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row no-gutters");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-8");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "product-details mr-2");
                __builder2.AddMarkupContent(13, "<div class=\"d-flex justify-content-between\"><b>PHƯƠNG THỨC VẬN CHUYỂN - THANH TOÁN</b></div>\r\n                    <hr>\r\n                    ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "table-wrapper-scroll-y my-custom-scrollbar");
                __builder2.OpenElement(16, "form");
                __builder2.AddAttribute(17, "class", "col-11 m-auto");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "row");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group col-6");
                __builder2.AddMarkupContent(22, "<label class=\"control-label\">Tên khách hàng</label>\r\n                                    ");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 145 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Checkout.razor"
                                                                       shipInfo.CusName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipInfo.CusName = __value, shipInfo.CusName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n                                ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group col-6");
                __builder2.AddMarkupContent(30, "<label class=\"control-label\">Địa chỉ giao hàng</label>\r\n                                    ");
                __builder2.OpenElement(31, "input");
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 150 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Checkout.razor"
                                                                       shipInfo.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipInfo.Address = __value, shipInfo.Address));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n                            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "row mt-2");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group col-6");
                __builder2.AddMarkupContent(40, "<label class=\"control-label\">Số điện thoại</label>\r\n                                    ");
                __builder2.OpenElement(41, "input");
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 157 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Checkout.razor"
                                                                       shipInfo.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipInfo.PhoneNumber = __value, shipInfo.PhoneNumber));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n\r\n                                ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-label-group col-6");
                __builder2.AddMarkupContent(48, "<label class=\"control-label\">Hình thức vận chuyển</label>\r\n                                    <br>\r\n                                    ");
                __builder2.OpenElement(49, "select");
                __builder2.OpenElement(50, "option");
                __builder2.AddAttribute(51, "value");
                __builder2.AddMarkupContent(52, "Trực tiếp");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                                        ");
                __builder2.OpenElement(54, "option");
                __builder2.AddAttribute(55, "value");
                __builder2.AddMarkupContent(56, "Tận nhà");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                            ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "row mt-2");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group col-6");
                __builder2.AddMarkupContent(62, "<label class=\"control-label\">Giá vận chuyển</label>\r\n                                    ");
                __builder2.OpenElement(63, "input");
                __builder2.AddAttribute(64, "type", "number");
                __builder2.AddAttribute(65, "class", "form-control");
                __builder2.AddAttribute(66, "readonly");
                __builder2.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 173 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Checkout.razor"
                                                                                     shipInfo.Price

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipInfo.Price = __value, shipInfo.Price, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n\r\n                                ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-label-group col-6");
                __builder2.AddMarkupContent(72, "<label class=\"control-label\">Đối tác vận chuyển</label>\r\n                                    <br>\r\n                                    ");
                __builder2.OpenElement(73, "select");
                __builder2.OpenElement(74, "option");
                __builder2.AddAttribute(75, "value");
                __builder2.AddContent(76, "Grab");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                                        ");
                __builder2.OpenElement(78, "option");
                __builder2.AddAttribute(79, "value");
                __builder2.AddContent(80, "Now");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                                        ");
                __builder2.OpenElement(82, "option");
                __builder2.AddAttribute(83, "value");
                __builder2.AddContent(84, "Gojek");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                            ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group mt-2");
                __builder2.AddMarkupContent(88, "<label class=\"control-label\">Ghi chú</label>\r\n                                ");
                __builder2.OpenElement(89, "textarea");
                __builder2.AddAttribute(90, "class", "form-control");
                __builder2.AddAttribute(91, "cols", "30");
                __builder2.AddAttribute(92, "rows", "5");
                __builder2.AddAttribute(93, "maxlength", "200");
                __builder2.AddAttribute(94, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 188 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Checkout.razor"
                                                                                                         shipInfo.Notes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipInfo.Notes = __value, shipInfo.Notes));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "col-md-4");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "payment-info");
                __builder2.AddMarkupContent(101, "<hr class=\"line\">\r\n                    ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "d-flex justify-content-between information");
                __builder2.AddMarkupContent(104, "<span>Tiền hàng</span>");
                __builder2.OpenElement(105, "span");
                __builder2.AddContent(106, 
#nullable restore
#line 199 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Checkout.razor"
                                                                                                         orderCart.Total

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                    ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "d-flex justify-content-between information");
                __builder2.AddMarkupContent(110, "<span>Shipping</span>");
                __builder2.OpenElement(111, "span");
                __builder2.AddContent(112, 
#nullable restore
#line 200 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Checkout.razor"
                                                                                                        shipInfo.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n                    ");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "d-flex justify-content-between information");
                __builder2.AddMarkupContent(116, "<span>Tổng cộng</span>");
                __builder2.OpenElement(117, "span");
                __builder2.AddAttribute(118, "id", "totalPrice");
                __builder2.AddContent(119, 
#nullable restore
#line 201 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Checkout.razor"
                                                                                                                          orderCart.Total + shipInfo.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, " \r\n                    <div id=\"paypal-button-container\"></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n            ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "row");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "col-12 text-end");
                __builder2.OpenElement(126, "input");
                __builder2.AddAttribute(127, "type", "button");
                __builder2.AddAttribute(128, "class", "ml-2 btn btn-dark");
                __builder2.AddAttribute(129, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 207 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Checkout.razor"
                                                                              Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(130, "value", "Quay lại");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 215 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Checkout.razor"
       
    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
    public ShipInfo shipInfo { get; set; }
    public Customer customer { get; set; }
    public int cusId;
    public Cart orderCart;

    //protected override void OnInitialized()
    //{
    //}

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("PaypalButton");
        }
    }

    protected override async Task OnInitializedAsync()
    {
        customer = new Customer();
        shipInfo = new ShipInfo();
        var cart = sessionStorage.GetItem<string>("cart");
        if (cart == null)
        {
            orderCart = new Share.Models.ViewModels.Cart();
        }
        else
        {
            orderCart = JsonConvert.DeserializeObject<Cart>(cart);
            if (orderCart.Total <= 1000000)
            {
                shipInfo.Price = 30000;
            }
            else if (orderCart.Total <= 2000000)
            {
                shipInfo.Price = 20000;
            }
            else
            {
                shipInfo.Price = 10000;
            }
        }

        cusId = sessionStorage.GetItem<int>("customerId");
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            using (var response = await client.GetAsync("Customer/?id=" + cusId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                customer = JsonConvert.DeserializeObject<Customer>(apiResponse);
            }
            shipInfo.CusName = customer.FullName;
            shipInfo.Address = customer.Address;
            shipInfo.PhoneNumber = customer.PhoneNumber;
        }

    }



    private void Cancel()
    {
        ModalInstance.CloseAsync(ModalResult.Ok<ShipInfo>(shipInfo));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
