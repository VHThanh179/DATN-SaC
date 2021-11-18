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
