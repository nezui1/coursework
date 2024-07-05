using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseWorkList;

public partial class FormParametrs : Form
{
    public ParametersClass? Parameters { get; private set; }

    public event EventHandler? ParametersSubmitted;

    public FormParametrs()
    {
        InitializeComponent();
    }



    private void buttonCreat_Click(object sender, EventArgs e)
    {
        int[] arr = new int[(int)numericUpDownSize.Value];

        Parameters = new ParametersClass(arr);

        ParametersSubmitted?.Invoke(this, EventArgs.Empty);

        this.Close();
    }

    private void buttonCancle_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
