
partial class frmMain
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.cmbTasks = new System.Windows.Forms.ComboBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cmbStartDate = new System.Windows.Forms.ComboBox();
            this.cmbEndDate = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbProjects
            // 
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(71, 36);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(121, 21);
            this.cmbProjects.TabIndex = 0;
            // 
            // cmbTasks
            // 
            this.cmbTasks.FormattingEnabled = true;
            this.cmbTasks.Location = new System.Drawing.Point(71, 85);
            this.cmbTasks.Name = "cmbTasks";
            this.cmbTasks.Size = new System.Drawing.Size(121, 21);
            this.cmbTasks.TabIndex = 1;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(13, 39);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 2;
            this.lblProject.Text = "Project";
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(13, 88);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(31, 13);
            this.lblTask.TabIndex = 3;
            this.lblTask.Text = "Task";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(301, 39);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(301, 88);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date";
            // 
            // cmbStartDate
            // 
            this.cmbStartDate.FormattingEnabled = true;
            this.cmbStartDate.Location = new System.Drawing.Point(372, 36);
            this.cmbStartDate.Name = "cmbStartDate";
            this.cmbStartDate.Size = new System.Drawing.Size(121, 21);
            this.cmbStartDate.TabIndex = 6;
            // 
            // cmbEndDate
            // 
            this.cmbEndDate.FormattingEnabled = true;
            this.cmbEndDate.Location = new System.Drawing.Point(372, 85);
            this.cmbEndDate.Name = "cmbEndDate";
            this.cmbEndDate.Size = new System.Drawing.Size(121, 21);
            this.cmbEndDate.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(16, 133);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(712, 247);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(532, 34);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(179, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(532, 83);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(179, 23);
            this.btnAddEntry.TabIndex = 10;
            this.btnAddEntry.Text = "Add Entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(198, 36);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(42, 23);
            this.btnAddProject.TabIndex = 11;
            this.btnAddProject.Text = "new";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(198, 83);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(42, 23);
            this.btnAddTask.TabIndex = 12;
            this.btnAddTask.Text = "new";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 392);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbEndDate);
            this.Controls.Add(this.cmbStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.cmbTasks);
            this.Controls.Add(this.cmbProjects);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbProjects;
    private System.Windows.Forms.ComboBox cmbTasks;
    private System.Windows.Forms.Label lblProject;
    private System.Windows.Forms.Label lblTask;
    private System.Windows.Forms.Label lblStartDate;
    private System.Windows.Forms.Label lblEndDate;
    private System.Windows.Forms.ComboBox cmbStartDate;
    private System.Windows.Forms.ComboBox cmbEndDate;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.Button btnAddEntry;
    private System.Windows.Forms.Button btnAddProject;
    private System.Windows.Forms.Button btnAddTask;
}