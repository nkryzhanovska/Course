using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Controller
{
    public class FilterViewControl:IFilterViewControl
    {

        public void AttachView(IFilterView view)
        {
            view.ConfigFileSelected += view_ConfigFileSelected;
            view.ItemAdded += view_ItemAdded;
            view.ItemRemoved +=view_ItemRemoved;
        }

        private void view_ItemRemoved(IFilterView sender, string item)
        {
            List<string> currentItems = sender.FilterItems;
            currentItems.Remove(item);
            using (StreamWriter writer = new StreamWriter(sender.FilePath))
            {

                foreach (var a in currentItems)
                {
                    writer.WriteLine(a);
                }


            }
            sender.FilterItems = currentItems;
        }

        private void view_ItemAdded(IFilterView sender, string newItem)
        {
            List<string> currentItems = sender.FilterItems;
            currentItems.Add(newItem);
            using (StreamWriter writer = new StreamWriter(sender.FilePath))
            {
                
                foreach (var item in currentItems)
                {
                    writer.WriteLine(item);
                }
                

            }
            sender.FilterItems = currentItems;
        }

        private void view_ConfigFileSelected(IFilterView sender, string pathToFile)
        {
            List<string> filterItems = new List<string>();
            using (StreamReader reader = new StreamReader(pathToFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    filterItems.Add(line);
                }
            }
            sender.FilterItems = filterItems;

        }
    }
}
