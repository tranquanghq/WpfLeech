using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;

namespace WpfLeech
{
    class Html
    {
        private HtmlDocument _doc;
        private HtmlNode _node;

        public string code(string Url,WebProxy proxy)
        {
            this._doc = this.Doc(Url, proxy);
            return this.node("//div[@class='posttext']");
        }

        private HtmlDocument Doc(string Url)
        {
            HtmlWeb hw = new HtmlWeb();
            HtmlDocument doc = hw.Load(Url);
            return doc;
        }

        private HtmlDocument Doc(string Url, WebProxy proxy)
        {
            HtmlWeb hw = new HtmlWeb();
            HtmlDocument doc = hw.Load(Url, "GET", proxy, null);
            return doc;
        }

        private string node(string Node)
        {
            HtmlNode wap = this._doc.DocumentNode.SelectSingleNode(Node);
            return wap.InnerText;
        }
    }
}
