// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Server.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Shared\MainLayout.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Shared\MainLayout.razor"
      
    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }
    protected async override Task OnInitializedAsync()
    {
        base.OnInitialized();
        var user = (await AuthStat).User;
        if (!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo($"Login?returnUrl={Uri.EscapeDataString(NavigationManager.Uri)}");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
