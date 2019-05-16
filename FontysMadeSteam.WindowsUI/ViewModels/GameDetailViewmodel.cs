using FontysMadeSteam.Logic;
using FontysMadeSteam.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FontysMadeSteam.WindowsUI.ViewModels
{
    public class GameDetailViewmodel
    {
        private GameLogic gameL = new GameLogic();
        public int id;
        public string Name;
        public DateTime datePublished;
        public string description;
        public string downloadUrl;
        public string uitgave;

        public GameDetailViewmodel(Game gameInfo)
        {
            id = gameInfo.Id;
            Name = gameInfo.Name;
            datePublished = gameInfo.DatePublished;
            description = gameInfo.Description;
            downloadUrl = gameInfo.DownloadUrl;
            uitgave = gameInfo.Uitgave;
        }
    }
}
