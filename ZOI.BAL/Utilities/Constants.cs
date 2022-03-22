using System;
using System.Collections.Generic;
using System.Text;

namespace ZOI.BAL.Utilities
{
    public class Constants
    {
        public class Template {

            //public static string GetActiveUser = "https://pmap.zoifintech.com/ZoiHome/api/ProductivityMailerDetails/GetActiveUser";

            //public static string GetProductivityMonitorMailer = "https://pmap.zoifintech.com/ZoiHome/api/ProductivityMailerDetails/GetProductivityMonitorMailer";

            //public static string GetActiveUserSessionUserID = "68491037-6af7-4380-a531-884ce12a5d2d";

            //public static string GetProductivitySessionUserID = "68491037-6af7-4380-a531-884ce12a5d2d";

            public static string Path = @"wwwroot\Template\Template.cshtml";

            public static string Nodatapath = @"wwwroot\Template\Nodata.html";
        }

        public class Procedure
        {
            public const string AddUpdateSupportUser = "trakzoSupport.Usp_AddUpdateSupportUser";
            public const string CheckifSupportEmailIdExists = "trakzoSupport.usp_CheckifSupportEmailIdExists";
            public const string SupportLogin = "trakzoSupport.usp_SupportLogin";
            public const string GetMailerSend = "agentreport.usp_MailerSend";
            public const string GetActiveUserList = "agentreport.usp_GetActiveUserDeatils";
            public const string ErrorLogs = "agentreport.usp_ErrorLogs";

            // Added on 18-08-2021
            public const string EntLastAccessTimeAW = "TrakZoSupport.EntLastAccessTimeAW";
        }

        public class MailSubject
        {
            public const string EntLastAccessTimeAW = "Enterprise Last Access Time Active Window";
        }

        public class EmailTemplates
        {
            public const string EntLastAccessTimeViewName = "EmailTemplates/EntLastAccessTimeEmailTemplate.cshtml";
            public const string EntLastAccessTimeAbsolutePath = "~/Views/EmailTemplates/EntLastAccessTimeEmailTemplate.cshtml";
        }
    }
}
