using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;



class EnterFileNameAndPrintExeptions
{
    //Write a program that enters file name along with its full file path 
    //(e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
    //Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all 
    //possible exceptions and print user-friendly error messages.


    static void ReadFile(string path)
    {
        string readText =File.ReadAllText(path);
        Console.WriteLine(readText);
    }
    static void Main()
    {
        try
        {
            string path = @"d:\Telerik kursove\regex.txt";
            ReadFile(path);
        }

        catch (ArgumentNullException)
        {
            Console.WriteLine("Path is null");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid ");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Path specified a file that is read-only or this operation is not supported on the current platform");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters ");
        }
            
    }
}

