#pragma checksum "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66ff5a0d641c9f2d91bd72573445a7caf988d22c"
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
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userdialog/{id}")]
    public partial class UserDialog : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.OpenElement(10, "h2");
            __builder.AddAttribute(11, "class", "card-title text-center font-weight-bold text-uppercase");
            __builder.AddContent(12, 
#nullable restore
#line 11 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                                                        Tilte

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-md-12");
            __builder.OpenElement(16, "form");
            __builder.AddAttribute(17, "asp-action", "Create");
            __builder.AddAttribute(18, "class", "form-signin");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(19);
            __builder.AddAttribute(20, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                              user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                                    SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(23);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                                ");
                __builder2.OpenElement(25, "input");
                __builder2.AddAttribute(26, "type", "hidden");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                            user.UserId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.UserId = __value, user.UserId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                                ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-label-group");
                __builder2.AddMarkupContent(32, "<label class=\"control-label\">Tên đăng nhập</label>\r\n                                    ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                  user.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.UserName = __value, user.UserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                                    ");
                __Blazor.Server.Pages.Users.UserDialog.TypeInference.CreateValidationMessage_0(__builder2, 38, 39, 
#nullable restore
#line 20 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                              () => user.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n                                ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(43, "<label class=\"control-label\">Họ tên</label>\r\n                                    ");
                __builder2.OpenElement(44, "input");
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                  user.FullName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.FullName = __value, user.FullName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                                    ");
                __Blazor.Server.Pages.Users.UserDialog.TypeInference.CreateValidationMessage_1(__builder2, 49, 50, 
#nullable restore
#line 26 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                              () => user.FullName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n                                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(54, "<label class=\"control-label\">Email</label>\r\n                                    ");
                __builder2.OpenElement(55, "input");
                __builder2.AddAttribute(56, "class", "form-control");
                __builder2.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                  user.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Email = __value, user.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                    ");
                __Blazor.Server.Pages.Users.UserDialog.TypeInference.CreateValidationMessage_2(__builder2, 60, 61, 
#nullable restore
#line 32 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                              () => user.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n                                ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(65, "<label class=\"control-label\">Ngày sinh</label>\r\n                                    ");
                __builder2.OpenElement(66, "input");
                __builder2.AddAttribute(67, "type", "date");
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                              user.DoB

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.DoB = __value, user.DoB, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                                    ");
                __Blazor.Server.Pages.Users.UserDialog.TypeInference.CreateValidationMessage_3(__builder2, 72, 73, 
#nullable restore
#line 38 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                              () => user.DoB

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n\r\n                                ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(77, "<label class=\"control-label\">Chức vụ</label>\r\n                                    ");
                __Blazor.Server.Pages.Users.UserDialog.TypeInference.CreateInputSelect_4(__builder2, 78, 79, "form-control", 80, 
#nullable restore
#line 43 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                               user.Roles

#line default
#line hidden
#nullable disable
                , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Roles = __value, user.Roles)), 82, () => user.Roles, 83, (__builder3) => {
                    __builder3.OpenElement(84, "option");
                    __builder3.AddAttribute(85, "value", 
#nullable restore
#line 44 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                        Role.Manager

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(86, "Quản lý");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\r\n                                        ");
                    __builder3.OpenElement(88, "option");
                    __builder3.AddAttribute(89, "value", 
#nullable restore
#line 45 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                        Role.Staff

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(90, "Nhân viên");
                    __builder3.CloseElement();
                }
                );
                __builder2.CloseElement();
#nullable restore
#line 49 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                 if (id == "0")
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(93, "<label class=\"control-label\">Mật khẩu</label>\r\n                                        ");
                __builder2.OpenElement(94, "input");
                __builder2.AddAttribute(95, "type", "password");
                __builder2.AddAttribute(96, "class", "form-control");
                __builder2.AddAttribute(97, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                                      user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                                        ");
                __Blazor.Server.Pages.Users.UserDialog.TypeInference.CreateValidationMessage_5(__builder2, 100, 101, 
#nullable restore
#line 54 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                                  () => user.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(104, "<label class=\"control-label\">Mật khẩu 2</label>\r\n                                        ");
                __builder2.OpenElement(105, "input");
                __builder2.AddAttribute(106, "type", "password");
                __builder2.AddAttribute(107, "class", "form-control");
                __builder2.AddAttribute(108, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                                      user.ConfirmPass

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.ConfirmPass = __value, user.ConfirmPass));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n                                        ");
                __Blazor.Server.Pages.Users.UserDialog.TypeInference.CreateValidationMessage_6(__builder2, 111, 112, 
#nullable restore
#line 60 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                                  () => user.ConfirmPass

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 62 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "form-label-group mt-3 form-check");
                __builder2.OpenElement(115, "label");
                __builder2.AddAttribute(116, "class", "form-check-label");
                __builder2.OpenElement(117, "input");
                __builder2.AddAttribute(118, "type", "checkbox");
                __builder2.AddAttribute(119, "class", "form-check-input");
                __builder2.AddAttribute(120, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                                                                   user.Status

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(121, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Status = __value, user.Status));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, " Hoạt động\r\n                                        ");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 70 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(125, "<button type=\"submit\" class=\"btn btn-info\">Lưu</button>\r\n                                    ");
                __builder2.OpenElement(126, "input");
                __builder2.AddAttribute(127, "type", "button");
                __builder2.AddAttribute(128, "class", "btn btn-primary");
                __builder2.AddAttribute(129, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
                                                                                            Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(130, "value", "Thoát");
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
#line 85 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserDialog.razor"
       
    [Parameter]
    public string id { get; set; }
    private Share.Models.User user { get; set; }
    private string Tilte = "";
    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            Tilte = "Thêm người dùng";
            user = new Share.Models.User();
        }
        else
        {
            Tilte = "Sửa người dùng";
            user = _userService.GetUser(int.Parse(id));
        }
    }
    private void SubmitForm()
    {
        if (user.UserId == 0)
        {
            _userService.AddUser(user);
        }
        else
        {
            _userService.EditUser(user.UserId, user);
        }
        navigation.NavigateTo("UserList");
    }
    private void Cancel()
    {
        navigation.NavigateTo("UserList", true);

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IUserSvc _userService { get; set; }
    }
}
namespace __Blazor.Server.Pages.Users.UserDialog
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
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591