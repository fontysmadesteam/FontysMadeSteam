using System;
using System.Collections.Generic;

namespace FontysMadeSteam.Interface
{
    public interface IGame
    {
        int Id { get; }
        string Name { get; }
        List<string> DownloadUrls { get; }
        List<string> MediaUrls { get; }
        string Description { get; }
    }
}
