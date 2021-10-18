#pragma checksum "D:\DATN\Project\SaCBackpack\Server\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a247a66225c2f05e7aa7a995f494e0c5518f1900"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages
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
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Server\Pages\Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN\Project\SaCBackpack\Server\Pages\Login.razor"
           [AllowAnonymous]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-9 col-md-7 col-lg-5 m-auto");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card card-signin my-5");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.AddMarkupContent(10, "<h5 class=\"card-title text-center font-weight-bold\">Đăng Nhập Website</h5>\r\n                    ");
            __builder.OpenElement(11, "form");
            __builder.AddAttribute(12, "class", "form-signin");
            __builder.AddMarkupContent(13, "<input type=\"hidden\">\r\n                        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-label-group");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "id", "username");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "placeholder", "Tên đăng nhập");
            __builder.AddAttribute(21, "required");
            __builder.AddAttribute(22, "autofocus");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "D:\DATN\Project\SaCBackpack\Server\Pages\Login.razor"
                                                                     username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "form-label-group mt-3");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "password");
            __builder.AddAttribute(30, "id", "password");
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 38 "D:\DATN\Project\SaCBackpack\Server\Pages\Login.razor"
                                                                                                                     Enter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "placeholder", "Mật khẩu");
            __builder.AddAttribute(34, "required");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "D:\DATN\Project\SaCBackpack\Server\Pages\Login.razor"
                                                                         password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "mt-3 btn btn-lg btn-dark btn-block text-uppercase");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\DATN\Project\SaCBackpack\Server\Pages\Login.razor"
                                                                                                    CheckLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(41, "Đăng nhập");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        <hr class=\"my-4\">");
#nullable restore
#line 43 "D:\DATN\Project\SaCBackpack\Server\Pages\Login.razor"
                         if (!string.IsNullOrEmpty(error))
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "alert alert-danger mt-3 mb-0");
            __builder.AddContent(45, 
#nullable restore
#line 45 "D:\DATN\Project\SaCBackpack\Server\Pages\Login.razor"
                                                                        (MarkupString)error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 46 "D:\DATN\Project\SaCBackpack\Server\Pages\Login.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "D:\DATN\Project\SaCBackpack\Server\Pages\Login.razor"
      
    private bool loading;
    private string error;

    string username = "";
    string password = "";

    private string Encode(string param)
    {
        return HttpUtility.UrlEncode(param);
    }
    public void Enter(KeyboardEventArgs e)
    {
        if (e.Code == "Enter" || e.Code == "NumpadEnter")
        {
            if (password != "")
            {
                CheckLogin();
            }
        }
    }
    private void CheckLogin()
    {
        error = "";
        if (username == "")
        {
            error = "- Vui lòng nhập Username";
        }
        if (password == "")
        {
            error += (error == "" ? "" : "<br/>" + "- Vui lòng nhập Password");
        }
        if (error == "")
        {
            NavigationManager.NavigateTo("CheckLogin?paramUsername=" + @Encode(@username)
                + "&paramPassword=" + @Encode(@password), true);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
