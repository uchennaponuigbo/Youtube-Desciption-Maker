using System.Drawing;
using System.Windows.Forms;

namespace Youtube_Desciption_Maker
{
    public static class DisplayWordAmount
    {
        public static void UpdateDescChar(ref RichTextBox richTextBox, ref Label richLabelTextLength)
        {
            if (richTextBox.Text.Length > richTextBox.MaxLength)
            {
                richLabelTextLength.Text = richTextBox.Text.Length.ToString();
                return;
            }

            richLabelTextLength.Text = richTextBox.TextLength.ToString();
            if (richTextBox.TextLength >= richTextBox.MaxLength)
                richLabelTextLength.ForeColor = Color.Red;
            else
                richLabelTextLength.ForeColor = Color.Black;          
        }

        
        public static void UpdateTitleChar(ref TextBox textBox, ref Label labelTextLength)
        {
            if (textBox.Text.Length > textBox.MaxLength)
                return;
            labelTextLength.Text = textBox.TextLength.ToString();
            if (textBox.TextLength >= textBox.MaxLength)
                labelTextLength.ForeColor = Color.Red;
            else
                labelTextLength.ForeColor = Color.Black;            
        }
    }
}

//private void ChangeLabelColor(TextBox text, RichTextBox rich, Label label)
//{
//    if ((text.Text.Length == text.MaxLength) 
//        || (rich.Text.Length == rich.MaxLength))
//        label.ForeColor = Color.Red;
//    else
//        label.ForeColor = Color.Black;
//}

//private void UpdateTitleChar()
//{
//    if (txtTitle.Text.Length > txtTitle.MaxLength)
//        return;
//    lblTitleLength.Text = txtTitle.Text.Length.ToString();
//    if (txtTitle.Text.Length >= txtTitle.MaxLength)
//        lblTitleLength.ForeColor = Color.Red;
//    else
//        lblTitleLength.ForeColor = Color.Black;
//    //ChangeLabelColor(txtTitle, richDesc, lblTitleLength);
//}

//private void UpdateDescChar()
//{
//    if (richDesc.Text.Length > richDesc.MaxLength)
//    {
//        lblDescLength.Text = richDesc.Text.Length.ToString();
//        return;
//    }

//    lblDescLength.Text = richDesc.Text.Length.ToString();
//    if (richDesc.Text.Length >= richDesc.MaxLength)
//        lblDescLength.ForeColor = Color.Red;
//    else
//        lblDescLength.ForeColor = Color.Black;
//    //ChangeLabelColor(txtTitle, richDesc, lblDescLength);
//}