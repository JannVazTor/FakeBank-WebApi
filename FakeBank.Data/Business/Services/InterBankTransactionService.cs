using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FakeBank.Data.Entities;
using FakeBank.Data.POCO;
using Newtonsoft.Json;

namespace FakeBank.Data.Business.Services
{
    public class InterBankTransactionService
    {
        public string InterBankTransaction(InterBankTransaction transaction)
        {
            var data = "CardNumber=" + transaction.CardNumber + 
                                "&ExpirationDate=" + transaction.ExpirationDate + 
                                "&SecurityCode=" + transaction.SecurityCode + 
                                "&Token=" + transaction.Token + 
                                "&Amount=" + transaction.Amount;
            var request = WebRequest.CreateHttp("http://bancomex.voyachi.me/api/t_interbancarias");
            request.Timeout = 100 * 1000;
            request.Method = WebRequestMethods.Http.Post;
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            var requestWriter = new StreamWriter(request.GetRequestStream());
            try
            {
                requestWriter.Write(data);
            }
            finally
            {
                requestWriter.Close();
            }
            var response = (HttpWebResponse)request.GetResponse();
            var reader = new StreamReader(response.GetResponseStream());
            var json = reader.ReadToEnd();
            return json.Length > 0 && !json.Equals("")? json.Replace("\"",""):"";
        }
    }
}
