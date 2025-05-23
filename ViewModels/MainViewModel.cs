using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using wallpaper_manager.Models;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Pickers.Provider;
using WinRT.Interop;

namespace wallpaper_manager.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        // Importing DLL for desktop wallpaper
        [ObservableProperty]
        ObservableCollection<WallPaper> wallPapers = new();

        public MainViewModel()
        {
            WallPapers.Add(new WallPaper() { ImagePath = "C:\\Users\\PC-Mathis\\Pictures\\OlayaMathis.jpg" });
        }

        [RelayCommand]
        private async Task OpenFileExplorer()
        {
            // Default file dialog | image only
            FileOpenPicker fileDialog = new FileOpenPicker()
            {
                ViewMode = PickerViewMode.Thumbnail,
                FileTypeFilter = { ".jpeg", ".jpg", ".png"}
            };

            nint windowHandle = WindowNative.GetWindowHandle(App.Window);
            InitializeWithWindow.Initialize(fileDialog, windowHandle);

            // Wait for image
            StorageFile file = await  fileDialog.PickSingleFileAsync();

            if (file != null) 
            { 
                // Creating new Image
                WallPaper newImg = new WallPaper() { ImagePath = file.Path };

                // Adding to local list
                WallPapers.Add(newImg);
            }
        }

}
