using System.Net;
using ImdbProxy.Model;

namespace ImdbProxy.Interfaces;

public interface IMovieViewer
{
    Task<Movie?> Request(string name);
}

public class OmdbMovieViewer : IMovieViewer
{
    private string _api = "73169aad";
    
    public async Task<Movie?> Request(string name)
    {
        var movieDataUrl = $"http://www.omdbapi.com/?t={name}apikey={_api}&";

        using var client = new WebClient();

        var uri = new Uri(movieDataUrl);
        
        client.DownloadStringAsync(uri);
        
        return null;
    }
}
//
// public class OmdbMovieViewerProxy : IMovieViewer
// {
//     public Movie? Request()
//     {
//         return null;
//     }
// }