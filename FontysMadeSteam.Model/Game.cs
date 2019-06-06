using FontysMadeSteam.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FontysMadeSteam.Model
{
    public class Game : IGame
    {   public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DatePublished { get; set; }
        public string Description { get; set; }
        public List<string> DownloadUrls { get; set; }
        public List<string> MediaUrls { get; set; }
        public List<string> Tags { get; set; }

        public Game(int id, string name, DateTime datePublished, string description, List<string> downloadUrls, List<string> mediaUrls, List<string> tags)
        {
            Id = id;
            Name = name;
            DatePublished = datePublished;
            Description = description;
            DownloadUrls = downloadUrls;
            MediaUrls = mediaUrls;
            Tags = tags;
        }
    }
}
