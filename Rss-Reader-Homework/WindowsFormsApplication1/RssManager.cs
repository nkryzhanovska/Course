using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public class RssManager : IDisposable
    {
        private string myurl;
        private string feedTitle;
        private string feedDescription;
        private Collection<Rss.Items> rssItems = new Collection<Rss.Items>();
        private bool isDisposed;

        public RssManager()
        {
            myurl = string.Empty;
        }

        public RssManager(string feedUrl)
        {
            myurl = feedUrl;
        }

        public string RssUrl
        {
            get { return myurl; }
            set { myurl = value; }
        }

        public Collection<Rss.Items> RssItems
        {
            get { return rssItems; }
        }

        public string FeedTitle
        {
            get { return feedTitle; }
        }

        public string FeedDescription
        {
            get { return feedDescription; }
        }

        public Collection<Rss.Items> GetFeed()
        {
            if (String.IsNullOrEmpty(RssUrl))
            {
                
                throw new ArgumentException("You must provide a feed URL");
            }
            using (XmlReader reader = XmlReader.Create(RssUrl))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(reader);
                ParseDocElements(xmlDoc.SelectSingleNode("//channel"), "title", ref feedTitle);
                ParseDocElements(xmlDoc.SelectSingleNode("//channel"), "description", ref feedDescription);
                ParseRssItems(xmlDoc);
                return rssItems;
            }
        }

        private void ParseRssItems(XmlDocument xmlDoc)
        {
            rssItems.Clear();
            XmlNodeList nodes = xmlDoc.SelectNodes("rss/channel/item");
            foreach (XmlNode node in nodes)
            {
                Rss.Items item = new Rss.Items();
                ParseDocElements(node, "title", ref item.Title);
                ParseDocElements(node, "description", ref item.Description);
                ParseDocElements(node, "link", ref item.Link);
                
                string date = null;
                ParseDocElements(node, "createDate", ref date);
                DateTime.TryParse(date, out item.Date);
                
                rssItems.Add(item);
            }
        }

        private void ParseDocElements(XmlNode parent, string xPath, ref string property)
        {
            XmlNode node = parent.SelectSingleNode(xPath);
            if (node != null)
            {
                property = node.InnerText;
            }
            else
                property = "Unresolvable";
        }

        private void Dispose(bool disposing)
        {
            if (disposing && !isDisposed)
            {
                rssItems.Clear();
                myurl = null;
                feedTitle = null;
                feedDescription = null;
            }
            
            isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }




    }
}
