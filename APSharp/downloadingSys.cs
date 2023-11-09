using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;

namespace APSharp
{
    class downloadingSys
    {
        WebClient client = new WebClient();

        public void downloadHtml()
        {
            client.Encoding = Encoding.UTF8;

            string title;
            string url;

            Console.Write("File Name: ");
            title = Console.ReadLine();

            Console.Write("URL (no https needed): ");
            url = Console.ReadLine();

            client.DownloadFile("https://" + url , "html/" + title +".html");
        }

    }
}
