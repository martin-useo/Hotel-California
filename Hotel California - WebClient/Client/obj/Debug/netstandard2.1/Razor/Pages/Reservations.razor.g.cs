#pragma checksum "C:\Users\Bruker 1\Documents\GitHub\Hotel-California\Hotel California - WebClient\Client\Pages\Reservations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "184b1c4bc39bed44bfb5552bfa3fdc8bf03dd22c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Reservations")]
    public partial class Reservations : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Find Your Reservations here</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h2>Login</h2>\r\n");
            __builder.AddMarkupContent(2, "<div>\r\n    Name\r\n    <input type=\"text\" id=\"cname\">\r\n    Password\r\n    <input type=\"password\" id=\"cpassword\">\r\n    <input type=\"button\" id=\"confirm\" class=\"button\" value=\"Confirm\">\r\n</div>\r\n\r\n");
            __builder.AddMarkupContent(3, "<h2>Reservation list</h2>\r\n\r\n");
            __builder.AddMarkupContent(4, @"<table>
    <tbody>
        <tr>
            <th scope=""col"">&nbsp;</th>
            <th scope=""col"">&nbsp;</th>
            <th scope=""col"">&nbsp;</th>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </tbody>
</table>");
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Bruker 1\Documents\GitHub\Hotel-California\Hotel California - WebClient\Client\Pages\Reservations.razor"
       
    [Parameter]
    public string cname { get; set; }
    public string cpassword { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
