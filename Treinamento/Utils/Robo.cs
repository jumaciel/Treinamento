using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento.Controller
{
    class Robo
    {
      public static string link;
        public static HtmlDocument htmldoc;

        public static HtmlNode GetHtmlNode()
        {
            HtmlNode htmlNode = htmldoc.DocumentNode;

            return htmlNode;
        }

        public static void SetHtmlNode(string url)
        {
            var web = new HtmlWeb();
            htmldoc = web.Load(url);
        }
    }
}
