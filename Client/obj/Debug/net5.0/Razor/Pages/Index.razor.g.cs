#pragma checksum "D:\DATN-SaC\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47e9431715be6d2f37197ba8b0c4dd529138bb46"
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
#line 1 "D:\DATN-SaC\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN-SaC\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DATN-SaC\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DATN-SaC\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\DATN-SaC\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\DATN-SaC\Client\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DATN-SaC\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\DATN-SaC\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\DATN-SaC\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN-SaC\Client\Pages\Index.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN-SaC\Client\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorAnimate.Animate>(0);
            __builder.AddAttribute(1, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 10 "D:\DATN-SaC\Client\Pages\Index.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 10 "D:\DATN-SaC\Client\Pages\Index.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, @"<section id=""hero""><div class=""container""><div class=""row""><div class=""col-lg-6 pt-5 pt-lg-0 order-2 order-lg-1 d-flex flex-column justify-content-center"" data-aos=""fade-up""><div><h1>We design digital products that help grow businesses</h1>
                        <h2>We are team of talented designers making websites with Bootstrap</h2>
                        <a href=""#about"" class=""btn-get-started scrollto"">Get Started</a></div></div>
                <div class=""col-lg-6 order-1 order-lg-2 hero-img"" data-aos=""fade-left""><img src=""assets/img/4dev.jpg"" class=""img-fluid"" alt></div></div></div></section>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(6);
            __builder.AddAttribute(7, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 28 "D:\DATN-SaC\Client\Pages\Index.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 28 "D:\DATN-SaC\Client\Pages\Index.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "<section id=\"services\" class=\"services section-bg\"><div class=\"container\"><div class=\"section-title\" data-aos=\"fade-up\"><h2>Dịch vụ</h2>\r\n                <p>Đến với dịch vụ của chúng tôi, quý khách sẽ được chọn những chiếc Balo & Phụ kiện chất lượng và mới nhất từ các nhà phân phối uy tín</p></div>\r\n\r\n            <div class=\"row\"><div class=\"col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0\" data-aos=\"zoom-in\"><div class=\"icon-box icon-box-pink\"><div class=\"icon\"><i class=\"bx bxl-shopify\"></i></div>\r\n                        <h4 class=\"title\"><a href>Sản phẩm chất lượng</a></h4>\r\n                        <p class=\"description\">SaC Backpack - nơi mua sắm cặp balo, túi xách, phụ kiện lý tưởng của nhiều bạn trẻ, là sự lựa chọn hoàn hảo dành cho bạn. </p></div></div>\r\n\r\n                <div class=\"col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0\" data-aos=\"zoom-in\" data-aos-delay=\"100\"><div class=\"icon-box icon-box-cyan\"><div class=\"icon\"><i class=\"bx bx-transfer-alt\"></i></div>\r\n                        <h4 class=\"title\"><a href>Giao hàng cực nhanh</a></h4>\r\n                        <p class=\"description\">Giao hàng trên toàn quốc cam kết đi hàng ngay khi nhận được đơn</p></div></div>\r\n\r\n                <div class=\"col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0\" data-aos=\"zoom-in\" data-aos-delay=\"200\"><div class=\"icon-box icon-box-green\"><div class=\"icon\"><i class=\"bx bx-dollar\"></i></div>\r\n                        <h4 class=\"title\"><a href>Giá cả phải chăng</a></h4>\r\n                        <p class=\"description\">Đến với SaC Backpack bạn có thể thoải mái lựa chọn những chiếc Balo & phụ kiện với giá cực rẻ</p></div></div>\r\n\r\n                <div class=\"col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0\" data-aos=\"zoom-in\" data-aos-delay=\"300\"><div class=\"icon-box icon-box-blue\"><div class=\"icon\"><i class=\"bx bxs-backpack\"></i></div>\r\n                        <h4 class=\"title\"><a href>Nhẹ nhàng thoải mái</a></h4>\r\n                        <p class=\"description\">Thiết kế chú trọng tới sự thoải mái và thời trang, sành điệu. </p></div></div></div></div></section>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(12);
            __builder.AddAttribute(13, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 76 "D:\DATN-SaC\Client\Pages\Index.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 76 "D:\DATN-SaC\Client\Pages\Index.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(16, "section");
                __builder2.AddAttribute(17, "id", "product");
                __builder2.AddAttribute(18, "class", "portfolio");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "container");
                __builder2.AddMarkupContent(21, @"<div class=""section-title"" data-aos=""fade-up""><h2>Sản phẩm</h2>
                <p>Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate. Et nemo qui impedit suscipit alias ea. Quia fugiat sit in iste officiis commodi quidem hic quas.</p></div>


        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "row portfolio-container");
                __builder2.AddAttribute(24, "data-aos", "fade-up");
                __builder2.AddAttribute(25, "data-aos-delay", "200");
#nullable restore
#line 99 "D:\DATN-SaC\Client\Pages\Index.razor"
             foreach (var item in products)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-lg-4 col-md-6 portfolio-item filter-app");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "portfolio-wrap");
#nullable restore
#line 103 "D:\DATN-SaC\Client\Pages\Index.razor"
                          
                            temp = imgUrl + item.Image;
                        

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(30, "img");
                __builder2.AddAttribute(31, "src", 
#nullable restore
#line 106 "D:\DATN-SaC\Client\Pages\Index.razor"
                                   temp

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(32, "class", "img-fluid");
                __builder2.AddAttribute(33, "alt");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "portfolio-info");
                __builder2.OpenElement(37, "h4");
                __builder2.AddContent(38, 
#nullable restore
#line 108 "D:\DATN-SaC\Client\Pages\Index.razor"
                                 item.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                            ");
                __builder2.OpenElement(40, "p");
                __builder2.AddContent(41, 
#nullable restore
#line 109 "D:\DATN-SaC\Client\Pages\Index.razor"
                                string.Format("{0:#,0}", item.Price)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(42, " VNĐ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                        ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "portfolio-links");
                __builder2.OpenElement(46, "a");
                __builder2.AddAttribute(47, "href", 
#nullable restore
#line 112 "D:\DATN-SaC\Client\Pages\Index.razor"
                                      temp

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(48, "data-gallery", "portfolioGallery");
                __builder2.AddAttribute(49, "class", "portfolio-lightbox");
                __builder2.AddAttribute(50, "title", 
#nullable restore
#line 112 "D:\DATN-SaC\Client\Pages\Index.razor"
                                                                                                               item.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(51, "<i class=\"bx bx-plus\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                            ");
                __builder2.OpenElement(53, "a");
                __builder2.AddAttribute(54, "href", "/detail/" + (
#nullable restore
#line 113 "D:\DATN-SaC\Client\Pages\Index.razor"
                                              item.ProductId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "title", "More Details");
                __builder2.AddMarkupContent(56, "<i class=\"bx bx-link\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 117 "D:\DATN-SaC\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(58);
            __builder.AddAttribute(59, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 153 "D:\DATN-SaC\Client\Pages\Index.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 153 "D:\DATN-SaC\Client\Pages\Index.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 153 "D:\DATN-SaC\Client\Pages\Index.razor"
                                                                                 TimeSpan.FromSeconds(0.5)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(63, "<section id=\"contact\" class=\"contact section-bg\"><div class=\"container\"><div class=\"section-title\" data-aos=\"fade-up\"><h2>Liên hệ với chúng tôi</h2></div>\r\n\r\n            <div class=\"row\"><div class=\"col-lg-5 d-flex align-items-stretch\" data-aos=\"fade-right\"><div class=\"info\"><div class=\"address\"><i class=\"bi bi-geo-alt\"></i>\r\n                            <h4>Location:</h4>\r\n                            <p>A108 Adam Street, New York, NY 535022</p></div>\r\n\r\n                        <div class=\"email\"><i class=\"bi bi-envelope\"></i>\r\n                            <h4>Email:</h4>\r\n                            <p>info@example.com</p></div>\r\n\r\n                        <div class=\"phone\"><i class=\"bi bi-phone\"></i>\r\n                            <h4>Call:</h4>\r\n                            <p>+1 5589 55488 55s</p></div>\r\n\r\n                        <iframe src=\"https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d12097.433213460943!2d-74.0062269!3d40.7101282!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xb89d1fe6bc499443!2sDowntown+Conference+Center!5e0!3m2!1smk!2sbg!4v1539943755621\" frameborder=\"0\" style=\"border:0; width: 100%; height: 290px;\" allowfullscreen></iframe></div></div>\r\n\r\n                <div class=\"col-lg-7 mt-5 mt-lg-0 d-flex align-items-stretch\" data-aos=\"fade-left\"><form action=\"forms/contact.php\" method=\"post\" role=\"form\" class=\"php-email-form\"><div class=\"row\"><div class=\"form-group col-md-6\"><label for=\"name\">Your Name</label>\r\n                                <input type=\"text\" name=\"name\" class=\"form-control\" id=\"name\" required></div>\r\n                            <div class=\"form-group col-md-6 mt-3 mt-md-0\"><label for=\"name\">Your Email</label>\r\n                                <input type=\"email\" class=\"form-control\" name=\"email\" id=\"email\" required></div></div>\r\n                        <div class=\"form-group mt-3\"><label for=\"name\">Subject</label>\r\n                            <input type=\"text\" class=\"form-control\" name=\"subject\" id=\"subject\" required></div>\r\n                        <div class=\"form-group mt-3\"><label for=\"name\">Message</label>\r\n                            <textarea class=\"form-control\" name=\"message\" rows=\"10\" required></textarea></div>\r\n                        <div class=\"my-3\"><div class=\"loading\">Loading</div>\r\n                            <div class=\"error-message\"></div>\r\n                            <div class=\"sent-message\">Your message has been sent. Thank you!</div></div>\r\n                        <div class=\"text-center\"><button type=\"submit\">Send Message</button></div></form></div></div></div></section>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 228 "D:\DATN-SaC\Client\Pages\Index.razor"
             

    public List<Product> products;
    protected string imgUrl = "";
    protected string temp = "";

    protected override async Task OnInitializedAsync()
    {
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();

        products = new List<Product>();
        using (var client = new HttpClient())
        {
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            using (var response = await client.GetAsync("Product"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                products = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(apiResponse);
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
