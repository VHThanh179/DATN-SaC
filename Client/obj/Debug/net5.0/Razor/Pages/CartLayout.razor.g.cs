#pragma checksum "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a0bb8f662d1d8dcfb6d490618f1284125760f48"
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
#line 1 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
using Share.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
using Share.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cart")]
    public partial class CartLayout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .my-custom-scrollbar {\r\n        position: relative;\r\n        height: 400px;\r\n        overflow: auto;\r\n    }\r\n\r\n    .table-wrapper-scroll-y {\r\n        display: block;\r\n    }\r\n    .payment-info {\r\n        background: blue;\r\n        padding: 10px;\r\n        border-radius: 6px;\r\n        color: #fff;\r\n        font-weight: bold\r\n    }\r\n    .product-details {\r\n        padding: 10px\r\n    }\r\n\r\n    body {\r\n        background: #eee\r\n    }\r\n\r\n    .cart {\r\n        background: #fff\r\n    }\r\n\r\n    .p-about {\r\n        font-size: 12px\r\n    }\r\n\r\n    .table-shadow {\r\n        -webkit-box-shadow: 5px 5px 15px -2px rgba(0, 0, 0, 0.42);\r\n        box-shadow: 5px 5px 15px -2px rgba(0, 0, 0, 0.42)\r\n    }\r\n\r\n    .type {\r\n        font-weight: 400;\r\n        font-size: 10px\r\n    }\r\n\r\n    label.radio {\r\n        cursor: pointer\r\n    }\r\n\r\n        label.radio input {\r\n            position: absolute;\r\n            top: 0;\r\n            left: 0;\r\n            visibility: hidden;\r\n            pointer-events: none\r\n        }\r\n\r\n        label.radio span {\r\n            padding: 1px 12px;\r\n            border: 2px solid #ada9a9;\r\n            display: inline-block;\r\n            color: #8f37aa;\r\n            border-radius: 3px;\r\n            text-transform: uppercase;\r\n            font-size: 11px;\r\n            font-weight: 300\r\n        }\r\n\r\n        label.radio input:checked + span {\r\n            border-color: #fff;\r\n            background-color: blue;\r\n            color: #fff\r\n        }\r\n\r\n    .credit-inputs {\r\n        background: rgb(102, 102, 221);\r\n        color: #fff !important;\r\n        border-color: rgb(102, 102, 221)\r\n    }\r\n\r\n        .credit-inputs::placeholder {\r\n            color: #fff;\r\n            font-size: 13px\r\n        }\r\n\r\n    .credit-card-label {\r\n        font-size: 9px;\r\n        font-weight: 300\r\n    }\r\n\r\n    .form-control.credit-inputs:focus {\r\n        background: rgb(102, 102, 221);\r\n        border: rgb(102, 102, 221)\r\n    }\r\n\r\n    .line {\r\n        border-bottom: 1px solid rgb(102, 102, 221)\r\n    }\r\n\r\n    .information span {\r\n        font-size: 12px;\r\n        font-weight: 500\r\n    }\r\n\r\n    .information {\r\n        margin-bottom: 5px\r\n    }\r\n\r\n    .items {\r\n        -webkit-box-shadow: 5px 5px 4px -1px rgba(0, 0, 0, 0.25);\r\n        box-shadow: 5px 5px 4px -1px rgba(0, 0, 0, 0.08)\r\n    }\r\n\r\n    .spec {\r\n        font-size: 11px\r\n    }\r\n    .button:focus {\r\n        outline: none;\r\n    }\r\n</style>\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(1);
            __builder.AddAttribute(2, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 129 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 129 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
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
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "d-flex justify-content-between");
                __builder2.AddMarkupContent(15, "<a href=\"/\" class=\"d-flex flex-row align-items-center\"><i class=\"fa fa-long-arrow-left\"></i><span class=\"ml-2\">Tiếp tục mua sắm</span></a>\r\n                        ");
                __builder2.OpenElement(16, "a");
                __builder2.AddAttribute(17, "style", "cursor:pointer");
                __builder2.AddAttribute(18, "class", "d-flex flex-row align-items-end");
                __builder2.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 136 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                                    ChangeDisplay

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(20, "<span class=\"ml-2\">Mã khuyến mãi</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                    <hr>\r\n                    ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "table-wrapper-scroll-y my-custom-scrollbar");
                __builder2.OpenElement(24, "table");
                __builder2.AddAttribute(25, "class", "table table-responsive mb-0");
                __builder2.OpenElement(26, "tbody");
#nullable restore
#line 166 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                 foreach (var item in orderCart.ListViewCart)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(27, "tr");
                __builder2.AddAttribute(28, "class");
                __builder2.OpenElement(29, "th");
                __builder2.AddAttribute(30, "scope", "row");
                __builder2.AddAttribute(31, "width", "300px");
                __builder2.OpenElement(32, "img");
                __builder2.AddAttribute(33, "class", "rounded");
                __builder2.AddAttribute(34, "src", 
#nullable restore
#line 170 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                        imgUrl + item.product.Image

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(35, "width", "40");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                                            ");
                __builder2.OpenElement(37, "span");
                __builder2.AddAttribute(38, "class", "ml-2");
                __builder2.OpenElement(39, "span");
                __builder2.AddAttribute(40, "class", "font-weight-bold");
                __builder2.AddContent(41, 
#nullable restore
#line 171 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                               item.product.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(42, "   ");
                __builder2.OpenElement(43, "span");
                __builder2.AddAttribute(44, "class", "spec badge bg-dark");
                __builder2.AddContent(45, 
#nullable restore
#line 171 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                                                                                                        item.product.Category.DisplayName()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                                        ");
                __builder2.OpenElement(47, "th");
                __builder2.AddAttribute(48, "class", "text-center");
                __builder2.OpenElement(49, "span");
                __builder2.OpenElement(50, "i");
                __builder2.AddAttribute(51, "class", "fa fa-minus");
                __builder2.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 174 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                   () => MinusQuantity(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(53, "   ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                                            ");
                __builder2.OpenElement(55, "span");
                __builder2.AddAttribute(56, "class");
                __builder2.AddContent(57, 
#nullable restore
#line 175 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                            item.Quantity

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(58, "   ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                            ");
                __builder2.OpenElement(60, "span");
                __builder2.OpenElement(61, "i");
                __builder2.AddAttribute(62, "class", "fa fa-plus");
                __builder2.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 176 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                  () => PlusQuantity(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                                        ");
                __builder2.OpenElement(65, "th");
                __builder2.AddAttribute(66, "class", "text-center");
                __builder2.AddAttribute(67, "width", "100px");
                __builder2.OpenElement(68, "span");
                __builder2.AddAttribute(69, "class", "font-weight-bold");
                __builder2.AddContent(70, 
#nullable restore
#line 178 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                                              string.Format("{0:#,0}", item.Price * item.Quantity)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(71, "đ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                                        ");
                __builder2.OpenElement(73, "th");
                __builder2.AddAttribute(74, "class", "text-center");
                __builder2.AddAttribute(75, "width", "30px");
                __builder2.OpenElement(76, "i");
                __builder2.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 179 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                          () => DeleteCart(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "class", "fa fa-trash-o ml-3 text-black-50 ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 181 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "col-md-4");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "payment-info");
                __builder2.AddMarkupContent(84, "<div class=\"d-flex justify-content-between align-items-center\"><span>Card details</span><img class=\"rounded\" src=\"https://i.imgur.com/WU501C8.jpg\" width=\"30\"></div>");
                __builder2.AddMarkupContent(85, "<span class=\"type d-block mt-3 mb-1\">Card type</span>");
                __builder2.AddMarkupContent(86, "<label class=\"radio\"><input type=\"radio\" name=\"card\" value=\"payment\" checked> <span><img width=\"30\" src=\"https://img.icons8.com/color/48/000000/mastercard.png\"></span></label>\r\n                    ");
                __builder2.AddMarkupContent(87, "<label class=\"radio\"><input type=\"radio\" name=\"card\" value=\"payment\"> <span><img width=\"30\" src=\"https://img.icons8.com/officel/48/000000/visa.png\"></span></label>\r\n                    ");
                __builder2.AddMarkupContent(88, "<label class=\"radio\"><input type=\"radio\" name=\"card\" value=\"payment\"> <span><img width=\"30\" src=\"https://img.icons8.com/ultraviolet/48/000000/amex.png\"></span></label>\r\n                    ");
                __builder2.AddMarkupContent(89, "<label class=\"radio\"><input type=\"radio\" name=\"card\" value=\"payment\"> <span><img width=\"30\" src=\"https://img.icons8.com/officel/48/000000/paypal.png\"></span></label>\r\n                    ");
                __builder2.AddMarkupContent(90, "<div><label class=\"credit-card-label\">Name on card</label><input type=\"text\" class=\"form-control credit-inputs\" placeholder=\"Name\" autofocus></div>\r\n                    ");
                __builder2.AddMarkupContent(91, "<div><label class=\"credit-card-label\">Card number</label><input type=\"text\" class=\"form-control credit-inputs\" placeholder=\"0000 0000 0000 0000\"></div>\r\n                    ");
                __builder2.AddMarkupContent(92, @"<div class=""row""><div class=""col-md-6""><label class=""credit-card-label"">Date</label><input type=""text"" class=""form-control credit-inputs"" placeholder=""12/24""></div>
                        <div class=""col-md-6""><label class=""credit-card-label"">CVV</label><input type=""text"" class=""form-control credit-inputs"" placeholder=""342""></div></div>");
#nullable restore
#line 201 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                     if (flag)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(93, "<div id=\"couponInput\"><label class=\"credit-card-label\">Coupon code</label><input type=\"text\" class=\"form-control credit-inputs\" placeholder=\"0000 0000 0000 0000\"></div>");
#nullable restore
#line 204 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(94, "<hr class=\"line\">\r\n                    ");
                __builder2.AddMarkupContent(95, "<div class=\"d-flex justify-content-between information\"><span>Subtotal</span><span>$3000.00</span></div>\r\n                    ");
                __builder2.AddMarkupContent(96, "<div class=\"d-flex justify-content-between information\"><span>Shipping</span><span>$20.00</span></div>\r\n                    ");
                __builder2.AddMarkupContent(97, "<div class=\"d-flex justify-content-between information\"><span>Total(Incl. taxes)</span><span>$3020.00</span></div>");
                __builder2.AddMarkupContent(98, "<button class=\"btn btn-primary btn-block d-flex justify-content-between mt-3\" type=\"button\"><span>$3020.00</span><span>Checkout<i class=\"fa fa-long-arrow-right ml-1\"></i></span></button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n            ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "d-flex justify-content-between pl-3");
                __builder2.OpenElement(102, "span");
                __builder2.AddMarkupContent(103, "&nbsp; Bạn đã thêm ");
                __builder2.AddContent(104, 
#nullable restore
#line 214 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                          orderCart.ListViewCart.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(105, " sản phẩm vào giỏ hàng");
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
#line 224 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
       
    private string emailAddress;
    public Cart orderCart;
    private double totalCost = 0;
    protected string imgUrl = "";
    protected string temp = "";

    protected override void OnInitialized()
    {
        emailAddress = sessionStorage.GetItem<string>("Email");
        var cart = sessionStorage.GetItem<string>("cart");
        if (cart == null)
        {
            orderCart = new Share.Models.ViewModels.Cart();
        }
        else
        {
            orderCart = JsonConvert.DeserializeObject<Cart>(cart);
        }
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
    }

    private void PlusQuantity(CartItem item)
    {
        item.Quantity++;
    }
    private void MinusQuantity(CartItem item)
    {
        if (item.Quantity > 0)
        {
            item.Quantity--;
        }
    }

    //private void UpdateCart(CartItem item)
    //{
    //    item.Price = item.Quantity * item.product.Price;
    //    orderCart.Total = Calculate(orderCart.ListViewCart);
    //    sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));
    //}

    private void DeleteCart(CartItem item)
    {
        orderCart.ListViewCart.Remove(item);
        orderCart.Total = Calculate(orderCart.ListViewCart);
        sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));
    }

    private async Task OrderCart()
    {
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        var khachhangid = sessionStorage.GetItem<int>("khachhangId");

        orderCart.CustomerId = khachhangid;

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            StringContent content = new StringContent(JsonConvert.SerializeObject(orderCart), System.Text.Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            HttpResponseMessage response = await client.PostAsync(apiUrl + "Cart", content);

            if (response.StatusCode != HttpStatusCode.OK)
            {

            }
            else
            {
                sessionStorage.RemoveItem("cart");
                await JSRuntime.InvokeAsync<object>("clearCart", "");
                NavigationManager.NavigateTo("/history");
            }
        }
    }

    private float Calculate(List<CartItem> listCart)
    {
        float total = 0;
        if (listCart != null)
        {
            for (int i = 0; i < listCart.Count; i++)
            {
                total += listCart[i].Price;
            }
        }
        return total;
    }

    private bool flag = false;
    private void ChangeDisplay()
    {
        if (!flag)
            flag = true;
        else
            flag = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
