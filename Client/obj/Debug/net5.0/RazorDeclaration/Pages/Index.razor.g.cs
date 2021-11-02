// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "D:\DATN\Project\SaCBackpack\Client\Pages\Index.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Client\Pages\Index.razor"
using Share.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN\Project\SaCBackpack\Client\Pages\Index.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\DATN\Project\SaCBackpack\Client\Pages\Index.razor"
           
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
#line 313 "D:\DATN\Project\SaCBackpack\Client\Pages\Index.razor"
      

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
