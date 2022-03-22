using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ZOI.BAL.Services.Interface
{
    public interface IErrorLogService
    {
        DataSet GetErrorLog(string controller, string action, string errorTrace, string errorMessage, string userID);

        void ErrorLogFile(string objectName, string sourceName, string errorTrace, string errorMessage, string errorDate, string userID);

      }
}
