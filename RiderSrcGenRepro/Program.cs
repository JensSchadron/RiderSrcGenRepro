// See https://aka.ms/new-console-template for more information

using System.Net.Http.Json;
using RiderSrcGenRepro.JSON;

Console.WriteLine("Hello, World!");

const string API_URI = "https://meowfacts.herokuapp.com/";
var httpClient = new HttpClient
{
	BaseAddress = new Uri(API_URI)
};

var response = await httpClient.GetFromJsonAsync(API_URI, MeowFactsSerializerContext.Default.MeowFactsDto).ConfigureAwait(false);
Console.WriteLine(response.Data.First());

Console.WriteLine("Goodbye, World!");