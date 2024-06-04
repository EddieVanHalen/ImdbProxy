using Newtonsoft.Json;

namespace ImdbProxy.Model;

public class Movie
{
    [JsonProperty("Title")] public string Title { get; set; }
    
    [JsonProperty("Rated")] public string Rated { get; set; }

    [JsonProperty("Released")] public string Released { get; set; }
    
    [JsonProperty("Runtime")] public string Runtime { get; set; }
    
    [JsonProperty("Genre")] public string Genre { get; set; }
    
    [JsonProperty("Director")] public string Director { get; set; }
    
    [JsonProperty("Writer")] public string Writer { get; set; }
    
    [JsonProperty("Actors")] public string Actors { get; set; }
    
    [JsonProperty("Plot")] public string Plot { get; set; }
    
    [JsonProperty("Language")] public string Language { get; set; }
}