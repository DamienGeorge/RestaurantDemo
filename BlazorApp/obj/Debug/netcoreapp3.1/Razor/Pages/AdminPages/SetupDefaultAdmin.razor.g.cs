#pragma checksum "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\SetupDefaultAdmin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11aecb9fb9d987c6924de8a8315767f8894a908d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/setup")]
    public partial class SetupDefaultAdmin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>You\'ve reached a secret page to setup the default admin</h3>");
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Dan.G\source\repos\RestaurantDemoApp\BlazorApp\Pages\AdminPages\SetupDefaultAdmin.razor"
       
    const string Admin = "Administrator";
    const string User = "User";

    protected override async Task OnParametersSetAsync()
    {
        await SetupTask();
        await SetupRole();
    }

    private async Task SetupTask()
    {
        string[] roles = { Admin, User };

        foreach (var role in roles)
        {
            var roleExists = await roleManager.RoleExistsAsync(role);

            if (!roleExists)
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
        }
    }

    private async Task SetupRole()
    {
        string defaultAdmin = config.GetValue<string>("DefaultAdmin");

        var userToSetup = await userManager.FindByEmailAsync(defaultAdmin);

        if (userToSetup != null)
        {
            await userManager.AddToRoleAsync(userToSetup, Admin);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> roleManager { get; set; }
    }
}
#pragma warning restore 1591
