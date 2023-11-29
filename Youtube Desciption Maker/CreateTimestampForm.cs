using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtensionMethods;

namespace Youtube_Desciption_Maker
{
    //Original form size before temp modifying
    //697, 376
    public partial class CreateTimestampForm : Form
    {
        //public List</*string*/TimeStamp> TimeStampList { get; private set; }
        /// <summary>
        /// Iterator variable for all the timestamps contained in the list
        /// </summary>
        private uint index;
        private const string Add = "Add";
        private const string Edit = "Edit";

        private enum IndexListView
        {
            Spaces,
            Index,
            Time,
            Title,
            Summary
        }

        private int EnumToIntIndex(IndexListView index) => Convert.ToInt32(index);

        public CreateTimestampForm(int wordCount, List<TimeStamp> reserved)
        {
            InitializeComponent();
            //TimeStampList = new List</*string*/TimeStamp>();

            index = 1;
            chkSpaces.Checked = true;

            lblCurrentTextLength.Text = txtTitle.TextLength.ToString();
            lblMaxTextLength.Text = txtTitle.MaxLength.ToString();

            lblCurrentRichLength.Text = richSummary.TextLength.ToString();
            lblMaxRichLength.Text = richSummary.MaxLength.ToString();

            lblTimestampSize.Text = lblTotal.Text =
                lblTimestampAmount.Text = 0.ToString();

            if (reserved.Count > 0)
            {
                foreach(TimeStamp item in reserved)
                {
                    AddIntoListView(item.Timestamp, item.Title, item.Summary);
                    lblTimestampSize.Text = item.Size.ToString();
                    int addition = Convert.ToInt32(lblTotal.Text);
                    lblTotal.Text = (addition + item.Size).ToString();
                    AutoScrollListBox();
                }
            }

            DisplayTimestampHint(Globals.MaxVideoLength, Color.Gray);
            lblDescriptionSize.Text = wordCount.ToString();
            
            //345, 306 old form size
        }

        private bool ValidateTimestamp(string text)
        {
            //https://regex101.com/
            //https://www.regextutorial.org/regex-for-numbers-and-ranges.php
            string pattern = "^(\b([0-9]|1[0-1])\b):?([0-5])?[0-9]:[0-5][0-9]$";
            return Regex.IsMatch(text, pattern);
        }

        private void AddIntoListView(string timeStamp, string title, string summary)
        {
            //ORDER MATTERS HERE
            ListViewItem listItem = new ListViewItem();
            listItem.Checked = chkSpaces.Checked;
            listItem.SubItems.Add($"{index++}");

            listItem.SubItems.Add(timeStamp);

            listItem.SubItems.Add(title);
            listItem.SubItems.Add(summary);
            listViewTimeStamps.Items.Add(listItem);

            lblTimestampAmount.Text = (index - 1).ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text == Add)
            {
                //ORDER MATTERS HERE
                //ListViewItem listItem = new ListViewItem();
                //listItem.Checked = chkSpaces.Checked;
                //listItem.SubItems.Add($"{index++}");

                //listItem.SubItems.Add(txtTimestamp.Text);

                //listItem.SubItems.Add(txtTitle.Text);
                //listItem.SubItems.Add(richSummary.Text);
                //listViewTimeStamps.Items.Add(listItem);

                //lblTimestampAmount.Text = (index - 1).ToString();
                AddIntoListView(txtTimestamp.Text, txtTitle.Text, richSummary.Text);
                //GetSizesOfTimestamps();
                Clear();
                AutoScrollListBox();
            }
            else if(btnAdd.Text == Edit)
            {
                int selectedIndex = listViewTimeStamps.SelectedIndices[0];

                listViewTimeStamps.Items[selectedIndex].Checked = chkSpaces.Checked;

                listViewTimeStamps.Items[selectedIndex].
                    SubItems[EnumToIntIndex(IndexListView.Time)].Text = txtTimestamp.Text;

                listViewTimeStamps.Items[selectedIndex].
                    SubItems[EnumToIntIndex(IndexListView.Title)].Text = txtTitle.Text;

                listViewTimeStamps.Items[selectedIndex].
                    SubItems[EnumToIntIndex(IndexListView.Summary)].Text = richSummary.Text;

                //get old size and total, subtract the difference, update the total label for processing
                //in method below
                int oldSize = Convert.ToInt32(lblTimestampSize.Text);
                int total = Convert.ToInt32(lblTotal.Text);
                total -= oldSize;

                lblTotal.Text = total.ToString();

                GetSizesOfTimestamps(true);
                Clear(true);
                btnAdd.Text = Add;

                //deselects item
                listViewTimeStamps.SelectedItems.Clear();
            }
        }

        private void GetSizesOfTimestamps(bool adding = true)
        {
            int size = txtTitle.TextLength + txtTimestamp.TextLength + richSummary.TextLength;
            lblTimestampSize.Text = size.ToString();

            if(adding)
            {
                int addition = Convert.ToInt32(lblTotal.Text);
                lblTotal.Text = (addition + size).ToString();

                int descriptionSize = Convert.ToInt32(lblDescriptionSize.Text);
                if (addition + descriptionSize >= Globals.DescriptionLength)
                    lblTotal.ForeColor = Color.Red;
                else
                    lblTotal.ForeColor = Color.Black;
            }
        }
       
        private void Clear(bool clearTime = false)
        {
            txtTitle.Text = richSummary.Text = "";
            if (clearTime)
            {
                txtTimestamp.Text = "";
                DisplayTimestampHint(Globals.MaxVideoLength, Color.Gray);
            }              
        }

        //finish button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AutoScrollListBox()
        {
            //int nItems = listTimeStamps.Height / listTimeStamps.ItemHeight;
            //listTimeStamps.TopIndex = listTimeStamps.Items.Count - nItems;

            listViewTimeStamps.TopItem = listViewTimeStamps.Items[listViewTimeStamps.Items.Count - 1];
        }

        private void txtTimeStampTitle_TextChanged(object sender, EventArgs e)
        {
            DisplayWordAmount.UpdateTitleChar(ref txtTitle, ref lblCurrentTextLength);
        }

        private void richSummary_TextChanged(object sender, EventArgs e)
        {
            DisplayWordAmount.UpdateDescChar(ref richSummary, ref lblCurrentRichLength);
        }

        //exit without closing
        private void btnExitForm_Click(object sender, EventArgs e)
        { 
            Close();
        }
             
        private void lblTimestampAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayTimestampHint(string videoLength, Color color)
        {
            txtTimestamp.Text = videoLength;
            txtTimestamp.ForeColor = color;
        }

        private void txtTimestamp_Leave(object sender, EventArgs e)
        {
            if (txtTimestamp.Text == "")
            {
                DisplayTimestampHint(Globals.MaxVideoLength, Color.Gray);
            }
        }

        private void txtTimestamp_Enter(object sender, EventArgs e)
        {
            if (txtTimestamp.Text == Globals.MaxVideoLength)
            {
                DisplayTimestampHint("", Color.Black);
            }
        }

        //
        private void listViewTimeStamps_SelectedIndexChanged(object sender, EventArgs e)
        {
            //https://stackoverflow.com/a/42789493/9521550
            if (listViewTimeStamps.SelectedIndices.Count > 0)
            {
                int selectedIndex = listViewTimeStamps.SelectedIndices[0];

                chkSpaces.Checked = listViewTimeStamps.Items[selectedIndex].Checked;

                txtTimestamp.Text = listViewTimeStamps.Items[selectedIndex].
                    SubItems[EnumToIntIndex(IndexListView.Time)].Text;

                txtTitle.Text = listViewTimeStamps.Items[selectedIndex].
                    SubItems[EnumToIntIndex(IndexListView.Title)].Text;

                richSummary.Text = listViewTimeStamps.Items[selectedIndex].
                    SubItems[EnumToIntIndex(IndexListView.Summary)].Text;

                GetSizesOfTimestamps(false);

                btnAdd.Text = Edit;
            }
            else
            {
                Clear(true);
                btnAdd.Text = Add;
                lblTimestampSize.Text = "0";
            }
                
        }

        public List<TimeStamp> TimeStampList()
        {
            List<TimeStamp> list = new List<TimeStamp>(listViewTimeStamps.Items.Count);
            for (int i = 0; i < listViewTimeStamps.Items.Count; i++)
            {
                ListViewItem listview = listViewTimeStamps.Items[i];

                TimeStamp timestamp = new TimeStamp
                    (listview.SubItems[EnumToIntIndex(IndexListView.Time)].Text, 
                    listview.SubItems[EnumToIntIndex(IndexListView.Title)].Text,
                    listview.SubItems[EnumToIntIndex(IndexListView.Summary)].Text, listview.Checked);

                list.Add(timestamp);
            }
            return list;
        }

        //prevents column width resizing
        private void listViewTimeStamps_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listViewTimeStamps.Columns[e.ColumnIndex].Width;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewTimeStamps.SelectedIndices.Count > 0)
            {
                int deletedIndex = 0;
                for(int i = listViewTimeStamps.SelectedItems.Count - 1; i > -1; i--)
                {
                    ListViewItem item = listViewTimeStamps.SelectedItems[i];
                    deletedIndex = item.Index;
                    listViewTimeStamps.Items[deletedIndex].Remove();
                    index--;
                }

                //reorder indices starting from the deleted index
                for (int j = deletedIndex; j < listViewTimeStamps.Items.Count; j++)
                {
                    string text = listViewTimeStamps.Items[j].SubItems
                        [EnumToIntIndex(IndexListView.Index)].Text;
                    int itemIndex = Convert.ToInt32(text);
                    itemIndex--;
                    listViewTimeStamps.Items[j].SubItems
                        [EnumToIntIndex(IndexListView.Index)].Text = itemIndex.ToString();
                }
            }
        }

        private void btnSaveForLater_Click(object sender, EventArgs e)
        {
            //passes timestamp list into main form and keeps it in memory until
            //user presses "add timestamp" again
            Close();
        }
    }
}