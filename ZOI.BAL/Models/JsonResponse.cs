using System;
using System.Collections.Generic;
using System.Text;

namespace ZOI.BAL.Models
{
    public class JsonResponse
    {
        public string Status { get; set; } = "S";

        public string Message { get; set; }

        public string Path { get; set; }

        public object List { get; set; }

        public string Object { get; set; }
        public string Token { get; set; }

        public int ID { get; set; }
    }
}
