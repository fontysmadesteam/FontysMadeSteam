using FontysMadeSteam.Interface;
using FontysMadeSteam.Logic;
using FontysMadeSteam.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FontysMadeSteam.WindowsUI.ViewModels
{
    
    public class AllGamesViewmodel
    {
        private GameLogic gameL = new GameLogic();
        public ObservableCollection<IGame> Games;
        private IEnumerable<IGame> gamelist;
        public AllGamesViewmodel()
        {
            gamelist = gameL.GetAllGames();
            Games = new ObservableCollection<IGame>(gamelist);
        }

        public void SearchGames(string input)
        {
            IGame searchResult = gamelist.FirstOrDefault(game => game.Name == input);
            Games.Clear();
            Games.Add(searchResult);
        }
        //public IGame SearchDevs(string input)
        //{
        //    var searchResult = gamelist.FirstOrDefault(game => game. == input);
        //    return searchResult;
        //}
        
    }
}
