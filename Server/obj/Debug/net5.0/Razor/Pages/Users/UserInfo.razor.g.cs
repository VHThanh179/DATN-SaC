#pragma checksum "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f6be8194725146cb2121946392a52c888d02ca5"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.Users
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
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userinfo/{id}")]
    public partial class UserInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-xl-8 mx-auto");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card card-signin flex-row shadow-lg card-signup");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.AddMarkupContent(10, "<h2 class=\"card-title text-center font-weight-bold text-uppercase\">Thông tin</h2>\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-12");
            __builder.OpenElement(13, "form");
            __builder.AddAttribute(14, "asp-action", "Create");
            __builder.AddAttribute(15, "class", "form-signin");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(16);
            __builder.AddAttribute(17, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                              user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                                                    SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(20);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                                ");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "type", "hidden");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                                            user.UserId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.UserId = __value, user.UserId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\r\n                                ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-label-group row");
                __builder2.AddMarkupContent(29, "<label class=\"control-label col-5\">Tên đăng nhập</label>\r\n                                    ");
                __builder2.OpenElement(30, "span");
                __builder2.AddAttribute(31, "class", "font-weight-bold col-7");
                __builder2.AddContent(32, 
#nullable restore
#line 24 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                                                          user.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\r\n                                ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-label-group mt-3 row");
                __builder2.AddMarkupContent(36, "<label class=\"control-label col-5\">Họ tên</label>\r\n                                    ");
                __builder2.OpenElement(37, "input");
                __builder2.AddAttribute(38, "class", "form-control col-5");
                __builder2.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                                  user.FullName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.FullName = __value, user.FullName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                                    ");
                __Blazor.Server.Pages.Users.UserInfo.TypeInference.CreateValidationMessage_0(__builder2, 42, 43, 
#nullable restore
#line 32 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                                              () => user.FullName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n\r\n                                ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-label-group mt-3 row");
                __builder2.AddMarkupContent(47, "<label class=\"control-label col-5\">Email</label>\r\n                                    ");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "class", "form-control col-5");
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                                  user.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Email = __value, user.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                                    ");
                __Blazor.Server.Pages.Users.UserInfo.TypeInference.CreateValidationMessage_1(__builder2, 53, 54, 
#nullable restore
#line 38 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                                              () => user.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n                                ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-label-group mt-3 row");
                __builder2.AddMarkupContent(58, "<label class=\"control-label col-5\">Ngày sinh</label>\r\n                                    ");
                __builder2.OpenElement(59, "input");
                __builder2.AddAttribute(60, "type", "date");
                __builder2.AddAttribute(61, "class", "form-control col-5");
                __builder2.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                                              user.DoB

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.DoB = __value, user.DoB, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                                    ");
                __Blazor.Server.Pages.Users.UserInfo.TypeInference.CreateValidationMessage_2(__builder2, 65, 66, 
#nullable restore
#line 44 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                                              () => user.DoB

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 47 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                 if (user.Roles == Role.Staff)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(67, "<div class=\"form-label-group mt-3 row\"><label class=\"control-label col-5\">Chức vụ: </label>\r\n                                        <span class=\"font-weight-bold col-7\">Nhân viên</span></div>");
#nullable restore
#line 53 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(68, "<div class=\"form-label-group mt-3 row\"><label class=\"control-label col-5\">Chức vụ: </label>\r\n                                        <span class=\"font-weight-bold col-7\">Quản lý</span></div>");
#nullable restore
#line 60 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                 if (user.Status)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(69, "<div class=\"form-label-group mt-3 row\"><label class=\"control-label col-5\">Trạng thái: </label>\r\n                                        <span class=\"font-weight-bold col-7\">Hoạt động</span></div>");
#nullable restore
#line 69 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(70, "<div class=\"form-label-group mt-3 row\"><label class=\"control-label col-5\">Trạng thái: </label>\r\n                                        <span class=\"font-weight-bold col-7\">Không hoạt động</span></div>");
#nullable restore
#line 76 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(73, "<button type=\"submit\" class=\"btn btn-info\">Lưu</button>\r\n                                    ");
                __builder2.OpenElement(74, "input");
                __builder2.AddAttribute(75, "type", "button");
                __builder2.AddAttribute(76, "class", "btn btn-primary");
                __builder2.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
                                                                                            Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "value", "Thoát");
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
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserInfo.razor"
       
    [Parameter]
    public string id { get; set; }
    private Share.Models.User user { get; set; }
    private ToastParameters _toastParameters;

    protected override void OnInitialized()
    {
        user = _userService.GetUser(int.Parse(id));
    }
    private async void SubmitForm()
    {
        _toastParameters = new ToastParameters();
        int ret = _userService.EditUser(user.UserId, user);
        if (ret != 0)
        {
            _toastParameters.Add(nameof(Notification.Title), "Chỉnh sửa người dùng thành công!");
            _toastParameters.Add(nameof(Notification.IsSuccess), true);
            toastService.ShowToast<Notification>(_toastParameters);
            await JSRuntime.InvokeVoidAsync("RefeshUser.refreshData");
        }
        else
        {
            _toastParameters.Add(nameof(Notification.Title), "Chỉnh sửa người dùng thất bại!");
            _toastParameters.Add(nameof(Notification.IsSuccess), false);
            toastService.ShowToast<Notification>(_toastParameters);
        }
    }
    private void Cancel()
    {
        navigation.NavigateTo("UserList", true);

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IUserSvc _userService { get; set; }
    }
}
namespace __Blazor.Server.Pages.Users.UserInfo
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
    }
}
#pragma warning restore 1591
