namespace Youtube_Desciption_Maker
{
    partial class frmDescriptionMaker
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCopyNotif = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richDesc = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboDateAchieved = new System.Windows.Forms.ComboBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopyTitle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importWholeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTextFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.lblMaxTitleLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitleLength = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescLength = new System.Windows.Forms.Label();
            this.lblMaxDescLength = new System.Windows.Forms.Label();
            this.btnClearTitle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.btnClearSavedTimes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // lblCopyNotif
            // 
            this.lblCopyNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyNotif.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCopyNotif.Location = new System.Drawing.Point(662, 48);
            this.lblCopyNotif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyNotif.Name = "lblCopyNotif";
            this.lblCopyNotif.Size = new System.Drawing.Size(95, 48);
            this.lblCopyNotif.TabIndex = 0;
            this.lblCopyNotif.Text = "label1";
            this.lblCopyNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMM d, yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 47);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 5, 23, 24, 16, 0);
            // 
            // richDesc
            // 
            this.richDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richDesc.Location = new System.Drawing.Point(16, 92);
            this.richDesc.Margin = new System.Windows.Forms.Padding(4);
            this.richDesc.MaxLength = 5000;
            this.richDesc.Name = "richDesc";
            this.richDesc.Size = new System.Drawing.Size(539, 348);
            this.richDesc.TabIndex = 5;
            this.richDesc.Text = "";
            this.richDesc.TextChanged += new System.EventHandler(this.richDesc_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cboDateAchieved);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(572, 278);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(185, 118);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 11);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 28);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboDateAchieved
            // 
            this.cboDateAchieved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDateAchieved.FormattingEnabled = true;
            this.cboDateAchieved.Items.AddRange(new object[] {
            "Uploaded on",
            "Published on",
            "Run achieved on",
            "Streamed on"});
            this.cboDateAchieved.Location = new System.Drawing.Point(13, 79);
            this.cboDateAchieved.Margin = new System.Windows.Forms.Padding(4);
            this.cboDateAchieved.Name = "cboDateAchieved";
            this.cboDateAchieved.Size = new System.Drawing.Size(160, 24);
            this.cboDateAchieved.TabIndex = 10;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(563, 147);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(90, 28);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy Desc";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(666, 147);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 28);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear Desc";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter a description for your video.";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(61, 59);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.MaxLength = 100;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(492, 24);
            this.txtTitle.TabIndex = 13;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Title:";
            // 
            // btnCopyTitle
            // 
            this.btnCopyTitle.Location = new System.Drawing.Point(563, 101);
            this.btnCopyTitle.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyTitle.Name = "btnCopyTitle";
            this.btnCopyTitle.Size = new System.Drawing.Size(90, 28);
            this.btnCopyTitle.TabIndex = 18;
            this.btnCopyTitle.Text = "Copy Title";
            this.btnCopyTitle.UseVisualStyleBackColor = true;
            this.btnCopyTitle.Click += new System.EventHandler(this.btnCopyTitle_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 30);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.importWholeFileToolStripMenuItem,
            this.importTextFromFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(381, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // importWholeFileToolStripMenuItem
            // 
            this.importWholeFileToolStripMenuItem.Name = "importWholeFileToolStripMenuItem";
            this.importWholeFileToolStripMenuItem.Size = new System.Drawing.Size(381, 26);
            this.importWholeFileToolStripMenuItem.Text = "Copy Text into Title and Description Boxes...";
            this.importWholeFileToolStripMenuItem.Click += new System.EventHandler(this.importWholeFileToolStripMenuItem_Click);
            // 
            // importTextFromFileToolStripMenuItem
            // 
            this.importTextFromFileToolStripMenuItem.Name = "importTextFromFileToolStripMenuItem";
            this.importTextFromFileToolStripMenuItem.Size = new System.Drawing.Size(381, 26);
            this.importTextFromFileToolStripMenuItem.Text = "Copy Text into Description Box...";
            this.importTextFromFileToolStripMenuItem.Click += new System.EventHandler(this.importTextFromFileToolStripMenuItem_Click);
            // 
            // lblMaxTitleLength
            // 
            this.lblMaxTitleLength.AutoSize = true;
            this.lblMaxTitleLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTitleLength.Location = new System.Drawing.Point(63, 17);
            this.lblMaxTitleLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxTitleLength.Name = "lblMaxTitleLength";
            this.lblMaxTitleLength.Size = new System.Drawing.Size(32, 18);
            this.lblMaxTitleLength.TabIndex = 20;
            this.lblMaxTitleLength.Text = "999";
            this.lblMaxTitleLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "/";
            // 
            // lblTitleLength
            // 
            this.lblTitleLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLength.Location = new System.Drawing.Point(4, 17);
            this.lblTitleLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleLength.Name = "lblTitleLength";
            this.lblTitleLength.Size = new System.Drawing.Size(32, 18);
            this.lblTitleLength.TabIndex = 22;
            this.lblTitleLength.Text = "000";
            this.lblTitleLength.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "/";
            // 
            // lblDescLength
            // 
            this.lblDescLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescLength.Location = new System.Drawing.Point(3, 14);
            this.lblDescLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescLength.Name = "lblDescLength";
            this.lblDescLength.Size = new System.Drawing.Size(65, 29);
            this.lblDescLength.TabIndex = 24;
            this.lblDescLength.Text = "0000";
            this.lblDescLength.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMaxDescLength
            // 
            this.lblMaxDescLength.AutoSize = true;
            this.lblMaxDescLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxDescLength.Location = new System.Drawing.Point(86, 14);
            this.lblMaxDescLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxDescLength.Name = "lblMaxDescLength";
            this.lblMaxDescLength.Size = new System.Drawing.Size(65, 29);
            this.lblMaxDescLength.TabIndex = 25;
            this.lblMaxDescLength.Text = "9999";
            // 
            // btnClearTitle
            // 
            this.btnClearTitle.Location = new System.Drawing.Point(666, 101);
            this.btnClearTitle.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearTitle.Name = "btnClearTitle";
            this.btnClearTitle.Size = new System.Drawing.Size(90, 28);
            this.btnClearTitle.TabIndex = 26;
            this.btnClearTitle.Text = "Clear Title";
            this.btnClearTitle.UseVisualStyleBackColor = true;
            this.btnClearTitle.Click += new System.EventHandler(this.btnClearTitle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMaxDescLength);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblDescLength);
            this.groupBox2.Location = new System.Drawing.Point(585, 390);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(159, 44);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTitleLength);
            this.groupBox3.Controls.Add(this.lblMaxTitleLength);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(561, 42);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(97, 41);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // btnAddTime
            // 
            this.btnAddTime.Location = new System.Drawing.Point(563, 202);
            this.btnAddTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(93, 49);
            this.btnAddTime.TabIndex = 29;
            this.btnAddTime.Text = "Add Timestamps";
            this.btnAddTime.UseVisualStyleBackColor = true;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // btnClearSavedTimes
            // 
            this.btnClearSavedTimes.Enabled = false;
            this.btnClearSavedTimes.Location = new System.Drawing.Point(664, 202);
            this.btnClearSavedTimes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearSavedTimes.Name = "btnClearSavedTimes";
            this.btnClearSavedTimes.Size = new System.Drawing.Size(93, 49);
            this.btnClearSavedTimes.TabIndex = 30;
            this.btnClearSavedTimes.Text = "Clear Saved Timestamps";
            this.btnClearSavedTimes.UseVisualStyleBackColor = true;
            this.btnClearSavedTimes.Click += new System.EventHandler(this.btnClearSavedTimes_Click);
            // 
            // frmDescriptionMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 453);
            this.Controls.Add(this.btnClearSavedTimes);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClearTitle);
            this.Controls.Add(this.btnCopyTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richDesc);
            this.Controls.Add(this.lblCopyNotif);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDescriptionMaker";
            this.Text = "Description Maker";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCopyNotif;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richDesc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ComboBox cboDateAchieved;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopyTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importWholeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTextFromFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog save;
        private System.Windows.Forms.Label lblMaxTitleLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitleLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescLength;
        private System.Windows.Forms.Label lblMaxDescLength;
        private System.Windows.Forms.Button btnClearTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Button btnClearSavedTimes;
    }
}

