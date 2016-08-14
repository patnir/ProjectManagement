using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class frmAddTask : Form
{
    private clsTask mTask;
    private clsProject mProject;

    public frmAddTask(clsTask task, clsProject project)
    {
        InitializeComponent();

        mTask = task;
        mProject = project;
    }

    private bool validateInput()
    {
        if (txtTaskTitle.Text.Trim().Length == 0)
        {
            messageBoxOK("Task Title is required.");
            return false;
        }

        return true;
    }

    private void messageBoxOK(string errorMessage)
    {
        MessageBox.Show(errorMessage, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnAddNewTask_Click(object sender, EventArgs e)
    {
        if (validateInput() == false)
        {
            return;
        }

        mTask.Title = txtTaskTitle.Text.Trim();
        mTask.ProjectID = mProject.ProjectID;
        mTask.Entries = new List<clsEntry>();

        DialogResult = DialogResult.OK;
    }
}
