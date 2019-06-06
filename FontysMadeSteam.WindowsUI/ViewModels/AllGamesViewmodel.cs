using FontysMadeSteam.Interface;
using FontysMadeSteam.Logic;
using FontysMadeSteam.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace FontysMadeSteam.WindowsUI.ViewModels
{

    public class AllGamesViewmodel
    {
        private GameLogic gameL = new GameLogic();
        public ObservableCollection<IGame> Games;
        public ObservableCollection<string> Semesters;
        private IEnumerable<IGame> gamelist;
        public AllGamesViewmodel()
        {
            gamelist = gameL.GetAllGames();
            Games = new ObservableCollection<IGame>(gamelist);
            Semesters = new ObservableCollection<string>(gameL.GetAllSemesters());
        }

        public void SearchGames(string input)
        {
            var searchResult = gamelist.Where(game => game.Name.Contains(input));
            Games.Clear();
            foreach (var result in searchResult)
            {
                Games.Add(result);
            }
        }

        //public IGame SearchDevs(string input)
        //{
        //    var searchResult = gamelist.FirstOrDefault(game => game. == input);
        //    return searchResult;
        //}

    }
}
