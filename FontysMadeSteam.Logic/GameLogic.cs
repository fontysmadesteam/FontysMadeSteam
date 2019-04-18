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
        public List<Game> GetGamesFilteredByTag(List<string> listOfTags)
        {
            List<Game> filteredListOfGames = new List<Game>();
            foreach (string tag in listOfTags)
            {
                foreach (Game game in GameRepository.GetAllGames())
                {
                    foreach (string gameTag in game.Tags)
                    {
                        if (gameTag == tag & !filteredListOfGames.Contains(game))
                        {
                            filteredListOfGames.Add(game);
                            break;
                        }
                    }

                }
            }
            return filteredListOfGames;
        }
    }
}
