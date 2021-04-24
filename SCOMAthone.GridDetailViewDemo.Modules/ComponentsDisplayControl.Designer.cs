
namespace SCOMAthon.GridDetailViewDemo.Modules
{
  partial class ComponentsDisplayControl
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
      this.gbLogicalDisks = new System.Windows.Forms.GroupBox();
      this.lvDisks = new System.Windows.Forms.ListView();
      this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chSizeGB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.gbLogicalDisks.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.SuspendLayout();
      // 
      // gbLogicalDisks
      // 
      this.gbLogicalDisks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.gbLogicalDisks.Controls.Add(this.lvDisks);
      this.gbLogicalDisks.Location = new System.Drawing.Point(3, 3);
      this.gbLogicalDisks.Name = "gbLogicalDisks";
      this.gbLogicalDisks.Size = new System.Drawing.Size(321, 290);
      this.gbLogicalDisks.TabIndex = 0;
      this.gbLogicalDisks.TabStop = false;
      this.gbLogicalDisks.Text = "Computer Disks";
      // 
      // lvDisks
      // 
      this.lvDisks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chSizeGB});
      this.lvDisks.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lvDisks.HideSelection = false;
      this.lvDisks.Location = new System.Drawing.Point(3, 16);
      this.lvDisks.Name = "lvDisks";
      this.lvDisks.Size = new System.Drawing.Size(315, 271);
      this.lvDisks.TabIndex = 0;
      this.lvDisks.UseCompatibleStateImageBehavior = false;
      this.lvDisks.View = System.Windows.Forms.View.Details;
      // 
      // chName
      // 
      this.chName.Text = "Name";
      // 
      // chSizeGB
      // 
      this.chSizeGB.Text = "Size, GB";
      this.chSizeGB.Width = 120;
      // 
      // ComponentsDisplayControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gbLogicalDisks);
      this.Name = "ComponentsDisplayControl";
      this.Size = new System.Drawing.Size(758, 296);
      this.gbLogicalDisks.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gbLogicalDisks;
    private System.Windows.Forms.ListView lvDisks;
    private System.Windows.Forms.ColumnHeader chName;
    private System.Windows.Forms.ColumnHeader chSizeGB;
  }
}
