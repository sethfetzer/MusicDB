namespace MusicExplorer
{
  partial class FormAmazonCredentials
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAmazonCredentials));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxAccountNumber = new System.Windows.Forms.TextBox();
      this.textBoxAccessKeyId = new System.Windows.Forms.TextBox();
      this.buttonOk = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.ForeColor = System.Drawing.Color.Teal;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(335, 56);
      this.label1.TabIndex = 0;
      this.label1.Text = resources.GetString("label1.Text");
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(46, 85);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(90, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Account Number:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(56, 108);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(80, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Access Key ID:";
      // 
      // textBoxAccountNumber
      // 
      this.textBoxAccountNumber.Location = new System.Drawing.Point(142, 82);
      this.textBoxAccountNumber.Name = "textBoxAccountNumber";
      this.textBoxAccountNumber.Size = new System.Drawing.Size(158, 20);
      this.textBoxAccountNumber.TabIndex = 2;
      // 
      // textBoxAccessKeyId
      // 
      this.textBoxAccessKeyId.Location = new System.Drawing.Point(142, 108);
      this.textBoxAccessKeyId.Name = "textBoxAccessKeyId";
      this.textBoxAccessKeyId.Size = new System.Drawing.Size(158, 20);
      this.textBoxAccessKeyId.TabIndex = 4;
      // 
      // buttonOk
      // 
      this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonOk.Location = new System.Drawing.Point(156, 150);
      this.buttonOk.Name = "buttonOk";
      this.buttonOk.Size = new System.Drawing.Size(75, 23);
      this.buttonOk.TabIndex = 5;
      this.buttonOk.Text = "OK";
      this.buttonOk.UseVisualStyleBackColor = true;
      this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
      // 
      // FormAmazonCredentials
      // 
      this.AcceptButton = this.buttonOk;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(347, 194);
      this.Controls.Add(this.buttonOk);
      this.Controls.Add(this.textBoxAccessKeyId);
      this.Controls.Add(this.textBoxAccountNumber);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormAmazonCredentials";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Amazon Credentials";
      this.Load += new System.EventHandler(this.FormAmazonCredentials_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxAccountNumber;
    private System.Windows.Forms.TextBox textBoxAccessKeyId;
    private System.Windows.Forms.Button buttonOk;
  }
}