using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using HtmlAgilityPack;
using System.Net.Http.Headers;
using System.Net;
using System.IO;


namespace Program.cs
{
    internal class Program
    {
        
        public static async void Main(string[] args)
        {
            Console.WriteLine("we are ready to go!");
            Console.WriteLine("send the link to website u wanna scrape or the file");
            string link = Console.ReadLine();

            HttpClient client = new HttpClient(); 
            HttpRequestMessage request =  new HttpRequestMessage(HttpMethod.Get, link);
            var content =  request.Content; 
            
            if (content == null)  //Is crashing here
            {
                Console.WriteLine("Dang it! we could'nt find anything");

            }
           else
            {
                Console.WriteLine(content);
                Console.ReadLine();
                
            }

            Console.WriteLine("test 2");
            

            




            


        }

        
    }
}

