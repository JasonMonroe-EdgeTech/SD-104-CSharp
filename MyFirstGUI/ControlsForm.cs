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
    public partial class ControlsForm : Form
    {
        MyDataModel dm = new MyDataModel();

        public ControlsForm()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            //txtMessage.Text = listBox1.SelectedItem.ToString();

            //MessageBox.Show("Warning", "This is a Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            DialogResult response = MessageBox.Show("Do You Want to Continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(response == DialogResult.Yes)
            {
                //user chose yes
            }
            else
            {
                //user chose no
            }

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dm.Employees.Add(new Employee(txtName.Text));
            dm.SaveChanges();

            //clear textbox
            txtName.Text = "";
        }

        private void ControlsForm_Load(object sender, EventArgs e)
        {

            foreach(Employee employee in dm.Employees)
            {
                tvEmployees.Nodes[0].Nodes.Add(employee.Name);
                
            }
        }

        private void tvEmployees_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MyDataModel dm = new MyDataModel();
            foreach(Employee employee in dm.Employees)
            {
                if(employee.Name == e.Node.Text)
                {
                    txtEmployeeId.Text = employee.Id.ToString();
                    txtEmployeeName.Text = employee.Name;
                    nudEmployeeAge.Value = employee.Age;
                }
            }
            
            tabControl.SelectedTab = tabEditEmployee;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            MyDataModel dm = new MyDataModel();
            Employee employee = new Employee(txtEmployeeName.Text);
            employee.Id = Convert.ToInt32(txtEmployeeId.Text);
            employee.Age = (int)nudEmployeeAge.Value;
            dm.Entry(employee).State = System.Data.Entity.EntityState.Modified;
            dm.SaveChanges();
        }
    }
}
