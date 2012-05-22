namespace MusicExplorer
{
  partial class AlbumDetails
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumDetails));
      this.listViewTracks = new System.Windows.Forms.ListView();
      this.columnHeaderTrack = new System.Windows.Forms.ColumnHeader();
      this.columnHeaderDuration = new System.Windows.Forms.ColumnHeader();
      this.columnHeaderTrackTitle = new System.Windows.Forms.ColumnHeader();
      this.panelRightTop = new System.Windows.Forms.Panel();
      this.labelDiscs = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.pictureBoxAlbumCover = new System.Windows.Forms.PictureBox();
      this.labelGenre = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.labelTitle = new System.Windows.Forms.Label();
      this.labelLabel = new System.Windows.Forms.Label();
      this.labelDate = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.labelArtist = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.splitter2 = new System.Windows.Forms.Splitter();
      this.textBoxLyrics = new System.Windows.Forms.TextBox();
      this.panelRightTop.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).BeginInit();
      this.SuspendLayout();
      // 
      // listViewTracks
      // 
      this.listViewTracks.BackColor = System.Drawing.SystemColors.Control;
      this.listViewTracks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTrack,
            this.columnHeaderDuration,
            this.columnHeaderTrackTitle});
      this.listViewTracks.Dock = System.Windows.Forms.DockStyle.Top;
      this.listViewTracks.FullRowSelect = true;
      this.listViewTracks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.listViewTracks.HideSelection = false;
      this.listViewTracks.Location = new System.Drawing.Point(0, 132);
      this.listViewTracks.MultiSelect = false;
      this.listViewTracks.Name = "listViewTracks";
      this.listViewTracks.Size = new System.Drawing.Size(367, 123);
      this.listViewTracks.TabIndex = 14;
      this.listViewTracks.UseCompatibleStateImageBehavior = false;
      this.listViewTracks.View = System.Windows.Forms.View.Details;
      this.listViewTracks.SelectedIndexChanged += new System.EventHandler(this.listViewTracks_SelectedIndexChanged);
      // 
      // columnHeaderTrack
      // 
      this.columnHeaderTrack.Text = "Track";
      this.columnHeaderTrack.Width = 50;
      // 
      // columnHeaderDuration
      // 
      this.columnHeaderDuration.Text = "Duration";
      // 
      // columnHeaderTrackTitle
      // 
      this.columnHeaderTrackTitle.Text = "Title";
      this.columnHeaderTrackTitle.Width = 242;
      // 
      // panelRightTop
      // 
      this.panelRightTop.Controls.Add(this.labelDiscs);
      this.panelRightTop.Controls.Add(this.label5);
      this.panelRightTop.Controls.Add(this.pictureBoxAlbumCover);
      this.panelRightTop.Controls.Add(this.labelGenre);
      this.panelRightTop.Controls.Add(this.label12);
      this.panelRightTop.Controls.Add(this.labelTitle);
      this.panelRightTop.Controls.Add(this.labelLabel);
      this.panelRightTop.Controls.Add(this.labelDate);
      this.panelRightTop.Controls.Add(this.label8);
      this.panelRightTop.Controls.Add(this.labelArtist);
      this.panelRightTop.Controls.Add(this.label6);
      this.panelRightTop.Controls.Add(this.label7);
      this.panelRightTop.Controls.Add(this.label9);
      this.panelRightTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelRightTop.Location = new System.Drawing.Point(0, 18);
      this.panelRightTop.Name = "panelRightTop";
      this.panelRightTop.Size = new System.Drawing.Size(367, 114);
      this.panelRightTop.TabIndex = 15;
      // 
      // labelDiscs
      // 
      this.labelDiscs.AutoSize = true;
      this.labelDiscs.Location = new System.Drawing.Point(49, 93);
      this.labelDiscs.Name = "labelDiscs";
      this.labelDiscs.Size = new System.Drawing.Size(93, 13);
      this.labelDiscs.TabIndex = 67;
      this.labelDiscs.Text = "<number of discs>";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(13, 93);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(36, 13);
      this.label5.TabIndex = 66;
      this.label5.Text = "Discs:";
      // 
      // pictureBoxAlbumCover
      // 
      this.pictureBoxAlbumCover.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlbumCover.Image")));
      this.pictureBoxAlbumCover.Location = new System.Drawing.Point(271, 21);
      this.pictureBoxAlbumCover.Name = "pictureBoxAlbumCover";
      this.pictureBoxAlbumCover.Size = new System.Drawing.Size(88, 82);
      this.pictureBoxAlbumCover.TabIndex = 60;
      this.pictureBoxAlbumCover.TabStop = false;
      // 
      // labelGenre
      // 
      this.labelGenre.AutoSize = true;
      this.labelGenre.Location = new System.Drawing.Point(49, 59);
      this.labelGenre.Name = "labelGenre";
      this.labelGenre.Size = new System.Drawing.Size(81, 13);
      this.labelGenre.TabIndex = 59;
      this.labelGenre.Text = "<type of music>";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(10, 59);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(39, 13);
      this.label12.TabIndex = 58;
      this.label12.Text = "Genre:";
      // 
      // labelTitle
      // 
      this.labelTitle.AutoSize = true;
      this.labelTitle.Location = new System.Drawing.Point(49, 8);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new System.Drawing.Size(66, 13);
      this.labelTitle.TabIndex = 51;
      this.labelTitle.Text = "<album title>";
      this.labelTitle.UseMnemonic = false;
      // 
      // labelLabel
      // 
      this.labelLabel.AutoSize = true;
      this.labelLabel.Location = new System.Drawing.Point(49, 42);
      this.labelLabel.Name = "labelLabel";
      this.labelLabel.Size = new System.Drawing.Size(88, 13);
      this.labelLabel.TabIndex = 55;
      this.labelLabel.Text = "<recording label>";
      // 
      // labelDate
      // 
      this.labelDate.AutoSize = true;
      this.labelDate.Location = new System.Drawing.Point(49, 76);
      this.labelDate.Name = "labelDate";
      this.labelDate.Size = new System.Drawing.Size(77, 13);
      this.labelDate.TabIndex = 57;
      this.labelDate.Text = "<release date>";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(16, 76);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(33, 13);
      this.label8.TabIndex = 56;
      this.label8.Text = "Date:";
      // 
      // labelArtist
      // 
      this.labelArtist.AutoSize = true;
      this.labelArtist.Location = new System.Drawing.Point(49, 25);
      this.labelArtist.Name = "labelArtist";
      this.labelArtist.Size = new System.Drawing.Size(70, 13);
      this.labelArtist.TabIndex = 53;
      this.labelArtist.Text = "<artist name>";
      this.labelArtist.UseMnemonic = false;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(16, 25);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(33, 13);
      this.label6.TabIndex = 52;
      this.label6.Text = "Artist:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(19, 8);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(30, 13);
      this.label7.TabIndex = 50;
      this.label7.Text = "Title:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(13, 42);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(36, 13);
      this.label9.TabIndex = 54;
      this.label9.Text = "Label:";
      // 
      // label4
      // 
      this.label4.BackColor = System.Drawing.Color.Blue;
      this.label4.Dock = System.Windows.Forms.DockStyle.Top;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.White;
      this.label4.Location = new System.Drawing.Point(0, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(367, 18);
      this.label4.TabIndex = 13;
      this.label4.Text = "Album Details";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label3
      // 
      this.label3.BackColor = System.Drawing.Color.Blue;
      this.label3.Dock = System.Windows.Forms.DockStyle.Top;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(0, 258);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(367, 18);
      this.label3.TabIndex = 16;
      this.label3.Text = "Lyrics";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // splitter2
      // 
      this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
      this.splitter2.Location = new System.Drawing.Point(0, 255);
      this.splitter2.Name = "splitter2";
      this.splitter2.Size = new System.Drawing.Size(367, 3);
      this.splitter2.TabIndex = 18;
      this.splitter2.TabStop = false;
      // 
      // textBoxLyrics
      // 
      this.textBoxLyrics.BackColor = System.Drawing.SystemColors.Control;
      this.textBoxLyrics.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxLyrics.Location = new System.Drawing.Point(0, 276);
      this.textBoxLyrics.Multiline = true;
      this.textBoxLyrics.Name = "textBoxLyrics";
      this.textBoxLyrics.ReadOnly = true;
      this.textBoxLyrics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBoxLyrics.Size = new System.Drawing.Size(367, 93);
      this.textBoxLyrics.TabIndex = 19;
      // 
      // AlbumDetails
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.textBoxLyrics);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.splitter2);
      this.Controls.Add(this.listViewTracks);
      this.Controls.Add(this.panelRightTop);
      this.Controls.Add(this.label4);
      this.Name = "AlbumDetails";
      this.Size = new System.Drawing.Size(367, 369);
      this.panelRightTop.ResumeLayout(false);
      this.panelRightTop.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView listViewTracks;
    private System.Windows.Forms.ColumnHeader columnHeaderTrack;
    private System.Windows.Forms.ColumnHeader columnHeaderDuration;
    private System.Windows.Forms.ColumnHeader columnHeaderTrackTitle;
    private System.Windows.Forms.Panel panelRightTop;
    private System.Windows.Forms.Label labelDiscs;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.PictureBox pictureBoxAlbumCover;
    private System.Windows.Forms.Label labelGenre;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.Label labelLabel;
    private System.Windows.Forms.Label labelDate;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label labelArtist;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Splitter splitter2;
    private System.Windows.Forms.TextBox textBoxLyrics;
  }
}
