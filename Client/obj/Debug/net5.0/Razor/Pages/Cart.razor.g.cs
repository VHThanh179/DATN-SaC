#pragma checksum "D:\DATN\Project\SaCBackpack\Client\Pages\Cart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42a7654c2fea617de48d611395e3e708c9bfb9b4"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/cart")]
    public partial class Cart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .payment-info {\r\n        background: blue;\r\n        padding: 10px;\r\n        border-radius: 6px;\r\n        color: #fff;\r\n        font-weight: bold\r\n    }\r\n\r\n    .product-details {\r\n        padding: 10px\r\n    }\r\n\r\n    body {\r\n        background: #eee\r\n    }\r\n\r\n    .cart {\r\n        background: #fff\r\n    }\r\n\r\n    .p-about {\r\n        font-size: 12px\r\n    }\r\n\r\n    .table-shadow {\r\n        -webkit-box-shadow: 5px 5px 15px -2px rgba(0, 0, 0, 0.42);\r\n        box-shadow: 5px 5px 15px -2px rgba(0, 0, 0, 0.42)\r\n    }\r\n\r\n    .type {\r\n        font-weight: 400;\r\n        font-size: 10px\r\n    }\r\n\r\n    label.radio {\r\n        cursor: pointer\r\n    }\r\n\r\n    label.radio input {\r\n        position: absolute;\r\n        top: 0;\r\n        left: 0;\r\n        visibility: hidden;\r\n        pointer-events: none\r\n    }\r\n\r\n    label.radio span {\r\n        padding: 1px 12px;\r\n        border: 2px solid #ada9a9;\r\n        display: inline-block;\r\n        color: #8f37aa;\r\n        border-radius: 3px;\r\n        text-transform: uppercase;\r\n        font-size: 11px;\r\n        font-weight: 300\r\n    }\r\n\r\n    label.radio input:checked + span {\r\n        border-color: #fff;\r\n        background-color: blue;\r\n        color: #fff\r\n    }\r\n\r\n    .credit-inputs {\r\n        background: rgb(102, 102, 221);\r\n        color: #fff !important;\r\n        border-color: rgb(102, 102, 221)\r\n    }\r\n\r\n    .credit-inputs::placeholder {\r\n        color: #fff;\r\n        font-size: 13px\r\n    }\r\n\r\n    .credit-card-label {\r\n        font-size: 9px;\r\n        font-weight: 300\r\n    }\r\n\r\n    .form-control.credit-inputs:focus {\r\n        background: rgb(102, 102, 221);\r\n        border: rgb(102, 102, 221)\r\n    }\r\n\r\n    .line {\r\n        border-bottom: 1px solid rgb(102, 102, 221)\r\n    }\r\n\r\n    .information span {\r\n        font-size: 12px;\r\n        font-weight: 500\r\n    }\r\n\r\n    .information {\r\n        margin-bottom: 5px\r\n    }\r\n\r\n    .items {\r\n        -webkit-box-shadow: 5px 5px 4px -1px rgba(0, 0, 0, 0.25);\r\n        box-shadow: 5px 5px 4px -1px rgba(0, 0, 0, 0.08)\r\n    }\r\n\r\n    .spec {\r\n        font-size: 11px\r\n    }\r\n   \r\n</style>\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(1);
            __builder.AddAttribute(2, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 111 "D:\DATN\Project\SaCBackpack\Client\Pages\Cart.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 111 "D:\DATN\Project\SaCBackpack\Client\Pages\Cart.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<div class=\"container p-3 rounded cart\"><div class=\"row no-gutters\"><div class=\"col-md-8\"><div class=\"product-details mr-2\"><a href=\"/\" class=\"d-flex flex-row align-items-center\"><i class=\"fa fa-long-arrow-left\"></i><span class=\"ml-2\">Continue Shopping</span></a>\r\n                    <hr>\r\n                    <h6 class=\"mb-0\">Shopping cart</h6>\r\n                    <div class=\"d-flex justify-content-between\"><span>You have 4 items in your cart</span>\r\n                        <div class=\"d-flex flex-row align-items-center\"><span class=\"text-black-50\">Sort by:</span>\r\n                            <div class=\"price ml-2\"><span class=\"mr-1\">price</span><i class=\"fa fa-angle-down\"></i></div></div></div>\r\n                    <div class=\"d-flex justify-content-between align-items-center mt-3 p-2 items rounded\"><div class=\"d-flex flex-row\"><img class=\"rounded\" src=\"https://i.imgur.com/QRwjbm5.jpg\" width=\"40\">\r\n                            <div class=\"ml-2\"><span class=\"font-weight-bold d-block\">Iphone 11 pro</span><span class=\"spec\">256GB, Navy Blue</span></div></div>\r\n                        <div class=\"d-flex flex-row align-items-center\"><span class=\"d-block\">2</span><span class=\"d-block ml-5 font-weight-bold\">$900</span><i class=\"fa fa-trash-o ml-3 text-black-50\"></i></div></div>\r\n                    <div class=\"d-flex justify-content-between align-items-center mt-3 p-2 items rounded\"><div class=\"d-flex flex-row\"><img class=\"rounded\" src=\"https://i.imgur.com/GQnIUfs.jpg\" width=\"40\">\r\n                            <div class=\"ml-2\"><span class=\"font-weight-bold d-block\">One pro 7T</span><span class=\"spec\">256GB, Navy Blue</span></div></div>\r\n                        <div class=\"d-flex flex-row align-items-center\"><span class=\"d-block\">2</span><span class=\"d-block ml-5 font-weight-bold\">$900</span><i class=\"fa fa-trash-o ml-3 text-black-50\"></i></div></div>\r\n                    <div class=\"d-flex justify-content-between align-items-center mt-3 p-2 items rounded\"><div class=\"d-flex flex-row\"><img class=\"rounded\" src=\"https://i.imgur.com/o2fKskJ.jpg\" width=\"40\">\r\n                            <div class=\"ml-2\"><span class=\"font-weight-bold d-block\">Google pixel 4 XL</span><span class=\"spec\">256GB, Axe black</span></div></div>\r\n                        <div class=\"d-flex flex-row align-items-center\"><span class=\"d-block\">1</span><span class=\"d-block ml-5 font-weight-bold\">$800</span><i class=\"fa fa-trash-o ml-3 text-black-50\"></i></div></div>\r\n                    <div class=\"d-flex justify-content-between align-items-center mt-3 p-2 items rounded\"><div class=\"d-flex flex-row\"><img class=\"rounded\" src=\"https://i.imgur.com/Tja5H1c.jpg\" width=\"40\">\r\n                            <div class=\"ml-2\"><span class=\"font-weight-bold d-block\">Samsung galaxy Note 10&nbsp;</span><span class=\"spec\">256GB, Navy Blue</span></div></div>\r\n                        <div class=\"d-flex flex-row align-items-center\"><span class=\"d-block\">1</span><span class=\"d-block ml-5 font-weight-bold\">$999</span><i class=\"fa fa-trash-o ml-3 text-black-50\"></i></div></div></div></div>\r\n            <div class=\"col-md-4\"><div class=\"payment-info\"><div class=\"d-flex justify-content-between align-items-center\"><span>Card details</span><img class=\"rounded\" src=\"https://i.imgur.com/WU501C8.jpg\" width=\"30\"></div><span class=\"type d-block mt-3 mb-1\">Card type</span><label class=\"radio\"><input type=\"radio\" name=\"card\" value=\"payment\" checked> <span><img width=\"30\" src=\"https://img.icons8.com/color/48/000000/mastercard.png\"></span></label>\r\n                    <label class=\"radio\"><input type=\"radio\" name=\"card\" value=\"payment\"> <span><img width=\"30\" src=\"https://img.icons8.com/officel/48/000000/visa.png\"></span></label>\r\n                    <label class=\"radio\"><input type=\"radio\" name=\"card\" value=\"payment\"> <span><img width=\"30\" src=\"https://img.icons8.com/ultraviolet/48/000000/amex.png\"></span></label>\r\n                    <label class=\"radio\"><input type=\"radio\" name=\"card\" value=\"payment\"> <span><img width=\"30\" src=\"https://img.icons8.com/officel/48/000000/paypal.png\"></span></label>\r\n                    <div><label class=\"credit-card-label\">Name on card</label><input type=\"text\" class=\"form-control credit-inputs\" placeholder=\"Name\" autofocus></div>\r\n                    <div><label class=\"credit-card-label\">Card number</label><input type=\"text\" class=\"form-control credit-inputs\" placeholder=\"0000 0000 0000 0000\"></div>\r\n                    <div class=\"row\"><div class=\"col-md-6\"><label class=\"credit-card-label\">Date</label><input type=\"text\" class=\"form-control credit-inputs\" placeholder=\"12/24\"></div>\r\n                        <div class=\"col-md-6\"><label class=\"credit-card-label\">CVV</label><input type=\"text\" class=\"form-control credit-inputs\" placeholder=\"342\"></div></div>\r\n                    <hr class=\"line\">\r\n                    <div class=\"d-flex justify-content-between information\"><span>Subtotal</span><span>$3000.00</span></div>\r\n                    <div class=\"d-flex justify-content-between information\"><span>Shipping</span><span>$20.00</span></div>\r\n                    <div class=\"d-flex justify-content-between information\"><span>Total(Incl. taxes)</span><span>$3020.00</span></div><button class=\"btn btn-primary btn-block d-flex justify-content-between mt-3\" type=\"button\"><span>$3020.00</span><span>Checkout<i class=\"fa fa-long-arrow-right ml-1\"></i></span></button></div></div></div></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591