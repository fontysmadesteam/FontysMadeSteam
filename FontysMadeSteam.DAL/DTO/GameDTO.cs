using FontysMadeSteam.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FontysMadeSteam.DAL.DTO
{
    public class GameDTO : IGame
    {
        public string Name => throw new NotImplementedException();

        public string DownloadUrl => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();
        public Uri ImageUrl => throw new NotImplementedException();
        public int Id => throw new NotImplementedException();
    }
}
