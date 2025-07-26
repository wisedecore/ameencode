using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Web;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace WindowsFormsApplication2
{
    class Clsarabicchange
    {
        public string answer = "";
        ResourceManager res_man;

        CultureInfo cul;
        public string changetoarabic(string input)
        {




            string from = "en";
            string to = "fr";
            var fromLanguage = from;
            var toLanguage = to;

            //http://translate.google.com/#en/fr/test%20this

            //var 
            // @"https://translate.googleapis.com/tran...{fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(input)}";


            // "https://translate.googleapis.com/translate_a/single?client=gtx&sl=" + from + "&tl=" + to + "&dt=t&q=";
            // "https://translate.googleapis.com/translate_a/single?client=gtx&sl=" + from + "&tl=" + to + "&dt=t&ie=UTF-8&oe=UTF-8&q=";
            var url = "https://translate.googleapis.com/translate_a/single?client=gtx&ie=UTF-8&oe=UTF-8&sl=" + from + "&tl=" + to + "&hl=ru&dt=t&dj=1&source=icon&tk=467103.467103&q=";
            url = @"https://translate.googleapis.com/tran...{en}&tl={fr}&dt=t&q={HttpUtility.UrlEncode("+input+")}";
            url = string.Format(@"http://translate.google.com/translate_a/t?client=j&text={0}&hl=en&sl={1}&tl={2}",
                               HttpUtility.UrlEncode(input), "en", "fr");



           
            //var webclient = new WebClient
            //  { 
                  WebClient web = new WebClient();

                  //web.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                  //web.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");
                 // Encoding = System.Text.Encoding.UTF8;
                  //web.Encoding = Encoding.UTF8;

              //};
                  Encoding encoding = System.Text.Encoding.UTF8;
                  web.Encoding = encoding;
                  var result = web.DownloadString(url);
                  //var result = web.DownloadString(url);



            result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);





            //// res_man = new ResourceManager("WindowsFormsApplication1.language.Resource", typeof(MDIForms).Assembly);


            // CultureInfo arabicCulture = new CultureInfo("ar");

            // // Use TextInfo to convert the word to the specified culture
            // TextInfo textInfo = arabicCulture.TextInfo;
            // return textInfo.ToTitleCase(english.ToLower());

            // //Console.WriteLine($"{englishWord} in Arabic is: {arabicWord}");




            return result;
        }




        public string TranslateWithGoogle(string resource, string languagePair)
        {
            try
            {
                string result = "";
               
                //WebBrowser wb = new WebBrowser();

                //string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);
                //WebClient webClient = new WebClient();
                //webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                //webClient.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");
                
                //webClient.Encoding = System.Text.Encoding.Default;
                //string result = webClient.DownloadString(url);
                //result = result.Substring(result.IndexOf("<span title=\"") + "<span title=\"".Length);
                //result = result.Substring(result.IndexOf(">") + 1);
                //result = result.Substring(0, result.IndexOf("</span>"));
                //return result.Trim();



                return result;

                //Uri uri = new Uri("http://www.babelfish.com");

                //HttpWebRequest requesty = (HttpWebRequest)WebRequest.Create(uri);
                ////request.Referer = BABELFISHREFERER;
                //string postsourcedata;
                //string translationmode = "en_ar";
                //postsourcedata = "lp=" + translationmode + "&tt=urltext&intl=1&doit=done&urltext=" + HttpUtility.UrlEncode("ok");
                //requesty.Method = "POST";
                //requesty.ContentType = "application/x-www-form-urlencoded";
                //requesty.ContentLength = postsourcedata.Length;
                //requesty.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";
                //Stream writeStream = requesty.GetRequestStream();
                //UTF8Encoding encoding = new UTF8Encoding();
                //byte[] bytes = encoding.GetBytes(postsourcedata);
                //writeStream.Write(bytes, 0, bytes.Length);
                //writeStream.Close();
                //HttpWebResponse response = (HttpWebResponse)requesty.GetResponse();
                //Stream responseStream = response.GetResponseStream();
                //StreamReader readStream = new StreamReader(responseStream, Encoding.UTF8);
                //string page = readStream.ReadToEnd();
                //Regex reg = new Regex(@"<div style=padding:10px; lang=..>(.*?)</div>");
                //MatchCollection matches = reg.Matches(page);
                //if (matches.Count != 1 || matches[0].Groups.Count != 2)
                //{
                //    return "erro";
                //}
                //return matches[0].Groups[1].Value;

               // string fromCulture = "en";
               // string toCulture = "fr";
               // string translationMode = string.Concat(fromCulture, "_", toCulture);

               // string url = String.Format("http://babelfish.yahoo.com/translate_txt?lp={0}&tt=urltext&intl=1&doit=done&urltext={1}", translationMode, HttpUtility.UrlEncode(resource));
               // WebClient webClient = new WebClient();
               // webClient.Encoding = System.Text.Encoding.Default;
               // webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)");
                
               // string page = webClient.DownloadString(url);

               // int start = page.IndexOf("<div style=\"padding:0.6em;\">") + "<div style=\"padding:0.6em;\">".Length;
               // int finish = page.IndexOf("</div>", start);
               // string retVal = page.Substring(start, finish - start);
               //return retVal;


                //string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);
                //HttpClient httpClient = new HttpClient();
                //string result = httpClient.GetStringAsync(url).Result;
                //result = result.Substring(result.IndexOf("<span title=\"") + "<span title=\"".Length);
                //result = result.Substring(result.IndexOf(">") + 1);
                //result = result.Substring(0, result.IndexOf("</span>"));
                //return result.Trim();




            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                return string.Empty;
            }

        }


















        public static string Translate(string input, string languagePair, Encoding encoding)
        {
            string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text=       {0}&langpair={1}", input, languagePair);
            url = "https://translate.googleapis.com/translate_a/single?client=gtx&sl=es&tl=en&dt=t&ie=UTF-8&oe=UTF-8&q=";


            string result = String.Empty;

            using (WebClient webClient = new WebClient())
            {
                webClient.Encoding = encoding;

                webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                webClient.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");
                result = webClient.DownloadString(url);
            }
            return result;
            //HtmlDocument doc = new HtmlDocument();
            //doc.LoadHtml(result);
            //return doc.DocumentNode.SelectSingleNode("//textarea[@name='utrans']").InnerText;
        }


        public void functionloadanotheroneexe()
        {
            try
            {
                Process myProcess = new Process();
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.StartInfo.FileName = @"D:\openanotherexe\OOOTOOL.exe";

                myProcess.Start();
            }
            catch
            {

            }
            
           
            
        }

        public string transword(string input, string languagePair)
        {
            string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);

            //url = "https://translate.googleapis.com/translate_a/single?client=gtx&sl=en&tl=fr&dt=t&ie=UTF-8&oe=UTF-8&q=";
            //url = "http://www.google.com/translate_t?hl=en&fr=UTF8&text={hello}&langpair={1}";
            
            WebClient webClient = new WebClient();
            webClient.Encoding = System.Text.Encoding.UTF8;
            webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/18.5.0.0");
            webClient.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");

            string result = webClient.DownloadString(url);

            //ExtendedGoogleTranslate urlTranslate = new ExtendedGoogleTranslate();
            //result = urlTranslate.TranslateText(input, "en|bg");


         //url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);
         //   HttpClient httpClient = new HttpClient();
         //   result = httpClient.GetStringAsync(url).Result;
         //   //result = result.Substring(result.IndexOf("<span title=\"") + "<span title=\"".Length);
            //result = result.Substring(result.IndexOf(">") + 1);
            //result = result.Substring(0, result.IndexOf("</span>"));
            //return result.Trim();




            //result = result.Substring(result.IndexOf("id=result_box") + 22, result.IndexOf("id=result_box") + 500);
            //result = result.Substring(0, result.IndexOf("</div"));
            return result;

        }
    }

   
}
