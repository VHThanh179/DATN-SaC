#pragma checksum "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a23732b8a592119f6f84a0fc650d60f69214d5c8"
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
#line 12 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Share.Models;

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
#line 2 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
using Share.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
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
            __builder.AddMarkupContent(0, "<style>\r\n      :root {\r\n          --input-padding-x: 1.5rem;\r\n          --input-padding-y: .75rem;\r\n      }\r\n\r\n      .card-signin {\r\n          border: 0;\r\n          border-radius: 1rem;\r\n          box-shadow: 0 0.5rem 1rem 0 rgba(0, 0, 0, 0.1);\r\n      }\r\n\r\n          .card-signin .card-title {\r\n              margin-bottom: 2rem;\r\n              font-weight: 300;\r\n              font-size: 1.5rem;\r\n          }\r\n\r\n          .card-signin .card-body {\r\n              padding: 2rem;\r\n          }\r\n\r\n      .form-signin {\r\n          width: 100%;\r\n      }\r\n\r\n          .form-signin .btn {\r\n              font-size: 80%;\r\n              border-radius: 5rem;\r\n              letter-spacing: .1rem;\r\n              font-weight: bold;\r\n              padding: 1rem;\r\n              transition: all 0.2s;\r\n          }\r\n\r\n      .form-label-group {\r\n          position: relative;\r\n          margin-bottom: 1rem;\r\n      }\r\n\r\n          .form-label-group input {\r\n              height: auto;\r\n              border-radius: 2rem;\r\n          }\r\n\r\n          .form-label-group > input,\r\n          .form-label-group > label {\r\n              padding: var(--input-padding-y) var(--input-padding-x);\r\n          }\r\n\r\n          .form-label-group > label {\r\n              position: absolute;\r\n              top: 0;\r\n              left: 0;\r\n              display: block;\r\n              width: 100%;\r\n              margin-bottom: 0;\r\n              line-height: 1.5;\r\n              color: #495057;\r\n              border: 1px solid transparent;\r\n              border-radius: .25rem;\r\n              transition: all .1s ease-in-out;\r\n          }\r\n\r\n          .form-label-group input::-webkit-input-placeholder {\r\n              color: transparent;\r\n          }\r\n\r\n          .form-label-group input:-ms-input-placeholder {\r\n              color: transparent;\r\n          }\r\n\r\n          .form-label-group input::-ms-input-placeholder {\r\n              color: transparent;\r\n          }\r\n\r\n          .form-label-group input::-moz-placeholder {\r\n              color: transparent;\r\n          }\r\n\r\n          .form-label-group input::placeholder {\r\n              color: transparent;\r\n          }\r\n\r\n          .form-label-group input:not(:placeholder-shown) {\r\n              padding-top: calc(var(--input-padding-y) + var(--input-padding-y) * (2 / 3));\r\n              padding-bottom: calc(var(--input-padding-y) / 3);\r\n          }\r\n\r\n              .form-label-group input:not(:placeholder-shown) ~ label {\r\n                  padding-top: calc(var(--input-padding-y) / 3);\r\n                  padding-bottom: calc(var(--input-padding-y) / 3);\r\n                  font-size: 12px;\r\n                  color: #777;\r\n              }\r\n\r\n      .btn-google {\r\n          color: white;\r\n          background-color: #ea4335;\r\n      }\r\n\r\n      .btn-facebook {\r\n          color: white;\r\n          background-color: #3b5998;\r\n      }\r\n\r\n      /* Fallback for Edge\r\n    -------------------------------------------------- */\r\n\r\n</style>\r\n<br>\r\n<br>\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(1);
            __builder.AddAttribute(2, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 124 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 124 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
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
                __builder2.AddMarkupContent(17, "<h5 class=\"card-title text-center fw-bold\">ĐĂNG NHẬP HỆ THỐNG</h5>\r\n                            ");
                __builder2.OpenElement(18, "form");
                __builder2.AddAttribute(19, "class", "form-signin");
                __builder2.AddAttribute(20, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 132 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
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
#line 134 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
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
                __builder2.AddAttribute(40, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 139 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
                                                                                                             Enter

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "placeholder", "Mật khẩu");
                __builder2.AddAttribute(43, "required");
                __builder2.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 139 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
                                                                                      password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                                    ");
                __builder2.AddMarkupContent(47, "<label for=\"inputPassword\">Mật khẩu</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n                                ");
                __builder2.AddMarkupContent(49, @"<div class=""custom-control custom-checkbox mb-3""><input type=""checkbox"" class=""custom-control-input"" id=""customCheck1"">
                                    <label class=""custom-control-label"" for=""customCheck1"">Ghi nhớ mật khẩu</label></div>
                                ");
                __builder2.AddMarkupContent(50, "<div class=\"d-grid\"><button class=\"btn btn-lg btn-dark btn-block text-uppercase\" type=\"submit\">Đăng nhập</button></div>");
#nullable restore
#line 150 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
                                 if (!string.IsNullOrEmpty(error))
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "alert alert-danger mt-3 mb-0");
                __builder2.AddContent(53, 
#nullable restore
#line 152 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
                                                                                (MarkupString)error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 153 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(54, "<hr class=\"my-4\">\r\n                                ");
                __builder2.AddMarkupContent(55, "<div class=\"d-grid gap-2\"><button class=\"btn btn-lg btn-google btn-block text-uppercase\" type=\"submit\"><a href=\"/authentication/login\" style=\"text-decoration:none;\"><i class=\"fab fa-google mr-2\"></i> Đăng nhập với Google</a></button></div>");
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
            __builder.AddMarkupContent(56, "\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(57);
            __builder.AddAttribute(58, "Width", "500px");
            __builder.AddAttribute(59, "Height", "250px");
            __builder.AddAttribute(60, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 168 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 168 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
                                                                     IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsVisible = __value, IsVisible))));
            __builder.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(64);
                __builder2.AddAttribute(65, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(66, " Thông báo !");
                }
                ));
                __builder2.AddAttribute(67, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(68, " Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogAnimationSettings>(70);
                __builder2.AddAttribute(71, "Effect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Popups.DialogEffect>(
#nullable restore
#line 173 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
                                     DialogEffect.FlipXDown

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 173 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
                                                                      600

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogButtons>(74);
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(76);
                    __builder3.AddAttribute(77, "Content", "OK");
                    __builder3.AddAttribute(78, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 175 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(79, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 175 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
                                                              CloseDialog

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 179 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\Login.razor"
       
    private bool loading;
    private string error;
    string email = "";
    string password = "";
    private string name;

    private string Encode(string param)
    {
        return HttpUtility.UrlEncode(param);
    }
    public void Enter(KeyboardEventArgs e)
    {
        if(e.Code == "Enter" || e.Code == "NumpadEnter")
        {
            if(password != string.Empty || password != "")
            {
                Checklogin();
            }
        }
    }
    private async Task Checklogin()
    {
        error = "";
        if (email == "")
        {
            error = " - Bạn cần nhập email.";
        }
        if (password == "")
        {
            error += (error == "" ? "" : "<br/>") + " - Bạn cần nhập password.";
        }
        if (error == "")
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
                    //error += (error == "" ? "" : "<br/>") + "- Lỗi khi gọi API.";                   
                }
                else
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ViewToken>>(apiResponse);
                    if (list.Count > 0)
                    {
                        var viewToken = list[0];
                        var accessToken = viewToken.Token;
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
