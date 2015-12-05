using System;
using System.Collections.Generic;


  class DecimalToHexadecimal
    {
      //Write a program to convert decimal numbers to their hexadecimal representation

      static string ConvertDecimalToHexidecimal(int decimalNumber)
      {
          string hexadecimal = "";
          for (int i = decimalNumber; i > 0; i=i/16)
          {
              string reminder = (decimalNumber % 16).ToString(); ;
              decimalNumber = decimalNumber / 16;
              switch (reminder)
              {
                  case "10":
                      reminder = "A";
                      break;
                  case "11":
                      reminder = "B";
                      break;
                  case "12":
                      reminder = "C";
                      break;
                  case "13":
                      reminder = "D";
                      break;
                  case "14":
                      reminder = "E";
                      break;
                  case "15":
                      reminder = "F";
                      break;
                      
              }
              hexadecimal = reminder + hexadecimal;
          }
          return hexadecimal;
      }

        static void Main()
        {
            Console.WriteLine("Enter decimal number:");
            int decimalNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertDecimalToHexidecimal(decimalNumber));

        }
    }

