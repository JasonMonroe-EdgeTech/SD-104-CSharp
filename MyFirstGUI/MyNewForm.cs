using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstGUI
{
    public partial class MyNewForm : Form
    {
        public MyNewForm()
        {
            InitializeComponent();
        }

        private void ShowOtherForm_Click(object sender, EventArgs e)
        {
            ControlsForm controlsFormInstance1 = new ControlsForm();
            controlsFormInstance1.Show();
        }
    }
}
