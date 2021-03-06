#pragma checksum "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Accounts\AccountComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2385fc8b3b3f91f70c983ef97a14e25af6e760b"
// <auto-generated/>
#pragma warning disable 1591
namespace TreasuryExpress.Client.Pages._Accounts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using TreasuryExpress.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using TreasuryExpress.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using TreasuryExpress.Client.Pages._Accounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using TreasuryExpress.Client.Pages._Balances;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using TreasuryExpress.Client.Pages._Transactions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Accounts\AccountComponent.razor"
using TreasuryExpress.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AccountManager")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/AccountManager/{AccountId:int}")]
    public partial class AccountComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<TreasuryExpress.Client.Pages._Accounts.AccountFormComponent>(0);
            __builder.AddAttribute(1, "HandleSave", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TreasuryExpress.Shared.Account>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TreasuryExpress.Shared.Account>(this, 
#nullable restore
#line 8 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Accounts\AccountComponent.razor"
                                  HandleSaveAccount

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(2, (__value) => {
#nullable restore
#line 8 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Accounts\AccountComponent.razor"
                                                           accountForm = (TreasuryExpress.Client.Pages._Accounts.AccountFormComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenComponent<TreasuryExpress.Client.Pages._Accounts.AccountListComponent>(4);
            __builder.AddAttribute(5, "HandleEdit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TreasuryExpress.Shared.Account>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TreasuryExpress.Shared.Account>(this, 
#nullable restore
#line 12 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Accounts\AccountComponent.razor"
                                                      HandleEditAccount

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(6, (__value) => {
#nullable restore
#line 12 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Accounts\AccountComponent.razor"
                            accountTable = (TreasuryExpress.Client.Pages._Accounts.AccountListComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Accounts\AccountComponent.razor"
       

    private AccountFormComponent accountForm;

    private AccountListComponent accountTable;


    [Parameter]
    public int AccountId { get; set; }


    private void HandleEditAccount(Account account)
    {
        accountForm.Edit(account);
    }

    private void HandleSaveAccount(Account _ac)
    {
        accountTable.HandleSaveAccount(_ac);
    }



    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
    }


 



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
