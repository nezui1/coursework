namespace courseWorkList;

public partial class MainForm : Form
{

    private ManagerClass? manager;

    private DrawningState drawningState;

    private Solver solver;

    private Node current;


    public MainForm()
    {
        InitializeComponent();

        drawningState = new DrawningState(pictureBoxDrawningObj);


    }

    private void ShowFormParametrs()
    {
        FormParametrs formParametrs = new();
        formParametrs.ParametersSubmitted += FormParametrs_ParametersSubmitted;
        formParametrs.ShowDialog();
    }

    private void FormParametrs_ParametersSubmitted(object? sender, EventArgs e)
    {
        var formParametrs = sender as FormParametrs;
        if (formParametrs != null && formParametrs.Parameters != null)
        {
            manager = new ManagerClass(formParametrs.Parameters);
            StateClass? state = manager.Storage.Reset();
        }
        else
        {
            throw new Exception("Не удалось получить параметры из формы");
        }

    }

    private void buttonCreate_Click(object sender, EventArgs e)
    {
        ShowFormParametrs();
        drawningState.Clear();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        if (manager != null)
            manager.MakeStep((int)numericUpDownElemList.Value);
        else
            throw new Exception("Списка не существует");

        StateClass state = manager.Storage.GetCurrentState();



        if (state == null)
        {
            throw new Exception("Ошибка при получении следующего состояния");
        }

        drawningState.Visualize(state);

    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {
        if (manager == null)
        {
            throw new Exception("Списка не существует");
        }
        else
        {
            
            int s = manager.solver.Search((int)numericUpDownSearchElem.Value);
            int t = 0;

            if (s == -1)
            {
                while (t < manager.solver.list.size)
                {
                    StateClass state = new StateClass(manager.solver.list, t);
                    state.Searched = s;
                    manager.Storage.AddState(state);
                    t++;
                }
                manager.Storage.AddState(new StateClass(manager.solver.list, -1));
            }
            else
            {
                while (t <= s)
                {
                    StateClass state = new StateClass(manager.solver.list, t);
                    state.Searched = s;
                    manager.Storage.AddState(state);
                    t++;
                }
                manager.Storage.AddState(new StateClass(manager.solver.list, null));
            }
            
        }
    }

    private void buttonStep_Click(object sender, EventArgs e)
    {
        if (manager == null)
            throw new Exception("Списка не существует");
        else
            drawningState.Visualize(manager.Storage.GetNextState());
    }

    private void buttonStepDown_Click(object sender, EventArgs e)
    {

        if (manager == null)
            throw new Exception("Списка не существует");
        else
            drawningState.Visualize(manager.Storage.GetPreviousState());
    }

    private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                ParametersClass parameters = new ParametersClass([]);
                manager = new ManagerClass(parameters);
                manager.Storage.LoadFromFile(openFileDialog.FileName);
                drawningState.Visualize(manager.Storage.Reset());
                MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void SaveToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
        if (manager == null)
        {
            MessageBox.Show("Данные для сохранения отсутствуют", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                manager.Storage.SaveToFile(saveFileDialog.FileName);
                MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FormInfo info = new FormInfo();
        info.Show();
    }
}
