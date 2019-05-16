using System;
using System.Collections.Generic;
using System.Text;

namespace FontysMadeSteam.Model
{
    public class WpPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        List<string> Tags { get; set; }
        public WpPost()
        {

        }
    }
}
