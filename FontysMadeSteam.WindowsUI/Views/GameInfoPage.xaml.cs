using FontysMadeSteam.Model;
using FontysMadeSteam.WindowsUI.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FontysMadeSteam.WindowsUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GameInfoPage : Page
    {
        public GameDetailViewmodel Viewmodel { get; set; } 
        public GameInfoPage()
        {
            this.InitializeComponent();           
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Viewmodel = new GameDetailViewmodel((Game)e.Parameter);
        }
        private void BackToOverviewbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GameOverviewPage));
        }
    }
}
