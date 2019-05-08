using FontysMadeSteam.Logic;
using FontysMadeSteam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FontysMadeSteam.WindowsUI.ViewModels
{
    public class GameDetailViewmodel
    {
        private GameLogic gameL = new GameLogic();
        public Game Selectedgame;

        public GameDetailViewmodel()
        {

        }
    }
}
