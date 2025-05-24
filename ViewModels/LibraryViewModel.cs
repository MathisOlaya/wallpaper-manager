using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using wallpaper_manager.Models;
using Windows.Security.Cryptography.Core;
using Windows.Storage;

namespace wallpaper_manager.ViewModels
{
    public partial class LibraryViewModel : ObservableObject
    {
        // [ CONSTANTS ]
        const string API_BASE_URL = "https://pixabay.com/api/";

        // Variables
        public string API_SECRET_KEY = string.Empty;

        // Http Client
        HttpClient client = new HttpClient();

        // List which contains api search result
        [ObservableProperty]
        ObservableCollection<PixabayImage> images = new();

        public async Task Search(string entry)
        {
            // Hostname  
            UriBuilder BaseApiURL = new UriBuilder(API_BASE_URL);

            // Define query parameters
            var query = HttpUtility.ParseQueryString(BaseApiURL.Query);

            query["key"] = API_SECRET_KEY;

            // Query equal placeholder if entry is empty
            query["q"] = entry.Length == 0 ? "Couché de soleil" : entry;

            // Full URL
            BaseApiURL.Query = query.ToString();

            try
            {
                // Fetching API
                HttpResponseMessage response = await client.GetAsync(BaseApiURL.ToString());

                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // Read content as string
                    var stringContent = await response.Content.ReadAsStringAsync();

                    // Deserialize it
                    PixabayResponse? imagesResponse = JsonSerializer.Deserialize<PixabayResponse>(stringContent);

                   if(imagesResponse.Hits.Count > 0)
                    {
                        // Clear old list
                        Images.Clear();

                        // Get new content
                        foreach(PixabayImage img in imagesResponse.Hits)
                        {
                            Images.Add(img);
                        }
                    }
                }
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
        }
}
