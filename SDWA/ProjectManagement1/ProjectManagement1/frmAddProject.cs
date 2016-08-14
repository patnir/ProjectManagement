using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class frmAddProject : Form
{
    private clsProject mProject;

    public frmAddProject(clsProject project)
    {
        InitializeComponent();

        mProject = project;
    }

    private void btnAddNewProject_Click(object sender, EventArgs e)
    {
        if (validateInput() == false)
        {
            return;
        }

        mProject.Title = txtProjectTitle.Text.Trim();
        mProject.Tasks = new List<clsTask>();
        DialogResult = DialogResult.OK; 
    }

    private bool validateInput()
    {
        if (txtProjectTitle.Text.Trim().Length == 0)
        {
            messageBoxOK("Project Name is required");
            txtProjectTitle.Focus();
            return false;
        }
        return true;
    }

    private void messageBoxOK(string errorMessage)
    {
        MessageBox.Show(errorMessage, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
