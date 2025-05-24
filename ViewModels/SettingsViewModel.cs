using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallpaper_manager.ViewModels
{
    public partial class SettingsViewModel : ObservableObject
    {
        [RelayCommand]
        private void OpenFileExplorer()
        {
            // Open file explorer
            var localPath = Windows.Storage.ApplicationData.Current.LocalFolder.Path;

            System.Diagnostics.Process.Start("explorer.exe", localPath);
        }
}
