namespace Youtube_Desciption_Maker
{
    partial class CreateTimestampForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.maskTimeStamp = new System.Windows.Forms.MaskedTextBox();
            this.richSummary = new System.Windows.Forms.RichTextBox();
            this.txtTimeStampTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentRichLength = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaxRichLength = new System.Windows.Forms.Label();
            this.lblCurrentTextLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMaxTextLength = new System.Windows.Forms.Label();
            this.btnExitForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTimestampAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // maskTimeStamp
            // 
            this.maskTimeStamp.Location = new System.Drawing.Point(12, 35);
            this.maskTimeStamp.Mask = "90:00";
            this.maskTimeStamp.Name = "maskTimeStamp";
            this.maskTimeStamp.Size = new System.Drawing.Size(35, 20);
            this.maskTimeStamp.TabIndex = 2;
            // 
            // richSummary
            // 
            this.richSummary.Location = new System.Drawing.Point(12, 79);
            this.richSummary.MaxLength = 1500;
            this.richSummary.Name = "richSummary";
            this.richSummary.Size = new System.Drawing.Size(265, 111);
            this.richSummary.TabIndex = 3;
            this.richSummary.Text = "";
            this.richSummary.TextChanged += new System.EventHandler(this.richSummary_TextChanged);
            // 
            // txtTimeStampTitle
            // 
            this.txtTimeStampTitle.Location = new System.Drawing.Point(73, 35);
            this.txtTimeStampTitle.MaxLength = 150;
            this.txtTimeStampTitle.Name = "txtTimeStampTitle";
            this.txtTimeStampTitle.Size = new System.Drawing.Size(207, 20);
            this.txtTimeStampTitle.TabIndex = 4;
            this.txtTimeStampTitle.TextChanged += new System.EventHandler(this.txtTimeStampTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Summary";
            // 
            // btnFinish
            // 
            this.btnFinish.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFinish.Location = new System.Drawing.Point(202, 205);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 25);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Title";
            // 
            // lblCurrentRichLength
            // 
            this.lblCurrentRichLength.AutoSize = true;
            this.lblCurrentRichLength.Location = new System.Drawing.Point(73, 62);
            this.lblCurrentRichLength.Name = "lblCurrentRichLength";
            this.lblCurrentRichLength.Size = new System.Drawing.Size(31, 13);
            this.lblCurrentRichLength.TabIndex = 9;
            this.lblCurrentRichLength.Text = "0000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "/";
            // 
            // lblMaxRichLength
            // 
            this.lblMaxRichLength.AutoSize = true;
            this.lblMaxRichLength.Location = new System.Drawing.Point(128, 62);
            this.lblMaxRichLength.Name = "lblMaxRichLength";
            this.lblMaxRichLength.Size = new System.Drawing.Size(31, 13);
            this.lblMaxRichLength.TabIndex = 11;
            this.lblMaxRichLength.Text = "9999";
            // 
            // lblCurrentTextLength
            // 
            this.lblCurrentTextLength.AutoSize = true;
            this.lblCurrentTextLength.Location = new System.Drawing.Point(104, 19);
            this.lblCurrentTextLength.Name = "lblCurrentTextLength";
            this.lblCurrentTextLength.Size = new System.Drawing.Size(25, 13);
            this.lblCurrentTextLength.TabIndex = 12;
            this.lblCurrentTextLength.Text = "000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "/";
            // 
            // lblMaxTextLength
            // 
            this.lblMaxTextLength.AutoSize = true;
            this.lblMaxTextLength.Location = new System.Drawing.Point(153, 19);
            this.lblMaxTextLength.Name = "lblMaxTextLength";
            this.lblMaxTextLength.Size = new System.Drawing.Size(25, 13);
            this.lblMaxTextLength.TabIndex = 14;
            this.lblMaxTextLength.Text = "999";
            // 
            // btnExitForm
            // 
            this.btnExitForm.Location = new System.Drawing.Point(107, 205);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(75, 25);
            this.btnExitForm.TabIndex = 15;
            this.btnExitForm.Text = "Exit";
            this.btnExitForm.UseVisualStyleBackColor = true;
            this.btnExitForm.Click += new System.EventHandler(this.btnExitForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Timestamp no. :";
            // 
            // lblTimestampAmount
            // 
            this.lblTimestampAmount.AutoSize = true;
            this.lblTimestampAmount.Location = new System.Drawing.Point(245, 62);
            this.lblTimestampAmount.Name = "lblTimestampAmount";
            this.lblTimestampAmount.Size = new System.Drawing.Size(19, 13);
            this.lblTimestampAmount.TabIndex = 17;
            this.lblTimestampAmount.Text = "99";
            // 
            // CreateTimestampForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExitForm;
            this.ClientSize = new System.Drawing.Size(292, 242);
            this.Controls.Add(this.lblTimestampAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExitForm);
            this.Controls.Add(this.lblMaxTextLength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCurrentTextLength);
            this.Controls.Add(this.lblMaxRichLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCurrentRichLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimeStampTitle);
            this.Controls.Add(this.richSummary);
            this.Controls.Add(this.maskTimeStamp);
            this.Controls.Add(this.btnAdd);
            this.Name = "CreateTimestampForm";
            this.Text = "Add Timestamp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox maskTimeStamp;
        private System.Windows.Forms.RichTextBox richSummary;
        private System.Windows.Forms.TextBox txtTimeStampTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentRichLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaxRichLength;
        private System.Windows.Forms.Label lblCurrentTextLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMaxTextLength;
        private System.Windows.Forms.Button btnExitForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTimestampAmount;
    }
}