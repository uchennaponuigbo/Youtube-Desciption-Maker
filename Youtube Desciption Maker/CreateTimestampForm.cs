using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtensionMethods;

namespace Youtube_Desciption_Maker
{
    public partial class CreateTimestampForm : Form
    {
        public List</*string*/TimeStamp> TimeStampList { get; private set; }
        /// <summary>
        /// Iterator variable for all the timestamps contained in the list
        /// </summary>
        //private int index;

        public CreateTimestampForm(int wordCount)
        {
            InitializeComponent();
            TimeStampList = new List</*string*/TimeStamp>();

            lblCurrentTextLength.Text = txtTimeStampTitle.TextLength.ToString();
            lblMaxTextLength.Text = txtTimeStampTitle.MaxLength.ToString();

            lblCurrentRichLength.Text = richSummary.TextLength.ToString();
            lblMaxRichLength.Text = richSummary.MaxLength.ToString();

            lblDescriptionSize.Text = wordCount.ToString();
            lblTimestampSize.Text = 
                lblTotal.Text = 
                lblTimestampAmount.Text =
                0.ToString();

            //index = 0;
            //btnNext.Enabled = false;
            //btnPrevious.Enabled = false;
            maskTimeStamp.Text = " 0:00";
            chkSpaces.Checked = true;

            //345, 306 old form size
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            richSummary.Focus();
            
            TimeStamp timestamp = new TimeStamp(maskTimeStamp.Text, txtTimeStampTitle.Text, 
                richSummary.Text, chkSpaces.Checked);
            if (timestamp.isValidTimestamp)
            {
                if(listTimeStamps.SelectedIndex == -1) //if nothing is selected in listbox
                {
                    TimeStampList.Add(timestamp/*.ToString()*/);
                    lblTimestampAmount.Text = TimeStampList.Count.ToString();                     
                    lblTimestampSize.Text = timestamp.Size.ToString();
                    int addition = Convert.ToInt32(lblTotal.Text);
                    lblTotal.Text = (addition + timestamp.Size).ToString();
                    
                    listTimeStamps.Items.Add(MarkTimeStampIntoListbox(timestamp));
                    addition += timestamp.Size;

                    int descriptionSize = Convert.ToInt32(lblDescriptionSize.Text);
                    if (addition + descriptionSize >= 5000)
                        lblTotal.ForeColor = Color.Red;
                    else
                        lblTotal.ForeColor = Color.Black;
                }
                else
                {
                    chkSpaces.Checked = false;        
                    string getFirstValue = listTimeStamps.SelectedItem.ToString();
                    int labelledIndex = Convert.ToInt32(getFirstValue.Truncate(1)); //index labelled in the list
                    int userIndex = listTimeStamps.SelectedIndex; //selected index the user clicked

                    int newSize = timestamp.Size;
                    int oldSize = TimeStampList[userIndex].Size;
                    int total = Convert.ToInt32(lblTotal.Text);

                    //The idea is to subtract the old size from the total but add new size to total
                    //it took me two months (on and off, mostly off) to figure out this issue
                    if (newSize > oldSize)
                    {
                        total -= oldSize;
                        total += newSize;
                    }                       
                    else //I don't know exactly why switching the ordering works as intended but... math, I guess
                    {
                        total += newSize;
                        total -= oldSize;
                    }                        
                    
                    lblTotal.Text = total.ToString();

                    int descriptionSize = Convert.ToInt32(lblDescriptionSize.Text);
                    if (total + descriptionSize >= 5000)
                        lblTotal.ForeColor = Color.Red;
                    else
                        lblTotal.ForeColor = Color.Black;

                    TimeStampList[userIndex] = timestamp;

                    lblTimestampSize.Text = TimeStampList[userIndex].Size.ToString();
                    listTimeStamps.Items.Insert(userIndex, 
                        MarkTimeStampIntoListbox(TimeStampList[userIndex], labelledIndex)); //prevents index from being
                    listTimeStamps.Items.Remove(listTimeStamps.SelectedItem); //labelled incorrectly
                    listTimeStamps.SelectedIndex = -1;
                }

                AutoScrollListBox();
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
        //returns the index, the time and the title
        private string MarkTimeStampIntoListbox(in TimeStamp timestamp, int index = -1)
        {
            //not going to add a delete button, so I can simply index the next value
            //if I ever do add a delete button, I'll remove the index and let the user keep track of
            //the numerical order of the timestamps
            if(index == -1)
                return $"{TimeStampList.Count} | {timestamp.Timestamp} - {timestamp.Title}";
            else
                return $"{index} | {timestamp.Timestamp} - {timestamp.Title}";
        }

        private void AutoScrollListBox()
        {
            int nItems = listTimeStamps.Height / listTimeStamps.ItemHeight;
            listTimeStamps.TopIndex = listTimeStamps.Items.Count - nItems;
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
     
        private void FillTextboxes(int i)
        {   //TODO: why is i -1? Yet, it changes the values without a problem
            //the problem is that it unselects the index when I edit an index
            //issue is fixed by simply wrapping a check if the index is -1
            txtTimeStampTitle.Text = TimeStampList[i].Title;
            if (TimeStampList[i].Timestamp.Length == 5)
                maskTimeStamp.Text = TimeStampList[i].Timestamp;
            else //retains original format of string before it went into the list
                maskTimeStamp.Text = " " + TimeStampList[i].Timestamp;
            richSummary.Text = TimeStampList[i].Summary;
            lblTimestampSize.Text = TimeStampList[i].Size.ToString();
            chkSpaces.Checked = TimeStampList[i].AllowSpaces;     
        }
       

        private void lblTimestampAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void listTimeStamps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listTimeStamps.SelectedIndex != -1)
                FillTextboxes(listTimeStamps.SelectedIndex);           
        }

        private void listTimeStamps_DoubleClick(object sender, EventArgs e)
        {
            if(listTimeStamps.SelectedIndex != -1) //prevents user from double clicking anywhere in listbox
            {//they must select an index
                listTimeStamps.SelectedIndex = -1;
                Clear();
            }  
        }
    }
}