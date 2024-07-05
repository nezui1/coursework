using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWorkList;
[Serializable]
public class StateClass
{
    public DoubleLinkedList List;

    public int? Highlighted;

    public int? Searched;
    public StateClass(DoubleLinkedList list, int? highlighted)
    {
        List = list;
        Highlighted = highlighted;

    }

}
