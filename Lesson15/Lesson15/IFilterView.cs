using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    public delegate void FilterItemAddedEventHandler(IFilterView sender, string newItem);
    public delegate void ConfigFileSelectedEventHandler(IFilterView sender, string pathToFile);

    public interface IFilterView
    {
        event FilterItemAddedEventHandler ItemAdded;
        event ConfigFileSelectedEventHandler ConfigFileSelected;

        string FilterName { set; get; }
        string FilePath { set; get; }

        void LoadFilterItems(List<string> filterItems);

    }
}
