using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Controller
{
    public interface IFilterViewControl
    {
        void AttachView(IFilterView view);
    }
}
