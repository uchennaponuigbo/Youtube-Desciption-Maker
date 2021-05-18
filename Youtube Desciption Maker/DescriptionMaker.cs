using System;
using System.IO;
using System.Windows.Forms;
using ExtensionMethods;

namespace Youtube_Desciption_Maker
{
    public partial class frmDescriptionMaker : Form
    {
        public frmDescriptionMaker()
        {
            InitializeComponent();

            lblCopyNotif.Text = "";
            cboDateAchieved.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;

            lblMaxTitleLength.Text = txtTitle.MaxLength.ToString();
            lblTitleLength.Text = txtTitle.Text.Length.ToString();

            lblMaxDescLength.Text = richDesc.MaxLength.ToString();
            lblDescLength.Text = richDesc.Text.Length.ToString();
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

        private string AddandModifyText(string text)
        {
            if (richDesc.Text.Length > richDesc.MaxLength)
                return "";
            int trunicate = text.Length + richDesc.Text.Length; 
            if (trunicate > richDesc.MaxLength) 
            {
                //trunicate the string so that it'll fit inside the remaining length
                //ex: 'Uploaded on Mar 28th' goes beyond the maxlength of rich box by a few digits 
                //subtract the maxlength from the length, then trunicate up to that amount,
                //return that string.
                trunicate -= richDesc.MaxLength;
                trunicate -= text.Length;
                if (trunicate < 0)
                    trunicate *= -1;
                return text.Truncate(trunicate);
            } 
            else
                return text;
        }

        private void AdjustWordLength()
        {
            if (richDesc.Text.Length > richDesc.MaxLength)
            {
                int truncate = richDesc.Text.Length - richDesc.MaxLength;
                richDesc.Text = richDesc.Text.Truncate(richDesc.Text.Length - truncate);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string d = $"{cboDateAchieved.Text} {dateTimePicker1.Text}{Environment.NewLine}";
            d = AddandModifyText(d);
            richDesc.AppendText(d);
        }

        private void Clear()
        {
            richDesc.Text = "";
            txtTitle.Text = "";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show("Empty all text from the textboxes in this form?",
                "Clear Fields?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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
            save.FileName = txtTitle.Text;

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
            if(richDesc.Text.Length >= richDesc.MaxLength)
            {
                MessageBox.Show($"The description is at the maximum capacity of {richDesc.MaxLength} characters."
                    , "Going Above Capacity Error");
                return;
            }
            else
            {
                if (importEntire)
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
                        if (importEntire)
                            txtTitle.Text = r.ReadLine(); //get first line of file onto textbox
                        while (line != null)
                        {
                            line = r.ReadLine();
                            if (line != null)
                                richDesc.AppendText(line + Environment.NewLine);
                        }
                        AdjustWordLength();
                        r.Close();
                    }
                    openFileDialog1.FileName = "";
                }
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

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            //UpdateTitleChar();
            DisplayWordAmount.UpdateTitleChar(txtTitle, lblTitleLength);
        }

        private void richDesc_TextChanged(object sender, EventArgs e)
        {
            //UpdateDescChar();
            DisplayWordAmount.UpdateDescChar(richDesc, lblDescLength);
        }

        private void btnClearTitle_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            CreateTimestampForm timestamp = new CreateTimestampForm(richDesc.TextLength);
            DialogResult selectedButton = timestamp.ShowDialog();      
            if(selectedButton == DialogResult.OK)
            {
                foreach (var item in timestamp.TimeStampList)
                {
                    richDesc.AppendText(item.ToString());
                }
                AdjustWordLength();
            }           
        }
    }
}
