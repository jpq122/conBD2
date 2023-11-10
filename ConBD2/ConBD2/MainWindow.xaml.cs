using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ConBD2
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var item = (NavigationViewItem)args.SelectedItem;

            switch (item.Name)
            {
                case "Aff_Rng":
                    mainFrame.Navigate(typeof(MainWindow));
                    break;
                case "Aff_Pro":
                    mainFrame.Navigate(typeof(MainWindow));
                    break;
                case "Aff_Mai":
                    mainFrame.Navigate(typeof(AfficherMaison));
                    break;
                case "Add_Pro":
                    mainFrame.Navigate(typeof(MainWindow));
                    break;
                case "Add_Mai":
                    mainFrame.Navigate(typeof(MainWindow));
                    break;
            }
        }
    }
}
