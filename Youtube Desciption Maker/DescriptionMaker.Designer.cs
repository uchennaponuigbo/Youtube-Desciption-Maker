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
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnCopyTitle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importWholeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTextFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            // 
            // lblCopyNotif
            // 
            this.lblCopyNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyNotif.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCopyNotif.Location = new System.Drawing.Point(470, 42);
            this.lblCopyNotif.Name = "lblCopyNotif";
            this.lblCopyNotif.Size = new System.Drawing.Size(71, 39);
            this.lblCopyNotif.TabIndex = 0;
            this.lblCopyNotif.Text = "label1";
            this.lblCopyNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMM d, yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 38);
            this.dateTimePicker1.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 3, 0, 0, 0, 0);
            // 
            // richDesc
            // 
            this.richDesc.Location = new System.Drawing.Point(12, 75);
            this.richDesc.Name = "richDesc";
            this.richDesc.Size = new System.Drawing.Size(371, 235);
            this.richDesc.TabIndex = 5;
            this.richDesc.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cboDateAchieved);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(389, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 96);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
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
            this.cboDateAchieved.Location = new System.Drawing.Point(10, 64);
            this.cboDateAchieved.Name = "cboDateAchieved";
            this.cboDateAchieved.Size = new System.Drawing.Size(121, 21);
            this.cboDateAchieved.TabIndex = 10;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(390, 75);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(74, 23);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy Desc";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(390, 236);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear Desc";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter your description for your video.";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(76, 48);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(308, 20);
            this.txtTitle.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Video Title";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(389, 265);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(78, 23);
            this.btnClearAll.TabIndex = 17;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnCopyTitle
            // 
            this.btnCopyTitle.Location = new System.Drawing.Point(390, 46);
            this.btnCopyTitle.Name = "btnCopyTitle";
            this.btnCopyTitle.Size = new System.Drawing.Size(75, 23);
            this.btnCopyTitle.TabIndex = 18;
            this.btnCopyTitle.Text = "Copy Title";
            this.btnCopyTitle.UseVisualStyleBackColor = true;
            this.btnCopyTitle.Click += new System.EventHandler(this.btnCopyTitle_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // importWholeFileToolStripMenuItem
            // 
            this.importWholeFileToolStripMenuItem.Name = "importWholeFileToolStripMenuItem";
            this.importWholeFileToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.importWholeFileToolStripMenuItem.Text = "Import Whole File...";
            this.importWholeFileToolStripMenuItem.Click += new System.EventHandler(this.importWholeFileToolStripMenuItem_Click);
            // 
            // importTextFromFileToolStripMenuItem
            // 
            this.importTextFromFileToolStripMenuItem.Name = "importTextFromFileToolStripMenuItem";
            this.importTextFromFileToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.importTextFromFileToolStripMenuItem.Text = "Import Text from File...";
            this.importTextFromFileToolStripMenuItem.Click += new System.EventHandler(this.importTextFromFileToolStripMenuItem_Click);
            // 
            // frmDescriptionMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 323);
            this.Controls.Add(this.btnCopyTitle);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richDesc);
            this.Controls.Add(this.lblCopyNotif);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDescriptionMaker";
            this.Text = "Description Maker";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnCopyTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importWholeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTextFromFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog save;
    }
}

