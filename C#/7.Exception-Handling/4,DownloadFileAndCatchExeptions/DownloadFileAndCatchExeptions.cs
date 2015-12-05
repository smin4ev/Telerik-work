using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

class DownloadFileAndCatchExeptions
{
    //Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
    //and stores it the current directory. Find in Google how to download files in C#. Be sure to catch 
    //all exceptions and to free any used resources in the finally block

    static void Main()
    {
        using (WebClient client = new WebClient())
        {
            try
            {
                client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "d:/Telerik kursove/Test/proba.jpg");
                Console.WriteLine("Download successful!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address parameter is null");
            }
            catch (WebException)
            {
                Console.WriteLine("Address is invalid or file name is empty or file does not exist!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads");
            }
            finally
            {
                client.Dispose();
            }

    
        }
        
    }
}

