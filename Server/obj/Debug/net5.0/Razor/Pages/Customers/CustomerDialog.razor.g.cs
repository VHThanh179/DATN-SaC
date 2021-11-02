#pragma checksum "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8271020bedd8c017f49bb853335feb9486b7580a"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.Customers
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
#line 2 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/customerdialog/{id}")]
    public partial class CustomerDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-xl-6 mx-auto");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card card-signin flex-row shadow-lg card-signup");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.AddMarkupContent(10, "<h2 class=\"card-title text-center font-weight-bold text-uppercase\">Thông tin khách hàng</h2>\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-12");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                          customer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                                                    SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                            ");
                __builder2.OpenElement(19, "input");
                __builder2.AddAttribute(20, "type", "hidden");
                __builder2.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                                        customer.CustomerId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.CustomerId = __value, customer.CustomerId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                            ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "<label class=\"control-label\">Họ và tên</label>\r\n                                ");
                __builder2.OpenElement(27, "input");
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "readonly");
                __builder2.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                              customer.FullName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.FullName = __value, customer.FullName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                                ");
                __Blazor.Server.Pages.Customers.CustomerDialog.TypeInference.CreateValidationMessage_0(__builder2, 33, 34, 
#nullable restore
#line 19 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                                          ()=>customer.FullName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "<label class=\"control-label\">Ngày sinh</label>\r\n                                ");
                __builder2.OpenElement(39, "input");
                __builder2.AddAttribute(40, "type", "date");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "readonly");
                __builder2.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                                          customer.CreatedDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.CreatedDate = __value, customer.CreatedDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                                ");
                __Blazor.Server.Pages.Customers.CustomerDialog.TypeInference.CreateValidationMessage_1(__builder2, 46, 47, 
#nullable restore
#line 24 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                                          ()=>customer.CreatedDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                            ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "<label class=\"control-label\">Số điện thoại</label>\r\n                                ");
                __builder2.OpenElement(52, "input");
                __builder2.AddAttribute(53, "type", "number");
                __builder2.AddAttribute(54, "class", "form-control");
                __builder2.AddAttribute(55, "readonly");
                __builder2.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                                            customer.PhoneNumber

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.PhoneNumber = __value, customer.PhoneNumber, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                                ");
                __Blazor.Server.Pages.Customers.CustomerDialog.TypeInference.CreateValidationMessage_2(__builder2, 59, 60, 
#nullable restore
#line 29 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                                          ()=>customer.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                            ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group");
                __builder2.AddMarkupContent(64, "<label class=\"control-label\">Email</label>\r\n                                ");
                __builder2.OpenElement(65, "input");
                __builder2.AddAttribute(66, "class", "form-control");
                __builder2.AddAttribute(67, "readonly");
                __builder2.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                              customer.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.Email = __value, customer.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                                ");
                __Blazor.Server.Pages.Customers.CustomerDialog.TypeInference.CreateValidationMessage_3(__builder2, 71, 72, 
#nullable restore
#line 34 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                                          ()=>customer.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                            ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group");
                __builder2.AddMarkupContent(76, "<label class=\"control-label\">Địa chỉ</label>\r\n                                ");
                __builder2.OpenElement(77, "input");
                __builder2.AddAttribute(78, "class", "form-control");
                __builder2.AddAttribute(79, "readonly");
                __builder2.AddAttribute(80, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                              customer.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.Address = __value, customer.Address));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                                ");
                __Blazor.Server.Pages.Customers.CustomerDialog.TypeInference.CreateValidationMessage_4(__builder2, 83, 84, 
#nullable restore
#line 39 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                                          ()=>customer.Address

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                            ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group form-check");
                __builder2.OpenElement(88, "label");
                __builder2.AddAttribute(89, "class", "form-check-label");
                __builder2.OpenElement(90, "input");
                __builder2.AddAttribute(91, "type", "checkbox");
                __builder2.AddAttribute(92, "class", "form-check-input");
                __builder2.AddAttribute(93, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                                                                           customer.Status

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.Status = __value, customer.Status));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, " Trạng thái\r\n                                    ");
                __Blazor.Server.Pages.Customers.CustomerDialog.TypeInference.CreateValidationMessage_5(__builder2, 96, 97, 
#nullable restore
#line 44 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                                              ()=>customer.Status

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                            ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-group");
                __builder2.AddMarkupContent(101, "<button type=\"submit\" class=\"btn btn-info\">Lưu</button>\r\n                                ");
                __builder2.OpenElement(102, "button");
                __builder2.AddAttribute(103, "type", "submit");
                __builder2.AddAttribute(104, "class", "btn btn-primary");
                __builder2.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
                                                                                         Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(106, "Thoát");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Customers\CustomerDialog.razor"
       
    [Parameter]
    public string id { get; set; }

    private Share.Models.Customer customer { get; set; }

    protected override void OnInitialized()
    {
        customer = _customerSvc.GetCustomer(int.Parse(id));
    }

    private void SubmitForm()
    {
        _customerSvc.EditCustomer(customer.CustomerId, customer);
        navigation.NavigateTo("customerlist", true);
    }

    private void Cancel()
    {
        navigation.NavigateTo("customerlist", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.ICustomerSvc _customerSvc { get; set; }
    }
}
namespace __Blazor.Server.Pages.Customers.CustomerDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
