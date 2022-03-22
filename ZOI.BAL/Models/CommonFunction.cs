using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text;

namespace ZOI.BAL.Models
{
   public class CommonFunction
    {
        public class Response
        {
            public decimal ID { get; set; }

            public object Data { get; set; }

            public string Data1 { get; set; }

            public string Status { get; set; }

            public string Message { get; set; }

            public string Resp { get; set; }

            public int LeaveStatus { get; set; }
        }

        public static string GetBaseURL(string key)
        {
            string getUrl = GetSectionValues(key);
            return getUrl;
        }

        public static string GetSectionValues(string sectionKey)
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            var root = configurationBuilder.Build();
            return root.GetValue<string>(sectionKey);
        }
    }
}
