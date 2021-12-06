// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Crypto_Dashboard_2.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\willi\Desktop\WebProjects\Blazor Apps\Crypto_Dashboard_2\Crypto_Dashboard_2\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\willi\Desktop\WebProjects\Blazor Apps\Crypto_Dashboard_2\Crypto_Dashboard_2\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\willi\Desktop\WebProjects\Blazor Apps\Crypto_Dashboard_2\Crypto_Dashboard_2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\willi\Desktop\WebProjects\Blazor Apps\Crypto_Dashboard_2\Crypto_Dashboard_2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\willi\Desktop\WebProjects\Blazor Apps\Crypto_Dashboard_2\Crypto_Dashboard_2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\willi\Desktop\WebProjects\Blazor Apps\Crypto_Dashboard_2\Crypto_Dashboard_2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\willi\Desktop\WebProjects\Blazor Apps\Crypto_Dashboard_2\Crypto_Dashboard_2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\willi\Desktop\WebProjects\Blazor Apps\Crypto_Dashboard_2\Crypto_Dashboard_2\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\willi\Desktop\WebProjects\Blazor Apps\Crypto_Dashboard_2\Crypto_Dashboard_2\Client\_Imports.razor"
using Crypto_Dashboard_2.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\willi\Desktop\WebProjects\Blazor Apps\Crypto_Dashboard_2\Crypto_Dashboard_2\Client\_Imports.razor"
using Crypto_Dashboard_2.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\willi\Desktop\WebProjects\Blazor Apps\Crypto_Dashboard_2\Crypto_Dashboard_2\Client\Pages\FetchData.razor"
using Crypto_Dashboard_2.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\willi\Desktop\WebProjects\Blazor Apps\Crypto_Dashboard_2\Crypto_Dashboard_2\Client\Pages\FetchData.razor"
using Crypto_Dashboard_2.Client.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\willi\Desktop\WebProjects\Blazor Apps\Crypto_Dashboard_2\Crypto_Dashboard_2\Client\Pages\FetchData.razor"
 
    public string SearchText { get; set; } = "";

    public List<CoinData> response;
    public List<CoinData> filteredResponse = new List<CoinData>();

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("FetchData.OnInitializedAsync() called...");

        response = await httpClient.GetFromJsonAsync<List<CoinData>>("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=100&page=1&sparkline=false");

        filteredResponse.AddRange(response);
    }

    public void OnSearchTermChange()
    {
        Console.WriteLine("OnSearchTermChange() called, search term = " + SearchText);
        filteredResponse = response.Where(coin => coin.name.ToLower().Contains(SearchText.ToLower())).ToList();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
