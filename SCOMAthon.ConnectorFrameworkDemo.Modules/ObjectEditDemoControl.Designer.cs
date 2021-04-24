
namespace SCOMAthon.ConnectorFrameworkDemo.Modules
{
  partial class ObjectEditDemoControl
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
      this.pHeader = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.pFooter = new System.Windows.Forms.Panel();
      this.btDelete = new System.Windows.Forms.Button();
      this.dgvDemoObjects = new System.Windows.Forms.DataGridView();
      this.cDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cKeyProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cStringProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cIntProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cCommitStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pHeader.SuspendLayout();
      this.pFooter.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDemoObjects)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.SuspendLayout();
      // 
      // pHeader
      // 
      this.pHeader.Controls.Add(this.label1);
      this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pHeader.Location = new System.Drawing.Point(0, 0);
      this.pHeader.Name = "pHeader";
      this.pHeader.Size = new System.Drawing.Size(662, 60);
      this.pHeader.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(13, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(485, 37);
      this.label1.TabIndex = 0;
      this.label1.Text = "SCOMAthon Object Editor Demo";
      // 
      // pFooter
      // 
      this.pFooter.Controls.Add(this.btDelete);
      this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pFooter.Location = new System.Drawing.Point(0, 483);
      this.pFooter.Name = "pFooter";
      this.pFooter.Size = new System.Drawing.Size(662, 30);
      this.pFooter.TabIndex = 1;
      // 
      // btDelete
      // 
      this.btDelete.Location = new System.Drawing.Point(3, 3);
      this.btDelete.Name = "btDelete";
      this.btDelete.Size = new System.Drawing.Size(108, 23);
      this.btDelete.TabIndex = 0;
      this.btDelete.Text = "Delete Object";
      this.btDelete.UseVisualStyleBackColor = true;
      this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
      // 
      // dgvDemoObjects
      // 
      this.dgvDemoObjects.AllowUserToOrderColumns = true;
      this.dgvDemoObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDemoObjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDisplayName,
            this.cKeyProperty,
            this.cStringProperty,
            this.cIntProperty,
            this.cCommitStatus});
      this.dgvDemoObjects.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvDemoObjects.Location = new System.Drawing.Point(0, 60);
      this.dgvDemoObjects.Name = "dgvDemoObjects";
      this.dgvDemoObjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvDemoObjects.Size = new System.Drawing.Size(662, 423);
      this.dgvDemoObjects.TabIndex = 2;
      this.dgvDemoObjects.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDemoObjects_DataError);
      // 
      // cDisplayName
      // 
      this.cDisplayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.cDisplayName.DataPropertyName = "DisplayName";
      this.cDisplayName.HeaderText = "Display Name";
      this.cDisplayName.Name = "cDisplayName";
      // 
      // cKeyProperty
      // 
      this.cKeyProperty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.cKeyProperty.DataPropertyName = "KeyProperty";
      this.cKeyProperty.HeaderText = "Key (String)";
      this.cKeyProperty.Name = "cKeyProperty";
      // 
      // cStringProperty
      // 
      this.cStringProperty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.cStringProperty.DataPropertyName = "StringProperty";
      this.cStringProperty.HeaderText = "String Value";
      this.cStringProperty.Name = "cStringProperty";
      // 
      // cIntProperty
      // 
      this.cIntProperty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.cIntProperty.DataPropertyName = "IntProperty";
      this.cIntProperty.FillWeight = 30F;
      this.cIntProperty.HeaderText = "IntValue";
      this.cIntProperty.Name = "cIntProperty";
      // 
      // cCommitStatus
      // 
      this.cCommitStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.cCommitStatus.DataPropertyName = "CommitStatus";
      this.cCommitStatus.FillWeight = 50F;
      this.cCommitStatus.HeaderText = "Commit Status";
      this.cCommitStatus.Name = "cCommitStatus";
      // 
      // ObjectEditDemoControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dgvDemoObjects);
      this.Controls.Add(this.pFooter);
      this.Controls.Add(this.pHeader);
      this.Name = "ObjectEditDemoControl";
      this.Size = new System.Drawing.Size(662, 513);
      this.pHeader.ResumeLayout(false);
      this.pHeader.PerformLayout();
      this.pFooter.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDemoObjects)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pHeader;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel pFooter;
    private System.Windows.Forms.Button btDelete;
    private System.Windows.Forms.DataGridView dgvDemoObjects;
    private System.Windows.Forms.DataGridViewTextBoxColumn cDisplayName;
    private System.Windows.Forms.DataGridViewTextBoxColumn cKeyProperty;
    private System.Windows.Forms.DataGridViewTextBoxColumn cStringProperty;
    private System.Windows.Forms.DataGridViewTextBoxColumn cIntProperty;
    private System.Windows.Forms.DataGridViewTextBoxColumn cCommitStatus;
  }
}
