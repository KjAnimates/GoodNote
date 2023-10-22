using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodNote
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add the task, and close the window
        /// </summary>
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            // Close the window
            this.Close();
        }
    }
}
