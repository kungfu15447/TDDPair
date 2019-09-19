using System;
using System.Collections.Generic;
using System.Text;

namespace FunBag
{
    public interface IBag
    {
        void Add(int Item);
        int Remove();
        int CountSize();
        List<int> getBag();
    }
}
