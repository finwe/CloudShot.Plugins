namespace PluginExample
{
	partial class SettingsControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.components = new System.ComponentModel.Container();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.openFolderButton = new System.Windows.Forms.Button();
      this.mainTable = new System.Windows.Forms.TableLayoutPanel();
      this.loginTypeHeader = new CloudShot.Core.Controls.HeaderLabel();
      this.screenshotsDescription = new System.Windows.Forms.Label();
      this.headerLabel1 = new CloudShot.Core.Controls.HeaderLabel();
      this.selectFolderControl = new SelectFolderControl();
      this.mainTable.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolTip
      // 
      this.toolTip.AutomaticDelay = 200;
      this.toolTip.AutoPopDelay = 0;
      this.toolTip.InitialDelay = 200;
      this.toolTip.ReshowDelay = 0;
      this.toolTip.ShowAlways = true;
      // 
      // openFolderButton
      // 
      this.openFolderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.openFolderButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
      this.openFolderButton.Location = new System.Drawing.Point(127, 161);
      this.openFolderButton.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
      this.openFolderButton.Name = "openFolderButton";
      this.openFolderButton.Size = new System.Drawing.Size(180, 28);
      this.openFolderButton.TabIndex = 13;
      this.openFolderButton.Text = "Open gallery";
      this.openFolderButton.UseVisualStyleBackColor = true;
      this.openFolderButton.Click += new System.EventHandler(this.OnViewScreenshotsClick);
      // 
      // mainTable
      // 
      this.mainTable.ColumnCount = 1;
      this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.mainTable.Controls.Add(this.loginTypeHeader, 0, 0);
      this.mainTable.Controls.Add(this.openFolderButton, 0, 5);
      this.mainTable.Controls.Add(this.screenshotsDescription, 0, 4);
      this.mainTable.Controls.Add(this.headerLabel1, 0, 3);
      this.mainTable.Controls.Add(this.selectFolderControl, 0, 1);
      this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainTable.Location = new System.Drawing.Point(0, 0);
      this.mainTable.Margin = new System.Windows.Forms.Padding(0);
      this.mainTable.Name = "mainTable";
      this.mainTable.RowCount = 7;
      this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.mainTable.Size = new System.Drawing.Size(435, 200);
      this.mainTable.TabIndex = 1;
      // 
      // loginTypeHeader
      // 
      this.loginTypeHeader.Dock = System.Windows.Forms.DockStyle.Fill;
      this.loginTypeHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.loginTypeHeader.Location = new System.Drawing.Point(0, 0);
      this.loginTypeHeader.Margin = new System.Windows.Forms.Padding(0);
      this.loginTypeHeader.Name = "loginTypeHeader";
      this.loginTypeHeader.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
      this.loginTypeHeader.Size = new System.Drawing.Size(435, 30);
      this.loginTypeHeader.TabIndex = 14;
      this.loginTypeHeader.Text = "SAVE LOCATION";
      this.loginTypeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // screenshotsDescription
      // 
      this.screenshotsDescription.AutoSize = true;
      this.screenshotsDescription.Dock = System.Windows.Forms.DockStyle.Fill;
      this.screenshotsDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.screenshotsDescription.ForeColor = System.Drawing.Color.Gray;
      this.screenshotsDescription.Location = new System.Drawing.Point(4, 132);
      this.screenshotsDescription.Margin = new System.Windows.Forms.Padding(4, 2, 3, 2);
      this.screenshotsDescription.Name = "screenshotsDescription";
      this.screenshotsDescription.Size = new System.Drawing.Size(428, 26);
      this.screenshotsDescription.TabIndex = 17;
      this.screenshotsDescription.Text = "View all shots saved to Local/Network Folder";
      // 
      // headerLabel1
      // 
      this.headerLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.headerLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel1.Location = new System.Drawing.Point(0, 100);
      this.headerLabel1.Margin = new System.Windows.Forms.Padding(0);
      this.headerLabel1.Name = "headerLabel1";
      this.headerLabel1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
      this.headerLabel1.Size = new System.Drawing.Size(435, 30);
      this.headerLabel1.TabIndex = 18;
      this.headerLabel1.Text = "GALLERY";
      this.headerLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // selectFolderControl
      // 
      this.selectFolderControl.DefaultPath = null;
      this.selectFolderControl.Description = "Select folder";
      this.selectFolderControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.selectFolderControl.Location = new System.Drawing.Point(4, 30);
      this.selectFolderControl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.selectFolderControl.MinimumSize = new System.Drawing.Size(100, 30);
      this.selectFolderControl.Name = "selectFolderControl";
      this.selectFolderControl.SelectedPath = "";
      this.selectFolderControl.Size = new System.Drawing.Size(427, 60);
      this.selectFolderControl.TabIndex = 19;
      // 
      // FileSystemStorageSettingsControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.mainTable);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "FileSystemStorageSettingsControl";
      this.Size = new System.Drawing.Size(435, 200);
      this.mainTable.ResumeLayout(false);
      this.mainTable.PerformLayout();
      this.ResumeLayout(false);

		}

		#endregion
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.Button openFolderButton;
    private System.Windows.Forms.TableLayoutPanel mainTable;
    private CloudShot.Core.Controls.HeaderLabel loginTypeHeader;
    private System.Windows.Forms.Label screenshotsDescription;
    private CloudShot.Core.Controls.HeaderLabel headerLabel1;
    private SelectFolderControl selectFolderControl;
  }
}
