
using Microsoft.AspNetCore.Hosting;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using ZOI.BAL.Services.Interface;
using ZOI.BAL.Utilities;
using ZOI.DAL.DatabaseUtility.Interface;

namespace ZOI.BAL.Services
{
    public class ErrorLogService : IErrorLogService
    {
        #region Error logs

        private readonly IADODataFuntion _adoDataFunction;
        private readonly IHostingEnvironment _hostingEnvironment;
        public ErrorLogService(IADODataFuntion adoDataFunction, IHostingEnvironment hostingEnvironment)
        {
            _adoDataFunction = adoDataFunction;
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Method for maintaining error log
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="action"></param>
        /// <param name="errorTrace"></param>
        /// <param name="errorMessage"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public DataSet GetErrorLog(string controller, string action, string errorTrace, string errorMessage, string userID)
        {
            DataSet dataSet = new DataSet();
            try
            {
                SqlParameter[] objParam =
                {
                   new SqlParameter("@ControllerName", SqlDbType.VarChar) { Value = controller},
                   new SqlParameter("@ActionName", SqlDbType.VarChar) { Value = action},
                   new SqlParameter("@ErrorTrace", SqlDbType.VarChar) { Value = errorTrace},
                   new SqlParameter("@ErrorMessage", SqlDbType.VarChar) { Value = errorMessage},
                   new SqlParameter("@UserID", SqlDbType.VarChar) { Value = userID},
                   new SqlParameter("@SessionID", SqlDbType.VarChar) { Value = userID}
                };
                dataSet = _adoDataFunction.ExecuteDataset(Constants.Procedure.ErrorLogs, objParam);
            }
            catch (Exception ex)
            {
                if (errorMessage.StartsWith(CommonFunctionMessage.APIRequestMessage.NetworkError))
                {
                    ErrorLogFile(this.GetType().Name.ToString(), MethodBase.GetCurrentMethod().Name.ToString(), ex.StackTrace, ex.Message, DateTime.Now.ToString(), userID);
                }
                throw ex;
            }
            return dataSet;
        }

        /// <summary>
        /// Method for error log text file generation if database network related error occurs
        /// </summary>
        /// <param name="controllerName"></param>
        /// <param name="actionName"></param>
        /// <param name="errorTrace"></param>
        /// <param name="errorMessage"></param>
        /// <param name="errorDate"></param>
        /// <param name="userID"></param>
        public void ErrorLogFile(string controllerName, string actionName, string errorTrace, string errorMessage, string errorDate, string userID)
        {
            string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "ErrorLog\\");
            string file = "ErrorLog.txt";
            //string file = "ErrorLog_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Date + ".txt";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            string[] createText = { "Error Date:" + errorDate, "Object Name: " + controllerName, "Action: " + actionName, "Error Trace: " + errorTrace, "Error Message: " + errorMessage, "User ID: " + userID };
            File.AppendAllLines(Path.Combine(filePath, file), createText, Encoding.UTF8);
        }
        #endregion

       
    }
}