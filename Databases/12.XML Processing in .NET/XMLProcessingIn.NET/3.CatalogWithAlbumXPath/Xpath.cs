using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _3.CatalogWithAlbumXPath
{
    //3.Implement the previous task using XPath.


    class Xpath
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalogue.xml");

            Dictionary<string, int> artistAlbum = new Dictionary<string, int>();

            string XpathQuery = "catalogue/album";

            XmlNodeList artistLists = doc.SelectNodes(XpathQuery);

            foreach (XmlNode artist in artistLists)
            {
                string artistName = artist.SelectSingleNode("artist").InnerXml;

                if (artistAlbum.ContainsKey(artistName))
                {
                    artistAlbum[artistName]++;
                }
                else 
                {
                    artistAlbum.Add(artistName,1);
                }
            }

            foreach (var artist in artistAlbum)
            {
                Console.WriteLine("{0} - {1}", artist.Key, artist.Value);
            }
        }
    }
}
