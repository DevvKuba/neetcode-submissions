public class Node
{
    public int Key { get; set; }
    public int Val { get; set; }
    public Node prev { get; set; }
    public Node next { get; set; }

    public Node(int key, int val)
    {
        Key = key;
        Val = val;
        prev = null;
        next = null;
    }
}

public class LRUCache
{
    public int Capacity { get; set; }
    // mpa key to nodes
    public Dictionary<int, Node> Cache { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public LRUCache(int capacity)
    {

        Cache = new Dictionary<int, Node>();
        Capacity = capacity;
        Left = new Node(0, 0);
        Right = new Node(0, 0);
        Left.next = Right;
        Right.prev = Left;

    }

    // remove from list
    public void Remove(Node node)
    {
        var Prev = node.prev;
        var Next = node.next;

        Prev.next = Next;
        Next.prev = Prev;
    }

    // insert at right
    public void Insert(Node node)
{
    var Prev = Right.prev;

    Prev.next = node;
    node.prev = Prev;

    node.next = Right;
    Right.prev = node;
}

    public int Get(int key)
    {
        if (Cache.ContainsKey(key))
        {
            Node node = Cache[key];
            Remove(node);
            Insert(node);
            return node.Val;
        }
        else
        {
            return -1;
        }
    }

    public void Put(int key, int value)
    {
        if (Cache.ContainsKey(key))
        {
            Remove(Cache[key]);
        }
        Node newNode = new Node(key, value);
        Cache[key] = newNode;
        Insert(newNode);

        if (Cache.Count > Capacity)
        {
            // remove and delete the LRU
            var lru = Left.next;
            Remove(lru);
            Cache.Remove(lru.Key);

        }
    }
}