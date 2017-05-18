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
                if (frmMain.tsmTabbed.Checked)
                {

                    foreach (Control control in frmMain.Controls)
                    {
                        try
                        {
                            TabControl tabControl = (TabControl)control;
                            TabPage tabPage = tabControl.SelectedTab;
                            CustomRichTextBox richTextBox = (CustomRichTextBox)tabPage.Controls[0];
                            this.searchInRichTextBox(richTextBox);
                        }
                        catch (InvalidCastException ex) { }
                    }
                }
                else {
                    Form activeForm = frmMain.ActiveMdiChild;
                        
                        
                            CustomRichTextBox richTextBox = (CustomRichTextBox)activeForm.Controls[0];
                            this.searchInRichTextBox(richTextBox);
                        
                    
                }

            }
        }

        private void searchInRichTextBox(CustomRichTextBox richTextBox)
        {

            richTextBox.TextChanged -=((FrmMain) this.Owner).rtbTextChanged;
            string text = richTextBox.Text;
            richTextBox.Clear();

            richTextBox.Text = text;
            startIndex = richTextBox.Text.IndexOf(cmbFind.Text, startIndex + 1);
            if (startIndex != -1)
            {
                richTextBox.Select(startIndex, cmbFind.Text.Length);
                richTextBox.SelectionColor = System.Drawing.Color.White;
                richTextBox.SelectionBackColor = System.Drawing.Color.Blue;
                richTextBox.TextChanged += ((FrmMain)this.Owner).rtbTextChanged;
            }
        }

        private void cmbFind_KeyPreseed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
                btbFind_Click(null, null);

        }
    }
}
