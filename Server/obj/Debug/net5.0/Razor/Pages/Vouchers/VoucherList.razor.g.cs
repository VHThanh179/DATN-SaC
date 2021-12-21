#pragma checksum "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12fc5fd37e8f3d73a2e2751e29bd9e0bb3f97677"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1 class=\"font-weight-bold text-center\">Danh sách giảm giá</h1>");
#nullable restore
#line 7 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
 if (vouchers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading ...</em></p>");
#nullable restore
#line 10 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "text-right");
            __builder.AddMarkupContent(4, "<a style=\"text-decoration:none;\" href=\"/voucherdialog/0\"><button type=\"button\" class=\"btn btn-success btn-circle btn-md\"><i class=\"fa fa-plus\" style=\"color:white;font-size:20px;\"></i></button></a>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "d-flex justify-content-end");
            __builder.OpenElement(7, "select");
            __builder.AddAttribute(8, "name", "cars");
            __builder.AddAttribute(9, "class", "custom-select col-2 mr-2");
            __builder.AddAttribute(10, "value", 
#nullable restore
#line 20 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                                                                     SearchCategory

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 20 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                                                                                                SearchVoucherCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(12, "option");
            __builder.AddAttribute(13, "value");
            __builder.AddMarkupContent(14, "Chọn thể loại");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", 
#nullable restore
#line 22 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                            CategoryDiscount.Percent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, "Phần trăm");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", 
#nullable restore
#line 23 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                            CategoryDiscount.Cash

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "Tiền mặt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "select");
            __builder.AddAttribute(25, "name", "cars");
            __builder.AddAttribute(26, "class", "custom-selec col-2 mr-2");
            __builder.AddAttribute(27, "value", 
#nullable restore
#line 25 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                                                                    SearchStatus

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 25 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                                                                                             SearchVoucherStatus

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value");
            __builder.AddMarkupContent(31, "Chọn trạng thái");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", "True");
            __builder.AddMarkupContent(35, "Còn hiệu lực");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", "False");
            __builder.AddMarkupContent(39, "Hết hiệu lực");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "text");
            __builder.AddAttribute(43, "class", "form-control col-2 mr-2");
            __builder.AddAttribute(44, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                                                                                               SearchInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "placeholder", "Nhập thông tin tìm kiếm...");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                                                                        SearchString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchString = __value, SearchString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "btn btn-outline-primary form-control col-1");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                                                                         OnInitialized

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(52, "Tìm kiếm");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    <br>\r\n    <br>");
            __builder.CloseElement();
            __builder.OpenElement(54, "table");
            __builder.AddAttribute(55, "class", "table table-hover text-center");
            __builder.OpenElement(56, "thead");
            __builder.AddAttribute(57, "class", "thead-dark");
            __builder.OpenElement(58, "tr");
            __builder.OpenElement(59, "th");
            __builder.AddAttribute(60, "style", "cursor: pointer");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                                                        ()=>VoucherSorting("VoucherCode")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(62, "Mã voucher");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "th");
            __builder.AddAttribute(65, "style", "cursor: pointer");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                                                        ()=>VoucherSorting("StartDate")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(67, "Ngày hiệu lực");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.OpenElement(69, "th");
            __builder.AddAttribute(70, "style", "cursor: pointer");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                                                        ()=>VoucherSorting("EndDate")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(72, "Ngày kết thúc");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenElement(74, "th");
            __builder.AddAttribute(75, "style", "cursor: pointer");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                                                        ()=>VoucherSorting("Status")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(77, "Trạng thái");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "th");
            __builder.AddAttribute(80, "style", "cursor: pointer");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                                                        ()=>VoucherSorting("VoucherQuantity")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(82, "Số lượng");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.OpenElement(84, "th");
            __builder.AddAttribute(85, "style", "cursor: pointer");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                                                        ()=>VoucherSorting("CategoryDiscount")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(87, "Loại giảm giá");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.OpenElement(89, "th");
            __builder.AddAttribute(90, "style", "cursor: pointer");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                                                        ()=>VoucherSorting("Value")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(92, "Giá trị");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                <th></th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n        ");
            __builder.OpenElement(95, "tbody");
#nullable restore
#line 51 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
             foreach (var item in vouchers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(96, "tr");
            __builder.OpenElement(97, "td");
            __builder.AddContent(98, 
#nullable restore
#line 54 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                         item.VoucherCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                    ");
            __builder.OpenElement(100, "td");
            __builder.AddContent(101, 
#nullable restore
#line 55 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                         item.StartDate.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                    ");
            __builder.OpenElement(103, "td");
            __builder.AddContent(104, 
#nullable restore
#line 56 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                         item.EndDate.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.OpenElement(106, "td");
#nullable restore
#line 58 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                         if (item.Status)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(107, "<span>Còn hiệu lực</span>");
#nullable restore
#line 61 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(108, "<span>Hết hiệu lực</span>");
#nullable restore
#line 65 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                    ");
            __builder.OpenElement(110, "td");
            __builder.AddContent(111, 
#nullable restore
#line 67 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                         item.VoucherQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                    ");
            __builder.OpenElement(113, "td");
            __builder.AddContent(114, 
#nullable restore
#line 68 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                         item.CategoryDiscount.DisplayName()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                    ");
            __builder.OpenElement(116, "td");
            __builder.AddContent(117, 
#nullable restore
#line 69 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                         item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                    ");
            __builder.OpenElement(119, "td");
            __builder.OpenElement(120, "a");
            __builder.AddAttribute(121, "class", "btn btn-info");
            __builder.AddAttribute(122, "href", "/voucherdialog/" + (
#nullable restore
#line 71 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
                                                                      item.VoucherId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(123, "Sửa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 77 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherList.razor"
       
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
