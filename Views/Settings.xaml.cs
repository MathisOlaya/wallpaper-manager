using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using wallpaper_manager.Helpers;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace wallpaper_manager.Views;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class Settings : Page
{
    public Settings()
    {
        InitializeComponent();

        // Get ViewModel instance
        var vm = this.DataContext as ViewModels.SettingsViewModel;

        // Init all language
        foreach(KeyValuePair<string, string> country in GlobalHelpers.Languages)
        {
            this.LanguageSelector.Items.Add(
                new MenuFlyoutItem
                {
                    Text = country.Key,
                    Tag = country.Value,
                    Command = vm.UpdateApiLanguageCommand,
                    CommandParameter = country
                });
        }
    }
}
