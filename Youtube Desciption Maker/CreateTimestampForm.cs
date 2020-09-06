using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_Desciption_Maker
{
    public partial class CreateTimestampForm : Form
    {
        public List<string> TimestampList { get; private set; }

        public CreateTimestampForm()
        {
            InitializeComponent();
            TimestampList = new List<string>();

            lblCurrentTextLength.Text = txtTimeStampTitle.TextLength.ToString();
            lblMaxTextLength.Text = txtTimeStampTitle.MaxLength.ToString();

            lblCurrentRichLength.Text = richSummary.TextLength.ToString();
            lblMaxRichLength.Text = richSummary.MaxLength.ToString();

            lblTimestampAmount.Text = TimestampList.Count.ToString();
        }

        //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.maskedtextbox.mask?view=netcore-3.1
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TimeStamp timestamp = new TimeStamp(maskTimeStamp.Text, txtTimeStampTitle.Text, richSummary.Text);
            if (timestamp.isValidTimestamp)
            {
                TimestampList.Add(timestamp.ToString());
                lblTimestampAmount.Text = TimestampList.Count.ToString();
                //MessageBox.Show(timestamp.ToString());
                Clear();
            }
            else
                MessageBox.Show("Invalid timestamp!");
            
        }
       
        private void Clear()
        {
            maskTimeStamp.Text = "";
            txtTimeStampTitle.Text = "";
            richSummary.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //finish button
            Close();
        }

        private void txtTimeStampTitle_TextChanged(object sender, EventArgs e)
        {
            DisplayWordAmount.UpdateTitleChar(txtTimeStampTitle, lblCurrentTextLength);
        }

        private void richSummary_TextChanged(object sender, EventArgs e)
        {
            DisplayWordAmount.UpdateDescChar(richSummary, lblCurrentRichLength);
        }

        private void btnExitForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
