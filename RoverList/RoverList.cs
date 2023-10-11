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

    /// <summary>
    /// Returns the node at a given position
    /// NOTE: This method isn't in the base class but can be VERY helpful to create.
    /// </summary>
    /// <param name="position"></param>
    /// <returns></returns>
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
