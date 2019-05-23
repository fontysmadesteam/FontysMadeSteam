using FontysMadeSteam.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FontysMadeSteam.Model
{
    public class Game : IGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DatePublished { get; set; }
        public string Description { get; set; }
        public string DownloadUrl { get; set; }
        public string Uitgave { get; set; }
        public Game()
        {

        }
        public Game(int id, string name, DateTime datePublished, string description, string downloadUrl, string uitgave)
        {
            Id = id;
            Name = name;
            DatePublished = datePublished;
            Description = description;
            DownloadUrl = downloadUrl;
            Uitgave = uitgave;
        }
    }
}
