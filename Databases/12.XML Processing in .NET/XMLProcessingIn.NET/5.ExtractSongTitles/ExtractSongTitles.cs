﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _5.ExtractSongTitles
{
    //5.Write a program, which using XmlReader extracts all song titles from catalogue.xml.


    class ExtractSongTitles
    {
        static void Main(string[] args)
        {
            using (XmlReader reader = XmlReader.Create("../../catalogue.xml"))
            {
                while (reader.Read()) 
                {
                    if ((reader.NodeType == XmlNodeType.Element) & (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
