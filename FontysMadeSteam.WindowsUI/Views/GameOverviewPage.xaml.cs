using FontysMadeSteam.Logic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FontysMadeSteam.WindowsUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GameOverviewPage : Page
    {
        public AllGamesViewmodel ViewModel;
        public GameOverviewPage()
        {
            ViewModel = new AllGamesViewmodel();
            this.InitializeComponent();
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var gridviewItem = (GridView)sender;
            var game = (Game)gridviewItem.SelectedItem;
            this.Frame.Navigate(typeof(GameInfoPage), game);
        }

        private void Btn_search_Click(object sender, RoutedEventArgs e)
        {
            string input = Searchbox.Text;
            ViewModel.SearchGames(input);
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OptionsAllCheckBox_Indeterminate(object sender, RoutedEventArgs e)
        {

        }

        private void OptionsAllCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void OptionsAllCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //foreach (var checkbox in Semesters)
            //{

            //}
        }

        private void Btn_openPanel_Click(object sender, RoutedEventArgs e)
        {
            if (FilterPanel.IsPaneOpen == true)
            {
                FilterPanel.IsPaneOpen = false;
            }
            else
            {
                FilterPanel.IsPaneOpen = true;
            }
            
        }
    }
}
