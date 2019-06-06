using FontysMadeSteam.DAL.Context;
using FontysMadeSteam.DAL.Repository;
using FontysMadeSteam.Interface;
using FontysMadeSteam.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
            GameSQLContext sqlgamecontext = new GameSQLContext();
            this.ParseData(sqlgamecontext.GetWpPosts());
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

        public IEnumerable<Game> ParseData(IEnumerable<WpPost> wpPosts)
        {
            string description = "";
            string url = "";
            List<string> downloadUrls = new List<string>();
            List<string> mediaUrls = new List<string>();
            List<Game> games = new List<Game>();

            foreach (WpPost wpPost in wpPosts)
            {
                Regex filter = new Regex(@"<p\sid=""(.+?)"">(.+?)</p>");
                MatchCollection matches = filter.Matches(wpPost.Content);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        Group contentType = match.Groups[1];
                        Group content = match.Groups[2];

                        if (contentType.Value == "description")
                        {
                            description = content.Value;
                        }
                        else if (contentType.Value == "url")
                        {
                            url = content.Value;
                            if (url.Contains("download"))
                            {
                                downloadUrls.Add(url);
                            }
                            else if (url.Contains("media")) {
                                mediaUrls.Add(url);
                            }

                        }

                    }
                    Game game = new Game(wpPost.Id, wpPost.Title, DateTime.Now, description, downloadUrls, mediaUrls, wpPost.Tags);
                    games.Add(game);
                    description = "";
                    downloadUrls.Clear();
                    mediaUrls.Clear();                   
                }
            }
            return games;
        }
    }
}
