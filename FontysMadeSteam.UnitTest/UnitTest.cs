using FontysMadeSteam.DAL;
using FontysMadeSteam.DAL.Context;
using FontysMadeSteam.Interface;
using FontysMadeSteam.Logic;
using FontysMadeSteam.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FontysMadeSteam.UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void GetAllGames_DidGetAllGames_Test()
        {
            List<Game> listGamesExpected = new List<Game>();
            List<Game> listGamesResult = new List<Game>();
            GameLogic gameLogic = new GameLogic();

            listGamesExpected = GameContext.listOfGames.OfType<Game>().ToList();
            listGamesResult = gameLogic.GetAllGames().OfType<Game>().ToList();

            //Assert.AreEqual(listGamesExpected, listGamesResult);
            for (int i = 0; i < listGamesExpected.Count; i++)
            {
                Assert.AreEqual(listGamesExpected[i], listGamesResult[i]);
            }
        }

        public void GetAllFilteredGames()
        {
            List<Game> listGamesExpected = new List<Game>();
            List<Game> listGamesResult = new List<Game>();
            GameLogic gameLogic = new GameLogic();

            listGamesExpected = GameContext.listOfGames.OfType<Game>().ToList();
            listGamesResult = gameLogic.GetAllGames().OfType<Game>().ToList();

            //Assert.AreEqual(listGamesExpected, listGamesResult);
            for (int i = 0; i < listGamesExpected.Count; i++)
            {
                Assert.AreEqual(listGamesExpected[i], listGamesResult[i]);
            }
        }
    }
}
