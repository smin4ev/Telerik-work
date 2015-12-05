using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2.CatalogWithAlbums
{
    //2.Write program that extracts all different artists which are found in the catalog.xml. 
    //For each author you should print the number of albums in the catalogue. Use the DOM parser and a hash-table.
    class CatalogWithAlbums
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalogue.xml");
            XmlNode rootNode = doc.DocumentElement;
            Dictionary<string, int> artistAlbums = new Dictionary<string, int>();


            foreach (XmlElement artist in rootNode.ChildNodes)
            {
                var artistName = artist["artist"].InnerXml;

                if (artistAlbums.ContainsKey(artistName))
                {
                    artistAlbums[artistName]++;
                }
                else 
                {
                    artistAlbums.Add(artistName, 1);
                }
            }

            foreach (var item in artistAlbums)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }

        }
    }
}
