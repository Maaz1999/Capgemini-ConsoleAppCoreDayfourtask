using ConsoleAppCoreDayfourtask1.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumeWebAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<Registration> rList = new List<Registration>();
            var httpclient = new HttpClient();
            var response = await httpclient.GetAsync("https://localhost:44374/api/Registration");
            string result = await response.Content.ReadAsStringAsync();
            rList = JsonConvert.DeserializeObject<List<Registration>>(result);

            foreach (var i in rList)
            {
                Console.WriteLine("Registration ID: " + i.RId + ", Name: " + i.FirstName + ", Mail ID: " + i.MailId + ", Contact Number: " + i.ContactNo + ", Experience: " + i.Experience + ", Skills: " + i.Skills);
            }
        }
    }
}