#pragma checksum "D:\murat\netcore\Murat\WebUI\Areas\Manager\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe5fec976497400b2b3c858c5cc110adfb0e9b71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Manager/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\murat\netcore\Murat\WebUI\Areas\Manager\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\murat\netcore\Murat\WebUI\Areas\Manager\Views\_ViewImports.cshtml"
using WebUI.Areas.Manager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\murat\netcore\Murat\WebUI\Areas\Manager\Views\_ViewImports.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe5fec976497400b2b3c858c5cc110adfb0e9b71", @"/Areas/Manager/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f835ffc85f895912cf86b4b7c882cf17e201a6f9", @"/Areas/Manager/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Manager_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\murat\netcore\Murat\WebUI\Areas\Manager\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--begin::Wrapper-->
<div class=""wrapper d-flex flex-column flex-row-fluid mt-5 mt-lg-10"" id=""kt_wrapper"">
    <!--begin::Content-->
    <div class=""content flex-column-fluid"" id=""kt_content"">
        <!--begin::Toolbar-->
        <div class=""toolbar d-flex flex-stack flex-wrap mb-5 mb-lg-7"" id=""kt_toolbar"">
            <!--begin::Page title-->
            <div class=""page-title d-flex flex-column py-1"">
                <!--begin::Title-->
                <h1 class=""d-flex align-items-center my-1"">
                    <span class=""text-dark fw-bolder fs-1"">Profil Bilgileri</span>
                </h1>
                <!--end::Title-->
                <!--begin::Breadcrumb-->
                <ul class=""breadcrumb breadcrumb-separatorless fw-bold fs-7 my-1"">
                    <!--begin::Item-->
                    <li class=""breadcrumb-item text-muted"">
                        <a href=""/manamt"" class=""text-muted text-hover-primary"">AnaSayfa</a>
                    </li>
               ");
            WriteLiteral(@"     <!--end::Item-->
                    <!--begin::Item-->
                    <li class=""breadcrumb-item"">
                        <span class=""bullet bg-gray-200 w-5px h-2px""></span>
                    </li>
                    <!--end::Item-->
                    <!--begin::Item-->
                    <li class=""breadcrumb-item text-dark"">Profil</li>
                    <!--end::Item-->
                </ul>
                <!--end::Breadcrumb-->
            </div>
            <!--end::Page title-->
            <!--begin::Actions-->
            <div class=""d-flex align-items-center py-1"">

                <!--begin::Button-->
                <!--end::Button-->
            </div>
            <!--end::Actions-->
        </div>
        <!--end::Toolbar-->
        <!--begin::Post-->
        <div class=""post"" id=""kt_post"">
            <!--begin::Navbar-->
            <div class=""card mb-5 mb-xl-10"">
                <div class=""card-body pt-9 pb-0"">
                    <!--begin::De");
            WriteLiteral(@"tails-->
                    <div class=""d-flex flex-wrap flex-sm-nowrap mb-3"">
                        <!--begin: Pic-->
                        <div class=""me-7 mb-4"">
                            <div class=""symbol symbol-100px symbol-lg-160px symbol-fixed position-relative"">
                                <img src=""/manamt/assets/media/avatars/150-26.jpg"" alt=""image"" />
                                <div class=""position-absolute translate-middle bottom-0 start-100 mb-6 bg-success rounded-circle border border-4 border-white h-20px w-20px""></div>
                            </div>
                        </div>
                        <!--end::Pic-->
                        <!--begin::Info-->
                        <div class=""flex-grow-1"">
                            <!--begin::Title-->
                            <div class=""d-flex justify-content-between align-items-start flex-wrap mb-2"">
                                <!--begin::User-->
                                <div class=""d-fl");
            WriteLiteral(@"ex flex-column"">
                                    <!--begin::Name-->
                                    <div class=""d-flex align-items-center mb-2"">
                                        <a href=""#"" class=""text-gray-900 text-hover-primary fs-2 fw-bolder me-1"">");
#nullable restore
#line 71 "D:\murat\netcore\Murat\WebUI\Areas\Manager\Views\Home\Index.cshtml"
                                                                                                            Write(Model.currentUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 71 "D:\murat\netcore\Murat\WebUI\Areas\Manager\Views\Home\Index.cshtml"
                                                                                                                                         Write(Model.currentUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                        <a href=""#"">
                                            <!--begin::Svg Icon | path: icons/duotune/general/gen026.svg-->
                                            <span class=""svg-icon svg-icon-1 svg-icon-primary"">
                                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""24px"" height=""24px"" viewBox=""0 0 24 24"">
                                                    <path d=""M10.0813 3.7242C10.8849 2.16438 13.1151 2.16438 13.9187 3.7242V3.7242C14.4016 4.66147 15.4909 5.1127 16.4951 4.79139V4.79139C18.1663 4.25668 19.7433 5.83365 19.2086 7.50485V7.50485C18.8873 8.50905 19.3385 9.59842 20.2758 10.0813V10.0813C21.8356 10.8849 21.8356 13.1151 20.2758 13.9187V13.9187C19.3385 14.4016 18.8873 15.491 19.2086 16.4951V16.4951C19.7433 18.1663 18.1663 19.7433 16.4951 19.2086V19.2086C15.491 18.8873 14.4016 19.3385 13.9187 20.2758V20.2758C13.1151 21.8356 10.8849 21.8356 10.0813 20.2758V20.2758C9.59842 19.3385 8.50905 18.8873 7.50485 19.20");
            WriteLiteral(@"86V19.2086C5.83365 19.7433 4.25668 18.1663 4.79139 16.4951V16.4951C5.1127 15.491 4.66147 14.4016 3.7242 13.9187V13.9187C2.16438 13.1151 2.16438 10.8849 3.7242 10.0813V10.0813C4.66147 9.59842 5.1127 8.50905 4.79139 7.50485V7.50485C4.25668 5.83365 5.83365 4.25668 7.50485 4.79139V4.79139C8.50905 5.1127 9.59842 4.66147 10.0813 3.7242V3.7242Z"" fill=""#00A3FF"" />
                                                    <path class=""permanent"" d=""M14.8563 9.1903C15.0606 8.94984 15.3771 8.9385 15.6175 9.14289C15.858 9.34728 15.8229 9.66433 15.6185 9.9048L11.863 14.6558C11.6554 14.9001 11.2876 14.9258 11.048 14.7128L8.47656 12.4271C8.24068 12.2174 8.21944 11.8563 8.42911 11.6204C8.63877 11.3845 8.99996 11.3633 9.23583 11.5729L11.3706 13.4705L14.8563 9.1903Z"" fill=""white"" />
                                                </svg>
                                            </span>
                                            <!--end::Svg Icon-->
                                        </a>

                             ");
            WriteLiteral(@"       </div>
                                    <!--end::Name-->
                                    <!--begin::Info-->
                                    <div class=""d-flex flex-wrap fw-bold fs-6 mb-4 pe-2"">
                                        <a href=""#"" class=""d-flex align-items-center text-gray-400 text-hover-primary me-5 mb-2"">
                                            <!--begin::Svg Icon | path: icons/duotune/communication/com006.svg-->
                                            <span class=""svg-icon svg-icon-4 me-1"">
                                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"">
                                                    <path opacity=""0.3"" d=""M22 12C22 17.5 17.5 22 12 22C6.5 22 2 17.5 2 12C2 6.5 6.5 2 12 2C17.5 2 22 6.5 22 12ZM12 7C10.3 7 9 8.3 9 10C9 11.7 10.3 13 12 13C13.7 13 15 11.7 15 10C15 8.3 13.7 7 12 7Z"" fill=""black"" />
                                                    <path d=""M12 22");
            WriteLiteral(@"C14.6 22 17 21 18.7 19.4C17.9 16.9 15.2 15 12 15C8.8 15 6.09999 16.9 5.29999 19.4C6.99999 21 9.4 22 12 22Z"" fill=""black"" />
                                                </svg>
                                            </span>
                                            <!--end::Svg Icon-->Developer
                                        </a>
                                        <a href=""#"" class=""d-flex align-items-center text-gray-400 text-hover-primary me-5 mb-2"">
                                            <!--begin::Svg Icon | path: icons/duotune/general/gen018.svg-->
                                            <span class=""svg-icon svg-icon-4 me-1"">
                                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"">
                                                    <path opacity=""0.3"" d=""M18.0624 15.3453L13.1624 20.7453C12.5624 21.4453 11.5624 21.4453 10.9624 20.7453L6.06242 15.3453C4.56242 13.6453 3.76242 11.");
            WriteLiteral(@"4453 4.06242 8.94534C4.56242 5.34534 7.46242 2.44534 11.0624 2.04534C15.8624 1.54534 19.9624 5.24534 19.9624 9.94534C20.0624 12.0453 19.2624 13.9453 18.0624 15.3453Z"" fill=""black"" />
                                                    <path d=""M12.0624 13.0453C13.7193 13.0453 15.0624 11.7022 15.0624 10.0453C15.0624 8.38849 13.7193 7.04535 12.0624 7.04535C10.4056 7.04535 9.06241 8.38849 9.06241 10.0453C9.06241 11.7022 10.4056 13.0453 12.0624 13.0453Z"" fill=""black"" />
                                                </svg>
                                            </span>
                                            <!--end::Svg Icon-->istanbul
                                        </a>
                                        <a href=""#"" class=""d-flex align-items-center text-gray-400 text-hover-primary mb-2"">
                                            <!--begin::Svg Icon | path: icons/duotune/communication/com011.svg-->
                                            <span class=""svg-icon svg-icon-4 me-1");
            WriteLiteral(@""">
                                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"">
                                                    <path opacity=""0.3"" d=""M21 19H3C2.4 19 2 18.6 2 18V6C2 5.4 2.4 5 3 5H21C21.6 5 22 5.4 22 6V18C22 18.6 21.6 19 21 19Z"" fill=""black"" />
                                                    <path d=""M21 5H2.99999C2.69999 5 2.49999 5.10005 2.29999 5.30005L11.2 13.3C11.7 13.7 12.4 13.7 12.8 13.3L21.7 5.30005C21.5 5.10005 21.3 5 21 5Z"" fill=""black"" />
                                                </svg>
                                            </span>
                                            <!--end::Svg Icon-->");
#nullable restore
#line 115 "D:\murat\netcore\Murat\WebUI\Areas\Manager\Views\Home\Index.cshtml"
                                                           Write(Model.currentUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </div>
                                    <!--end::Info-->
                                </div>
                                <!--end::User-->
                                <!--begin::Actions-->
                                <div class=""d-flex my-4"">
                                    <a href=""#"" class=""btn btn-sm btn-primary me-3"" data-bs-toggle=""modal"" data-bs-target=""#kt_modal_offer_a_deal"">Hire Me</a>
                                </div>
                                <!--end::Actions-->
                            </div>
                            <!--end::Title-->
                            <!--begin::Stats-->
                            <div class=""d-flex flex-wrap flex-stack"">
                            </div>
                            <!--end::Stats-->
                        </div>
                        <!--end::Info-->
                    </div>
                    <!--end::Deta");
            WriteLiteral(@"ils-->

                </div>
            </div>
            <!--end::Navbar-->
            <!--begin::Wrapper-->
            <div class=""d-flex flex-stack mb-5"">
                <!--begin::Search-->
                <div class=""d-flex align-items-center position-relative my-1"">
                    <span class=""svg-icon svg-icon-2"">...</span>
                    <input type=""text"" data-kt-docs-table-filter=""search"" class=""form-control form-control-solid w-250px ps-15"" placeholder=""Search Customers"" />
                </div>
                <!--end::Search-->
                <!--begin::Toolbar-->
                <div class=""d-flex justify-content-end"" data-kt-docs-table-toolbar=""base"">
                    <!--begin::Filter-->
                    <button type=""button"" class=""btn btn-light-primary me-3"" data-bs-toggle=""tooltip"" title=""Coming Soon"">
                        <span class=""svg-icon svg-icon-2"">...</span>
                        Filter
                    </button>
                ");
            WriteLiteral(@"    <!--end::Filter-->
                    <!--begin::Add customer-->
                    <button type=""button"" class=""btn btn-primary"" data-bs-toggle=""tooltip"" title=""Coming Soon"">
                        <span class=""svg-icon svg-icon-2"">...</span>
                        Add Customer
                    </button>
                    <!--end::Add customer-->
                </div>
                <!--end::Toolbar-->
                <!--begin::Group actions-->
                <div class=""d-flex justify-content-end align-items-center d-none"" data-kt-docs-table-toolbar=""selected"">
                    <div class=""fw-bolder me-5"">
                        <span class=""me-2"" data-kt-docs-table-select=""selected_count""></span> Selected
                    </div>

                    <button type=""button"" class=""btn btn-danger"" data-bs-toggle=""tooltip"" title=""Coming Soon"">
                        Selection Action
                    </button>
                </div>
                <!--end::Group ac");
            WriteLiteral(@"tions-->
            </div>
            <!--end::Wrapper-->
            <!--begin::Datatable-->
            <table id=""kt_datatable_example_1"" class=""table align-middle table-row-dashed fs-6 gy-5"">
                <thead>
                    <tr class=""text-start text-gray-400 fw-bolder fs-7 text-uppercase gs-0"">
                        <th class=""w-10px pe-2"">
                            <div class=""form-check form-check-sm form-check-custom form-check-solid me-3"">
                                <input class=""form-check-input"" type=""checkbox"" data-kt-check=""true"" data-kt-check-target=""#kt_datatable_example_1 .form-check-input"" value=""1"" />
                            </div>
                        </th>
                        <th>Customer Name</th>
                        <th>Email</th>
                        <th>Company</th>
                        <th>Payment Method</th>
                        <th>Created Date</th>
                        <th class=""text-end min-w-100px"">Actions</th>
");
            WriteLiteral(@"                    </tr>
                </thead>
                <tbody class=""text-gray-600 fw-bold"">
                </tbody>
            </table>
            <!--end::Datatable-->
        </div>
        <!--end::Post-->
    </div>
    <!--end::Content-->
    <!--begin::Footer-->
    <div class=""footer pt-10 pb-5 d-flex flex-column flex-md-row flex-stack"" id=""kt_footer"">
        <!--begin::Copyright-->
        <div class=""text-dark order-2 order-md-1"">
            <span class=""text-muted fw-bold me-1"">2021©</span>
            <a href=""/Home"" target=""_blank"" class=""text-gray-800 text-hover-primary"">MURATTAS</a>
        </div>
        <!--end::Copyright-->
        <!--begin::Menu-->
        <ul class=""menu menu-gray-600 menu-hover-primary fw-bold order-1"">
            <li class=""menu-item"">
                <a href=""/About"" target=""_blank"" class=""menu-link px-2"">About</a>
            </li>
            <li class=""menu-item"">
                <a href=""/Contact"" target=""_blank"" class=""men");
            WriteLiteral("u-link px-2\">Support</a>\r\n            </li>\r\n\r\n        </ul>\r\n        <!--end::Menu-->\r\n    </div>\r\n    <!--end::Footer-->\r\n</div>\r\n<!--end::Wrapper-->\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591