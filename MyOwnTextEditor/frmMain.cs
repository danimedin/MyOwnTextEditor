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
        private Model.Content content;
        public frmMain()
        {
            InitializeComponent();
            content = new Model.Content();
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void tsmiNew_Click(object sender, EventArgs e)
        {

            if (content.DirtyBit)
            {
                switch (this.showSaveQuestion())
                { 
                    case DialogResult.Yes:
                        
                            this.tsmiSave_Click(sender, e);
                            this.rtbContent.Text = string.Empty;
                            content = new Model.Content();
                    break;
                    case DialogResult.No:
                  
                        this.rtbContent.Text = string.Empty;
                        content = new Model.Content();
                        break;
                }
            }

            
        }
        private void tsmiOpen_Click(object sender, EventArgs e)
        {

            if (content.DirtyBit)
            {
                switch (this.showSaveQuestion())
                {
                    case DialogResult.Yes:

                        this.tsmiSave_Click(sender, e);
                        this.rtbContent.Text = string.Empty;
                        content = new Model.Content();
                        this.open();
                        break;
                    case DialogResult.No:

                        this.rtbContent.Text = string.Empty;
                        content = new Model.Content();
                        this.open();
                        break;
                }

            }
            else {
                this.open(); 
            }
          

        }
         private void open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.rtbContent.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
                    this.content.FileName = openFileDialog.FileName;
                    this.content.offDirtyBit();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("There was an error reading the file");
                }
            }

        }
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (this.content.FileName == String.Empty)
            {
                this.tsmiSaveAs_Click(sender, e);
            }
            else
            {
                System.IO.File.WriteAllText(content.FileName, this.rtbContent.Text);
                this.content.offDirtyBit();

            }
                 
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, this.rtbContent.Text);
                    this.content.FileName = saveFileDialog.FileName;
                    this.content.offDirtyBit();
                }catch (Exception exception)
                {
                    MessageBox.Show("There was an error writing the file");
                }
            }
        }

        private void rtbTextChanged(object sender, EventArgs e)
        {
            this.content.onDirtyBit();
        }

        private void myOwnForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (content.DirtyBit)
            {
                switch (this.showSaveQuestion())
                {
                    case DialogResult.Yes:

                        this.tsmiSave_Click(sender, e);                      
                       
                        break;
                    case DialogResult.Cancel:
                        e.Cancel=true;
                        break;

                        
                }

            }
        }
        private DialogResult showSaveQuestion()
        {
            return MessageBox.Show(
                   "Do you want to save changes to the document "
                   + content.FileName,
                   "Do you want to save the document",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Exclamation);
        }
    }
}
