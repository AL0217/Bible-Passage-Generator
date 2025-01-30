// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text;
using Microsoft.VisualBasic;

namespace HelloWorld{
    class Program{
            static void Main(String[] args){
                using (var wb = new HttpClient())
                {
                    string url = "https://api.biblegateway.com/2/";
                    var data = new NameValueCollection();
                    data["username"] = "AL0217";
                    data["password"] = "Andylau0217*";

                    wb.BaseAddress = new Uri(url);
                    wb.DefaultRequestHeaders.Accept.Clear();
                    

                    var response = wb.UploadValues(url, "POST", data);
                    string response_str = Encoding.UTF8.GetString(response);
                    Console.WriteLine(response_str);
                }
            }
    }
}