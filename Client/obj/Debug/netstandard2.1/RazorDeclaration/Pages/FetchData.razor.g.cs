#pragma checksum "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "282545b52fa1d3b64ec904d7c3fc5e33d257e5b7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TreasuryExpress.Client.Pages
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
#line 2 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\FetchData.razor"
using TreasuryExpress.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        Console.Write(forecasts);
    }

    private void tryDelete(int id)
    {
        List<WeatherForecast> forecastList = forecasts.ToList().Where(x=>x.id!=id).ToList();
        forecasts = forecastList.ToArray();

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591