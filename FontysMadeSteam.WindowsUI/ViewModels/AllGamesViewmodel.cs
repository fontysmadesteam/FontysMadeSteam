﻿using FontysMadeSteam.Interface;
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
        public AllGamesViewmodel()
        {
            Games = new ObservableCollection<IGame>(gameL.GetAllGames());
        }

    }
}
