
namespace SCOMAthon.SplashScreenDemo.Modules
{
  partial class DemoSplashScreen
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoSplashScreen));
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label2 = new System.Windows.Forms.Label();
      this.lMGName = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.lMGId = new System.Windows.Forms.Label();
      this.lbConnectedUsers = new System.Windows.Forms.ListBox();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(160, 35);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(559, 42);
      this.label1.TabIndex = 0;
      this.label1.Text = "SCOMAthon Demo: Hello Wrold!";
      // 
      // textBox1
      // 
      this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.textBox1.Location = new System.Drawing.Point(167, 80);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(552, 173);
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.groupBox1.Controls.Add(this.lbConnectedUsers);
      this.groupBox1.Controls.Add(this.lMGId);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.lMGName);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Location = new System.Drawing.Point(167, 259);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(552, 167);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Connected Management Group Details";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Name:";
      // 
      // lMGName
      // 
      this.lMGName.AutoSize = true;
      this.lMGName.Location = new System.Drawing.Point(93, 16);
      this.lMGName.Name = "lMGName";
      this.lMGName.Size = new System.Drawing.Size(54, 13);
      this.lMGName.TabIndex = 1;
      this.lMGName.Text = "lMGName";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 42);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(90, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Connected users:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(6, 29);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(19, 13);
      this.label6.TabIndex = 4;
      this.label6.Text = "Id:";
      // 
      // lMGId
      // 
      this.lMGId.AutoSize = true;
      this.lMGId.Location = new System.Drawing.Point(93, 29);
      this.lMGId.Name = "lMGId";
      this.lMGId.Size = new System.Drawing.Size(35, 13);
      this.lMGId.TabIndex = 5;
      this.lMGId.Text = "lMGId";
      // 
      // lbConnectedUsers
      // 
      this.lbConnectedUsers.FormattingEnabled = true;
      this.lbConnectedUsers.Location = new System.Drawing.Point(9, 58);
      this.lbConnectedUsers.Name = "lbConnectedUsers";
      this.lbConnectedUsers.Size = new System.Drawing.Size(314, 95);
      this.lbConnectedUsers.TabIndex = 6;
      // 
      // DemoSplashScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Name = "DemoSplashScreen";
      this.Size = new System.Drawing.Size(909, 572);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lMGId;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lMGName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListBox lbConnectedUsers;
  }
}
