#pragma checksum "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecf1d8e455a0030d8e1dd6b71a513c5d2c3c2d7f"
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
#nullable restore
#line 17 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
using Share.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(InnerPageLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    :root {\r\n        --input-padding-x: 1.5rem;\r\n        --input-padding-y: .75rem;\r\n    }\r\n\r\n    .card-signin {\r\n        border: 0;\r\n        border-radius: 1rem;\r\n        box-shadow: 0 0.5rem 1rem 0 rgba(0, 0, 0, 0.1);\r\n    }\r\n\r\n        .card-signin .card-title {\r\n            margin-bottom: 2rem;\r\n            font-weight: 300;\r\n            font-size: 1.5rem;\r\n        }\r\n\r\n        .card-signin .card-body {\r\n            padding: 2rem;\r\n        }\r\n\r\n    .form-signin {\r\n        width: 100%;\r\n    }\r\n\r\n        .form-signin .btn {\r\n            font-size: 80%;\r\n            border-radius: 5rem;\r\n            letter-spacing: .1rem;\r\n            font-weight: bold;\r\n            padding: 1rem;\r\n            transition: all 0.2s;\r\n        }\r\n\r\n    .form-label-group {\r\n        position: relative;\r\n        margin-bottom: 1rem;\r\n    }\r\n\r\n        .form-label-group input {\r\n            height: auto;\r\n            border-radius: 2rem;\r\n        }\r\n\r\n        .form-label-group > input,\r\n        .form-label-group > label {\r\n            padding: var(--input-padding-y) var(--input-padding-x);\r\n        }\r\n\r\n        .form-label-group > label {\r\n            position: absolute;\r\n            top: 0;\r\n            left: 0;\r\n            display: block;\r\n            width: 100%;\r\n            margin-bottom: 0;\r\n            line-height: 1.5;\r\n            color: #495057;\r\n            border: 1px solid transparent;\r\n            border-radius: .25rem;\r\n            transition: all .1s ease-in-out;\r\n        }\r\n\r\n        .form-label-group input::-webkit-input-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input:-ms-input-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input::-ms-input-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input::-moz-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input::placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input:not(:placeholder-shown) {\r\n            padding-top: calc(var(--input-padding-y) + var(--input-padding-y) * (2 / 3));\r\n            padding-bottom: calc(var(--input-padding-y) / 3);\r\n        }\r\n\r\n            .form-label-group input:not(:placeholder-shown) ~ label {\r\n                padding-top: calc(var(--input-padding-y) / 3);\r\n                padding-bottom: calc(var(--input-padding-y) / 3);\r\n                font-size: 12px;\r\n                color: #777;\r\n            }\r\n\r\n    .btn-google {\r\n        color: white;\r\n        background-color: #ea4335;\r\n    }\r\n\r\n    .btn-facebook {\r\n        color: white;\r\n        background-color: #3b5998;\r\n    }\r\n\r\n    /*.ds {\r\n        text-align: center;\r\n        font-weight: bold;\r\n        font-size: 18px;\r\n    }\r\n\r\n    .e-dlg-content {\r\n        display: flex !important;\r\n        align-items: center !important;\r\n        justify-content: space-around !important;\r\n    }\r\n\r\n    .e-dialog {\r\n        border-radius: 30px;\r\n    }\r\n\r\n    .e-footer-content,\r\n    .e-dlg-header-content {\r\n        background: transparent;\r\n    }*/\r\n\r\n    #button {\r\n        background-color: #E53935;\r\n        border: none;\r\n        border-radius: 5px;\r\n        font-weight: 700;\r\n        width: 60px;\r\n    }\r\n\r\n    .e-popup.e-popup-open.e-dialog {\r\n        border-radius: 20px;\r\n    }\r\n\r\n    .e-dialog .e-dlg-header-content {\r\n        background-color: #FF5252;\r\n        border-radius: 20px 20px 0px 0px;\r\n    }\r\n\r\n        .e-dialog .e-dlg-header-content + .e-dlg-content {\r\n            padding: 0;\r\n        }\r\n\r\n    .e-dialog .e-dlg-header {\r\n        position: relative;\r\n        font-size: 25px;\r\n        font-weight: bold;\r\n        color: linen;\r\n        margin-left: 10px;\r\n    }\r\n\r\n    .e-dialog .e-footer-content {\r\n        padding: 15px;\r\n        border-radius: 0px 0px 20px 20px;\r\n    }\r\n\r\n    .e-dialog .e-dlg-header-content {\r\n        padding: 6px;\r\n    }\r\n\r\n    .dialogText {\r\n        color: #D50000;\r\n        font-size: 20px;\r\n        margin: 44px 11px;\r\n        font-weight: 700;\r\n    }\r\n\r\n    .e-dialog .e-dlg-header-content .e-btn.e-dlg-closeicon-btn {\r\n        margin-right: 10px;\r\n    }\r\n\r\n    .e-dialog .e-dlg-header-content .e-icon-dlg-close {\r\n        color: #FFFFFF;\r\n        margin-top: 10px;\r\n    }\r\n\r\n    .e-dlg-header, .e-dlg-header * {\r\n        color: #FFFFFF;\r\n    }\r\n\r\n    /* Fallback for Edge\r\n    -------------------------------------------------- */\r\n\r\n</style>\r\n<br>\r\n<br>\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(1);
            __builder.AddAttribute(2, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 207 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 207 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
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
                __builder2.AddMarkupContent(17, "<h5 class=\"card-title text-center fw-bold\">ĐĂNG NHẬP</h5>\r\n                            ");
                __builder2.OpenElement(18, "form");
                __builder2.AddAttribute(19, "class", "form-signin");
                __builder2.AddAttribute(20, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 215 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
                                                                 Checklogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-label-group");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "type", "text");
                __builder2.AddAttribute(25, "id", "inputEmail");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "placeholder", "Email");
                __builder2.AddAttribute(28, "autofocus");
                __builder2.AddAttribute(29, "required");
                __builder2.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 217 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
                                                                               email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                                    ");
                __builder2.AddMarkupContent(33, "<label for=\"inputEmail\">Địa chỉ mail</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n                                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-label-group");
                __builder2.OpenElement(37, "input");
                __builder2.AddAttribute(38, "type", "password");
                __builder2.AddAttribute(39, "id", "inputPassword");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "placeholder", "Mật khẩu");
                __builder2.AddAttribute(42, "required");
                __builder2.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 222 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
                                                                                      password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                                    ");
                __builder2.AddMarkupContent(46, "<label for=\"inputPassword\">Mật khẩu</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n                                ");
                __builder2.AddMarkupContent(48, "<div class=\"d-grid\"><button class=\"btn btn-lg btn-dark btn-block text-uppercase\" type=\"submit\">Đăng nhập</button></div>\r\n                                <hr class=\"my-4\">\r\n                                ");
                __builder2.AddMarkupContent(49, "<div class=\"d-grid gap-2\"><a class=\"btn btn-lg btn-google btn-block text-uppercase\" href=\"/authentication/login\" style=\"text-decoration:none;\"><i class=\"fab fa-google mr-2\"></i> Đăng nhập với Google</a></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(51);
            __builder.AddAttribute(52, "Width", "509px");
            __builder.AddAttribute(53, "Height", "220px");
            __builder.AddAttribute(54, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 254 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 254 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 254 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
                                                                                          IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsVisible = __value, IsVisible))));
            __builder.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(59);
                __builder2.AddAttribute(60, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(61, "<i class=\"fa fa-exclamation-triangle\"></i> Thông báo!");
                }
                ));
                __builder2.AddAttribute(62, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(63, "<h1 class=\"dialogText\">Đăng nhập thất bại! Tài khoản đã dừng hoạt động!</h1>");
                }
                ));
                __builder2.AddAttribute(64, "FooterTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(65, "button");
                    __builder3.AddAttribute(66, "id", "button");
                    __builder3.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 261 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
                                           CloseDialog

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "class", "e-control e-btn");
                    __builder3.AddAttribute(69, "data-ripple", "true");
                    __builder3.AddContent(70, "OK");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogAnimationSettings>(72);
                __builder2.AddAttribute(73, "Effect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Popups.DialogEffect>(
#nullable restore
#line 264 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
                                     DialogEffect.FlipXDown

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 264 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
                                                                      600

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 267 "D:\DATN\Project\SaCBackpack\Client\Pages\Login.razor"
       
    private bool loading;
    string email = "";
    string password = "";
    private string name;
    public Customer cus;
    private ToastParameters _toastParameters;

    private string Encode(string param)
    {
        return HttpUtility.UrlEncode(param);
    }
    //public void Enter(KeyboardEventArgs e)
    //{
    //    if (e.Code == "Enter" || e.Code == "NumpadEnter")
    //    {
    //        if (password != string.Empty || password != "")
    //        {
    //            Checklogin();
    //        }
    //    }
    //}
    private async Task Checklogin()
    {
        _toastParameters = new ToastParameters();
        if (email == "")
        {
            _toastParameters.Add(nameof(Notification.Title), "Vui lòng nhập email!");
            _toastParameters.Add(nameof(Notification.IsSuccess), false);
            toastService.ShowToast<Notification>(_toastParameters);
        }
        if (password == "")
        {
            _toastParameters.Add(nameof(Notification.Title), "Vui lòng nhập mật khẩu!");
            _toastParameters.Add(nameof(Notification.IsSuccess), false);
            toastService.ShowToast<Notification>(_toastParameters);
        }
        if (email != "" && password != "")
        {
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            using (var client = new HttpClient())
            {
                ViewWebLogin viewWebLogin = new ViewWebLogin() { Email = email, Password = password };
                client.DefaultRequestHeaders.Add("Access-Control-Alow-Origin", "*");
                StringContent content = new StringContent(JsonConvert.SerializeObject(viewWebLogin),
                    System.Text.Encoding.UTF8,
                    "application/json");
                HttpResponseMessage response = await client.PostAsync(apiUrl + "Token", content);
                if (response.StatusCode != HttpStatusCode.OK)
                {

                }
                else
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ViewToken>>(apiResponse);
                    if (list.Count > 0)
                    {
                        var viewToken = list[0];
                        var accessToken = viewToken.Token;
                        if (accessToken != null)
                        {
                            cus = new Customer();
                            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                            using (var resCus = await client.GetAsync(apiUrl + "Customer/?id=" + viewToken.customerID))
                            {
                                string apiResCus = await resCus.Content.ReadAsStringAsync();
                                cus = JsonConvert.DeserializeObject<Customer>(apiResCus);
                            }
                            if (cus.Status)
                            {
                                sessionStorage.SetItem("CusName", viewToken.customerName);
                                sessionStorage.SetItem("customerId", viewToken.customerID);
                                sessionStorage.SetItem("Email", email);
                                sessionStorage.SetItem("AccessToken", accessToken);
                                NavigationManager.NavigateTo("/", true);
                            }
                            else
                            {
                                OpenDialog();
                            }
                        }
                    }
                    else
                    {
                        _toastParameters.Add(nameof(Notification.Title), "Đăng nhập thất bại! Vui lòng kiểm tra lại thông tin");
                        _toastParameters.Add(nameof(Notification.IsSuccess), false);
                        toastService.ShowToast<Notification>(_toastParameters);
                    }
                }
            }
        }
    }


    private bool IsVisible { get; set; }

    private void OpenDialog()
    {
        IsVisible = true;
    }

    private void CloseDialog()
    {
        IsVisible = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
