using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public interface IFilter
    {
        void ApplyFilter(string InputFile, string FilterFile,  string OutputFile, int type);
        void ApplyFilter1(string InputFile, string FilterFile, string FilterFile1, string OutputFile, int type);
        void FilterBlack(List<string> InputList, List<string> outFilter);
        void FilterkWhite(List<string> InputList, List<string> outFilter);
        void FilterBlackWhite(List<string> InputList, List<string> outFilter, List<string> outFilter1);

    }
}
