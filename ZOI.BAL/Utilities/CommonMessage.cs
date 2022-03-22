using System;
using System.Collections.Generic;
using System.Text;

namespace ZOI.BAL.Utilities
{
    public class CommonFunctionMessage
    {
        public static class ResponseStatus
        {
            public const string Success = "S";
            public const string Failed = "F";
        }
        public static class APIRequestStatus
        {
            public const string Failed = "F";
            public const string Success = "S";
        }
        public static class ResponseMessage
        {
            public const string Failed = "Failed";
            public const string Success = "Success";
            public const string RequiredFields = "Kindly provide required fields";
            public const string UnabletoProcessRequest = "Unable to process your request.";
            public const string NoDatailAvailable = "No Details available";
        }

        public static class APIRequestMessage
        {
           
            public const string Failed = "Failed";
            public const string Success = "Success";
            public const string UserIdProvide = "Kindly Provide User Id";
            public const string UserDetailsNotAvailable = "User Details Not Available";
            public const string NetworkError = "Network Error";
            public const string UnabletoProcessRequest = "Unable to process your request.";
        }
    }
}
