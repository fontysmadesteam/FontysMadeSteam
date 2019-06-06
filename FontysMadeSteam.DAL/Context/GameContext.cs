using FontysMadeSteam.Interface;
using FontysMadeSteam.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FontysMadeSteam.DAL.Context
{
    public class GameContext
    {

        #region dummy data 
        public static List<IGame> listOfGames = new List<IGame>()
        {
            new Game(1,"game1", DateTime.Now, "description1", new List<string>(){ "downloadlink1", "downloadlink2" }, new List<string>(){ "Medialink1", "Medialink2" } , new List<string>(){ "tag1", "tag2" }),
            new Game(2,"game2", DateTime.Now, "description1", new List<string>(){ "downloadlink1", "downloadlink2" }, new List<string>(){ "Medialink1", "Medialink2" } , new List<string>(){ "tag1", "tag2" })
        };
        #endregion
    }
}
