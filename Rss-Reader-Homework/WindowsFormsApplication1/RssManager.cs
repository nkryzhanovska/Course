using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RssReaderHomework
{
    public class RssManager
    {
        public DateTime Date;
        public string Title;
        public string Description;
        public string Link;
        public RssItems Items;

        public string Url;

        public RssManager(string url)
        {
            Items = new RssItems();
            XmlTextReader xmlReader = new XmlTextReader(url);

            XmlDocument xmlDoc = new XmlDocument();
            Url = url;
            try
            {
                xmlDoc.Load(xmlReader);
                xmlReader.Close();
                XmlNode channelNode = xmlDoc.GetElementsByTagName("channel")[0];
                if (channelNode != null)
                {
                    foreach (XmlNode node in channelNode.ChildNodes)
                    {
                        switch (node.Name)
                        {
                            case "title":
                                {
                                    Title = node.InnerText;
                                    break;
                                }
                            case "link":
                                {
                                    Link = node.InnerText;
                                    break;
                                }
                            case "description":
                                {
                                    Description = node.InnerText;
                                    break;
                                }
                            case "pubDate":
                                {
                                    DateTime.TryParse(node.InnerText, out Date);
                                    break;
                                }
                            case "item":
                                {
                                    RssItem channelItem = new RssItem(node);
                                    Items.Add(channelItem);
                                    break;
                                }
                        }
                    }
                }
                else
                {
                    throw new Exception("The error in XML. The channel description is not found");
                }
            }

            catch (System.Net.WebException ex)
            {
                MessageBox.Show("The Feed URL is not valid. Try to enter valid feed URL");                                 
            } 


            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("Feed URL not found. Try to enter valid feed URL");                
            }

            catch (XmlException ex)
            {
                MessageBox.Show("XML file is broken. Try another feed URL");                
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                xmlReader.Close();
            }
        }

        public RssManager()
        {
            Url = string.Empty;
        }
       
    }
}
