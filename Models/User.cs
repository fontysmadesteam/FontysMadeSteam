using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User
    {
        public string Name { get; private set; }
        public Date DatePublished { get; private set; }
        public string Description { get; private set; }
        public string DownloadLink { get; private set; }
        public List<string> Tags { get; private set; }

        public User(string name, Date datePublished, string description, string downloadLink, List<string> tags)
        {
            Name = name;
            DatePublished = datePublished;
            Description = description;
            DownloadLink = downloadLink;
            Tags = tags;
        }
    }
}
