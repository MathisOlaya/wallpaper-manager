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
using System.Threading.Tasks;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace wallpaper_manager.Views;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class Library : Page
{
    public Library()
    {
        InitializeComponent();
    private async Task CheckApiKey()
    {
        string? apiKey = Environment.GetEnvironmentVariable("PIXABAY_SECRET");

        if (string.IsNullOrEmpty(apiKey))
        {

            // Displaying alert if user didn't give any API KEY
            ContentDialog alert = new ContentDialog
            {
                Title = "Attention",
                Content = "Vous n'avez pas renseign� de cl� API pour Pixabay.\nImpossible de faire fonctionner la barre de recherche.\nConsultez le GitHub pour plus d'informations.",
                CloseButtonText = "Ok",
                XamlRoot = this.XamlRoot
            };

            await alert.ShowAsync();
        }
    }

    private async void TextBox_KeyDown(object sender, KeyRoutedEventArgs e)
    {
        if (e.Key == Windows.System.VirtualKey.Enter)
        {
            var text = TextBox.Text;

            if (this.DataContext is ViewModels.LibraryViewModel viewModel)
            {
                await viewModel.Search(text);
            }
        }
    }
}
