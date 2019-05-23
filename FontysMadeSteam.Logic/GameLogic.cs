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
        }

        public List<string> GetAllSemesters()
        {
            return GameRepository.GetAllSemesters();
            
        }
        public List<Game> Search(string parameter, SearchType type)
        {
            //implementation
            return null;
        }

        //Methode is Misschien onnodig, als we geen tags kunnen gebruiken.
        //Heb hem voor nu even omgezet naar filteren op semester/Uitgave
        public List<Game> GetGamesFilteredBySemester(List<Uitgave> listOfSemesters)
        {
            List<Game> filteredListOfGames = new List<Game>();
            foreach (Uitgave semester in listOfSemesters)
            {
                foreach (Game game in GameRepository.GetAllGames())
                {
                    if (game.Uitgave.Jaar == semester.Jaar & game.Uitgave.Seizoen.ToString() == semester.Seizoen.ToString() & !filteredListOfGames.Contains(game))
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
