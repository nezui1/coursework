namespace courseWorkList;
[Serializable]
public class ManagerClass
{
    public Solver solver;

    public StateStorageClass Storage;

    public ManagerClass(ParametersClass parametersClass)
    {
        this.solver = new Solver(parametersClass);

        this.Storage = new StateStorageClass();
    }

    public void MakeStep(int data)
    {
        solver.Add(data);
        DoubleLinkedList list = new(solver.GetState().List);
        Storage.AddState(new StateClass(list, null));
        Storage.currentIndex++;
    }
}
