#pragma checksum "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8fb12d1d01add271def7f8adb1e929781d25e66"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
using Share.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/productlist")]
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "<h1 class=\"font-weight-bold text-center\">Danh sách sản phẩm</h1>");
#nullable restore
#line 8 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
     if (products == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading ...</em></p>");
#nullable restore
#line 11 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "text-right");
            __builder.AddMarkupContent(5, "<button type=\"button\" class=\"btn btn-success btn-circle btn-md\"><a style=\"text-decoration:none;\" href=\"/productdialog/0\"><i class=\"fa fa-plus\" style=\"color:white;font-size:20px;\"></i></a></button>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
                                   SearchString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchString = __value, SearchString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-outline-success");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
                                                          OnParametersSet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "<i class=\"fa fa-search\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-outline-primary");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
                                                          OnInitialized

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "Danh sách");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    <br>\r\n    <br>");
            __builder.CloseElement();
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "table table-hover text-center");
            __builder.AddMarkupContent(25, @"<thead class=""thead-dark""><tr><th scope=""col"">Tên</th>
                    <th scope=""col"">Giá</th>
                    <th scope=""col"">Phân loại</th>
                    <th scope=""col"" style=""width:20%"">Hình</th>
                    <th scope=""col"">Trạng thái</th>
                    <th scope=""col"" style=""width:30%"">Thông tin</th>
                    <th scope=""col"">Hành động</th></tr></thead>
            ");
            __builder.OpenElement(26, "tbody");
#nullable restore
#line 43 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
                 foreach (var item in products)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "tr");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 46 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
                             item.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 47 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
                             item.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 48 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
                             item.Category.DisplayName()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "td");
            __builder.OpenElement(38, "img");
            __builder.AddAttribute(39, "src", "images/Product/" + (
#nullable restore
#line 49 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
                                                      item.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "style", "width:150px; height:150px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "td");
#nullable restore
#line 51 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
                             if (item.Status)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<span>Còn hàng</span>");
#nullable restore
#line 54 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "<span>Hết hàng</span>");
#nullable restore
#line 58 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 60 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
                             item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "td");
            __builder.OpenElement(50, "a");
            __builder.AddAttribute(51, "class", "btn btn-info");
            __builder.AddAttribute(52, "href", "/productdialog/" + (
#nullable restore
#line 62 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
                                                                          item.ProductId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "Sửa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductList.razor"
       
    [Parameter]
    public string SearchString { get; set; }

    public List<Product> products { get; set; }

    protected override void OnParametersSet()
    {
        if (!string.IsNullOrEmpty(SearchString))
        {
            products = _productSvc.GetAllProduct().Where(x => x.ProductName.ToUpper().Contains(SearchString.ToUpper())).ToList();
        }
        else
        {
            products = _productSvc.GetAllProduct();
        }
    }

    protected override void OnInitialized()
    {
        products = _productSvc.GetAllProduct();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IProductSvc _productSvc { get; set; }
    }
}
#pragma warning restore 1591
