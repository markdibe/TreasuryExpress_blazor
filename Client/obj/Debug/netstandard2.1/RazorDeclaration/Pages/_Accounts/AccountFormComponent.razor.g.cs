#pragma checksum "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Accounts\AccountFormComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ecd02c069b7f5f179005a795e522a153add1d02"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Accounts\AccountFormComponent.razor"
using TreasuryExpress.Shared;

#line default
#line hidden
#nullable disable
    public partial class AccountFormComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Accounts\AccountFormComponent.razor"
       

    private Account account;

    [Parameter]
    public EventCallback<Account> HandleSave { get; set; }

    protected  override void OnInitialized()
    {
        base.OnInitialized();
        account = new Account();
    }

    private async Task AddAccount()
    {
        HttpResponseMessage response;
        if (account.AccountId != default)
        {
            response = await http.PutAsJsonAsync($"Accounts/{account.AccountId}", account);
        }
        else
        {
            response = await http.PostAsJsonAsync("Accounts", account);
        }

        account =  await response.Content.ReadFromJsonAsync<Account>();
    }

    private async Task SaveAccount()
    {
        Task accountadded = AddAccount();
        await accountadded;
        await HandleSave.InvokeAsync(account);
        account = new Account();
    }

    public void Edit(Account Editaccount)
    {
        this.account = Editaccount;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
