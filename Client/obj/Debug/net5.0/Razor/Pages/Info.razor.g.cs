#pragma checksum "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef1791d44bee381a4ebea80f67c44cd5c04d0f43"
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
#line 18 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/info/{id}")]
    public partial class Info : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    :root {\r\n        --input-padding-x: 1.5rem;\r\n        --input-padding-y: .75rem;\r\n    }\r\n\r\n    .card-signin {\r\n        border: 0;\r\n        border-radius: 1rem;\r\n        box-shadow: 0 0.5rem 1rem 0 rgba(0, 0, 0, 0.1);\r\n    }\r\n\r\n        .card-signin .card-title {\r\n            margin-bottom: 2rem;\r\n            font-weight: 300;\r\n            font-size: 1.5rem;\r\n        }\r\n\r\n        .card-signin .card-body {\r\n            padding: 2rem;\r\n        }\r\n\r\n    .form-signin {\r\n        width: 100%;\r\n    }\r\n\r\n        .form-signin .btn {\r\n            font-size: 80%;\r\n            border-radius: 5rem;\r\n            letter-spacing: .1rem;\r\n            font-weight: bold;\r\n            padding: 1rem;\r\n            transition: all 0.2s;\r\n        }\r\n\r\n    .form-label-group {\r\n        position: relative;\r\n        margin-bottom: 1rem;\r\n    }\r\n\r\n        .form-label-group input {\r\n            height: auto;\r\n            border-radius: 2rem;\r\n        }\r\n\r\n        .form-label-group > input,\r\n        .form-label-group > label {\r\n            padding: var(--input-padding-y) var(--input-padding-x);\r\n        }\r\n\r\n        .form-label-group > label {\r\n            position: absolute;\r\n            top: 0;\r\n            left: 0;\r\n            display: block;\r\n            width: 100%;\r\n            margin-bottom: 0;\r\n            line-height: 1.5;\r\n            color: #495057;\r\n            border: 1px solid transparent;\r\n            border-radius: .25rem;\r\n            transition: all .1s ease-in-out;\r\n        }\r\n\r\n        .form-label-group input::-webkit-input-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input:-ms-input-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input::-ms-input-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input::-moz-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input::placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input:not(:placeholder-shown) {\r\n            padding-top: calc(var(--input-padding-y) + var(--input-padding-y) * (2 / 3));\r\n            padding-bottom: calc(var(--input-padding-y) / 3);\r\n        }\r\n\r\n            .form-label-group input:not(:placeholder-shown) ~ label {\r\n                padding-top: calc(var(--input-padding-y) / 3);\r\n                padding-bottom: calc(var(--input-padding-y) / 3);\r\n                font-size: 12px;\r\n                color: #777;\r\n            }\r\n\r\n\r\n    /* Fallback for Edge\r\n        -------------------------------------------------- */\r\n\r\n</style>\r\n<br>\r\n<br>\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(1);
            __builder.AddAttribute(2, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 115 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 115 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
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
                __builder2.AddMarkupContent(17, "<h5 class=\"card-title text-center fw-bold\">Thông tin cá nhân</h5>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(18);
                __builder2.AddAttribute(19, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 123 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                              cus

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 123 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                                                   SubmitForm

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(21, "class", "form-signin");
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(23);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n                                ");
                    __builder3.OpenElement(25, "input");
                    __builder3.AddAttribute(26, "type", "hidden");
                    __builder3.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 125 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                                            cus.CustomerId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cus.CustomerId = __value, cus.CustomerId));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(29, "\r\n                                ");
                    __builder3.OpenElement(30, "div");
                    __builder3.AddAttribute(31, "class", "form-label-group");
                    __builder3.OpenElement(32, "input");
                    __builder3.AddAttribute(33, "type", "text");
                    __builder3.AddAttribute(34, "id", "inputEmail");
                    __builder3.AddAttribute(35, "class", "form-control");
                    __builder3.AddAttribute(36, "readonly");
                    __builder3.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 127 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                                                              cus.Email

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cus.Email = __value, cus.Email));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(39, "\r\n                                    ");
                    __builder3.AddMarkupContent(40, "<label class=\"control-label\">Địa chỉ Email</label>\r\n                                    ");
                    __Blazor.Client.Pages.Info.TypeInference.CreateValidationMessage_0(__builder3, 41, 42, 
#nullable restore
#line 129 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                                              () => cus.Email

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\r\n\r\n                                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(44);
                    __builder3.AddAttribute(45, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Authorized) => (__builder4) => {
                        __builder4.OpenElement(46, "div");
                        __builder4.AddAttribute(47, "class", "form-label-group");
                        __builder4.OpenElement(48, "input");
                        __builder4.AddAttribute(49, "type", "text");
                        __builder4.AddAttribute(50, "id", "inputFullname");
                        __builder4.AddAttribute(51, "class", "form-control");
                        __builder4.AddAttribute(52, "readonly");
                        __builder4.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 135 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                                                                         cus.FullName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cus.FullName = __value, cus.FullName));
                        __builder4.SetUpdatesAttributeName("value");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(55, "\r\n                                            ");
                        __builder4.AddMarkupContent(56, "<label class=\"control-label\">Họ tên</label>\r\n                                            ");
                        __Blazor.Client.Pages.Info.TypeInference.CreateValidationMessage_1(__builder4, 57, 58, 
#nullable restore
#line 137 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                                                      () => cus.FullName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.AddAttribute(59, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((NotAuthorized) => (__builder4) => {
                        __builder4.OpenElement(60, "div");
                        __builder4.AddAttribute(61, "class", "form-label-group");
                        __builder4.OpenElement(62, "input");
                        __builder4.AddAttribute(63, "type", "text");
                        __builder4.AddAttribute(64, "id", "inputFullname");
                        __builder4.AddAttribute(65, "class", "form-control");
                        __builder4.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 142 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                                                                         cus.FullName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cus.FullName = __value, cus.FullName));
                        __builder4.SetUpdatesAttributeName("value");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(68, "\r\n                                            ");
                        __builder4.AddMarkupContent(69, "<label class=\"control-label\">Họ tên</label>\r\n                                            ");
                        __Blazor.Client.Pages.Info.TypeInference.CreateValidationMessage_2(__builder4, 70, 71, 
#nullable restore
#line 144 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                                                      () => cus.FullName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "                           \r\n\r\n                                ");
                    __builder3.OpenElement(73, "div");
                    __builder3.AddAttribute(74, "class", "form-label-group");
                    __builder3.OpenElement(75, "input");
                    __builder3.AddAttribute(76, "type", "date");
                    __builder3.AddAttribute(77, "id", "inputEmail");
                    __builder3.AddAttribute(78, "class", "form-control");
                    __builder3.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 150 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                                                              cus.DoB

#line default
#line hidden
#nullable disable
                    , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cus.DoB = __value, cus.DoB, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\r\n                                    ");
                    __builder3.AddMarkupContent(82, "<label class=\"control-label\">Ngày sinh</label>\r\n                                    ");
                    __Blazor.Client.Pages.Info.TypeInference.CreateValidationMessage_3(__builder3, 83, 84, 
#nullable restore
#line 152 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                                              () => cus.DoB

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\r\n\r\n                                ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "form-label-group");
                    __builder3.OpenElement(88, "input");
                    __builder3.AddAttribute(89, "type", "text");
                    __builder3.AddAttribute(90, "id", "inputEmail");
                    __builder3.AddAttribute(91, "class", "form-control");
                    __builder3.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 156 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                                                              cus.Address

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cus.Address = __value, cus.Address));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(94, "\r\n                                    ");
                    __builder3.AddMarkupContent(95, "<label class=\"control-label\">Địa chỉ</label>\r\n                                    ");
                    __Blazor.Client.Pages.Info.TypeInference.CreateValidationMessage_4(__builder3, 96, 97, 
#nullable restore
#line 158 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                                              () => cus.Address

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(98, "\r\n\r\n                                ");
                    __builder3.OpenElement(99, "div");
                    __builder3.AddAttribute(100, "class", "form-label-group");
                    __builder3.OpenElement(101, "input");
                    __builder3.AddAttribute(102, "type", "text");
                    __builder3.AddAttribute(103, "id", "inputEmail");
                    __builder3.AddAttribute(104, "class", "form-control");
                    __builder3.AddAttribute(105, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 162 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                                                              cus.PhoneNumber

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(106, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cus.PhoneNumber = __value, cus.PhoneNumber));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(107, "\r\n                                    ");
                    __builder3.AddMarkupContent(108, "<label class=\"control-label\">Số điện thoại</label>\r\n                                    ");
                    __Blazor.Client.Pages.Info.TypeInference.CreateValidationMessage_5(__builder3, 109, 110, 
#nullable restore
#line 164 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                                              () => cus.PhoneNumber

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(111, "\r\n\r\n                                ");
                    __builder3.OpenElement(112, "div");
                    __builder3.AddAttribute(113, "class", "d-grid gap-2");
                    __builder3.AddMarkupContent(114, "<button class=\"btn btn-lg btn-google btn-block text-uppercase\" value=\"Lưu\" type=\"submit\">Lưu</button>\r\n                                    ");
                    __builder3.OpenElement(115, "button");
                    __builder3.AddAttribute(116, "class", "btn btn-lg btn-facebook btn-block text-uppercase");
                    __builder3.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 169 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
                                                                                                                Cancel

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(118, "value", "Thoát");
                    __builder3.AddMarkupContent(119, "Thoát");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
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
#line 180 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
       
    [Parameter]
    public string id { get; set; }
    public Customer cus;
    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0" || id == "0")
        {
            NavigationManager.NavigateTo("/");
        }
        else
        {
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            var accessToken = sessionStorage.GetItem<string>("AccessToken");
            var accessTokenGoogle = AuthStat.Result.User.Claims.Where(_ => _.Type == "APIjwt").Select(_ => _.Value).FirstOrDefault();
            cus = new Customer();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                client.BaseAddress = new Uri(apiUrl);
                if (accessTokenGoogle != null && accessTokenGoogle != "")
                {
                    using (var response = await client.GetAsync("Customer/GetCustomerbyMail/?email=" + id))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        cus = JsonConvert.DeserializeObject<Customer>(apiResponse);
                    }
                }
                else
                {
                    using (var response = await client.GetAsync("Customer/?id=" + id))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        cus = JsonConvert.DeserializeObject<Customer>(apiResponse);
                    }
                }
            }
        }
    }

    private async void SubmitForm()
    {
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        var accessTokenGoogle = AuthStat.Result.User.Claims.Where(_ => _.Type == "APIjwt").Select(_ => _.Value).FirstOrDefault();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        var customerId = sessionStorage.GetItem<int>("customerId");
        using (var client = new HttpClient())
        {
            if (accessToken != null && accessToken != "")
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            }
            if (accessTokenGoogle != null && accessTokenGoogle != "")
            {
                customerId = cus.CustomerId;
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenGoogle);
            }
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            StringContent content = new StringContent(JsonConvert.SerializeObject(cus), System.Text.Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            HttpResponseMessage response = await client.PutAsync("customer/?id=" + customerId, content);

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
                    NavigationManager.NavigateTo("/", true);
                }
            }
        }
    }
    private void Cancel()
    {
        NavigationManager.NavigateTo("/", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.Client.Pages.Info
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
    }
}
#pragma warning restore 1591
