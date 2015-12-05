using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _4.DeleteAlbum
{
    //4.Using the DOM parser write a program to delete from catalog.xml all albums having price > 20.


    class DeleteAlbum
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalogue.xml");

            foreach (XmlNode item in doc.DocumentElement)
            {
                if (decimal.Parse(item["price"].InnerText) > 20)
                {
                    XmlNode parent =item.ParentNode;
                    parent.RemoveChild(item);
                }
            }


            doc.Save("../../catalogueDeleted.xml");
        }
    }
}
