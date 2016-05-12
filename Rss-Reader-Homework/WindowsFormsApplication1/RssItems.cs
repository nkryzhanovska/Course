using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReaderHomework
{
    public class RssItems : List<RssItem>
    {
        new public bool Contains(RssItem item)
        {
            foreach (RssItem checkItem in this)
            {
                if (item.Title == checkItem.Title)
                {
                    return true;
                }                              
            }
            return false;
        }

        public RssItem GetItem(string title)
        {
            
            foreach (RssItem checkItem in this)
            {
                if (checkItem.Title == title)
                {
                    return checkItem;
                }
            }
            return null;
        }

    }
}
