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
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(
            UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

        private static readonly UInt32 SPI_SETDESKWALLPAPER = 0x14;
        private static readonly UInt32 SPIF_UPDATEINIFILE = 0x01;
        private static readonly UInt32 SPIF_SENDWININICHANGE = 0x02;


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

        // Method for updating desktop background
        private void SetWallpaper(String path)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            key.SetValue(@"WallpaperStyle", 0.ToString());
            key.SetValue(@"TileWallpaper", 0.ToString());

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }

    }


}
