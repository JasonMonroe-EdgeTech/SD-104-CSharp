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
    public partial class frmStopwatch : Form
    {
        public frmStopwatch()
        {
            InitializeComponent();
        }

        double elapsedTime = 0.0;
        bool isOn = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            isOn = true;
            async();
            

        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            isOn = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime += 0.1;
            txtMessage.Text = elapsedTime.ToString();
        }

        async void async()
        {
            await timer();
            MessageBox.Show("Running task async");
        }

        private Task<int> timer()
        {
            while (isOn)
            {
                elapsedTime += 0.1;
                txtMessage.Text = elapsedTime.ToString();
            }

            return new Task<int>(() => 0);
        }
    }
}
