using System;

namespace FontysMadeSteam.Interface
{
    public interface IGame
    {
        int Id { get; }
        string Name { get; }
        string DownloadUrl { get; }
        string Description { get; }
        Uri ImageUrl { get; }
    }
}
