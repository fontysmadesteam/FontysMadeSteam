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
            new Game(1,"game1", DateTime.Now, "description1", "downloadlink1", new Uitgave(){ Seizoen = Model.Enums.Seizoen.Voorjaar, Jaar = 2017}),
            new Game(2,"game2", DateTime.Now, "description1", "downloadlink2", new Uitgave(){ Seizoen = Model.Enums.Seizoen.Voorjaar, Jaar = 2018}),
            new Game(3,"game3", DateTime.Now, "description2", "downloadlink3", new Uitgave(){ Seizoen = Model.Enums.Seizoen.Najaar, Jaar = 2017}),
            new Game(4,"game4", DateTime.Now, "description3", "downloadlink4", new Uitgave(){ Seizoen = Model.Enums.Seizoen.Najaar, Jaar = 2018})
        };

        public static List<string> listOfSemesters = new List<string>()
        {
            "Voorjaar 2017",
            "Najaar 2017",
            "Voorjaar 2018",
            "Najaar 2018"
        };
        #endregion
    }
}
