using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_Desciption_Maker
{
    public partial class frmDescriptionMaker : Form
    {
        public frmDescriptionMaker()
        {
            InitializeComponent();
            lblCopyNotif.Text = "";
            cboDateAchieved.SelectedIndex = 0;
        }

        private void timer1Tick(object sender, EventArgs e)
        {
            lblCopyNotif.Text = "";
            timer1.Enabled = false;
            
        }

        private void CopyText(string text)
        {
            try
            {
                Clipboard.SetText(text);
                lblCopyNotif.Text = "Copied to Clipboard!";
                timer1.Tick += timer1Tick;
                timer1.Enabled = true;

            }
            catch (ArgumentNullException) { }
            catch (NullReferenceException) { }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //richDesc.SelectAll();
            //richDesc.Focus();
            CopyText(richDesc.Text);
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            richDesc.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            richDesc.AppendText($"{cboDateAchieved.Text} {dateTimePicker1.Text}{Environment.NewLine}");
        }

        private void Clear()
        {
            richDesc.Text = "";
            txtTitle.Text = "";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Clear();
        }       

        private void btnCopyTitle_Click(object sender, EventArgs e)
        {
            CopyText(txtTitle.Text);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save to a new text file in a specfic format
            //title on top
            //description underneath
            save.Filter = "Text files (*.txt)|*.txt";
            save.Title = "Save as Text File";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (FileStream S = File.Open(save.FileName, FileMode.Create))
                {
                    using (StreamWriter st = new StreamWriter(S))
                    {
                        st.WriteLine(txtTitle.Text); 
                        foreach (var aa in richDesc.Lines)
                            st.WriteLine(aa);
                        st.Close();
                    }
                    S.Close();
                }
                save.FileName = "";
            }
        }

        private void ImportintoRichText(bool importEntire)
        {
            if(importEntire)
            {
                Clear();
            }

            openFileDialog1.DefaultExt = "*.txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            string line = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader r = new StreamReader(openFileDialog1.FileName))
                {
                    if(importEntire)
                        txtTitle.Text = r.ReadLine(); //get first line of file onto textbox
                    while (line != null)
                    {
                        line = r.ReadLine();
                        if (line != null)
                            richDesc.AppendText(line + Environment.NewLine);
                    }
                    r.Close();
                }
                openFileDialog1.FileName = "";
            }
        }
        private void importWholeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //will clear textbox and richtexbox
            //imports saved text file created from this windows form
            ImportintoRichText(true);            
        }

        private void importTextFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //imports raw text into rich textbox
            ImportintoRichText(false);
        }
    }
}
