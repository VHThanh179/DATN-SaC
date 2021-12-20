// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 11 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\StatisticalPage.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/statistical")]
    public partial class StatisticalPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 204 "D:\DATN\Project\SaCBackpack\Server\Pages\StatisticalPage.razor"
      
    public List<Statistical> statisticals { get; set; }
    public List<TotalStatistical> totalStatistical { get; set; }
    public string CategoryOption { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    int ids = 0;

    protected override void OnInitialized()
    {
        StartDate = DateTime.Now.ToString();
        EndDate = DateTime.Now.ToString();
        statisticals = _statisticalSvc.GetAllStatistical();
        totalStatistical = _statisticalSvc.GetTotalStatistical();
    }

    protected void TypeofStatistical(ChangeEventArgs args)
    {
        CategoryOption = args.Value.ToString();
        statisticals = _statisticalSvc.GetAllStatistical();
    }

    protected void SearchStatistical()
    {
        statisticals = _statisticalSvc.SearchStatistical(DateTime.Parse(StartDate), DateTime.Parse(EndDate));
        CategoryOption = "SearchStatistical";
    }

    protected void StatisticalSorting(string SortColumn)
    {
        statisticals = _statisticalSvc.GetAllStatistical();
        if (ids == 0)
        {
            ids = 1;
            switch (SortColumn)
            {
                case "StatisticalMonth":
                    statisticals = statisticals.OrderBy(x => x.StatisticalMonth).ToList();
                    break;
                case "QuantityRegister":
                    statisticals = statisticals.OrderBy(x => x.QuantityRegister).ToList();
                    break;
                case "QuantityOrder":
                    statisticals = statisticals.OrderBy(x => x.QuantityOrder).ToList();
                    break;
                case "Revenue":
                    statisticals = statisticals.OrderBy(x => x.Revenue).ToList();
                    break;
                case "Transport":
                    statisticals = statisticals.OrderBy(x => x.Transport).ToList();
                    break;
                case "TotalRevenue":
                    statisticals = statisticals.OrderBy(x => x.TotalRevenue).ToList();
                    break;
            }
        }
        else
        {
            ids = 0;

            switch (SortColumn)
            {
                case "StatisticalMonth":
                    statisticals = statisticals.OrderByDescending(x => x.StatisticalMonth).ToList();
                    break;
                case "QuantityRegister":
                    statisticals = statisticals.OrderByDescending(x => x.QuantityRegister).ToList();
                    break;
                case "QuantityOrder":
                    statisticals = statisticals.OrderByDescending(x => x.QuantityOrder).ToList();
                    break;
                case "Revenue":
                    statisticals = statisticals.OrderByDescending(x => x.Revenue).ToList();
                    break;
                case "Transport":
                    statisticals = statisticals.OrderByDescending(x => x.Transport).ToList();
                    break;
                case "TotalRevenue":
                    statisticals = statisticals.OrderByDescending(x => x.TotalRevenue).ToList();
                    break;
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IStatisticalSvc _statisticalSvc { get; set; }
    }
}
#pragma warning restore 1591
