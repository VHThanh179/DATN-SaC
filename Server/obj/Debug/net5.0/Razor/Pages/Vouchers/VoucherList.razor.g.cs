#pragma checksum "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9d9c4e359dff027bb15abcc3abb38c4acad8b22"
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
#line 16 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
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
#line 7 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
 if (vouchers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading ...</em></p>");
#nullable restore
#line 10 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
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
            __builder.AddAttribute(6, "class");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
                                   SearchString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchString = __value, SearchString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-outline-success");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
                                                          OnParametersSet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(15, "<i class=\"fa fa-search\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-outline-primary");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
                                                          OnInitialized

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "Danh sách");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    <br>\r\n    <br>");
            __builder.CloseElement();
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table table-hover text-center");
            __builder.AddMarkupContent(24, @"<thead class=""thead-dark""><tr><th>Mã voucher</th>
                <th>Ngày hiệu lực</th>
                <th>Ngày kết thúc</th>
                <th>Trạng thái</th>
                <th>Số lượng</th>
                <th>Loại giảm giá</th>
                <th>Giá trị</th>
                <th></th></tr></thead>
        ");
            __builder.OpenElement(25, "tbody");
#nullable restore
#line 42 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
             foreach (var item in vouchers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "tr");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 45 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
                         item.VoucherCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 46 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
                         item.StartDate.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 47 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
                         item.EndDate.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
#nullable restore
#line 49 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
                         if (item.Status)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "<span>Còn hiệu lực</span>");
#nullable restore
#line 52 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "<span>Hết hiệu lực</span>");
#nullable restore
#line 56 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 58 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
                         item.VoucherQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 59 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
                         item.CategoryDiscount.DisplayName()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 60 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
                         item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "td");
            __builder.OpenElement(50, "a");
            __builder.AddAttribute(51, "class", "btn btn-info");
            __builder.AddAttribute(52, "href", "/voucherdialog/" + (
#nullable restore
#line 62 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
                                                                      item.VoucherId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "Sửa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Vouchers\VoucherList.razor"
       
    [Parameter]
    public string SearchString { get; set; }
    public List<Voucher> vouchers;
    protected override void OnInitialized()
    {
        vouchers = _voucherSvc.GetAllVoucher();
    }
    protected override void OnParametersSet()
    {
        if (!string.IsNullOrEmpty(SearchString))
        {
            vouchers = _voucherSvc.GetAllVoucher().Where(x => x.VoucherCode.ToUpper().Contains(SearchString.ToUpper())).ToList();
        }
        else
        {
            vouchers = _voucherSvc.GetAllVoucher();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IVoucherSvc _voucherSvc { get; set; }
    }
}
#pragma warning restore 1591
