#pragma checksum "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c17bd77feaa4823143928a4f015e4f4eb61fb81"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.ShipInfoes
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
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/shipinfodialog/{id}")]
    public partial class ShipInfoDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-4 m-auto");
            __builder.AddMarkupContent(4, "<h2 class=\"text-success text-center\">Thông tin giao hàng</h2>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                          shipinfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                                                    SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "type", "hidden");
                __builder2.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                                        shipinfo.ShipId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipinfo.ShipId = __value, shipinfo.ShipId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "<label class=\"control-label\">Mã đơn hàng</label>\r\n                ");
                __builder2.OpenElement(19, "input");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "readonly");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                              shipinfo.OrderId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipinfo.OrderId = __value, shipinfo.OrderId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n            ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "<label class=\"control-label\">Tên khách hàng</label>\r\n                ");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "readonly");
                __builder2.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                              shipinfo.CusName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipinfo.CusName = __value, shipinfo.CusName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\r\n            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
                __builder2.AddMarkupContent(36, "<label class=\"control-label\">Địa chỉ giao hàng</label>\r\n                ");
                __builder2.OpenElement(37, "input");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                              shipinfo.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipinfo.Address = __value, shipinfo.Address));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                ");
                __Blazor.Server.Pages.ShipInfoes.ShipInfoDialog.TypeInference.CreateValidationMessage_0(__builder2, 42, 43, 
#nullable restore
#line 30 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                                          () => shipinfo.Address

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n\r\n            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "<label class=\"control-label\">Số điện thoại</label>\r\n                ");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "class", "form-control");
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                              shipinfo.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipinfo.PhoneNumber = __value, shipinfo.PhoneNumber));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                ");
                __Blazor.Server.Pages.ShipInfoes.ShipInfoDialog.TypeInference.CreateValidationMessage_1(__builder2, 53, 54, 
#nullable restore
#line 36 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                                          () => shipinfo.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-label-group");
                __builder2.AddMarkupContent(58, "<label class=\"control-label\">Hình thức vận chuyển</label>");
#nullable restore
#line 41 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                 if (shipinfo.ShippingMethod)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(59, "<input class=\"form-control\" value=\"Giao hàng tận nhà\" readonly>");
#nullable restore
#line 44 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(60, "<input class=\"form-control\" value=\"Lấy hàng trực tiếp\" readonly>");
#nullable restore
#line 48 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n            ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group");
                __builder2.AddMarkupContent(64, "<label class=\"control-label\">Ghi chú</label>\r\n                ");
                __builder2.OpenElement(65, "textarea");
                __builder2.AddAttribute(66, "class", "form-control");
                __builder2.AddAttribute(67, "cols", "30");
                __builder2.AddAttribute(68, "rows", "5");
                __builder2.AddAttribute(69, "maxlength", "200");
                __builder2.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                                                      shipinfo.Notes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipinfo.Notes = __value, shipinfo.Notes));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                ");
                __Blazor.Server.Pages.ShipInfoes.ShipInfoDialog.TypeInference.CreateValidationMessage_2(__builder2, 73, 74, 
#nullable restore
#line 55 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                                          () => shipinfo.Notes

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n\r\n            ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "form-group");
                __builder2.AddMarkupContent(78, "<label class=\"control-label\">Giá vận chuyển</label>\r\n                ");
                __builder2.OpenElement(79, "input");
                __builder2.AddAttribute(80, "class", "form-control");
                __builder2.AddAttribute(81, "readonly");
                __builder2.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                              shipinfo.Price

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipinfo.Price = __value, shipinfo.Price));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                ");
                __Blazor.Server.Pages.ShipInfoes.ShipInfoDialog.TypeInference.CreateValidationMessage_3(__builder2, 85, 86, 
#nullable restore
#line 61 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                                          () => shipinfo.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n\r\n            ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-label-group");
                __builder2.AddMarkupContent(90, "<label class=\"control-label\">Đối tác vận chuyển</label>\r\n                ");
                __Blazor.Server.Pages.ShipInfoes.ShipInfoDialog.TypeInference.CreateInputSelect_4(__builder2, 91, 92, "form-control", 93, 
#nullable restore
#line 66 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                                           shipinfo.Partner

#line default
#line hidden
#nullable disable
                , 94, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shipinfo.Partner = __value, shipinfo.Partner)), 95, () => shipinfo.Partner, 96, (__builder3) => {
#nullable restore
#line 67 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                     foreach (var partner in Enum.GetValues(typeof(Partner)))
                    {
                        if ((Partner)partner == Partner.None)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(97, "option");
                    __builder3.AddAttribute(98, "value", 
#nullable restore
#line 71 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                                            partner

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(99, "Không có đơn vị");
                    __builder3.CloseElement();
#nullable restore
#line 72 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(100, "option");
                    __builder3.AddAttribute(101, "value", 
#nullable restore
#line 75 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                                            partner

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(102, 
#nullable restore
#line 75 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                                                      partner

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 76 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n\r\n            ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-group m-3");
                __builder2.OpenElement(106, "button");
                __builder2.AddAttribute(107, "type", "submit");
                __builder2.AddAttribute(108, "class", "btn btn-info");
                __builder2.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                                                                       () => toastService.ShowSuccess("Lưu thành công!")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(110, "Lưu");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n                ");
                __builder2.OpenElement(112, "input");
                __builder2.AddAttribute(113, "type", "button");
                __builder2.AddAttribute(114, "class", "btn btn-primary");
                __builder2.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(116, "value", "Thoát");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "D:\DATN\Project\SaCBackpack\Server\Pages\ShipInfoes\ShipInfoDialog.razor"
       
    [Parameter]
    public string id { get; set; }

    private ShipInfo shipinfo { get; set; }
    IReadOnlyList<IBrowserFile> selectedFiles;
    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            shipinfo = new ShipInfo();
        }
        else
        {
            shipinfo = _shipInfoSvc.GetShipInfo(int.Parse(id));
        }
    }

    private void SubmitForm()
    {
        if (shipinfo.ShipId == 0)
        {
            _shipInfoSvc.AddShipInfo(shipinfo);
        }
        else
        {
            _shipInfoSvc.EditShipInfo(shipinfo.ShipId, shipinfo);
        }
        navigation.NavigateTo("shipinfolist", true);
    }
    private void Cancel()
    {
        navigation.NavigateTo("shipinfolist", true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IShipInfoSvc _shipInfoSvc { get; set; }
    }
}
namespace __Blazor.Server.Pages.ShipInfoes.ShipInfoDialog
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
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
