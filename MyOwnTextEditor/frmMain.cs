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
    public partial class FrmMain : Form
    {
        
        private List<CustomRichTextBox> customTextRichBoxes;
       
        public FrmMain()
        {
            InitializeComponent();
            customTextRichBoxes = new List<CustomRichTextBox>();
           

           CustomRichTextBox richTextBox = new CustomRichTextBox(new Model.Content());
           richTextBox.Dock = DockStyle.Fill;
         
           tp1.Controls.Add(richTextBox);
           richTextBox.TextChanged += this.rtbTextChanged;
           this.tcMain.SelectedTab = tp1;
            this.customTextRichBoxes.Add(richTextBox);
            

        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {


            this.newTabPage();

        }
        private void tsmiOpen_Click(object sender, EventArgs e)
        {

            if (this.tsmTabbed.Checked)
            {
                this.newTabPage();
                this.open();
            }else
            {
                this.newChildForm();
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
                    if (this.tsmTabbed.Checked) { 

                        TabPage selectedTab = this.tcMain.SelectedTab;
                        foreach (Control control in selectedTab.Controls)
                        {
                        try
                        {
                            CustomRichTextBox richTextBox = (CustomRichTextBox)control;
                            richTextBox.Text = System.IO.File.ReadAllText(openFileDialog.FileName);

                            Model.Content content = richTextBox.Content;
                            content.FileName = openFileDialog.FileName;
                            content.offDirtyBit();
                            
                            this.Text = "MyOwnTextEditor - " + content.FileName;
                            selectedTab.Text = content.FileName;
                            
                        }
                        catch (InvalidCastException e) { }

                        }
                    }
                    else
                    {
                        Form form = this.MdiChildren.Last();
                        try
                        {
                            CustomRichTextBox richTextBox = (CustomRichTextBox) form.Controls[0];

                            richTextBox.Text= System.IO.File.ReadAllText(openFileDialog.FileName);
                            Model.Content content = richTextBox.Content;
                            content.FileName = openFileDialog.FileName;
                            content.offDirtyBit();
                            form.Text = content.FileName;
                        }
                        catch (InvalidCastException ex) { } 
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
            if (this.tsmTabbed.Checked)
            {
                if (customTextRichBoxes[tcMain.SelectedIndex].Content.FileName == String.Empty)
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
                            CustomRichTextBox richTextBox = (CustomRichTextBox)control;
                            System.IO.File.WriteAllText(this.customTextRichBoxes[this.tcMain.SelectedIndex].Content.FileName, richTextBox.Text);
                            Model.Content content = this.customTextRichBoxes[this.tcMain.SelectedIndex].Content;
                            content.offDirtyBit();
                            selectedTab.Text = content.FileName;



                        }
                        catch (InvalidCastException ex) { }

                    }



                }
            }
            else {
                try
                {
                    Form form = this.ActiveMdiChild;
                
             
                    CustomRichTextBox richTextBox = (CustomRichTextBox)form.Controls[0];
                    if (richTextBox.Content.FileName == String.Empty)
                    {
                        this.tsmiSaveAs_Click(sender, e);
                    }else { 
                    System.IO.File.WriteAllText(richTextBox.Content.FileName, richTextBox.Text);
                    Model.Content content = richTextBox.Content;
                    content.offDirtyBit();
                    form.Text = content.FileName;
                    }
                }
                catch (NullReferenceException ex)
                {

                }
                
            }


        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            if (this.tsmTabbed.Checked)
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
                                CustomRichTextBox richTextBox = (CustomRichTextBox)control;
                                System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox.Text);
                                Model.Content content = richTextBox.Content;
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
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try {
                        Form form = this.ActiveMdiChild;
                        CustomRichTextBox richTextBox = (CustomRichTextBox)form.Controls[0];
                        System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox.Text);
                        Model.Content content = richTextBox.Content;
                        content.FileName = saveFileDialog.FileName;
                        content.offDirtyBit();
                        this.Text = "MyOwnTextEditor - " + content.FileName;
                        form.Text = content.FileName;
                    }
                    catch(NullReferenceException ex){

                    }

                }
            }

        }

        public void rtbTextChanged(object sender, EventArgs e)
        {
            if (this.tsmTabbed.Checked)
            {
                if (!this.customTextRichBoxes[this.tcMain.SelectedIndex].Content.DirtyBit)
                {
                    this.customTextRichBoxes[this.tcMain.SelectedIndex].Content.onDirtyBit();
                    this.tcMain.SelectedTab.Text = this.tcMain.SelectedTab.Text + '*';
                }
            }
            else
            {
                CustomRichTextBox richTextBox = (CustomRichTextBox)sender;
                if (!richTextBox.Content.DirtyBit)
                {
                    richTextBox.Content.onDirtyBit();
                    richTextBox.Parent.Text = richTextBox.Parent.Text + '*';
                }
            }
                
        }

        private void myOwnForm_Closing(object sender, FormClosingEventArgs e)
        {
            int i = 0;
            if (this.tsmTabbed.Checked) { 
                foreach (CustomRichTextBox richTextBox in this.customTextRichBoxes)
                {
                    Model.Content content = richTextBox.Content;
                    tcMain.SelectedTab = tcMain.TabPages[i];
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
            else
            {
                foreach (CustomRichTextBox richTextBox in this.customTextRichBoxes)
                {
                    Model.Content content = richTextBox.Content;
                    this.MdiChildren[i].Focus();

                   
                    
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
            newTabPage();
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
            CustomRichTextBox richTextBox = new CustomRichTextBox(new Model.Content());
            TabPage tabPage = new TabPage("new File");

            this.tcMain.TabPages.Insert(this.tcMain.TabPages.Count - 1, tabPage);
            tabPage.Controls.Add(richTextBox);
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.TextChanged += this.rtbTextChanged;
            this.tcMain.SelectedTab = tabPage;

            this.customTextRichBoxes.Add(richTextBox);
        }
        private void newChildForm()
        {
            CustomRichTextBox richTextBox = new CustomRichTextBox(new Model.Content());
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.TextChanged += this.rtbTextChanged;
            Form form = new Form();
            form.MdiParent = this;
            form.Controls.Add(richTextBox);
            form.Show();

            this.customTextRichBoxes.Add(richTextBox);

        }

        private void tsmiFind_Click(object sender, EventArgs e)
        {
            FrmSearch frmSearch = new FrmSearch();
            frmSearch.Show();
            frmSearch.Owner = this;
            

        }

        private void vistaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmWindow_Click(object sender, EventArgs e)
        {
            this.tsmWindow.Enabled = false;
            this.tsmWindow.Checked = true;
            this.tsmTabbed.Enabled = true;
            this.tsmTabbed.Checked = false;
            this.IsMdiContainer = true;

            createSelectedTabForm();

            foreach (TabPage tabPage in this.tcMain.TabPages) {
                if (tabPage.GetHashCode() != tcMain.SelectedTab.GetHashCode())
                {

                
                foreach (Control control in tabPage.Controls) {
                    try {
                        CustomRichTextBox richTextBox = (CustomRichTextBox)control;
                        Form form = new Form();
                        form.MdiParent = this;
                        form.Controls.Add(richTextBox);
                        
                        form.Text = tabPage.Text;
                        form.Show();
                        form.BringToFront();
                       

                        
                    } catch (InvalidCastException ex) { }

                    }
                }
            }
            


            this.tcMain.Controls.Clear();
            this.tcMain.Dispose();
        }

        private void createSelectedTabForm()
        {

            CustomRichTextBox richTextBox = (CustomRichTextBox)tcMain.SelectedTab.Controls[0];
            Form form = new Form();
            form.MdiParent = this;
            form.Controls.Add(richTextBox);

            form.Text = tcMain.SelectedTab.Text;
            form.Show();
        }

        private void tsmTabbed_Click(object sender, EventArgs e)
        {
            this.tsmWindow.Enabled = true;
            this.tsmWindow.Checked = false;
            this.tsmTabbed.Enabled = false;
            this.tsmTabbed.Checked = true;
            TabControl tabControl = new TabControl();
               tabControl.Location = new Point(0, 51);
               tabControl.Size = new Size(557, 387);
               tabControl.ItemSize = new Size(68, 35);
               tabControl.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
         
         
            this.Controls.Add(tabControl);
            tabControl.SelectedIndexChanged += this.tcMain_selectedIndexChanged;
         this.tcMain = tabControl;


            foreach (Form form in this.MdiChildren)
            {
                foreach (Control control in form.Controls)
                {
                    try
                    {
                        CustomRichTextBox richTextBox = (CustomRichTextBox)control;

                        TabPage tabPage = new TabPage();
                        tabPage.Controls.Add(richTextBox);
                        tcMain.TabPages.Add(tabPage);
                        tabPage.Text = form.Text;



                    }
                    catch (InvalidCastException ex) { }


                }
                form.Dispose();
            }
            tpPlus = new TabPage();
            tpPlus.Text = "+";
            tcMain.TabPages.Add(tpPlus);
            this.IsMdiContainer = false;
        }
    }
}
