using System.Text.Json.Serialization;

public class Digimon
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}