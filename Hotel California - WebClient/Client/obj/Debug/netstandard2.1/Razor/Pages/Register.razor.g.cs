#pragma checksum "C:\Users\Bruker 1\Documents\GitHub\Hotel-California\Hotel California - WebClient\Client\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "703c5d8b8090052618c60bdbaae1f0cf4d5c464b"
// <auto-generated/>
#pragma warning disable 1591
namespace Hotel_California___WebClient.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bruker 1\Documents\GitHub\Hotel-California\Hotel California - WebClient\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruker 1\Documents\GitHub\Hotel-California\Hotel California - WebClient\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruker 1\Documents\GitHub\Hotel-California\Hotel California - WebClient\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruker 1\Documents\GitHub\Hotel-California\Hotel California - WebClient\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bruker 1\Documents\GitHub\Hotel-California\Hotel California - WebClient\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bruker 1\Documents\GitHub\Hotel-California\Hotel California - WebClient\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bruker 1\Documents\GitHub\Hotel-California\Hotel California - WebClient\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bruker 1\Documents\GitHub\Hotel-California\Hotel California - WebClient\Client\_Imports.razor"
using Hotel_California___WebClient.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bruker 1\Documents\GitHub\Hotel-California\Hotel California - WebClient\Client\_Imports.razor"
using Hotel_California___WebClient.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"box\">\r\n<h1>Here, you can register as a new Client</h1>\r\n<h6>If you already have registered, you can go book your rooms</h6>\r\n</div>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div>\r\n    Name\r\n    <input type=\"text\" id=\"cname\">\r\n    Password\r\n    <input type=\"password\" id=\"cpassword\">\r\n    <input type=\"button\" id=\"confirm\" class=\"button\" value=\"Confirm\">\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Bruker 1\Documents\GitHub\Hotel-California\Hotel California - WebClient\Client\Pages\Register.razor"
       
    [Parameter]
    public string cname { get; set; }
    public string cpassword { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
