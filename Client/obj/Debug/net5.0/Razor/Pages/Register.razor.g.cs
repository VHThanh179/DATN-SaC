#pragma checksum "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38bfcce09e411146163190f54fde760fb2fb2a45"
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
#line 17 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(InnerPageLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    :root {\r\n        --input-padding-x: 1.5rem;\r\n        --input-padding-y: .75rem;\r\n    }\r\n\r\n    .card-signin {\r\n        border: 0;\r\n        border-radius: 1rem;\r\n        box-shadow: 0 0.5rem 1rem 0 rgba(0, 0, 0, 0.1);\r\n    }\r\n\r\n        .card-signin .card-title {\r\n            margin-bottom: 2rem;\r\n            font-weight: 300;\r\n            font-size: 1.5rem;\r\n        }\r\n\r\n        .card-signin .card-body {\r\n            padding: 2rem;\r\n        }\r\n\r\n    .form-signin {\r\n        width: 100%;\r\n    }\r\n\r\n        .form-signin .btn {\r\n            font-size: 80%;\r\n            border-radius: 5rem;\r\n            letter-spacing: .1rem;\r\n            font-weight: bold;\r\n            padding: 1rem;\r\n            transition: all 0.2s;\r\n        }\r\n\r\n    .form-label-group {\r\n        position: relative;\r\n        margin-bottom: 1rem;\r\n    }\r\n\r\n        .form-label-group input {\r\n            height: auto;\r\n            border-radius: 2rem;\r\n        }\r\n\r\n        .form-label-group > input,\r\n        .form-label-group > label {\r\n            padding: var(--input-padding-y) var(--input-padding-x);\r\n        }\r\n\r\n        .form-label-group > label {\r\n            position: absolute;\r\n            top: 0;\r\n            left: 0;\r\n            display: block;\r\n            width: 100%;\r\n            margin-bottom: 0;\r\n            line-height: 1.5;\r\n            color: #495057;\r\n            border: 1px solid transparent;\r\n            border-radius: .25rem;\r\n            transition: all .1s ease-in-out;\r\n        }\r\n\r\n        .form-label-group input::-webkit-input-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input:-ms-input-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input::-ms-input-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input::-moz-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input::placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input:not(:placeholder-shown) {\r\n            padding-top: calc(var(--input-padding-y) + var(--input-padding-y) * (2 / 3));\r\n            padding-bottom: calc(var(--input-padding-y) / 3);\r\n        }\r\n\r\n            .form-label-group input:not(:placeholder-shown) ~ label {\r\n                padding-top: calc(var(--input-padding-y) / 3);\r\n                padding-bottom: calc(var(--input-padding-y) / 3);\r\n                font-size: 12px;\r\n                color: #777;\r\n            }\r\n\r\n    .btn-google {\r\n        color: white;\r\n        background-color: #ea4335;\r\n    }\r\n\r\n    .btn-facebook {\r\n        color: white;\r\n        background-color: #3b5998;\r\n    }\r\n\r\n    /* Fallback for Edge\r\n    -------------------------------------------------- */\r\n\r\n</style>\r\n<br>\r\n<br>\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(1);
            __builder.AddAttribute(2, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 122 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 122 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "mt-2");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "container");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-sm-9 col-md-7 col-lg-5 mx-auto");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "card card-signin my-5");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "card-body");
                __builder2.AddMarkupContent(17, "<h5 class=\"card-title text-center fw-bold\">ĐĂNG KÝ THÀNH VIÊN</h5>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(18);
                __builder2.AddAttribute(19, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 130 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                  customer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 130 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                                            SubmitForm

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(21, "class", "form-signin");
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(23);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n                                    <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n                                    ");
                    __builder3.AddMarkupContent(25, @"<div class=""d-grid gap-2""><button class=""btn btn-lg btn-google btn-block text-uppercase"" type=""submit""><i class=""fab fa-google mr-2""></i> Đăng ký bằng Google</button>
                                        <button class=""btn btn-lg btn-facebook btn-block text-uppercase"" type=""submit""><i class=""fab fa-facebook-f mr-2""></i> Đăng ký bằng Facebook</button></div>
                                    <hr class=""my-4"">
                                    ");
                    __builder3.AddMarkupContent(26, "<h6 class=\"card-title text-center fw-bold\">TẠO TÀI KHOẢN MỚI</h6>\r\n                                    ");
                    __builder3.OpenElement(27, "div");
                    __builder3.AddAttribute(28, "class", "form-label-group");
                    __builder3.OpenElement(29, "input");
                    __builder3.AddAttribute(30, "type", "email");
                    __builder3.AddAttribute(31, "id", "inputEmail");
                    __builder3.AddAttribute(32, "class", "form-control");
                    __builder3.AddAttribute(33, "placeholder", "Địa chỉ mail");
                    __builder3.AddAttribute(34, "required");
                    __builder3.AddAttribute(35, "autofocus");
                    __builder3.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 140 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                      customer.Email

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.Email = __value, customer.Email));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(38, "\r\n                                        ");
                    __builder3.AddMarkupContent(39, "<label for=\"inputEmail\">Địa chỉ mail</label>\r\n                                        ");
                    __Blazor.Client.Pages.Register.TypeInference.CreateValidationMessage_0(__builder3, 40, 41, 
#nullable restore
#line 142 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                                  () => customer.Email

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\r\n                                    ");
                    __builder3.OpenElement(43, "div");
                    __builder3.AddAttribute(44, "class", "form-label-group");
                    __builder3.OpenElement(45, "input");
                    __builder3.AddAttribute(46, "type", "text");
                    __builder3.AddAttribute(47, "id", "inputFullname");
                    __builder3.AddAttribute(48, "class", "form-control");
                    __builder3.AddAttribute(49, "placeholder", "Họ tên");
                    __builder3.AddAttribute(50, "required");
                    __builder3.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 145 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                      customer.FullName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.FullName = __value, customer.FullName));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\r\n                                        ");
                    __builder3.AddMarkupContent(54, "<label for=\"inputFullname\">Họ tên</label>\r\n                                        ");
                    __Blazor.Client.Pages.Register.TypeInference.CreateValidationMessage_1(__builder3, 55, 56, 
#nullable restore
#line 147 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                                  () => customer.FullName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(57, "\r\n                                    ");
                    __builder3.OpenElement(58, "div");
                    __builder3.AddAttribute(59, "class", "form-label-group");
                    __builder3.OpenElement(60, "input");
                    __builder3.AddAttribute(61, "type", "date");
                    __builder3.AddAttribute(62, "id", "dob");
                    __builder3.AddAttribute(63, "class", "form-control");
                    __builder3.AddAttribute(64, "placeholder", "Ngày sinh");
                    __builder3.AddAttribute(65, "required");
                    __builder3.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 150 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                      customer.DoB

#line default
#line hidden
#nullable disable
                    , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.DoB = __value, customer.DoB, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\r\n                                        ");
                    __builder3.AddMarkupContent(69, "<label for=\"dob\">Ngày sinh</label>\r\n                                        ");
                    __Blazor.Client.Pages.Register.TypeInference.CreateValidationMessage_2(__builder3, 70, 71, 
#nullable restore
#line 152 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                                  () => customer.DoB

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\r\n                                    ");
                    __builder3.OpenElement(73, "div");
                    __builder3.AddAttribute(74, "class", "form-label-group");
                    __builder3.OpenElement(75, "input");
                    __builder3.AddAttribute(76, "type", "text");
                    __builder3.AddAttribute(77, "id", "address");
                    __builder3.AddAttribute(78, "class", "form-control");
                    __builder3.AddAttribute(79, "placeholder", "Địa chỉ");
                    __builder3.AddAttribute(80, "required");
                    __builder3.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 155 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                      customer.Address

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.Address = __value, customer.Address));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\r\n                                        ");
                    __builder3.AddMarkupContent(84, "<label for=\"address\">Địa chỉ</label>\r\n                                        ");
                    __Blazor.Client.Pages.Register.TypeInference.CreateValidationMessage_3(__builder3, 85, 86, 
#nullable restore
#line 157 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                                  () => customer.Address

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\r\n                                    ");
                    __builder3.OpenElement(88, "div");
                    __builder3.AddAttribute(89, "class", "form-label-group");
                    __builder3.OpenElement(90, "input");
                    __builder3.AddAttribute(91, "type", "tel");
                    __builder3.AddAttribute(92, "id", "phone");
                    __builder3.AddAttribute(93, "class", "form-control");
                    __builder3.AddAttribute(94, "placeholder", "Số điện thoại");
                    __builder3.AddAttribute(95, "required");
                    __builder3.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 160 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                      customer.PhoneNumber

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.PhoneNumber = __value, customer.PhoneNumber));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(98, "\r\n                                        ");
                    __builder3.AddMarkupContent(99, "<label for=\"phone\">Số điện thoại</label>\r\n                                        ");
                    __Blazor.Client.Pages.Register.TypeInference.CreateValidationMessage_4(__builder3, 100, 101, 
#nullable restore
#line 162 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                                  () => customer.PhoneNumber

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(102, "\r\n                                    ");
                    __builder3.OpenElement(103, "div");
                    __builder3.AddAttribute(104, "class", "form-label-group");
                    __builder3.OpenElement(105, "input");
                    __builder3.AddAttribute(106, "type", "password");
                    __builder3.AddAttribute(107, "id", "inputPassword");
                    __builder3.AddAttribute(108, "class", "form-control");
                    __builder3.AddAttribute(109, "placeholder", "Mật khẩu");
                    __builder3.AddAttribute(110, "required");
                    __builder3.AddAttribute(111, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 165 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                      customer.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(112, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.Password = __value, customer.Password));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\r\n                                        ");
                    __builder3.AddMarkupContent(114, "<label for=\"inputPassword\">Mật khẩu</label>\r\n                                        ");
                    __Blazor.Client.Pages.Register.TypeInference.CreateValidationMessage_5(__builder3, 115, 116, 
#nullable restore
#line 167 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                                  () => customer.Password

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(117, "\r\n                                    ");
                    __builder3.OpenElement(118, "div");
                    __builder3.AddAttribute(119, "class", "form-label-group");
                    __builder3.OpenElement(120, "input");
                    __builder3.AddAttribute(121, "type", "password");
                    __builder3.AddAttribute(122, "id", "inputConfirmPassword");
                    __builder3.AddAttribute(123, "class", "form-control");
                    __builder3.AddAttribute(124, "placeholder", "Xác nhận mật khẩu");
                    __builder3.AddAttribute(125, "required");
                    __builder3.AddAttribute(126, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 170 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                      customer.ConfirmPassword

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(127, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.ConfirmPassword = __value, customer.ConfirmPassword));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(128, "\r\n                                        ");
                    __builder3.AddMarkupContent(129, "<label for=\"inputConfirmPassword\">Xác nhận mật khẩu</label>\r\n                                        ");
                    __Blazor.Client.Pages.Register.TypeInference.CreateValidationMessage_6(__builder3, 130, 131, 
#nullable restore
#line 172 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
                                                                  () => customer.ConfirmPassword

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(132, "\r\n                                    ");
                    __builder3.AddMarkupContent(133, "<div class=\"d-grid\"><input value=\"Đăng ký\" type=\"submit\" class=\"btn btn-lg btn-dark btn-block text-uppercase\"></div>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
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
#line 185 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Register.razor"
       
    Share.Models.Customer customer = new Share.Models.Customer();
    private string Tieude = "Đăng ký tài khoản";
    //Life cycle 
    protected override void OnInitialized()
    {
        customer.CreatedDate = DateTime.Now;
        customer.Status = true;
    }
    private async void SubmitForm()
    {
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        using (var client = new HttpClient())
        {            
            StringContent content = new StringContent(JsonConvert.SerializeObject(customer), System.Text.Encoding.UTF8,
                "application/json");
            client.DefaultRequestHeaders.Add("Access-Control-Alow-Origin", "*");
            HttpResponseMessage response = await client.PostAsync(apiUrl + "customer", content);

            if (response.StatusCode != HttpStatusCode.OK)
            {

            }
            else
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                if (apiResponse == "-1")
                {

                }
                else
                {
                    NavigationManager.NavigateTo("/");
                }
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
namespace __Blazor.Client.Pages.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
