using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodNote
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Executes when the form loads
        /// </summary>
        private void Form1_Load(object sender, EventArgs e) { }

        /// <summary>
        /// Executes when the "AddTask" Button is clicked.
        /// </summary>
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            // Show a new instance of the task form.
            AddTaskForm form = new AddTaskForm();

            // Shows the form as a dialog
            // It cannot be clicked away
            form.ShowDialog();
        }
    }
}
