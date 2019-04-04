using FontysMadeSteam.Interface;
using Models;
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
            new Game("game1", DateTime.Now, "description1", "downloadlink1", new List<string>(){ "tag1", "tag2" }),
            new Game("game2", DateTime.Now, "description2", "downloadlink2", new List<string>(){ "tag1", "tag2" })
        };
        #endregion
    }
}
