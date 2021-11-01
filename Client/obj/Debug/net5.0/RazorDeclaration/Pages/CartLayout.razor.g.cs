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
#line 12 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Share.Models;

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
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
using Share.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
using Share.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cart")]
    public partial class CartLayout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 224 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
       
    private string emailAddress;
    public Cart orderCart;
    private double totalCost = 0;
    protected string imgUrl = "";
    protected string temp = "";

    protected override void OnInitialized()
    {
        emailAddress = sessionStorage.GetItem<string>("Email");
        var cart = sessionStorage.GetItem<string>("cart");
        if (cart == null)
        {
            orderCart = new Share.Models.ViewModels.Cart();
        }
        else
        {
            orderCart = JsonConvert.DeserializeObject<Cart>(cart);
        }
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
    }

    private void PlusQuantity(CartItem item)
    {
        item.Quantity++;
    }
    private void MinusQuantity(CartItem item)
    {
        if (item.Quantity > 0)
        {
            item.Quantity--;
        }
    }

    //private void UpdateCart(CartItem item)
    //{
    //    item.Price = item.Quantity * item.product.Price;
    //    orderCart.Total = Calculate(orderCart.ListViewCart);
    //    sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));
    //}

    private void DeleteCart(CartItem item)
    {
        orderCart.ListViewCart.Remove(item);
        orderCart.Total = Calculate(orderCart.ListViewCart);
        sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));
    }

    private async Task OrderCart()
    {
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        var khachhangid = sessionStorage.GetItem<int>("khachhangId");

        orderCart.CustomerId = khachhangid;

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            StringContent content = new StringContent(JsonConvert.SerializeObject(orderCart), System.Text.Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            HttpResponseMessage response = await client.PostAsync(apiUrl + "Cart", content);

            if (response.StatusCode != HttpStatusCode.OK)
            {

            }
            else
            {
                sessionStorage.RemoveItem("cart");
                await JSRuntime.InvokeAsync<object>("clearCart", "");
                NavigationManager.NavigateTo("/history");
            }
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

    private bool flag = false;
    private void ChangeDisplay()
    {
        if (!flag)
            flag = true;
        else
            flag = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
