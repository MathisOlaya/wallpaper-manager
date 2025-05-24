using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using wallpaper_manager.ViewModels;
using Windows.Storage.Pickers;
using wallpaper_manager.Views;
using System.Threading.Tasks;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace wallpaper_manager
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Default page
            ContentFrame.Navigate(typeof(Views.Home));
        }

        // Instance for each pages
        private Views.Home _homepage = new Views.Home();
        private Views.Library _library = new Views.Library();
        private Views.Settings _settings = new Views.Settings();

        private async void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItem is NavigationViewItem item)
            {
                switch (item.Tag)
                {
                    case "home":
                        ContentFrame.Content = _homepage;
                        break;
                    case "library":
                        ContentFrame.Content = _library;
                        break;
                    case "Settings":
                        ContentFrame.Content = _settings;
                        break;
                }
            }
        }
    }
}
