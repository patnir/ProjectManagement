using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class frmMain : Form
{
    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    public frmMain()
    {
        InitializeComponent();
    }

    private void btnAddEntry_Click(object sender, EventArgs e)
    {
        clsEntry entry = new clsEntry();

        frmAddUpdateEntry addUpdate = new frmAddUpdateEntry("add", entry);

        if (addUpdate.ShowDialog() == DialogResult.OK)
        {
            refreshListView();
        }
    }

    private void refreshListView()
    {
        return;
    }
}
