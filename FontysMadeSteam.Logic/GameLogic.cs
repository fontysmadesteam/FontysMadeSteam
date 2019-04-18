using System;
using System.Collections.Generic;
using System.Text;
using FontysMadeSteam.Model;
﻿using FontysMadeSteam.DAL.Repository;
using FontysMadeSteam.Interface;

namespace FontysMadeSteam.Logic
{
    public class GameLogic
    {
        public Game GetGame(int game_id)
        {
            throw new NotImplementedException();
        } 
        public GameRepository GameRepository;
        public GameLogic()
        {
            GameRepository = new GameRepository();
        }
        public List<IGame> GetAllGames()
        {
            return GameRepository.GetAllGames();
        }
        public List<Game> Search(string parameter, SearchType type)
        {
            //implementation
            return null;
        }
    }
}
