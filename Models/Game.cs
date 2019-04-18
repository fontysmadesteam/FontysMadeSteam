using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Game
    {
        public string Name { get; private set; }
        public DateTime DatePublished { get; private set; }
        public string Discription { get; private set; }
        public string DownloadLink { get; private set; }
        public List<string> Tags { get; private set; }

        public Game(string name, DateTime datePublished, string discription, string downloadLink, List<string> tags)
        {
            Name = name;
            DatePublished = datePublished;
            Discription = discription;
            DownloadLink = downloadLink;
            Tags = tags;
        }
    }
}
