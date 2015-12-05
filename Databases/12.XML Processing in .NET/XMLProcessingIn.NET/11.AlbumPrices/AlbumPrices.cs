using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Xml;


namespace ExtractPriceAlbums
{
    //11.Write a program, which extract from the file catalog.xml the prices for all albums, 
    //published 5 years ago or earlier. Use XPath query.


    class ExtractPrice
    {
        static void Main()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../catalogue.xml");


            string xPathQuery = "/catalogue/album[year<2008]";
            XmlNodeList priceList = xmlDoc.SelectNodes(xPathQuery);


            foreach (XmlNode priceNode in priceList)
            {
                string albumName = priceNode.SelectSingleNode("name").InnerText;
                string price = priceNode.SelectSingleNode("price").InnerText;
                Console.WriteLine("{0} - {1}", albumName, price);
            }
        }
    }
} 
