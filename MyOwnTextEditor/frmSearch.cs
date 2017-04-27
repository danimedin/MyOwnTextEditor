using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOwnTextEditor
{
    
    public partial class FrmSearch : Form
    {
        private int startIndex = -1;
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void btbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btbFind_Click(object sender, EventArgs e)
        {

            if (!(this.cmbFind.Text == string.Empty)) {
                FrmMain frmMain = (FrmMain) this.Owner;
                foreach (Control control in frmMain.Controls)
                {
                    try
                    {
                        TabControl tabControl = (TabControl)control;
                        TabPage tabPage = tabControl.SelectedTab;
                        RichTextBox richTextBox = (RichTextBox) tabPage.Controls[0];
                        richTextBox.TextChanged  -= frmMain.rtbTextChanged;
                        string text = richTextBox.Text;
                        richTextBox.Clear();
                        richTextBox.Text = text;
                        startIndex = richTextBox.Text.IndexOf(cmbFind.Text,startIndex+1);
                        if (startIndex != -1) { 
                        richTextBox.Select(startIndex, cmbFind.Text.Length);
                        richTextBox.SelectionColor = System.Drawing.Color.White;
                        richTextBox.SelectionBackColor = System.Drawing.Color.Blue;
                        richTextBox.TextChanged += frmMain.rtbTextChanged;
                        }
                    }
                    catch (InvalidCastException ex) { }
                }
            }
        }
    }
}
