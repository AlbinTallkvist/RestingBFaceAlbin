using RestSharp;
using System.Text.Json;
using System.IO;

RestClient klient = new("https://digi-api.com/api/v1/digimon/");
string digimonNamn = "500";
RestRequest begär = new($"{digimonNamn}");
RestResponse svar = klient.GetAsync(begär).Result;

Digimon d = JsonSerializer.Deserialize<Digimon>(svar.Content);

System.Console.WriteLine(d.Name);
File.WriteAllText("digimon.json", svar.Content);


Console.ReadLine();

