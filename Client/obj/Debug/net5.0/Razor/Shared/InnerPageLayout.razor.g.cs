#pragma checksum "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Shared\InnerPageLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ec412a564829ae6933b514028f82c2aa5f95755"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Shared
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
    public partial class InnerPageLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<header id=""header"" class=""fixed-top d-flex align-items-center""><div class=""container d-flex align-items-center""><div class=""logo me-auto""><h1><a href=""index.html"">SaC Backpack</a></h1></div>

        <nav id=""navLogin"" class=""navbar order-last order-lg-0""><ul><li><a class=""nav-link "" href=""/"">Trang chủ</a></li>
                    <li class=""dropdown""><a style=""cursor:pointer""><span>Tài khoản</span> <i class=""bi bi-chevron-down""></i></a>
                        <ul><li><a class=""nav-link scrollto"" href=""/login"">Đăng nhập</a></li>
                            <li><a class=""nav-link scrollto"" href=""/register"">Đăng ký</a></li></ul></li></ul></nav></div></header>

");
            __builder.OpenElement(1, "main");
            __builder.AddAttribute(2, "id", "main");
            __builder.AddContent(3, 
#nullable restore
#line 36 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Shared\InnerPageLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(5, "<footer id=\"footer\"><div class=\"footer-top\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-3 col-md-6\"><div class=\"footer-info\"><h3>Scaffold</h3>\r\n                        <p>\r\n                            A108 Adam Street <br>\r\n                            NY 535022, USA<br><br>\r\n                            <strong>Phone:</strong> +1 5589 55488 55<br>\r\n                            <strong>Email:</strong> info@example.com<br></p>\r\n                        <div class=\"social-links mt-3\"><a href=\"#\" class=\"twitter\"><i class=\"bx bxl-twitter\"></i></a>\r\n                            <a href=\"#\" class=\"facebook\"><i class=\"bx bxl-facebook\"></i></a>\r\n                            <a href=\"#\" class=\"instagram\"><i class=\"bx bxl-instagram\"></i></a>\r\n                            <a href=\"#\" class=\"google-plus\"><i class=\"bx bxl-skype\"></i></a>\r\n                            <a href=\"#\" class=\"linkedin\"><i class=\"bx bxl-linkedin\"></i></a></div></div></div>\r\n\r\n                <div class=\"col-lg-2 col-md-6 footer-links\"><h4>Useful Links</h4>\r\n                    <ul><li><i class=\"bx bx-chevron-right\"></i> <a href=\"#\">Home</a></li>\r\n                        <li><i class=\"bx bx-chevron-right\"></i> <a href=\"#\">About us</a></li>\r\n                        <li><i class=\"bx bx-chevron-right\"></i> <a href=\"#\">Services</a></li>\r\n                        <li><i class=\"bx bx-chevron-right\"></i> <a href=\"#\">Terms of service</a></li>\r\n                        <li><i class=\"bx bx-chevron-right\"></i> <a href=\"#\">Privacy policy</a></li></ul></div>\r\n\r\n                <div class=\"col-lg-3 col-md-6 footer-links\"><h4>Our Services</h4>\r\n                    <ul><li><i class=\"bx bx-chevron-right\"></i> <a href=\"#\">Web Design</a></li>\r\n                        <li><i class=\"bx bx-chevron-right\"></i> <a href=\"#\">Web Development</a></li>\r\n                        <li><i class=\"bx bx-chevron-right\"></i> <a href=\"#\">Product Management</a></li>\r\n                        <li><i class=\"bx bx-chevron-right\"></i> <a href=\"#\">Marketing</a></li>\r\n                        <li><i class=\"bx bx-chevron-right\"></i> <a href=\"#\">Graphic Design</a></li></ul></div>\r\n\r\n                <div class=\"col-lg-4 col-md-6 footer-newsletter\"><h4>Our Newsletter</h4>\r\n                    <p>Tamen quem nulla quae legam multos aute sint culpa legam noster magna</p>\r\n                    <form action method=\"post\"><input type=\"email\" name=\"email\"><input type=\"submit\" value=\"Subscribe\"></form></div></div></div></div>\r\n\r\n    <div class=\"container\"><div class=\"credits\">\r\n\r\n            Designed by <b>4Dev</b></div></div></footer>");
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Shared\InnerPageLayout.razor"
       
    //string email;
    //int customerid;
    //protected override async Task OnInitializedAsync()
    //{
    //    email = sessionStorage.GetItem<string>("Email");

    //    customerid = sessionStorage.GetItem<int>("customerId");
    //}
    //protected void o()
    //{
    //    email = sessionStorage.GetItem<string>("Email");
    //}
    //protected void Logout()
    //{
    //    sessionStorage.RemoveItem("AccessToken");
    //    sessionStorage.RemoveItem("Email");
    //    NavigationManager.NavigateTo("/");
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
