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
#line 6 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
using Share.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkout")]
    public partial class Checkout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 251 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
       
    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }
    public ShipInfo shipInfo { get; set; }
    public Customer customer { get; set; }
    public APICart apiCart { get; set; }
    public int cusId;
    public string emailAddress;
    public string emailGoogle;
    public Cart orderCart;
    private int display;
    private int shipPartner;
    public double vouchervalue = 0;
    public string displayvalue = "";
    public string vouchercode { get; set; }
    public Voucher voucher;
    public List<Voucher> listvoucher;
    public double total = 0;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("PaypalButton");
        }
        if (display == 0)
        {
            Console.WriteLine(display + "non display");
            await JSRuntime.InvokeVoidAsync("noneDisplayMoreInfoShipping");
        }
        else
        {
            Console.WriteLine(display + "display");
            await JSRuntime.InvokeVoidAsync("displayMoreInfoShipping");
        }
    }
    protected override async Task OnInitializedAsync()
    {
        customer = new Customer();
        shipInfo = new ShipInfo();
        var cart = sessionStorage.GetItem<string>("cart");
        if (cart == null)
        {
            orderCart = new Share.Models.ViewModels.Cart();
        }
        else
        {
            orderCart = JsonConvert.DeserializeObject<Cart>(cart);
            if (orderCart.Total <= 1000000)
            {
                shipInfo.Price = 30000;
            }
            else if (orderCart.Total <= 2000000)
            {
                shipInfo.Price = 20000;
            }
            else
            {
                shipInfo.Price = 10000;
            }
        }

        cusId = sessionStorage.GetItem<int>("customerId");
        emailAddress = sessionStorage.GetItem<string>("Email");
        emailGoogle = AuthStat.Result.User.Claims.Where(_ => _.Type == "email").Select(_ => _.Value).FirstOrDefault();
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        customer = new Customer();
        if (emailAddress != null && emailAddress != "")
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                client.BaseAddress = new Uri(apiUrl);
                using (var response = await client.GetAsync("Customer/?id=" + cusId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    customer = JsonConvert.DeserializeObject<Customer>(apiResponse);
                }
            }
            shipInfo.CusName = customer.FullName;
            shipInfo.Address = customer.Address;
            shipInfo.PhoneNumber = customer.PhoneNumber;
        }
        if (emailGoogle != null && emailGoogle != "")
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                client.BaseAddress = new Uri(apiUrl);
                using (var response = await client.GetAsync("Customer/GetCustomerbyMail/?email=" + emailGoogle))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    customer = JsonConvert.DeserializeObject<Customer>(apiResponse);
                }
            }
            shipInfo.CusName = customer.FullName;
            shipInfo.Address = customer.Address;
            shipInfo.PhoneNumber = customer.PhoneNumber;
        }

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            using (var response = await client.GetAsync("Voucher"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                listvoucher = JsonConvert.DeserializeObject<List<Voucher>>(apiResponse);
            }
        }
    }

    private async Task OrderCart()
    {
        if (display == 0)
        {
            shipInfo.ShippingMethod = true;
        }
        else
        {
            shipInfo.ShippingMethod = false;
        }

        if (shipPartner == 1)
        {
            shipInfo.Partner = Partner.Grab;
        }
        else if (shipPartner == 2)
        {
            shipInfo.Partner = Partner.Now;
        }
        else if (shipPartner == 3)
        {
            shipInfo.Partner = Partner.Gojek;
        }
        else
        {
            shipInfo.Partner = Partner.None;
        }


        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        orderCart.CustomerId = customer.CustomerId;

        apiCart = new APICart();
        apiCart.cart = orderCart;
        apiCart.shipInfo = shipInfo;
        apiCart.voucherCode = vouchercode;

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            StringContent content = new StringContent(JsonConvert.SerializeObject(apiCart), System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(apiUrl + "Cart", content);
            if (response.StatusCode != HttpStatusCode.OK)
            {

            }
            else
            {
                sessionStorage.RemoveItem("cart");
                navigationManager.NavigateTo("/history");
            }
        }
    }

    private void Cancel()
    {
        ModalInstance.CloseAsync(ModalResult.Ok<ShipInfo>(shipInfo));
    }

    private void CheckVoucher()
    {
        voucher = new Voucher();
        foreach (var item in listvoucher)
        {
            if (vouchercode == item.VoucherCode)
            {
                voucher = item;
            }
        }
        if (voucher.VoucherCode != null)
        {
            if (voucher.Status)
            {
                if (voucher.VoucherQuantity > 0)
                {
                    if (voucher.CategoryDiscount == CategoryDiscount.Cash)
                    {
                        vouchervalue = voucher.Value;
                        displayvalue = string.Format("{0:#,0}", vouchervalue) + " VNĐ";
                    }
                    else
                    {
                        vouchervalue = voucher.Value / 100;
                        displayvalue = voucher.Value.ToString() + " %";
                    }
                }
                else
                {
                    Console.WriteLine("Voucher hết số lượng");
                }

            }
            else
            {
                vouchervalue = 0;
                displayvalue = "";
                Console.WriteLine("Voucher hết hạn");
            }
        }
        else
        {
            vouchervalue = 0;
            displayvalue = "";
            Console.WriteLine("Mã voucher sai");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
