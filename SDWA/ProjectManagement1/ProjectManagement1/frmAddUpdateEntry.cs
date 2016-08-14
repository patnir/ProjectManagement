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

        last7Days = new List<DateTime>();

        DateTime todayDate = DateTime.Today;

        for (var i = 0; i < 7; i++)
        {
            last7Days.Add(todayDate.AddDays(-1 * i));
        }

        foreach (DateTime date in last7Days)
        {
            cmbDate.Items.Add(date.ToShortDateString());
        }

        cmbDate.SelectedIndex = 0;

        mAddUpdateMode = addUpdateMode;

        mEntry = entry;

        Text = addUpdateMode + " Entry";

        if (addUpdateMode == "update")
        {
            
        }
    }
}
