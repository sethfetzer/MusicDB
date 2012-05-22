using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MusicExplorer
{
	/// <summary>
	/// Summary description for FormAbout.
	/// </summary>
	public class FormAbout : System.Windows.Forms.Form
	{
    #region Controls
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button buttonClose;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private Label label2;
    private System.ComponentModel.Container components = null;
    #endregion

		public FormAbout()
		{
			InitializeComponent();

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.buttonClose = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(132, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(271, 73);
      this.label1.TabIndex = 0;
      this.label1.Text = resources.GetString("label1.Text");
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(12, 167);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(341, 26);
      this.label4.TabIndex = 3;
      this.label4.Text = "Lyrics provided by LyricWiki. Report any errors to http://lyricwiki.org.";
      // 
      // buttonClose
      // 
      this.buttonClose.Location = new System.Drawing.Point(253, 208);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(75, 23);
      this.buttonClose.TabIndex = 4;
      this.buttonClose.Text = "Close";
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(16, 14);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(100, 100);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 8;
      this.pictureBox1.TabStop = false;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.ForeColor = System.Drawing.Color.Teal;
      this.label8.Location = new System.Drawing.Point(12, 212);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(183, 13);
      this.label8.TabIndex = 9;
      this.label8.Text = "Written by Ted Faison - May 1, 2009";
      // 
      // label9
      // 
      this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(132, 89);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(271, 39);
      this.label9.TabIndex = 10;
      this.label9.Text = "Artist and track info provided by MusicBrainz. Report errors to http://www.musicb" +
          "rainz.org.";
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(13, 128);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(390, 36);
      this.label2.TabIndex = 11;
      this.label2.Text = "Album info and cover art provided by Amazon. Any errors should be reported to htt" +
          "p://www.amazon.com.";
      // 
      // FormAbout
      // 
      this.AcceptButton = this.buttonClose;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
      this.ClientSize = new System.Drawing.Size(415, 245);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.buttonClose);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormAbout";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "About Music Explorer";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
		#endregion

    private void buttonClose_Click(object sender, System.EventArgs e)
    {
      Close();
    }
	}
}
