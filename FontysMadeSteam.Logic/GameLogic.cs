using FontysMadeSteam.DAL.Repository;
using FontysMadeSteam.Interface;
using FontysMadeSteam.Model;
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
        public IEnumerable<IGame> GetAllGames()
        {
            return GameRepository.GetAllGames();
            //foreach (var game in Games)
            //{
            //    yield return new Game(game.Name, game. game.Description, game.DownloadUrl);
            //}
        }
        public List<Game> Search(string parameter, SearchType type)
        {
            //implementation
            return null;
        }
        //Methode is Misschien onnodig, als we geen tags kunnen gebruiken.
        //Heb hem voor nu even omgezet naar filteren op semester/Uitgave
        public List<Game> GetGamesFilteredBySemester(List<string> listOfSemesters)
        {
            List<Game> filteredListOfGames = new List<Game>();
            foreach (string semester in listOfSemesters)
            {
                foreach (Game game in GameRepository.GetAllGames())
                {
                    if (game.Uitgave == semester & !filteredListOfGames.Contains(game))
                    {
                        filteredListOfGames.Add(game);
                        break;
                    }
                }
            }
            return filteredListOfGames;
        }
    }
}
