using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MusicExplorer
{
  public partial class FormAmazonCredentials : Form
  {
    public string AccountNumber
    {
      get { return textBoxAccountNumber.Text.Trim(); }
    }

    public string AccessKeyId
    {
      get { return textBoxAccessKeyId.Text.Trim(); }
    }
	
    public FormAmazonCredentials()
    {
      InitializeComponent();
    }

    private void buttonOk_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void FormAmazonCredentials_Load(object sender, EventArgs e)
    {
      textBoxAccountNumber.Text = Properties.Settings.Default.AmazonAwsAccountNumber;
      textBoxAccessKeyId.Text = Properties.Settings.Default.AmazonAwsAccessKeyId;
    }
  }
}