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
        /// <param name="sender"></param>
        /// <param name="e">Event Arguments</param>
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            // Close the window
            this.Close();
        }
    }
}
