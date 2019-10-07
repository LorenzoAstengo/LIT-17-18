using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Exercise07
{
    public class DownloadFile
    {
        public static void Download(string url)
        {
            Uri uri = new Uri(url);
            string filename = System.IO.Path.GetFileName(uri.LocalPath);
            try
            {
                WebClient myWebClient = new WebClient();
                myWebClient.DownloadFile(url, filename);                
            }
            catch(ArgumentNullException ane)
            {
                throw new ArgumentNullException("No url", ane);
            }
            catch (WebException we)
            {
                throw new WebException("Download failed", we);
            }
        }
    }
}
