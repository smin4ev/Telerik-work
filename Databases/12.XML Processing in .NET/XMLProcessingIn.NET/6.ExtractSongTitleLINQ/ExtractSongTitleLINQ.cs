using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace _6.ExtractSongTitleLINQ
{
    //6.Rewrite the same using XDocument and LINQ query.


    class ExtractSongTitleLINQ
    {
        static void Main(string[] args)
        {

            XDocument doc = XDocument.Load("../../catalogue.xml");
            var songs =
                from song in doc.Descendants("song")
                select new
                {
                    Title = song.Element("title").Value
                };
            Console.WriteLine("Found {0} songs in catalogue.xml", songs.Count());

            foreach (var song in songs)
            {
                Console.WriteLine("Title song is {0}", song.Title);
            }
        }
    }
}
