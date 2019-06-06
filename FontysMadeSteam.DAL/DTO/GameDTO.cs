using FontysMadeSteam.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FontysMadeSteam.DAL.DTO
{
    public class GameDTO : IGame
    {
        public string Name => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();
        public int Id => throw new NotImplementedException();

        public List<string> DownloadUrls => throw new NotImplementedException();

        public List<string> MediaUrls => throw new NotImplementedException();
    }
}
