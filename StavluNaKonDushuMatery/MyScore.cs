using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leaf.xNet;
using AngleSharp.Html;

namespace StavluNaKonDushuMatery
{
    class MyScore
    {
        public static string GetPage(string Link)
        {
            HttpRequest request = new HttpRequest();

            string response = request.Get(Link).ToString();
            return response;
        }

    }


}
