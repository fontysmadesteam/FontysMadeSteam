using FontysMadeSteam.Logic;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FontysMadeSteam.WindowsUI.ViewModels
{
    
    public class GameViewmodel
    {
        private GameLogic gameL = new GameLogic();
        public Game Selectedgame;
        public ObservableCollection<Game> Games;
        public GameViewmodel()
        {
            var games = gameL.GetAllGames();
            Games = new ObservableCollection<Game>();
        }
    }
}
