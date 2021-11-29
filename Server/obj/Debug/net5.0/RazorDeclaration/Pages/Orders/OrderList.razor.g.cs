// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Server.Pages.Orders
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
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
using Server.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
using Share.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/orderlist")]
    public partial class OrderList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderList.razor"
       
    public string SearchString { get; set; }
    public string SearchStatus { get; set; }
    int ids = 0;
    public List<Order> orders;

    protected void SearchInfo(ChangeEventArgs args)
    {
        SearchString = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchString))
        {
            orders = _orderService.GetAllOrder().Where(x => x.Customer.Email.ToUpper().Contains(SearchString.ToUpper())
            || (x.Customer.Address != null && x.Customer.Address.ToUpper().Contains(SearchString.ToUpper()))
            || x.Total.ToString().Contains(SearchString) || x.OrderDate.ToString().Contains(SearchString)).ToList();
        }
        else
        {
            orders = _orderService.GetAllOrder();
        }
    }

    protected void SearchOrderStatus(ChangeEventArgs args)
    {
        SearchStatus = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchStatus))
        {
            orders = _orderService.GetAllOrder().Where(x => x.OrderStatus.ToString() == SearchStatus).ToList();
        }
        else
        {
            orders = _orderService.GetAllOrder();
        }
    }

    protected void OrderSorting(string SortColumn)
    {
        orders = _orderService.GetAllOrder();
        if (ids == 0)
        {
            ids = 1;
            switch (SortColumn)
            {
                case "Email":
                    orders = orders.OrderBy(x => x.Customer.Email).ToList();
                    break;
                case "Address":
                    orders = orders.OrderBy(x => x.Customer.Address).ToList();
                    break;
                case "OrderDate":
                    orders = orders.OrderBy(x => x.OrderDate).ToList();
                    break;
                case "Total":
                    orders = orders.OrderBy(x => x.Total).ToList();
                    break;
                case "OrderStatus":
                    orders = orders.OrderBy(x => x.OrderStatus).ToList();
                    break;
            }
        }
        else
        {
            ids = 0;

            switch (SortColumn)
            {
                case "Email":
                    orders = orders.OrderByDescending(x => x.Customer.Email).ToList();
                    break;
                case "Address":
                    orders = orders.OrderByDescending(x => x.Customer.Address).ToList();
                    break;
                case "OrderDate":
                    orders = orders.OrderByDescending(x => x.OrderDate).ToList();
                    break;
                case "Total":
                    orders = orders.OrderByDescending(x => x.Total).ToList();
                    break;
                case "OrderStatus":
                    orders = orders.OrderByDescending(x => x.OrderStatus).ToList();
                    break;
            }
        }
    }

    protected override void OnInitialized()
    {
        orders = _orderService.GetAllOrder();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IOrderSvc _orderService { get; set; }
    }
}
#pragma warning restore 1591
