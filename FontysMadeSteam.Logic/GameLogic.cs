using FontysMadeSteam.DAL.Repository;
using FontysMadeSteam.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FontysMadeSteam.Logic
{
    public class GameLogic
    {
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
