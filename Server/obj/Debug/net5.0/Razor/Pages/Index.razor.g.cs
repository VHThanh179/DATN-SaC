#pragma checksum "D:\DATN\Project\SaCBackpack\Server\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76b8cc1296b4bcfe9cca68bfdd5cdcfa3c8cc9b8"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages
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
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div id=\"wrapper\"><div id=\"content-wrapper\" class=\"d-flex flex-column\"><div id=\"content\"><div class=\"container-fluid\"><div class=\"d-sm-flex align-items-center justify-content-between mb-4\"><h1 class=\"h3 mb-0 text-gray-800\">Dashboard</h1></div>\r\n                    \r\n                    <div class=\"row\"><div class=\"col-xl-3 col-md-6 mb-4\"><div class=\"card border-left-primary shadow h-100 py-2\"><div class=\"card-body\"><div class=\"row no-gutters align-items-center\"><div class=\"col mr-2\"><div class=\"text-xs font-weight-bold text-primary text-uppercase mb-1\">\r\n                                                Earnings (Monthly)</div>\r\n                                            <div class=\"h5 mb-0 font-weight-bold text-gray-800\">$40,000</div></div>\r\n                                        <div class=\"col-auto\"><i class=\"fas fa-calendar fa-2x text-gray-300\"></i></div></div></div></div></div>\r\n                        \r\n                        <div class=\"col-xl-3 col-md-6 mb-4\"><div class=\"card border-left-success shadow h-100 py-2\"><div class=\"card-body\"><div class=\"row no-gutters align-items-center\"><div class=\"col mr-2\"><div class=\"text-xs font-weight-bold text-success text-uppercase mb-1\">\r\n                                                Earnings (Annual)</div>\r\n                                            <div class=\"h5 mb-0 font-weight-bold text-gray-800\">$215,000</div></div>\r\n                                        <div class=\"col-auto\"><i class=\"fas fa-dollar-sign fa-2x text-gray-300\"></i></div></div></div></div></div>\r\n                        \r\n                        <div class=\"col-xl-3 col-md-6 mb-4\"><div class=\"card border-left-info shadow h-100 py-2\"><div class=\"card-body\"><div class=\"row no-gutters align-items-center\"><div class=\"col mr-2\"><div class=\"text-xs font-weight-bold text-info text-uppercase mb-1\">Tasks\r\n                                            </div>\r\n                                            <div class=\"row no-gutters align-items-center\"><div class=\"col-auto\"><div class=\"h5 mb-0 mr-3 font-weight-bold text-gray-800\">50%</div></div>\r\n                                                <div class=\"col\"><div class=\"progress progress-sm mr-2\"><div class=\"progress-bar bg-info\" role=\"progressbar\" style=\"width: 50%\" aria-valuenow=\"50\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div></div></div></div></div>\r\n                                        <div class=\"col-auto\"><i class=\"fas fa-clipboard-list fa-2x text-gray-300\"></i></div></div></div></div></div>\r\n\r\n                        \r\n                        <div class=\"col-xl-3 col-md-6 mb-4\"><div class=\"card border-left-warning shadow h-100 py-2\"><div class=\"card-body\"><div class=\"row no-gutters align-items-center\"><div class=\"col mr-2\"><div class=\"text-xs font-weight-bold text-warning text-uppercase mb-1\">\r\n                                                Pending Requests</div>\r\n                                            <div class=\"h5 mb-0 font-weight-bold text-gray-800\">18</div></div>\r\n                                        <div class=\"col-auto\"><i class=\"fas fa-comments fa-2x text-gray-300\"></i></div></div></div></div></div></div>\r\n\r\n                    \r\n                    <div class=\"row\"><div class=\"col-xl-8 col-lg-7\"><div class=\"card shadow mb-4\"><div class=\"card-header py-3 d-flex flex-row align-items-center justify-content-between\"><h6 class=\"m-0 font-weight-bold text-primary\">Earnings Overview</h6>\r\n                                    <div class=\"dropdown no-arrow\"><a class=\"dropdown-toggle\" href=\"#\" role=\"button\" id=\"dropdownMenuLink\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\"><i class=\"fas fa-ellipsis-v fa-sm fa-fw text-gray-400\"></i></a>\r\n                                        <div class=\"dropdown-menu dropdown-menu-right shadow animated--fade-in\" aria-labelledby=\"dropdownMenuLink\"><div class=\"dropdown-header\">Dropdown Header:</div>\r\n                                            <a class=\"dropdown-item\" href=\"#\">Action</a>\r\n                                            <a class=\"dropdown-item\" href=\"#\">Another action</a>\r\n                                            <div class=\"dropdown-divider\"></div>\r\n                                            <a class=\"dropdown-item\" href=\"#\">Something else here</a></div></div></div>\r\n                                \r\n                                <div class=\"card-body\"><div class=\"chart-area\"><canvas id=\"myAreaChart\"></canvas></div></div></div></div>\r\n\r\n                        \r\n                        <div class=\"col-xl-4 col-lg-5\"><div class=\"card shadow mb-4\"><div class=\"card-header py-3 d-flex flex-row align-items-center justify-content-between\"><h6 class=\"m-0 font-weight-bold text-primary\">Revenue Sources</h6>\r\n                                    <div class=\"dropdown no-arrow\"><a class=\"dropdown-toggle\" href=\"#\" role=\"button\" id=\"dropdownMenuLink\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\"><i class=\"fas fa-ellipsis-v fa-sm fa-fw text-gray-400\"></i></a>\r\n                                        <div class=\"dropdown-menu dropdown-menu-right shadow animated--fade-in\" aria-labelledby=\"dropdownMenuLink\"><div class=\"dropdown-header\">Dropdown Header:</div>\r\n                                            <a class=\"dropdown-item\" href=\"#\">Action</a>\r\n                                            <a class=\"dropdown-item\" href=\"#\">Another action</a>\r\n                                            <div class=\"dropdown-divider\"></div>\r\n                                            <a class=\"dropdown-item\" href=\"#\">Something else here</a></div></div></div>\r\n                                \r\n                                <div class=\"card-body\"><div class=\"chart-pie pt-4 pb-2\"><canvas id=\"myPieChart\"></canvas></div>\r\n                                    <div class=\"mt-4 text-center small\"><span class=\"mr-2\"><i class=\"fas fa-circle text-primary\"></i> Direct\r\n                                        </span>\r\n                                        <span class=\"mr-2\"><i class=\"fas fa-circle text-success\"></i> Social\r\n                                        </span>\r\n                                        <span class=\"mr-2\"><i class=\"fas fa-circle text-info\"></i> Referral\r\n                                        </span></div></div></div></div></div>\r\n\r\n                    \r\n                    <div class=\"row\"><div class=\"col-lg-6 mb-4\"><div class=\"card shadow mb-4\"><div class=\"card-header py-3\"><h6 class=\"m-0 font-weight-bold text-primary\">Projects</h6></div>\r\n                                <div class=\"card-body\"><h4 class=\"small font-weight-bold\">Server Migration <span class=\"float-right\">20%</span></h4>\r\n                                    <div class=\"progress mb-4\"><div class=\"progress-bar bg-danger\" role=\"progressbar\" style=\"width: 20%\" aria-valuenow=\"20\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div></div>\r\n                                    <h4 class=\"small font-weight-bold\">Sales Tracking <span class=\"float-right\">40%</span></h4>\r\n                                    <div class=\"progress mb-4\"><div class=\"progress-bar bg-warning\" role=\"progressbar\" style=\"width: 40%\" aria-valuenow=\"40\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div></div>\r\n                                    <h4 class=\"small font-weight-bold\">Customer Database <span class=\"float-right\">60%</span></h4>\r\n                                    <div class=\"progress mb-4\"><div class=\"progress-bar\" role=\"progressbar\" style=\"width: 60%\" aria-valuenow=\"60\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div></div>\r\n                                    <h4 class=\"small font-weight-bold\">Payout Details <span class=\"float-right\">80%</span></h4>\r\n                                    <div class=\"progress mb-4\"><div class=\"progress-bar bg-info\" role=\"progressbar\" style=\"width: 80%\" aria-valuenow=\"80\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div></div>\r\n                                    <h4 class=\"small font-weight-bold\">Account Setup <span class=\"float-right\">Complete!</span></h4>\r\n                                    <div class=\"progress\"><div class=\"progress-bar bg-success\" role=\"progressbar\" style=\"width: 100%\" aria-valuenow=\"100\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div></div></div></div>\r\n\r\n                            \r\n                            <div class=\"row\"><div class=\"col-lg-6 mb-4\"><div class=\"card bg-primary text-white shadow\"><div class=\"card-body\">\r\n                                            Primary\r\n                                            <div class=\"text-white-50 small\">#4e73df</div></div></div></div>\r\n                                <div class=\"col-lg-6 mb-4\"><div class=\"card bg-success text-white shadow\"><div class=\"card-body\">\r\n                                            Success\r\n                                            <div class=\"text-white-50 small\">#1cc88a</div></div></div></div>\r\n                                <div class=\"col-lg-6 mb-4\"><div class=\"card bg-info text-white shadow\"><div class=\"card-body\">\r\n                                            Info\r\n                                            <div class=\"text-white-50 small\">#36b9cc</div></div></div></div>\r\n                                <div class=\"col-lg-6 mb-4\"><div class=\"card bg-warning text-white shadow\"><div class=\"card-body\">\r\n                                            Warning\r\n                                            <div class=\"text-white-50 small\">#f6c23e</div></div></div></div>\r\n                                <div class=\"col-lg-6 mb-4\"><div class=\"card bg-danger text-white shadow\"><div class=\"card-body\">\r\n                                            Danger\r\n                                            <div class=\"text-white-50 small\">#e74a3b</div></div></div></div>\r\n                                <div class=\"col-lg-6 mb-4\"><div class=\"card bg-secondary text-white shadow\"><div class=\"card-body\">\r\n                                            Secondary\r\n                                            <div class=\"text-white-50 small\">#858796</div></div></div></div>\r\n                                <div class=\"col-lg-6 mb-4\"><div class=\"card bg-light text-black shadow\"><div class=\"card-body\">\r\n                                            Light\r\n                                            <div class=\"text-black-50 small\">#f8f9fc</div></div></div></div>\r\n                                <div class=\"col-lg-6 mb-4\"><div class=\"card bg-dark text-white shadow\"><div class=\"card-body\">\r\n                                            Dark\r\n                                            <div class=\"text-white-50 small\">#5a5c69</div></div></div></div></div></div>\r\n\r\n                        <div class=\"col-lg-6 mb-4\"><div class=\"card shadow mb-4\"><div class=\"card-header py-3\"><h6 class=\"m-0 font-weight-bold text-primary\">Illustrations</h6></div>\r\n                                <div class=\"card-body\"><div class=\"text-center\"><img class=\"img-fluid px-3 px-sm-4 mt-3 mb-4\" style=\"width: 25rem;\" src=\"img/undraw_posting_photo.svg\" alt=\"...\"></div>\r\n                                    <p>Add some quality, svg illustrations to your project courtesy of <a target=\"_blank\" rel=\"nofollow\" href=\"https://undraw.co/\">unDraw</a>, a\r\n                                        constantly updated collection of beautiful svg images that you can use\r\n                                        completely free and without attribution!</p>\r\n                                    <a target=\"_blank\" rel=\"nofollow\" href=\"https://undraw.co/\">Browse Illustrations on\r\n                                        unDraw &rarr;</a></div></div>\r\n\r\n                            \r\n                            <div class=\"card shadow mb-4\"><div class=\"card-header py-3\"><h6 class=\"m-0 font-weight-bold text-primary\">Development Approach</h6></div>\r\n                                <div class=\"card-body\"><p>SB Admin 2 makes extensive use of Bootstrap 4 utility classes in order to reduce\r\n                                        CSS bloat and poor page performance. Custom CSS classes are used to create\r\n                                        custom components and custom utility classes.</p>\r\n                                    <p class=\"mb-0\">Before working with this theme, you should become familiar with the\r\n                                        Bootstrap framework, especially the utility classes.</p></div></div></div></div></div></div>\r\n            <footer class=\"sticky-footer bg-white\"><div class=\"container my-auto\"><div class=\"copyright text-center my-auto\"><span>Copyright &copy; Your Website 2021</span></div></div></footer></div></div>\r\n\r\n    \r\n    ");
            __builder.AddMarkupContent(1, "<a class=\"scroll-to-top rounded\" href=\"#page-top\"><i class=\"fas fa-angle-up\"></i></a>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
