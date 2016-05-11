using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApplication1
{
    public class RssItem
    {
            public DateTime Date;
            public string Title;
            public string Description;
            public string Link;

            public RssItem(XmlNode ItemTag)
            {
                foreach (XmlNode tag in ItemTag.ChildNodes)
                {
                    switch (tag.Name)
                    {
                        case "title":
                            {
                                this.Title = tag.InnerText;
                                break;
                            }
                        case "link":
                            {
                                this.Link = tag.InnerText;
                                break;
                            }
                        case "description":
                            {
                                this.Description = tag.InnerText;
                                break;
                            }
                        case "pubDate":
                            {
                                DateTime.TryParse(tag.InnerText, out this.Date);
                                break;
                            }

                    }
                }
            }

    }
}
