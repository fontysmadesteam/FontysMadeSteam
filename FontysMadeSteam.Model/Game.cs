using FontysMadeSteam.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FontysMadeSteam.Model
{
    public class Game : IGame
    {
        public string Name { get; set; }
        public DateTime DatePublished { get; set; }
        public string Description { get; set; }
        public string DownloadUrl { get; set; }
        public List<string> Tags { get; set; }

        public Game(string name, DateTime datePublished, string description, string downloadUrl, List<string> tags)
        {
            Name = name;
            DatePublished = datePublished;
            Description = description;
            DownloadUrl = downloadUrl;
            Tags = tags;
        }
    }
}
