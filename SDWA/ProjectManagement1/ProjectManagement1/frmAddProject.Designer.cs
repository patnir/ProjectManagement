partial class frmAddProject
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
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.txtProjectTitle = new System.Windows.Forms.TextBox();
            this.btnAddNewProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Location = new System.Drawing.Point(26, 31);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(63, 13);
            this.lblProjectTitle.TabIndex = 0;
            this.lblProjectTitle.Text = "Project Title";
            // 
            // txtProjectTitle
            // 
            this.txtProjectTitle.Location = new System.Drawing.Point(158, 28);
            this.txtProjectTitle.Name = "txtProjectTitle";
            this.txtProjectTitle.Size = new System.Drawing.Size(139, 20);
            this.txtProjectTitle.TabIndex = 1;
            // 
            // btnAddNewProject
            // 
            this.btnAddNewProject.Location = new System.Drawing.Point(89, 77);
            this.btnAddNewProject.Name = "btnAddNewProject";
            this.btnAddNewProject.Size = new System.Drawing.Size(134, 23);
            this.btnAddNewProject.TabIndex = 2;
            this.btnAddNewProject.Text = "Add New Project";
            this.btnAddNewProject.UseVisualStyleBackColor = true;
            this.btnAddNewProject.Click += new System.EventHandler(this.btnAddNewProject_Click);
            // 
            // frmAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 130);
            this.Controls.Add(this.btnAddNewProject);
            this.Controls.Add(this.txtProjectTitle);
            this.Controls.Add(this.lblProjectTitle);
            this.Name = "frmAddProject";
            this.Text = "frmAddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblProjectTitle;
    private System.Windows.Forms.TextBox txtProjectTitle;
    private System.Windows.Forms.Button btnAddNewProject;
}