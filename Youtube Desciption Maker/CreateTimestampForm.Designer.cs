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
            this.richSummary = new System.Windows.Forms.RichTextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.lblDescriptionSize = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTimestampSize = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTimestampAmount = new System.Windows.Forms.Label();
            this.chkSpaces = new System.Windows.Forms.CheckBox();
            this.listViewTimeStamps = new System.Windows.Forms.ListView();
            this.columnSpaces = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSummary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimestamp = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.btnSaveForLater = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(428, 307);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 52);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // richSummary
            // 
            this.richSummary.Location = new System.Drawing.Point(16, 96);
            this.richSummary.Margin = new System.Windows.Forms.Padding(4);
            this.richSummary.MaxLength = 2000;
            this.richSummary.Name = "richSummary";
            this.richSummary.Size = new System.Drawing.Size(405, 185);
            this.richSummary.TabIndex = 3;
            this.richSummary.Text = "";
            this.richSummary.TextChanged += new System.EventHandler(this.richSummary_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(107, 43);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.MaxLength = 200;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(314, 27);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTimeStampTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Summary";
            // 
            // btnFinish
            // 
            this.btnFinish.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFinish.Location = new System.Drawing.Point(998, 295);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(124, 36);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "Save and Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Title";
            // 
            // lblCurrentRichLength
            // 
            this.lblCurrentRichLength.AutoSize = true;
            this.lblCurrentRichLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRichLength.Location = new System.Drawing.Point(104, 73);
            this.lblCurrentRichLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentRichLength.Name = "lblCurrentRichLength";
            this.lblCurrentRichLength.Size = new System.Drawing.Size(40, 18);
            this.lblCurrentRichLength.TabIndex = 9;
            this.lblCurrentRichLength.Text = "0000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "/";
            // 
            // lblMaxRichLength
            // 
            this.lblMaxRichLength.AutoSize = true;
            this.lblMaxRichLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxRichLength.Location = new System.Drawing.Point(167, 73);
            this.lblMaxRichLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxRichLength.Name = "lblMaxRichLength";
            this.lblMaxRichLength.Size = new System.Drawing.Size(40, 18);
            this.lblMaxRichLength.TabIndex = 11;
            this.lblMaxRichLength.Text = "9999";
            // 
            // lblCurrentTextLength
            // 
            this.lblCurrentTextLength.AutoSize = true;
            this.lblCurrentTextLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTextLength.Location = new System.Drawing.Point(147, 14);
            this.lblCurrentTextLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentTextLength.Name = "lblCurrentTextLength";
            this.lblCurrentTextLength.Size = new System.Drawing.Size(32, 18);
            this.lblCurrentTextLength.TabIndex = 12;
            this.lblCurrentTextLength.Text = "000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "/";
            // 
            // lblMaxTextLength
            // 
            this.lblMaxTextLength.AutoSize = true;
            this.lblMaxTextLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTextLength.Location = new System.Drawing.Point(202, 14);
            this.lblMaxTextLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxTextLength.Name = "lblMaxTextLength";
            this.lblMaxTextLength.Size = new System.Drawing.Size(32, 18);
            this.lblMaxTextLength.TabIndex = 14;
            this.lblMaxTextLength.Text = "999";
            // 
            // btnExitForm
            // 
            this.btnExitForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitForm.Location = new System.Drawing.Point(998, 335);
            this.btnExitForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(124, 33);
            this.btnExitForm.TabIndex = 15;
            this.btnExitForm.Text = "Cancel and Exit";
            this.btnExitForm.UseVisualStyleBackColor = true;
            this.btnExitForm.Click += new System.EventHandler(this.btnExitForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "No. of Timestamps:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Description Size";
            // 
            // lblDescriptionSize
            // 
            this.lblDescriptionSize.AutoSize = true;
            this.lblDescriptionSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionSize.Location = new System.Drawing.Point(33, 55);
            this.lblDescriptionSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptionSize.Name = "lblDescriptionSize";
            this.lblDescriptionSize.Size = new System.Drawing.Size(56, 25);
            this.lblDescriptionSize.TabIndex = 20;
            this.lblDescriptionSize.Text = "9999";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(148, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 41);
            this.label8.TabIndex = 21;
            this.label8.Text = "Current Timestamp Size";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimestampSize
            // 
            this.lblTimestampSize.AutoSize = true;
            this.lblTimestampSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimestampSize.Location = new System.Drawing.Point(181, 55);
            this.lblTimestampSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimestampSize.Name = "lblTimestampSize";
            this.lblTimestampSize.Size = new System.Drawing.Size(56, 25);
            this.lblTimestampSize.TabIndex = 22;
            this.lblTimestampSize.Text = "9999";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(302, 55);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "9999";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(303, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 23);
            this.label11.TabIndex = 24;
            this.label11.Text = "Total";
            // 
            // lblTimestampAmount
            // 
            this.lblTimestampAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimestampAmount.Location = new System.Drawing.Point(383, 73);
            this.lblTimestampAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimestampAmount.Name = "lblTimestampAmount";
            this.lblTimestampAmount.Size = new System.Drawing.Size(24, 18);
            this.lblTimestampAmount.TabIndex = 25;
            this.lblTimestampAmount.Text = "99";
            this.lblTimestampAmount.TextChanged += new System.EventHandler(this.lblTimestampAmount_TextChanged);
            // 
            // chkSpaces
            // 
            this.chkSpaces.AutoSize = true;
            this.chkSpaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpaces.Location = new System.Drawing.Point(255, 14);
            this.chkSpaces.Margin = new System.Windows.Forms.Padding(4);
            this.chkSpaces.Name = "chkSpaces";
            this.chkSpaces.Size = new System.Drawing.Size(164, 22);
            this.chkSpaces.TabIndex = 31;
            this.chkSpaces.Text = "Include Spaces After";
            this.chkSpaces.UseVisualStyleBackColor = true;
            // 
            // listViewTimeStamps
            // 
            this.listViewTimeStamps.CheckBoxes = true;
            this.listViewTimeStamps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSpaces,
            this.columnIndex,
            this.columnTime,
            this.columnTitle,
            this.columnSummary});
            this.listViewTimeStamps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTimeStamps.FullRowSelect = true;
            this.listViewTimeStamps.GridLines = true;
            this.listViewTimeStamps.HideSelection = false;
            this.listViewTimeStamps.Location = new System.Drawing.Point(428, 18);
            this.listViewTimeStamps.MultiSelect = false;
            this.listViewTimeStamps.Name = "listViewTimeStamps";
            this.listViewTimeStamps.Size = new System.Drawing.Size(690, 270);
            this.listViewTimeStamps.TabIndex = 35;
            this.listViewTimeStamps.UseCompatibleStateImageBehavior = false;
            this.listViewTimeStamps.View = System.Windows.Forms.View.Details;
            this.listViewTimeStamps.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewTimeStamps_ColumnWidthChanging);
            this.listViewTimeStamps.SelectedIndexChanged += new System.EventHandler(this.listViewTimeStamps_SelectedIndexChanged);
            // 
            // columnSpaces
            // 
            this.columnSpaces.Text = "S";
            this.columnSpaces.Width = 22;
            // 
            // columnIndex
            // 
            this.columnIndex.Text = "Index";
            this.columnIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnIndex.Width = 46;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Time";
            this.columnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTime.Width = 70;
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            this.columnTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTitle.Width = 220;
            // 
            // columnSummary
            // 
            this.columnSummary.Text = "Summary";
            this.columnSummary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSummary.Width = 328;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblDescriptionSize);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblTimestampSize);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(19, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 93);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // txtTimestamp
            // 
            this.txtTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimestamp.Location = new System.Drawing.Point(19, 43);
            this.txtTimestamp.MaxLength = 8;
            this.txtTimestamp.Name = "txtTimestamp";
            this.txtTimestamp.Size = new System.Drawing.Size(79, 27);
            this.txtTimestamp.TabIndex = 0;
            this.txtTimestamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimestamp.Enter += new System.EventHandler(this.txtTimestamp_Enter);
            this.txtTimestamp.Leave += new System.EventHandler(this.txtTimestamp_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(544, 307);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 52);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTemplate.Location = new System.Drawing.Point(660, 307);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(100, 52);
            this.btnSaveTemplate.TabIndex = 38;
            this.btnSaveTemplate.Text = "Save as Template";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            // 
            // btnSaveForLater
            // 
            this.btnSaveForLater.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnSaveForLater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveForLater.Location = new System.Drawing.Point(891, 307);
            this.btnSaveForLater.Name = "btnSaveForLater";
            this.btnSaveForLater.Size = new System.Drawing.Size(100, 52);
            this.btnSaveForLater.TabIndex = 39;
            this.btnSaveForLater.Text = "Save For Later";
            this.btnSaveForLater.UseVisualStyleBackColor = true;
            this.btnSaveForLater.Click += new System.EventHandler(this.btnSaveForLater_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(775, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 52);
            this.button1.TabIndex = 40;
            this.button1.Text = "Load Template";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CreateTimestampForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExitForm;
            this.ClientSize = new System.Drawing.Size(1134, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveForLater);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTimestamp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listViewTimeStamps);
            this.Controls.Add(this.chkSpaces);
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
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.richSummary);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CreateTimestampForm";
            this.Text = "Add Timestamp";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox richSummary;
        private System.Windows.Forms.TextBox txtTitle;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDescriptionSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTimestampSize;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTimestampAmount;
        private System.Windows.Forms.CheckBox chkSpaces;
        private System.Windows.Forms.ListView listViewTimeStamps;
        private System.Windows.Forms.ColumnHeader columnIndex;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnSummary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimestamp;
        private System.Windows.Forms.ColumnHeader columnSpaces;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.Button btnSaveForLater;
        private System.Windows.Forms.Button button1;
    }
}