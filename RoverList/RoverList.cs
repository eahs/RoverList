using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RoverList;

public class RoverList<T> : RoverListBase<T>
{
    public RoverList()
    {
        Count = 0;
    }

    public override int Count { get; }

    public override void Add(T data)
    {
        throw new NotImplementedException();
    }

    public override void Add(int position, T data)
    {
        throw new NotImplementedException();
    }

    public override void Clear()
    {
        throw new NotImplementedException();
    }

    public override T ElementAt(int position)
    {
        throw new NotImplementedException();
    }

    private Node NodeAt(int position)
    {
        // FIXME: Returning a forced null value
        return null!;
    }

    public override void ListNodes()
    {
    }

    public override bool RemoveAt(int position)
    {
        return false;
    }
}
