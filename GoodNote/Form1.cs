﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void taskList_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode newNode = new TreeNode("Test");
            taskList.Nodes.Add(newNode);
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            new AddTaskForm().Show();
        }
    }
}
