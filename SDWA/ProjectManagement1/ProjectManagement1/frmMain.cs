using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class frmMain : Form
{
    public static List<clsProject> mProjects;

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    public frmMain()
    {
        InitializeComponent();
        mProjects = new List<clsProject>();
    }

    private void btnAddEntry_Click(object sender, EventArgs e)
    {
        clsEntry entry = new clsEntry();

        frmAddUpdateEntry addUpdate = new frmAddUpdateEntry("add", entry);

        if (addUpdate.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        refreshListView();
    }

    private void refreshListView()
    {
        return;
    }

    private void btnAddProject_Click(object sender, EventArgs e)
    {
        clsProject project = new clsProject();

        frmAddProject addProject = new frmAddProject(project);

        if (addProject.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        mProjects.Add(project);
        updateProjectComboBox();
    }

    private void updateProjectComboBox()
    {
        cmbProjects.Items.Clear();
        
        foreach (clsProject project in mProjects) 
        {
            cmbProjects.Items.Add(project.Title);
        }

        cmbProjects.SelectedIndex = mProjects.Count - 1;
    }

    private void btnAddTask_Click(object sender, EventArgs e)
    {
        if (cmbProjects.SelectedIndex < 0)
        {
            messageBoxOK("Select Project to add new Task to");
            return;
        }

        int index = cmbProjects.SelectedIndex;

        clsTask task = new clsTask();

        frmAddTask addTask = new frmAddTask(task, mProjects[index]);

        if (addTask.ShowDialog() != DialogResult.OK)
        {
            return;    
        }

        mProjects[index].Tasks.Add(task);

        updateTaskComboBox();

        cmbTasks.SelectedIndex = mProjects[index].Tasks.Count - 1;
    }

    private void updateTaskComboBox()
    {
        cmbTasks.Items.Clear();
        cmbTasks.Text = "";

        int index = cmbProjects.SelectedIndex;

        if (mProjects[index].Tasks == null)
        {
            return;
        }

        foreach (clsTask task in mProjects[index].Tasks)
        {
            cmbTasks.Items.Add(task.Title);
        }

        cmbTasks.SelectedIndex = mProjects[index].Tasks.Count - 1;
    }

    private void messageBoxOK(string errorMessage)
    {
        MessageBox.Show(errorMessage, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void cmbProjects_SelectedIndexChanged(object sender, EventArgs e)
    {
        updateTaskComboBox();
    }

}
