using System.Runtime.Serialization.Formatters.Binary;

namespace courseWorkList;
[Serializable]
public class StateStorageClass
{
    private List<StateClass> states;

    public int currentIndex;

    public int CountOfStates => states.Count;

    public StateStorageClass()
    {
        states = new();
        states.Add(new StateClass(new DoubleLinkedList(new ParametersClass([])), null));
        currentIndex = 0;
    }

    public void AddState(StateClass state)
    {
        states.Add(state);
    }

    public StateClass GetCurrentState()
    {
        return states[currentIndex];
    }

    public StateClass GetNextState()
    {
        if (currentIndex < CountOfStates - 1)
            return states[++currentIndex];

        return states[currentIndex];
    }

    public StateClass GetPreviousState()
    {
        if (currentIndex > 0)
            return states[--currentIndex];

        return states[currentIndex];
    }

    public StateClass? Reset()
    {
        currentIndex = 0;
        return states[currentIndex];
    }

    public void SaveToFile(string filePath)
    {
        using (FileStream fs = new(filePath, FileMode.Create))
        {
#pragma warning disable SYSLIB0011
            BinaryFormatter formatter = new();
            formatter.Serialize(fs, this);
#pragma warning restore SYSLIB0011
        }
    }

    public void LoadFromFile(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
#pragma warning disable SYSLIB0011
            BinaryFormatter formatter = new();
            states = ((StateStorageClass)formatter.Deserialize(fs)).states;
#pragma warning restore SYSLIB0011
        }
    }
}
