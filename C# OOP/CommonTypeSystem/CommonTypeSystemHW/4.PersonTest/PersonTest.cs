using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PersonTest
{
    //Create a class Person with two fields – name and age. Age can be left unspecified 
    //(may contain null value. Override ToString() to display the information of a person 
    //and if age is not specified – to say so. Write a program to test this functionality

    class PersonTest
    {
        static void Main(string[] args)
        {
            Person georgi = new Person("Georgi", 5);
            Person ivan = new Person("Ivan");
            Console.WriteLine(ivan);


        }
    }
}
