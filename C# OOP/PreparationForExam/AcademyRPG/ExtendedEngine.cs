﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class ExtendedEngine:Engine
    {
        public override void ExecuteCreateObjectCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "knight":
                        {
                            string name = commandWords[2];
                            Point location = Point.Parse(commandWords[3]);
                            int owner = int.Parse(commandWords[4]);
                            this.AddObject(new Knight(name, location, owner));
                            break;
                        }
                case "house":
                        {
                            Point location = Point.Parse(commandWords[2]);
                            int owner = int.Parse(commandWords[3]);
                            this.AddObject(new House(location, owner));
                            break;
                        }
                case "giant":
                        {
                            string name = commandWords[2];
                            Point location = Point.Parse(commandWords[3]);
                            this.AddObject(new Giant(name,location));
                            break; 
                        }
                case "rock":
                        {
                            int hitPoints = int.Parse(commandWords[2]);
                            Point location = Point.Parse(commandWords[3]);
                            this.AddObject(new Rock(hitPoints, location));
                            break;
                        }
                case "ninja":
                        {
                            string name = commandWords[2];
                            Point location = Point.Parse(commandWords[3]);
                            int owner = int.Parse(commandWords[4]);
                            this.AddObject(new Ninja(name, location, owner));
                            break;
                        }
                default:
                base.ExecuteCreateObjectCommand(commandWords);
                break;
                

            }
        }

    }
}
