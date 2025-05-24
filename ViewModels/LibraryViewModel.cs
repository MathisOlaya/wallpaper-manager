using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

        // Http Client
        HttpClient client = new HttpClient();

        // List which contains api search result
        [ObservableProperty]
        ObservableCollection<PixabayImage> images = new();
        public async Task Search(string entry)
        {
        }
}
