namespace courseWorkList;

[Serializable]
public class DoubleLinkedList
{

    public int size;

    public Node head;

    public int capacity;

    public DoubleLinkedList(ParametersClass parametersClass)
    {

        size = 0;

        capacity = parametersClass.Numbers.Length;

        Node currentNode = head;

        for (int i = 0; i < parametersClass.Numbers.Length; i++)
        {
            currentNode = new Node(parametersClass.Numbers[i]);
            currentNode = currentNode.Next;
        }
    }

    public DoubleLinkedList(DoubleLinkedList copyingList) 
    {
        this.capacity = copyingList.capacity;
        this.head = copyingList.head;
        this.size = copyingList.size;
    }
}

[Serializable]
public class Solver
{
    public DoubleLinkedList list;

    private Node head;
    public Solver(ParametersClass parametersClass)
    {
        this.list = new DoubleLinkedList(parametersClass);
    }

    public void Add(int value)
    {
        if (list.capacity == list.size)
        {
            MessageBox.Show("Список заполнен!");
            return;

        }
        var newNode = new Node(value);
        if (list.head == null)
        {
            list.head = newNode;
        }
        else
        {
            newNode.Next = list.head;
            list.head.Previous = newNode;
            list.head = newNode;
        }
        list.size++;
    }

    public int Search(int value)
    {
        var current = list.head;
        int n = 0;

        while (current != null)
        {
            if (current.Value == value)
            {
                return n;
            }
            current = current.Next;
            n++;
        }
        return -1;
    }

    public bool isEmpty()
    {
        return list.size == 0;
    }

    public void Clear()
    {
        list.head = null;
        list.size = 0;
    }

    public StateClass GetState()
    {
        return new StateClass(list, null);
    }
}

[Serializable]
public class Node
{
    public int Value { get; }
    public Node Next { get; set; }
    public Node Previous { get; set; }

    public Node(int value)
    {
        Value = value;
        Next = null;
        Previous = null;
    }
}
