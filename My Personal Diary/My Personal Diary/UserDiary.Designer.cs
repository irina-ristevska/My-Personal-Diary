namespace My_Personal_Diary
{
    partial class UserDiary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDiary));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnReminder = new System.Windows.Forms.Button();
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.ddlFontPicker = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.ddlSizePick = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.rtEditorDiary = new System.Windows.Forms.RichTextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblDateNewEntry = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHelloMessage = new System.Windows.Forms.Label();
            this.lbThisDateEntries = new System.Windows.Forms.ListBox();
            this.pnlListBox = new System.Windows.Forms.Panel();
            this.lblPickDateListBox = new System.Windows.Forms.Label();
            this.pbCalendarIcon = new System.Windows.Forms.PictureBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tsbFontColor = new System.Windows.Forms.ToolStripButton();
            this.tsbFontHighLighter = new System.Windows.Forms.ToolStripButton();
            this.pbUserIcon = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.pnlListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalendarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.pnlTop.Controls.Add(this.btnReminder);
            this.pnlTop.Controls.Add(this.btnEntry);
            this.pnlTop.Controls.Add(this.btnLogOut);
            this.pnlTop.Controls.Add(this.pbLogo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(926, 58);
            this.pnlTop.TabIndex = 0;
            // 
            // btnReminder
            // 
            this.btnReminder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReminder.BackColor = System.Drawing.Color.Transparent;
            this.btnReminder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReminder.ForeColor = System.Drawing.Color.White;
            this.btnReminder.Location = new System.Drawing.Point(593, 12);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(105, 34);
            this.btnReminder.TabIndex = 3;
            this.btnReminder.Text = "+ Reminder";
            this.btnReminder.UseVisualStyleBackColor = false;
            // 
            // btnEntry
            // 
            this.btnEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntry.BackColor = System.Drawing.Color.Transparent;
            this.btnEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.ForeColor = System.Drawing.Color.White;
            this.btnEntry.Location = new System.Drawing.Point(713, 12);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(93, 34);
            this.btnEntry.TabIndex = 2;
            this.btnEntry.Text = "+ Entry";
            this.btnEntry.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(821, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(93, 34);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.pnlListBox);
            this.panel1.Controls.Add(this.lbThisDateEntries);
            this.panel1.Controls.Add(this.lblHelloMessage);
            this.panel1.Controls.Add(this.pbUserIcon);
            this.panel1.Controls.Add(this.monthCalendar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 403);
            this.panel1.TabIndex = 0;
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.Color.Maroon;
            this.monthCalendar.Cursor = System.Windows.Forms.Cursors.Default;
            this.monthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar.Location = new System.Drawing.Point(14, 71);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.Maroon;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.panel3.Controls.Add(this.pbCalendarIcon);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.toolStrip);
            this.panel3.Controls.Add(this.rtEditorDiary);
            this.panel3.Controls.Add(this.tbTitle);
            this.panel3.Controls.Add(this.lblDateNewEntry);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(254, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 403);
            this.panel3.TabIndex = 2;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(143)))), ((int)(((byte)(163)))));
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.tsbFontColor,
            this.tsbFontHighLighter,
            this.toolStripLabel4,
            this.toolStripSeparator2,
            this.toolStripLabel5,
            this.ddlFontPicker,
            this.toolStripLabel6,
            this.ddlSizePick,
            this.toolStripLabel8});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(672, 40);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(24, 37);
            this.toolStripLabel1.Text = " ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(10, 37);
            this.toolStripLabel2.Text = " ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(10, 37);
            this.toolStripLabel3.Text = " ";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(10, 37);
            this.toolStripLabel4.Text = " ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(10, 37);
            this.toolStripLabel5.Text = " ";
            // 
            // ddlFontPicker
            // 
            this.ddlFontPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFontPicker.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddlFontPicker.Name = "ddlFontPicker";
            this.ddlFontPicker.Size = new System.Drawing.Size(150, 40);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(10, 37);
            this.toolStripLabel6.Text = " ";
            // 
            // ddlSizePick
            // 
            this.ddlSizePick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSizePick.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddlSizePick.Name = "ddlSizePick";
            this.ddlSizePick.Size = new System.Drawing.Size(75, 40);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(10, 37);
            this.toolStripLabel8.Text = " ";
            // 
            // rtEditorDiary
            // 
            this.rtEditorDiary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtEditorDiary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtEditorDiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtEditorDiary.Location = new System.Drawing.Point(18, 137);
            this.rtEditorDiary.Name = "rtEditorDiary";
            this.rtEditorDiary.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtEditorDiary.Size = new System.Drawing.Size(642, 254);
            this.rtEditorDiary.TabIndex = 3;
            this.rtEditorDiary.Text = "";
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.Salmon;
            this.tbTitle.Location = new System.Drawing.Point(18, 90);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(642, 23);
            this.tbTitle.TabIndex = 2;
            this.tbTitle.Text = " Diary Title";
            // 
            // lblDateNewEntry
            // 
            this.lblDateNewEntry.AutoSize = true;
            this.lblDateNewEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNewEntry.ForeColor = System.Drawing.Color.Salmon;
            this.lblDateNewEntry.Location = new System.Drawing.Point(47, 54);
            this.lblDateNewEntry.Name = "lblDateNewEntry";
            this.lblDateNewEntry.Size = new System.Drawing.Size(139, 20);
            this.lblDateNewEntry.TabIndex = 1;
            this.lblDateNewEntry.Text = "6.6.2016 Saturday";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(143)))), ((int)(((byte)(163)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(567, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblHelloMessage
            // 
            this.lblHelloMessage.AutoSize = true;
            this.lblHelloMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHelloMessage.Location = new System.Drawing.Point(76, 14);
            this.lblHelloMessage.Name = "lblHelloMessage";
            this.lblHelloMessage.Size = new System.Drawing.Size(117, 40);
            this.lblHelloMessage.TabIndex = 2;
            this.lblHelloMessage.Text = "Hello, User!\r\nWelcome back.\r\n";
            // 
            // lbThisDateEntries
            // 
            this.lbThisDateEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.lbThisDateEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbThisDateEntries.FormattingEnabled = true;
            this.lbThisDateEntries.Location = new System.Drawing.Point(14, 272);
            this.lbThisDateEntries.Name = "lbThisDateEntries";
            this.lbThisDateEntries.Size = new System.Drawing.Size(227, 104);
            this.lbThisDateEntries.TabIndex = 3;
            // 
            // pnlListBox
            // 
            this.pnlListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListBox.BackColor = System.Drawing.Color.Firebrick;
            this.pnlListBox.Controls.Add(this.lblPickDateListBox);
            this.pnlListBox.Location = new System.Drawing.Point(14, 251);
            this.pnlListBox.Name = "pnlListBox";
            this.pnlListBox.Size = new System.Drawing.Size(227, 21);
            this.pnlListBox.TabIndex = 4;
            // 
            // lblPickDateListBox
            // 
            this.lblPickDateListBox.AutoSize = true;
            this.lblPickDateListBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPickDateListBox.Location = new System.Drawing.Point(4, 4);
            this.lblPickDateListBox.Name = "lblPickDateListBox";
            this.lblPickDateListBox.Size = new System.Drawing.Size(174, 13);
            this.lblPickDateListBox.TabIndex = 0;
            this.lblPickDateListBox.Text = "Selected Date // On calendar click";
            // 
            // pbCalendarIcon
            // 
            this.pbCalendarIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbCalendarIcon.Image")));
            this.pbCalendarIcon.Location = new System.Drawing.Point(18, 51);
            this.pbCalendarIcon.Name = "pbCalendarIcon";
            this.pbCalendarIcon.Size = new System.Drawing.Size(26, 26);
            this.pbCalendarIcon.TabIndex = 5;
            this.pbCalendarIcon.TabStop = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::My_Personal_Diary.Properties.Resources.bold;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 37);
            this.toolStripButton1.Text = "tsbBold";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::My_Personal_Diary.Properties.Resources.italicc;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 37);
            this.toolStripButton2.Text = "tsbItalic";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::My_Personal_Diary.Properties.Resources.underline;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 37);
            this.toolStripButton3.Text = "tsbUnderline";
            // 
            // tsbFontColor
            // 
            this.tsbFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFontColor.Image = global::My_Personal_Diary.Properties.Resources.color;
            this.tsbFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFontColor.Name = "tsbFontColor";
            this.tsbFontColor.Size = new System.Drawing.Size(23, 37);
            this.tsbFontColor.Text = "toolStripButton4";
            // 
            // tsbFontHighLighter
            // 
            this.tsbFontHighLighter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFontHighLighter.Image = global::My_Personal_Diary.Properties.Resources.highlight;
            this.tsbFontHighLighter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFontHighLighter.Name = "tsbFontHighLighter";
            this.tsbFontHighLighter.Size = new System.Drawing.Size(23, 37);
            this.tsbFontHighLighter.Text = "toolStripButton5";
            // 
            // pbUserIcon
            // 
            this.pbUserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUserIcon.Image = global::My_Personal_Diary.Properties.Resources.User_Icon;
            this.pbUserIcon.InitialImage = null;
            this.pbUserIcon.Location = new System.Drawing.Point(14, 14);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.Size = new System.Drawing.Size(56, 50);
            this.pbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUserIcon.TabIndex = 1;
            this.pbUserIcon.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::My_Personal_Diary.Properties.Resources.LogoSmall;
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(9, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(131, 50);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // UserDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(926, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Name = "UserDiary";
            this.Text = "UserDiary";
            this.pnlTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.pnlListBox.ResumeLayout(false);
            this.pnlListBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalendarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnReminder;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbUserIcon;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblDateNewEntry;
        private System.Windows.Forms.RichTextBox rtEditorDiary;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton tsbFontColor;
        private System.Windows.Forms.ToolStripButton tsbFontHighLighter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox ddlFontPicker;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox ddlSizePick;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblHelloMessage;
        private System.Windows.Forms.ListBox lbThisDateEntries;
        private System.Windows.Forms.Panel pnlListBox;
        private System.Windows.Forms.Label lblPickDateListBox;
        private System.Windows.Forms.PictureBox pbCalendarIcon;
    }
}