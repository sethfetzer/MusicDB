namespace MusicExplorer
{
  partial class FormMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxArtist = new System.Windows.Forms.TextBox();
      this.buttonSearch = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.listViewAlbums = new System.Windows.Forms.ListView();
      this.columnHeaderYear = new System.Windows.Forms.ColumnHeader();
      this.columnHeaderTitle = new System.Windows.Forms.ColumnHeader();
      this.labelStatusBar = new System.Windows.Forms.Label();
      this.panelTop = new System.Windows.Forms.Panel();
      this.panelMiddle = new System.Windows.Forms.Panel();
      this.panelRight = new System.Windows.Forms.Panel();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.panelLeft = new System.Windows.Forms.Panel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.amazonCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panelTop.SuspendLayout();
      this.panelMiddle.SuspendLayout();
      this.panelLeft.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(33, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Artist:";
      // 
      // textBoxArtist
      // 
      this.textBoxArtist.Location = new System.Drawing.Point(38, 13);
      this.textBoxArtist.Name = "textBoxArtist";
      this.textBoxArtist.Size = new System.Drawing.Size(474, 20);
      this.textBoxArtist.TabIndex = 2;
      this.textBoxArtist.Text = "The Beatles";
      // 
      // buttonSearch
      // 
      this.buttonSearch.Location = new System.Drawing.Point(522, 11);
      this.buttonSearch.Name = "buttonSearch";
      this.buttonSearch.Size = new System.Drawing.Size(72, 24);
      this.buttonSearch.TabIndex = 3;
      this.buttonSearch.Text = "Search";
      this.buttonSearch.UseVisualStyleBackColor = true;
      this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.Blue;
      this.label2.Dock = System.Windows.Forms.DockStyle.Top;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(230, 18);
      this.label2.TabIndex = 4;
      this.label2.Text = "Albums";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // listViewAlbums
      // 
      this.listViewAlbums.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderYear,
            this.columnHeaderTitle});
      this.listViewAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listViewAlbums.FullRowSelect = true;
      this.listViewAlbums.HideSelection = false;
      this.listViewAlbums.Location = new System.Drawing.Point(0, 18);
      this.listViewAlbums.MultiSelect = false;
      this.listViewAlbums.Name = "listViewAlbums";
      this.listViewAlbums.Size = new System.Drawing.Size(230, 450);
      this.listViewAlbums.Sorting = System.Windows.Forms.SortOrder.Descending;
      this.listViewAlbums.TabIndex = 7;
      this.listViewAlbums.UseCompatibleStateImageBehavior = false;
      this.listViewAlbums.View = System.Windows.Forms.View.Details;
      this.listViewAlbums.SelectedIndexChanged += new System.EventHandler(this.listViewAlbums_SelectedIndexChanged);
      this.listViewAlbums.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewAlbums_ColumnClick);
      // 
      // columnHeaderYear
      // 
      this.columnHeaderYear.Text = "Year";
      this.columnHeaderYear.Width = 35;
      // 
      // columnHeaderTitle
      // 
      this.columnHeaderTitle.Text = "Title";
      this.columnHeaderTitle.Width = 181;
      // 
      // labelStatusBar
      // 
      this.labelStatusBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.labelStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.labelStatusBar.Location = new System.Drawing.Point(0, 541);
      this.labelStatusBar.Name = "labelStatusBar";
      this.labelStatusBar.Size = new System.Drawing.Size(602, 22);
      this.labelStatusBar.TabIndex = 8;
      this.labelStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // panelTop
      // 
      this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
      this.panelTop.Controls.Add(this.textBoxArtist);
      this.panelTop.Controls.Add(this.buttonSearch);
      this.panelTop.Controls.Add(this.label1);
      this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTop.Location = new System.Drawing.Point(0, 24);
      this.panelTop.Name = "panelTop";
      this.panelTop.Size = new System.Drawing.Size(602, 49);
      this.panelTop.TabIndex = 9;
      // 
      // panelMiddle
      // 
      this.panelMiddle.Controls.Add(this.panelRight);
      this.panelMiddle.Controls.Add(this.splitter1);
      this.panelMiddle.Controls.Add(this.panelLeft);
      this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelMiddle.Location = new System.Drawing.Point(0, 73);
      this.panelMiddle.Name = "panelMiddle";
      this.panelMiddle.Size = new System.Drawing.Size(602, 468);
      this.panelMiddle.TabIndex = 10;
      // 
      // panelRight
      // 
      this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelRight.Location = new System.Drawing.Point(233, 0);
      this.panelRight.Name = "panelRight";
      this.panelRight.Size = new System.Drawing.Size(369, 468);
      this.panelRight.TabIndex = 4;
      // 
      // splitter1
      // 
      this.splitter1.Location = new System.Drawing.Point(230, 0);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(3, 468);
      this.splitter1.TabIndex = 1;
      this.splitter1.TabStop = false;
      // 
      // panelLeft
      // 
      this.panelLeft.Controls.Add(this.listViewAlbums);
      this.panelLeft.Controls.Add(this.label2);
      this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelLeft.Location = new System.Drawing.Point(0, 0);
      this.panelLeft.Name = "panelLeft";
      this.panelLeft.Size = new System.Drawing.Size(230, 468);
      this.panelLeft.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(602, 24);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.aboutToolStripMenuItem.Text = "&About...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // ToolStripMenuItem
      // 
      this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amazonCredentialsToolStripMenuItem});
      this.ToolStripMenuItem.Name = "ToolStripMenuItem";
      this.ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
      this.ToolStripMenuItem.Text = "Options";
      // 
      // amazonCredentialsToolStripMenuItem
      // 
      this.amazonCredentialsToolStripMenuItem.Name = "amazonCredentialsToolStripMenuItem";
      this.amazonCredentialsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
      this.amazonCredentialsToolStripMenuItem.Text = "Amazon Credentials...";
      this.amazonCredentialsToolStripMenuItem.Click += new System.EventHandler(this.amazonCredentialsToolStripMenuItem_Click);
      // 
      // FormMain
      // 
      this.AcceptButton = this.buttonSearch;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(602, 563);
      this.Controls.Add(this.panelMiddle);
      this.Controls.Add(this.panelTop);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.labelStatusBar);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FormMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Music Explorer";
      this.panelTop.ResumeLayout(false);
      this.panelTop.PerformLayout();
      this.panelMiddle.ResumeLayout(false);
      this.panelLeft.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxArtist;
    private System.Windows.Forms.Button buttonSearch;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListView listViewAlbums;
    private System.Windows.Forms.ColumnHeader columnHeaderTitle;
    private System.Windows.Forms.Label labelStatusBar;
    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.Panel panelMiddle;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.Panel panelLeft;
    private System.Windows.Forms.ColumnHeader columnHeaderYear;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.Panel panelRight;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem amazonCredentialsToolStripMenuItem;
  }
}

