using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Game
    {
        public string Name { get; set; }
        public DateTime DatePublished { get; set; }
        public string Description { get; set; }
        public string DownloadLink { get; set; }
        public List<string> Tags { get; set; }

        public Game(string name, DateTime datePublished, string description, string downloadLink, List<string> tags)
        {
            Name = name;
            DatePublished = datePublished;
            Description = description;
            DownloadLink = downloadLink;
            Tags = tags;
        }
    }
}
