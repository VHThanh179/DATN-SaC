#pragma checksum "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d50f29de362f0667982e099c3fa6701c9b985537"
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
#line 11 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/productdialog/{id}")]
    public partial class ProductDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .my-custom-scrollbar {
        position: relative;
        height: 650px;
        overflow: auto;
    }

    .textEditorScroll {
        position: relative;
        height: 175px;
        overflow: auto;
    }

    .table-wrapper-scroll-y {
        display: block;
    }

    main {
        height: 650px;
    }
</style>
");
            __builder.OpenElement(1, "main");
            __builder.AddAttribute(2, "class", "row table-wrapper-scroll-y my-custom-scrollbar");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-10 m-auto");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 35 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                          product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 35 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
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
#line 37 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                        product.ProductId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.ProductId = __value, product.ProductId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group col-6");
                __builder2.AddMarkupContent(20, "<label class=\"control-label\">Tên sản phẩm</label>\r\n                    ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                  product.ProductName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.ProductName = __value, product.ProductName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __Blazor.Server.Pages.Products.ProductDialog.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 42 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                              () => product.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group col-6");
                __builder2.AddMarkupContent(31, "<label class=\"control-label\">Giá</label>\r\n                    ");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                  product.Price

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Price = __value, product.Price));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __Blazor.Server.Pages.Products.ProductDialog.TypeInference.CreateValidationMessage_1(__builder2, 37, 38, 
#nullable restore
#line 48 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                              () => product.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group col-6");
                __builder2.AddMarkupContent(44, "<label class=\"control-label\">Phân loại</label>\r\n                    ");
                __Blazor.Server.Pages.Products.ProductDialog.TypeInference.CreateInputSelect_2(__builder2, 45, 46, "form-control", 47, 
#nullable restore
#line 56 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                               product.Category

#line default
#line hidden
#nullable disable
                , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Category = __value, product.Category)), 49, () => product.Category, 50, (__builder3) => {
                    __builder3.OpenElement(51, "option");
                    __builder3.AddAttribute(52, "value", 
#nullable restore
#line 57 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                        Category.Backpack

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(53, "Ba lô");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\r\n                        ");
                    __builder3.OpenElement(55, "option");
                    __builder3.AddAttribute(56, "value", 
#nullable restore
#line 58 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                        Category.Accessories

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(57, "Phụ kiện");
                    __builder3.CloseElement();
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group col-6");
                __builder2.AddMarkupContent(61, "<label class=\"control-label\">Trạng thái</label>\r\n                    ");
                __Blazor.Server.Pages.Products.ProductDialog.TypeInference.CreateInputSelect_3(__builder2, 62, 63, "form-control", 64, 
#nullable restore
#line 63 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                              status

#line default
#line hidden
#nullable disable
                , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => status = __value, status)), 66, () => status, 67, (__builder3) => {
                    __builder3.AddMarkupContent(68, "<option value=\"true\">Còn hàng</option>\r\n                        ");
                    __builder3.AddMarkupContent(69, "<option value=\"false\">Không còn hàng</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n            ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "row");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group col-6");
                __builder2.AddMarkupContent(75, "<label class=\"control-label\">Chọn hình</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(76);
                __builder2.AddAttribute(77, "class", "form-control");
                __builder2.AddAttribute(78, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                                              OnInputFileChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 75 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                 if (product.Image != null)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group col-6");
                __builder2.OpenElement(81, "img");
                __builder2.AddAttribute(82, "src", "images/Product/" + (
#nullable restore
#line 78 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                                  product.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "style", "height:100px");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 80 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n            ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "row");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group col-12");
                __builder2.AddMarkupContent(89, "<label class=\"control-label\">\r\n                        Thông tin mô tả\r\n                    </label>\r\n                    ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "textEditorScroll table-wrapper-scroll-y");
                __builder2.OpenComponent<Syncfusion.Blazor.RichTextEditor.SfRichTextEditor>(92);
                __builder2.AddAttribute(93, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 88 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                                       product.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Description = __value, product.Description))));
                __builder2.AddAttribute(95, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.Description));
                __builder2.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.RichTextEditor.RichTextEditorToolbarSettings>(97);
                    __builder3.AddAttribute(98, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Syncfusion.Blazor.RichTextEditor.ToolbarItemModel>>(
#nullable restore
#line 89 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                                                  Toolbars

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n                        ");
                __Blazor.Server.Pages.Products.ProductDialog.TypeInference.CreateValidationMessage_4(__builder2, 100, 101, 
#nullable restore
#line 91 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                                  () => product.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n            ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "form-group text-center");
#nullable restore
#line 96 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                 if (id == "0")
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(105, "<button type=\"submit\" class=\"btn btn-info\">Thêm</button>");
#nullable restore
#line 99 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(106, "<button type=\"submit\" class=\"btn btn-info\">Cập nhật</button>");
#nullable restore
#line 103 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(107, "input");
                __builder2.AddAttribute(108, "type", "button");
                __builder2.AddAttribute(109, "class", "ml-2 btn btn-primary");
                __builder2.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                                                             Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(111, "value", "Thoát");
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
#line 113 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
       
    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

    [Parameter]
    public string id { get; set; }

    private string status = null;

    private Product product { get; set; }
    IReadOnlyList<IBrowserFile> selectedFiles;

    public List<ToolbarItemModel> Toolbars = new List<ToolbarItemModel>()
{
        new ToolbarItemModel() { Command = ToolbarCommand.Bold },
        new ToolbarItemModel() { Command = ToolbarCommand.Italic },
        new ToolbarItemModel() { Command = ToolbarCommand.Underline },
        new ToolbarItemModel() { Command = ToolbarCommand.FontSize },
        new ToolbarItemModel() { Command = ToolbarCommand.FontColor },
        new ToolbarItemModel() { Command = ToolbarCommand.LowerCase },
        new ToolbarItemModel() { Command = ToolbarCommand.UpperCase },
        new ToolbarItemModel() { Command = ToolbarCommand.Alignments },
        new ToolbarItemModel() { Command = ToolbarCommand.CreateLink },
        new ToolbarItemModel() { Command = ToolbarCommand.Undo },
        new ToolbarItemModel() { Command = ToolbarCommand.Redo }
        };


    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            product = new Product();
            product.Status = true;
        }
        else
        {
            product = _productSvc.GetProduct(int.Parse(id));
            if (product.Status == true)
            {
                status = "true";
            }
            else
            {
                status = "false";
            }
        }
    }

    private async void SubmitForm()
    {
        if (selectedFiles != null && selectedFiles.Count > 0)
        {
            var roothPath = $"{env.WebRootPath}\\images";
            if (!Directory.Exists(roothPath))
            {
                Directory.CreateDirectory(roothPath);
            }

            string dirPath = roothPath + @"\" + "Product";
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            var file = selectedFiles[0];
            string filePath = dirPath + @"\" + file.Name;
            {
                Stream stream = file.OpenReadStream();
                FileStream fs = File.Create(filePath);
                await stream.CopyToAsync(fs);
                stream.Close();
                fs.Close();
            }
            product.Image = file.Name;
        }
        if (product.ProductId == 0)
        {
            product.Status = bool.Parse(status);
            _productSvc.AddProduct(product);
        }
        else
        {
            product.Status = bool.Parse(status);
            _productSvc.EditProduct(product.ProductId, product);
        }
        navigation.NavigateTo("productlist", true);
    }
    private void Cancel()
    {
        //navigation.NavigateTo("productlist", true);
        ModalInstance.CloseAsync(ModalResult.Ok<Product>(product));
    }

    private void OnInputFileChange(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles();
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IProductSvc _productSvc { get; set; }
    }
}
namespace __Blazor.Server.Pages.Products.ProductDialog
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
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
