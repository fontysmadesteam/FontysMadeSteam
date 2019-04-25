using FontysMadeSteam.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FontysMadeSteam.DAL.Repository
{
    public class GameRepository
    {
        private Context.GameContext GameContext;
        public GameRepository()
        {
            GameContext = new Context.GameContext();
        }
        public List<IGame> GetAllGames()
        {
            return Context.GameContext.listOfGames;
        }


    }
}
