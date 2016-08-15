using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class frmAddUpdateEntry : Form
{
    private clsEntry mEntry;
    private string mAddUpdateMode;

    private List<DateTime> last7Days;

    public frmAddUpdateEntry(string addUpdateMode, clsEntry entry)
    {
        InitializeComponent();

        mAddUpdateMode = addUpdateMode;
        mEntry = entry;

        Text = addUpdateMode + " Entry";

        if (addUpdateMode == "update")
        {
            btnAddUpdate.Text = "Update";
            cmbDate.Items.Add(mEntry.Date.ToShortDateString());
        }

        // setting dates for Date combo box

        last7Days = new List<DateTime>();

        DateTime todayDate = DateTime.Today;

        for (var i = 0; i < 7; i++)
        {
            last7Days.Add(todayDate.AddDays(-1 * i));
        }

        foreach (DateTime date in last7Days)
        {
            cmbDate.Items.Add(date.ToShortDateString());

            txtDescription.Text = mEntry.Description;

            nudHours.Value = decimal.Parse(mEntry.Hours.ToString());
        }

        cmbDate.SelectedIndex = 0;

        updateProjectComboBox();

        updateTaskComboBox();
    }

    private void updateTaskComboBox()
    {
        if (frmMain.mProjects.Count == 0)
        {
            return;
        }

        cmbTasks.Text = "";
        cmbTasks.Items.Clear();

        int index = cmbProjects.SelectedIndex;

        foreach (clsTask task in frmMain.mProjects[index].Tasks)
        {
            cmbTasks.Items.Add(task.Title);
        }
    }

    private void updateProjectComboBox()
    {
        cmbProjects.Text = "";
        cmbProjects.Items.Clear();

        foreach (clsProject project in frmMain.mProjects)
        {
            cmbProjects.Items.Add(project.Title);
        }

        cmbProjects.SelectedIndex = frmMain.mProjects.Count - 1;
    }

    private void btnAddUpdate_Click(object sender, EventArgs e)
    {
        if (validateInput() == false)
        {
            return;
        }

        DialogResult = DialogResult.OK;
    }

    private bool validateInput()
    {
        return true;
    }

    private void cmbProjects_SelectedIndexChanged(object sender, EventArgs e)
    {
        updateTaskComboBox();
    }
}
