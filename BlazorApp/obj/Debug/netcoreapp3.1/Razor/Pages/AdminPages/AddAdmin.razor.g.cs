#pragma checksum "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\AddAdmin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aa47b4b270d33ebdaeaf219e7d7ab052f21d5f9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages.AdminPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using SupportLibrary.Data.AuthData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using SupportLibrary.Models.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using SupportLibrary.Data.ItemData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using SupportLibrary.Models.General;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\AddAdmin.razor"
           [Authorize(Roles = "Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/editadmin")]
    public partial class AddAdmin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add a person to admin list</h3>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\AddAdmin.razor"
 if (!String.IsNullOrEmpty(message))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "span");
            __builder.AddAttribute(3, "class", 
#nullable restore
#line 14 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\AddAdmin.razor"
                  cssValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, 
#nullable restore
#line 14 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\AddAdmin.razor"
                             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 15 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\AddAdmin.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\AddAdmin.razor"
                 user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __Blazor.BlazorApp.Pages.AdminPages.AddAdmin.TypeInference.CreateInputSelect_0(__builder2, 13, 14, 
#nullable restore
#line 19 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\AddAdmin.razor"
                              user.Email

#line default
#line hidden
#nullable disable
                , 15, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Email = __value, user.Email)), 16, () => user.Email, 17, (__builder3) => {
                    __builder3.AddMarkupContent(18, "\r\n        ");
                    __builder3.AddMarkupContent(19, "<option>Please select a user...</option>\r\n");
#nullable restore
#line 21 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\AddAdmin.razor"
         foreach (var u in users)
        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(20, "            ");
                    __builder3.OpenElement(21, "option");
                    __builder3.AddContent(22, 
#nullable restore
#line 23 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\AddAdmin.razor"
                     u.Email

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(23, "\r\n");
#nullable restore
#line 24 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\AddAdmin.razor"
        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(24, "    ");
                }
                );
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenElement(26, "button");
                __builder2.AddAttribute(27, "class", "btn btn-dark");
                __builder2.AddAttribute(28, "type", "submit");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\AddAdmin.razor"
                                                         HandleAddAdmin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(30, "Make Admin");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __builder2.OpenElement(32, "button");
                __builder2.AddAttribute(33, "class", "btn btn-danger");
                __builder2.AddAttribute(34, "type", "submit");
                __builder2.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\AddAdmin.razor"
                                                           HandleRevokeAdmin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(36, "Revoke Admin");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\AddAdmin.razor"
       
    string message = "";
    string cssValue = "";

    List<IdentityUser> users = new List<IdentityUser>();
    IdentityUser user = new IdentityUser();
    protected override async Task OnParametersSetAsync()
    {
        var userListGeneric = await userData.FetchUser<IdentityUser>();

        users = userListGeneric.ToList<IdentityUser>();
    }

    private async Task HandleAddAdmin()
    {

        if (PreliminaryCheck() == false)
        {
            return;
        }

        bool isAdmin = await CheckUserRole();

        if (!isAdmin)
        {
            await userManager.AddToRoleAsync(user, "Administrator");
            message = $"{user.Email} is now an Admin. Please request them to re-login for the permissions to take effect";
            cssValue = "text-success";
        }
        else
        {
            message = $"{user.Email} is already an Admin";
            cssValue = "text-danger";
        }

        user = new IdentityUser();
    }

    private async Task HandleRevokeAdmin()
    {
        if (PreliminaryCheck() ==false)
        {
            return;
        }

        bool isAdmin = await CheckUserRole();

        if (isAdmin)
        {
            await userManager.RemoveFromRoleAsync(user, "Administrator");
            message = $"{user.Email} is no longer an Admin. Please request them to re-login for the permissions to take effect";
            cssValue = "text-success";
        }
        else
        {
            message = $"{user.Email} is not an Admin";
            cssValue = "text-danger";
        }
        user = new IdentityUser();
    }

    private bool PreliminaryCheck()
    {
        if (user.Email is null)
        {
            message = "Please select a valid user!";
            cssValue = "text-danger";
            return false;
        }

        return true;
    }

    private async Task<bool> CheckUserRole()
    {
        user = await userManager.FindByEmailAsync(user.Email);

        return await userManager.IsInRoleAsync(user, "Administrator");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> roleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IIdentityDataAccess userData { get; set; }
    }
}
namespace __Blazor.BlazorApp.Pages.AdminPages.AddAdmin
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
