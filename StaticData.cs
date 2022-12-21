using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace AvaloniaClient;
public static class StaticData
{
    public static string Jwt { get; set; }

    public static RestClientOptions RestClientOptions
    {
        get;
    } = new RestClientOptions("http://localhost:80")
    {
        ThrowOnAnyError= true,
    };

    public static RestClient RestClient { get; } = new RestClient(RestClientOptions); 
}
