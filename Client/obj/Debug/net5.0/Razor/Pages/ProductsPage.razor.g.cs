#pragma checksum "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62ea23fdfb731906b80c25b3b811cce830bd3dd1"
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
#line 18 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
using Share.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
using Share.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class ProductsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>

    .product-detail-container {
        position: relative;
    }

    .thumbnail-image {
        border-radius: 10px !important;
    }

    .btn-page {
        color: black;
        padding: 8px 16px;
        text-decoration: none;
        transition: background-color .3s;
        margin: 0px 5px 0px 5px;
    }
    .btn-custom {
        color: black;
        padding: 8px 16px;
        text-decoration: none;
        transition: background-color .3s;
        border: 2px solid black;
        margin: 0px 5px 0px 5px;
    }
    .pagination-bar{
        text-align: center;
    }
    .pagination {
        display: inline-block;
    }
</style>
<br>
<br>
<br>
");
            __builder.OpenComponent<BlazorAnimate.Animate>(1);
            __builder.AddAttribute(2, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 46 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 46 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(5, "section");
                __builder2.AddAttribute(6, "id", "product");
                __builder2.AddAttribute(7, "class", "portfolio");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "container");
                __builder2.AddMarkupContent(10, "<div class=\"section-title\" data-aos=\"fade-up\"><h2>Sản phẩm</h2></div>\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row portfolio-container");
                __builder2.AddAttribute(13, "data-aos", "fade-up");
                __builder2.AddAttribute(14, "data-aos-delay", "200");
#nullable restore
#line 53 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                 foreach (var item in products)
                {                  

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", " col-3 filter-app");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "card ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "image-container ");
#nullable restore
#line 58 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                                  
                                    temp = imgUrl + item.Image;
                                

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(21, "img");
                __builder2.AddAttribute(22, "src", 
#nullable restore
#line 61 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                                           temp

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(23, "class", "img-fluid rounded thumbnail-image");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                                ");
                __builder2.OpenElement(25, "a");
                __builder2.AddAttribute(26, "href", "/detail/" + (
#nullable restore
#line 62 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                                                  item.ProductId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "title", "More Details");
                __builder2.AddMarkupContent(28, "<i class=\"bx bx-link\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "product-detail-container p-2");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "d-flex justify-content-between align-items-center");
                __builder2.OpenElement(34, "h4");
                __builder2.AddAttribute(35, "class", "dress-name text-center");
                __builder2.AddContent(36, 
#nullable restore
#line 67 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                                                                        item.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "product-detail-container p-2");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "d-flex justify-content-between align-items-center pt-1");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "d-flex flex-column mb-2");
                __builder2.OpenElement(44, "span");
                __builder2.AddAttribute(45, "class", "new-price");
                __builder2.AddContent(46, 
#nullable restore
#line 73 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                                                                                                   string.Format("{0:#,0}", item.Price)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(47, " VNĐ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                                    ");
                __builder2.OpenElement(49, "button");
                __builder2.AddAttribute(50, "class", "btn btn-dark btn-sm text-right");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                                                                                             () => AddCart(item.ProductId)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(52, "THÊM VÀO GIỎ HÀNG +");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 79 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "mt-3 pagintaion-bar");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "pagination");
                __builder2.OpenElement(58, "button");
                __builder2.AddAttribute(59, "class", "btn btn-outline-danger btn-custom");
                __builder2.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                                                                                  async () => await NavigaToPage("prev")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(61, "<i class=\"fa fa-backward\" aria-hidden=\"true\"></i> Trước\r\n                    ");
                __builder2.CloseElement();
#nullable restore
#line 86 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                     for (int i = startPage; i <= endPage; i++)
                    {
                        var currentPage = i;

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(62, "button");
                __builder2.AddAttribute(63, "class", "btn" + " btn-page" + " pagebutton" + " " + (
#nullable restore
#line 89 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                                                                 currentPage == curPage? "btn-danger":""

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                                                                                                                       async() => await RefreshRecord(currentPage)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(65, 
#nullable restore
#line 90 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                             currentPage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 92 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(66, "button");
                __builder2.AddAttribute(67, "class", "btn btn-outline-danger btn-custom");
                __builder2.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
                                                                                  async () => await NavigaToPage("next")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(69, "<i class=\"fa fa-forward\" aria-hidden=\"true\"></i> Tiếp\r\n                    ");
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
#line 101 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Client\Pages\ProductsPage.razor"
       
    public List<Product> products;
    public ProductDTO productDTO;
    protected string imgUrl = "";
    protected string temp = "";

    int totalPages;
    int totalRecords;
    int curPage;
    int pagerSize;
    int pageSize;
    int startPage;
    int endPage;

    protected override async Task OnInitializedAsync()
    {
        pagerSize = 4;
        pageSize = 4;
        curPage = 1;

        productDTO = new ProductDTO();
        products = new List<Product>();
        await LoadProduct();
    }
    public async Task LoadProduct()
    {
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        using (var client = new HttpClient())
        {
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            using (var response = await client.GetAsync("paging?PageNumber=" + curPage + "&PageSize=" + pageSize))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                productDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductDTO>(apiResponse);
            }
            products = productDTO.Products;
            totalRecords = productDTO.TotalCount;

            totalPages = (int)Math.Ceiling(totalRecords / (decimal)pageSize);

            SetPagerSize("forward");
        }
    }
    public async Task NavigaToPage(string direction)
    {
        if (direction == "next")
        {
            if (curPage < totalPages)
            {
                if (curPage == endPage)
                {
                    SetPagerSize("forward");
                }
                curPage += 1;
                await RefreshRecord(curPage);
            }
        }
        else if (direction == "prev")
        {
            if (curPage > 1)
            {
                if (curPage == startPage)
                {
                    SetPagerSize("back");
                }
                curPage -= 1;
                await RefreshRecord(curPage);
            }
        }

    }
    public async Task RefreshRecord(int currentPage)
    {
        curPage = currentPage;
        await LoadProduct();
    }
    public void SetPagerSize(string direction)
    {
        if (direction == "forward" && endPage < totalPages)
        {
            startPage = endPage + 1;
            if (endPage + pagerSize < totalPages)
            {
                endPage = startPage + pagerSize - 1;
            }
            else
            {
                endPage = totalPages;
            }
            this.StateHasChanged();
        }
        else if (direction == "back" && startPage > 1)
        {
            endPage = startPage - 1;
            startPage = startPage - pagerSize;
        }
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
