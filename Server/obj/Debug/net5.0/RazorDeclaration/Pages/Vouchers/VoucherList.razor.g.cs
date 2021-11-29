// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Server.Pages.Vouchers
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
#line 16 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
using Share.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/voucherlist")]
    public partial class VoucherList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
       
    //[Parameter]
    public string SearchString { get; set; }
    public string SearchCategory { get; set; }
    public string SearchStatus { get; set; }
    int ids = 0;
    public List<Voucher> vouchers;

    protected void SearchInfo(ChangeEventArgs args)
    {
        SearchString = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchString))
        {
            vouchers = _voucherSvc.GetAllVoucher().Where(x => x.VoucherCode.ToUpper().Contains(SearchString.ToUpper())
            || x.StartDate.ToString().Contains(SearchString) || x.EndDate.ToString().Contains(SearchString)
            || x.VoucherQuantity.ToString().Contains(SearchString) || x.Value.ToString().Contains(SearchString)).ToList();
        }
        else
        {
            vouchers = _voucherSvc.GetAllVoucher();
        }
    }

    protected void SearchVoucherCategory(ChangeEventArgs args)
    {
        SearchCategory = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchCategory))
        {
            vouchers = _voucherSvc.GetAllVoucher().Where(x => x.CategoryDiscount.ToString() == SearchCategory).ToList();
        }
        else
        {
            vouchers = _voucherSvc.GetAllVoucher();
        }
    }

    protected void SearchVoucherStatus(ChangeEventArgs args)
    {
        SearchStatus = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchStatus))
        {
            vouchers = _voucherSvc.GetAllVoucher().Where(x => x.Status.ToString() == SearchStatus).ToList();
        }
        else
        {
            vouchers = _voucherSvc.GetAllVoucher();
        }
    }

    protected void VoucherSorting(string SortColumn)
    {
        vouchers = _voucherSvc.GetAllVoucher();
        if (ids == 0)
        {
            ids = 1;
            switch (SortColumn)
            {
                case "VoucherCode":
                    vouchers = vouchers.OrderBy(x => x.VoucherCode).ToList();
                    break;
                case "StartDate":
                    vouchers = vouchers.OrderBy(x => x.StartDate).ToList();
                    break;
                case "EndDate":
                    vouchers = vouchers.OrderBy(x => x.EndDate).ToList();
                    break;
                case "Status":
                    vouchers = vouchers.OrderBy(x => x.Status).ToList();
                    break;
                case "VoucherQuantity":
                    vouchers = vouchers.OrderBy(x => x.VoucherQuantity).ToList();
                    break;
                case "CategoryDiscount":
                    vouchers = vouchers.OrderBy(x => x.CategoryDiscount).ToList();
                    break;
                case "Value":
                    vouchers = vouchers.OrderBy(x => x.Value).ToList();
                    break;
            }
        }
        else
        {
            ids = 0;

            switch (SortColumn)
            {
                case "VoucherCode":
                    vouchers = vouchers.OrderByDescending(x => x.VoucherCode).ToList();
                    break;
                case "StartDate":
                    vouchers = vouchers.OrderByDescending(x => x.StartDate).ToList();
                    break;
                case "EndDate":
                    vouchers = vouchers.OrderByDescending(x => x.EndDate).ToList();
                    break;
                case "Status":
                    vouchers = vouchers.OrderByDescending(x => x.Status).ToList();
                    break;
                case "VoucherQuantity":
                    vouchers = vouchers.OrderByDescending(x => x.VoucherQuantity).ToList();
                    break;
                case "CategoryDiscount":
                    vouchers = vouchers.OrderByDescending(x => x.CategoryDiscount).ToList();
                    break;
                case "Value":
                    vouchers = vouchers.OrderByDescending(x => x.Value).ToList();
                    break;
            }
        }
    }

    protected override void OnInitialized()
    {
        vouchers = _voucherSvc.GetAllVoucher();
    }
    //protected override void OnParametersSet()
    //{
    //    if (!string.IsNullOrEmpty(SearchString))
    //    {
    //        vouchers = _voucherSvc.GetAllVoucher().Where(x => x.VoucherCode.ToUpper().Contains(SearchString.ToUpper())).ToList();
    //    }
    //    else
    //    {
    //        vouchers = _voucherSvc.GetAllVoucher();
    //    }
    //}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IVoucherSvc _voucherSvc { get; set; }
    }
}
#pragma warning restore 1591
