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
    public partial class frmMain : Form
    {

        private List<Model.Content> files;
       
        public frmMain()
        {
            InitializeComponent();
            files = new List<Model.Content>();
            files.Add(new Model.Content());
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {

            
            this.tcMain_selectedIndexChanged(null, null);

        }
        private void tsmiOpen_Click(object sender, EventArgs e)
        {

          
            this.newTabPage();
            this.open();

        }
        private void open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TabPage selectedTab = this.tcMain.SelectedTab;
                    foreach (Control control in selectedTab.Controls)
                    {
                        try
                        {
                            RichTextBox richTextBox = (RichTextBox)control;
                            richTextBox.Text = System.IO.File.ReadAllText(openFileDialog.FileName);

                            Model.Content content = files[this.tcMain.SelectedIndex];
                            content.FileName = openFileDialog.FileName;
                            content.offDirtyBit();
                            
                            this.Text = "MyOwnTextEditor - " + content.FileName;
                            selectedTab.Text = content.FileName;
                            
                        }
                        catch (InvalidCastException e) { }

                    }
                                           
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show("There was an error reading the file");
                }
            }

        }
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (files[tcMain.SelectedIndex].FileName == String.Empty)
            {
                this.tsmiSaveAs_Click(sender, e);
            }
            else
            {
                TabPage selectedTab = this.tcMain.SelectedTab;
                foreach (Control control in selectedTab.Controls)
                {
                    try
                    {
                        RichTextBox richTextBox = (RichTextBox)control;
                        System.IO.File.WriteAllText(this.files[this.tcMain.SelectedIndex].FileName, richTextBox.Text);
                        Model.Content content = files[this.tcMain.SelectedIndex];                        
                        content.offDirtyBit();
                        selectedTab.Text = content.FileName;

                        

                    }
                    catch (InvalidCastException ex) { }

                }
                
                

            }


        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TabPage selectedTab = this.tcMain.SelectedTab;
                    foreach (Control control in selectedTab.Controls)
                    {
                        try
                        {
                            RichTextBox richTextBox = (RichTextBox)control;
                            System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox.Text);
                            Model.Content content = files[this.tcMain.SelectedIndex];
                            content.FileName = saveFileDialog.FileName;
                            content.offDirtyBit();
                            this.Text = "MyOwnTextEditor - " + content.FileName;
                            this.tcMain.SelectedTab.Text = content.FileName;



                        }
                        catch (InvalidCastException ex) { }

                    }
                   
                }
                catch (Exception exception)
                {
                    MessageBox.Show("There was an error writing the file");
                }
            }

        }

        private void rtbTextChanged(object sender, EventArgs e)
        {
            if  (! this.files[this.tcMain.SelectedIndex].DirtyBit )
            {
                this.files[this.tcMain.SelectedIndex].onDirtyBit();
                this.tcMain.SelectedTab.Text = this.tcMain.SelectedTab.Text + '*';
            }
            
        }

        private void myOwnForm_Closing(object sender, FormClosingEventArgs e)
        {
            int i = 0;
            foreach (Model.Content content in this.files) {
                tcMain.SelectedTab=tcMain.TabPages[i];
                i++;
                if (content.DirtyBit)
                {
                    switch (this.showSaveQuestion(content.FileName))
                    {
                        case DialogResult.Yes:

                            this.tsmiSave_Click(sender, e);

                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;


                    }

                }
            }
            
        }
        private DialogResult showSaveQuestion(string fileName)
        {
            return MessageBox.Show(
                   "Do you want to save changes to the document "
                   + fileName,
                   "Do you want to save the document",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Exclamation);
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            this.tsmiNew_Click(sender, e);
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            this.tsmiOpen_Click(sender, e);
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.tsmiSave_Click(sender, e);
        }

        private void tcMain_selectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tcMain.SelectedTab == tpPlus)
            {
                newTabPage();


            }
        }

        private void newTabPage()
        {
            RichTextBox richTextBox = new RichTextBox();
            TabPage tabPage = new TabPage("new File");

            this.tcMain.TabPages.Insert(this.tcMain.TabPages.Count - 1, tabPage);
            tabPage.Controls.Add(richTextBox);
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.TextChanged += this.rtbTextChanged;
            this.tcMain.SelectedTab = tabPage;

            files.Add(new Model.Content());
        }
      
    }
}
