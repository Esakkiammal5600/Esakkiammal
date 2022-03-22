using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace ZOI.Domain.Utilities
{
    public class MailerService
    {
        public MailerResult SendMailUsingSMTP(string fromMailId, string toMailID, string mailBodyHtml, string mailSubject, string smtpServer, int smtpPort, string smtpUserName, string smtpPassword, string attachment, string senderName = null)
        {
            try
            {
                MailerResult returnData = new MailerResult();
                using (SmtpClient SmtpServer = new SmtpClient(smtpServer))
                {
                    using (MailMessage mail = new MailMessage())
                    {
                        if (string.IsNullOrEmpty(senderName))
                        {
                            mail.From = new MailAddress(fromMailId, "");
                        }
                        else
                        {
                            mail.From = new MailAddress(fromMailId, senderName);
                        }
                        mail.To.Add(toMailID);
                        mail.Subject = mailSubject;
                        mail.Body = mailBodyHtml;
                        mail.IsBodyHtml = true;

                        if (!string.IsNullOrEmpty(attachment))
                        {
                            byte[] pdfbyte = System.IO.File.ReadAllBytes(attachment);
                            Attachment att = new Attachment(attachment);
                            mail.Attachments.Add(att);
                        }
                        SmtpServer.Port = smtpPort;
                        //mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
                        SmtpServer.Credentials = new System.Net.NetworkCredential(smtpUserName, smtpPassword);
                        //Port 25: 25 is typically used a clear text SMTP port. Usually when you have SMTP running on port 25, there is no SSL and no TLS. So set your email client accordingly.
                        //Port 465: 465 is usually used for SMTP over SSL, so you will need to have settings that reflect that. However it does not use TLS.
                        //Port 587: 587 is usually used for SMTP when using TLS. TLS is not the same as SSL. Typically anything where you need to set SSL to be on or off should be set to off. 
                        //          This includes any setting that goes along the lines of “SSLOnConnect”. It doesn’t mean TLS is less secure, it’s just a different way of creating the connection. 
                        //          Instead of SSL being used straight away, the secure connection is “negotiated” after connection.
                        SmtpServer.EnableSsl = smtpPort == 465 ? true : false;
                        try
                        {
                            SmtpServer.Send(mail);
                            returnData = new MailerResult(0, "Email Send Successfully");
                        }
                        catch (SmtpException ex)
                        {
                            returnData = new MailerResult(-1, ex.Message);
                        }
                    }
                }
                return returnData;
            }
            catch (Exception ex)
            {
                MailerResult returnData = new MailerResult(-1, ex.Message);
                return returnData;
            }
        }
        public class MailerResult
        {
            public MailerResult()
            {
            }



            public MailerResult(int StatusCode, string StatusMessage)
            {
                this.statusCode = StatusCode;
                this.Message = StatusMessage;
            }
            public int statusCode { get; set; }
            public string Message { get; set; }
        }
    }
}
