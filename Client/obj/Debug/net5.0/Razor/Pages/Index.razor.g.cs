#pragma checksum "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f6ee0d628c0527720beb5deba866e0bfe9e9be4"
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
#line 19 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
using Share.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
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
            __builder.AddMarkupContent(0, "<link href=\"/assets/css/products.css\" rel=\"stylesheet\">\r\n");
            __builder.AddMarkupContent(1, "<style>\r\n    .carousel-inner img {\r\n        width: 100%;\r\n    }\r\n\r\n    .card {\r\n        background-color: #fff;\r\n        border: none;\r\n        border-radius: 10px;\r\n        width: auto;\r\n        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);\r\n        margin-bottom: 20px;\r\n        height: 450px;\r\n    }\r\n\r\n        .card:hover {\r\n            border: solid;\r\n            border-color: black;\r\n            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19)\r\n        }\r\n\r\n    .image-container {\r\n        position: relative;\r\n        text-align: center;\r\n    }\r\n\r\n    .product-detail-container {\r\n        position: relative;\r\n    }\r\n\r\n    .thumbnail-image {\r\n        border-radius: 10px !important;\r\n    }\r\n\r\n    .discount {\r\n        background-color: red;\r\n        padding-top: 1px;\r\n        padding-bottom: 1px;\r\n        padding-left: 4px;\r\n        padding-right: 4px;\r\n        border-radius: 6px;\r\n        color: #fff\r\n    }\r\n\r\n    .wishlist {\r\n        height: 25px;\r\n        width: 25px;\r\n        background-color: #eee;\r\n        display: flex;\r\n        justify-content: center;\r\n        align-items: center;\r\n        border-radius: 50%;\r\n        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19)\r\n    }\r\n\r\n    .first {\r\n        position: absolute;\r\n        width: 100%;\r\n        padding: 9px\r\n    }\r\n\r\n    .dress-name {\r\n        font-weight: bold;\r\n        width: 100%;\r\n    }\r\n\r\n    .new-price {\r\n        font-size: 18px;\r\n        font-weight: bold;\r\n        color: red\r\n    }\r\n\r\n    .old-price {\r\n        font-weight: bold;\r\n        color: grey\r\n    }\r\n\r\n    .rating-number {\r\n        color: grey\r\n    }\r\n</style>\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(2);
            __builder.AddAttribute(3, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 105 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 105 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, @"<div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel""><div class=""carousel-inner""><div class=""carousel-item active""><img src=""/assets/img/banner1.jpg"" class=""d-block w-100"" alt=""Image1""></div>
            <div class=""carousel-item""><img src=""/assets/img/banner2.png"" class=""d-block w-100"" alt=""Image2""></div>
            <div class=""carousel-item""><img src=""/assets/img/banner3.png"" class=""d-block w-100"" alt=""Image3""></div></div>
        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev""><span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span></a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next""><span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span></a></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n<br> <br>\r\n       ");
            __builder.OpenComponent<BlazorAnimate.Animate>(8);
            __builder.AddAttribute(9, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 130 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                           Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 130 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                        TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "product-area section");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "container");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row");
                __builder2.AddMarkupContent(18, "<div class=\"col-12\"><div class=\"section-title\"><h2>Sản Phẩm Bán Chạy</h2>\r\n                               <hr></div></div>\r\n                       ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col-12");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "product-info");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "tab-content");
                __builder2.AddAttribute(25, "id", "myTabContent");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "tab-single");
                __builder2.OpenElement(28, "ul");
                __builder2.AddAttribute(29, "id", "autoWidth");
                __builder2.AddAttribute(30, "class", "cs-hidden");
#nullable restore
#line 149 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                            foreach (var item in products.Select((value, i) => new { i, value }))
                                           {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(31, "li");
                __builder2.AddAttribute(32, "class", "item-" + (
#nullable restore
#line 151 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                                item.i

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "box");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "slide-img");
#nullable restore
#line 154 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                             
                                                               temp = imgUrl + item.value.Image;
                                                           

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(37, "img");
                __builder2.AddAttribute(38, "src", 
#nullable restore
#line 157 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                                      temp

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(39, "alt", "1");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                                                           ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "overlay");
                __builder2.OpenElement(43, "a");
                __builder2.AddAttribute(44, "class", "buy-btn");
                __builder2.AddAttribute(45, "style", "cursor:pointer");
                __builder2.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 159 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                                                                                   () => AddCart(item.value.ProductId)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(47, "MUA NGAY");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                                                       ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "detail-box");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "type");
                __builder2.OpenElement(53, "a");
                __builder2.AddAttribute(54, "style", "cursor:pointer");
                __builder2.AddAttribute(55, "href", "/detail/" + (
#nullable restore
#line 164 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                                                                        item.value.ProductId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(56, 
#nullable restore
#line 164 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                                                                                               item.value.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 165 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                                if (item.value.Category == Category.Backpack)
                                                               {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(57, "<span>Ba lô</span>");
#nullable restore
#line 168 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                               }
                                                               else
                                                               {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(58, "<span>Phụ kiện</span>");
#nullable restore
#line 172 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                               }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                                           ");
                __builder2.OpenElement(60, "a");
                __builder2.AddAttribute(61, "href", "/detail/" + (
#nullable restore
#line 174 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                                             item.value.ProductId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "class", "price");
                __builder2.OpenElement(63, "b");
                __builder2.AddContent(64, 
#nullable restore
#line 175 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                                   string.Format("{0:#,0}", item.value.Price)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(65, "đ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 180 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                           }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
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
            __builder.AddMarkupContent(66, "\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(67);
            __builder.AddAttribute(68, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 194 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 194 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(71, "<section id=\"services\" class=\"services section-bg\"><div class=\"container\"><div class=\"section-title\" data-aos=\"fade-up\"><h2>Dịch vụ</h2>\r\n                <p>Đến với dịch vụ của chúng tôi, quý khách sẽ được chọn những chiếc Balo & Phụ kiện chất lượng và mới nhất từ các nhà phân phối uy tín</p></div>\r\n\r\n            <div class=\"row\"><div class=\"col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0\" data-aos=\"zoom-in\"><div class=\"icon-box icon-box-pink\"><div class=\"icon\"><i class=\"bx bxl-shopify\"></i></div>\r\n                        <h4 class=\"title\"><a href>Sản phẩm chất lượng</a></h4>\r\n                        <p class=\"description\">SaC Backpack - nơi mua sắm cặp balo, túi xách, phụ kiện lý tưởng của nhiều bạn trẻ, là sự lựa chọn hoàn hảo dành cho bạn. </p></div></div>\r\n\r\n                <div class=\"col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0\" data-aos=\"zoom-in\" data-aos-delay=\"100\"><div class=\"icon-box icon-box-cyan\"><div class=\"icon\"><i class=\"bx bx-transfer-alt\"></i></div>\r\n                        <h4 class=\"title\"><a href>Giao hàng cực nhanh</a></h4>\r\n                        <p class=\"description\">Giao hàng trên toàn quốc cam kết đi hàng ngay khi nhận được đơn</p></div></div>\r\n\r\n                <div class=\"col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0\" data-aos=\"zoom-in\" data-aos-delay=\"200\"><div class=\"icon-box icon-box-green\"><div class=\"icon\"><i class=\"bx bx-dollar\"></i></div>\r\n                        <h4 class=\"title\"><a href>Giá cả phải chăng</a></h4>\r\n                        <p class=\"description\">Đến với SaC Backpack bạn có thể thoải mái lựa chọn những chiếc Balo & phụ kiện với giá cực rẻ</p></div></div>\r\n\r\n                <div class=\"col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0\" data-aos=\"zoom-in\" data-aos-delay=\"300\"><div class=\"icon-box icon-box-blue\"><div class=\"icon\"><i class=\"bx bxs-backpack\"></i></div>\r\n                        <h4 class=\"title\"><a href>Nhẹ nhàng thoải mái</a></h4>\r\n                        <p class=\"description\">Thiết kế chú trọng tới sự thoải mái và thời trang, sành điệu. </p></div></div></div></div></section>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(73);
            __builder.AddAttribute(74, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 242 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 242 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 242 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                                                 TimeSpan.FromSeconds(0.5)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(78, @"<section id=""contact"" class=""contact section-bg""><div class=""container""><div class=""section-title"" data-aos=""fade-up""><h2>Liên hệ với chúng tôi</h2></div>

            <div class=""row""><div class=""col-lg-12 d-flex align-items-stretch"" data-aos=""fade-right""><div class=""info""><div class=""address""><i class=""bi bi-geo-alt""></i>
                            <h4>Location:</h4>
                            <p>CVPM Quang Trung, Quận 12, TP HCM</p></div>

                        <div class=""email""><i class=""bi bi-envelope""></i>
                            <h4>Email:</h4>
                            <p>web.sacbackpack@gmail.com</p></div>

                        <div class=""phone""><i class=""bi bi-phone""></i>
                            <h4>Call:</h4>
                            <p>0332780105</p></div>
                        <iframe src=""https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d15673.776858806688!2d106.6283556!3d10.8537789!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3175298945afff59%3A0xcf4afe79d65f5ddc!2zQ8O0bmcgdmnDqm4gcGjhuqduIG3hu4FtIFF1YW5nIFRydW5n!5e0!3m2!1svi!2s!4v1639199322451!5m2!1svi!2s"" frameborder=""0"" style=""border:0; width: 100%; height: 290px;"" allowfullscreen></iframe></div></div></div></div></section>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
           
    protected async override Task OnAfterRenderAsync(bool fistRender)
    {
        if (fistRender)
        {
            await JSRuntime.InvokeAsync<object>("initializeCarousel");
            fistRender = false;
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 284 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
      

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
            using (var response = await client.GetAsync("FiveProducts"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                products = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(apiResponse);
            }
        }
        await JSRuntime.InvokeVoidAsync("jqueryScript");
        await JSRuntime.InvokeVoidAsync("mostPopular");
        await JSRuntime.InvokeVoidAsync("productSlider");

    }

    private void AddCart(int id)
    {
        //var cart = HttpContext.Session.GetString("cart");//get key cart
        var cart = sessionStorage.GetItem<string>("cart");//get key cart
        if (cart == null)
        {
            var product = products.Where(u => u.ProductId == id).FirstOrDefault();
            List<CartItem> listCart = new List<CartItem>()
{
                    new CartItem
                    {
                        product = product,
                        Quantity = 1,
                        Price = product.Price
                    }
            };
            Cart orderCart = new Cart()
            {
                ListViewCart = listCart,
                Total = Calculate(listCart)
            };

            sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));
            toastService.ShowSuccess("Lưu thành công!");
            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));
        }
        else
        {
            var product = products.Where(u => u.ProductId == id).FirstOrDefault();
            Cart orderCart = JsonConvert.DeserializeObject<Cart>(cart);
            bool check = true;
            for (int i = 0; i < orderCart.ListViewCart.Count; i++)
            {
                if (orderCart.ListViewCart[i].product.ProductId == id)
                {
                    orderCart.ListViewCart[i].Quantity++;
                    orderCart.ListViewCart[i].Price = product.Price * orderCart.ListViewCart[i].Quantity;
                    check = false;
                }
            }

            if (check)
            {
                orderCart.ListViewCart.Add(new CartItem
                {
                    product = product,
                    Quantity = 1,
                    Price = product.Price * 1
                });
            }
            orderCart.Total = Calculate(orderCart.ListViewCart);
            sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));


            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
