﻿namespace My_Personal_Diary
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDiary));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnEntry = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btEditEntry = new System.Windows.Forms.Button();
            this.btDeleteE = new System.Windows.Forms.Button();
            this.pnlListBox = new System.Windows.Forms.Panel();
            this.lblPickDateListBox = new System.Windows.Forms.Label();
            this.lbThisDateEntries = new System.Windows.Forms.ListBox();
            this.lblHelloMessage = new System.Windows.Forms.Label();
            this.pbUserIcon = new System.Windows.Forms.PictureBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbCalendarIcon = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsBold = new System.Windows.Forms.ToolStripButton();
            this.tsItalic = new System.Windows.Forms.ToolStripButton();
            this.tsUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsbFontColor = new System.Windows.Forms.ToolStripButton();
            this.tsbFontHighLighter = new System.Windows.Forms.ToolStripButton();
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
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.ttTips = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalendarIcon)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.pnlTop.Controls.Add(this.btnSave);
            this.pnlTop.Controls.Add(this.btnLogOut);
            this.pnlTop.Controls.Add(this.pbLogo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1066, 58);
            this.pnlTop.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(143)))), ((int)(((byte)(163)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(813, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 34);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save All ";
            this.ttTips.SetToolTip(this.btnSave, "Save all the changes made to your Diary file");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(143)))), ((int)(((byte)(163)))));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(961, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(93, 34);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log out";
            this.ttTips.SetToolTip(this.btnLogOut, "Log out and close");
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            // btnEntry
            // 
            this.btnEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(143)))), ((int)(((byte)(163)))));
            this.btnEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.ForeColor = System.Drawing.Color.White;
            this.btnEntry.Location = new System.Drawing.Point(686, 5);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(93, 28);
            this.btnEntry.TabIndex = 2;
            this.btnEntry.Text = "+ Entry";
            this.ttTips.SetToolTip(this.btnEntry, "Click to open a new blank entry");
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.btEditEntry);
            this.panel1.Controls.Add(this.btDeleteE);
            this.panel1.Controls.Add(this.pnlListBox);
            this.panel1.Controls.Add(this.lbThisDateEntries);
            this.panel1.Controls.Add(this.lblHelloMessage);
            this.panel1.Controls.Add(this.pbUserIcon);
            this.panel1.Controls.Add(this.monthCalendar);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 585);
            this.panel1.TabIndex = 0;
            // 
            // btEditEntry
            // 
            this.btEditEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.btEditEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditEntry.ForeColor = System.Drawing.Color.White;
            this.btEditEntry.Location = new System.Drawing.Point(14, 532);
            this.btEditEntry.Name = "btEditEntry";
            this.btEditEntry.Size = new System.Drawing.Size(120, 34);
            this.btEditEntry.TabIndex = 5;
            this.btEditEntry.Text = "Edit Entry";
            this.btEditEntry.UseVisualStyleBackColor = false;
            this.btEditEntry.Click += new System.EventHandler(this.btEditEntry_Click);
            // 
            // btDeleteE
            // 
            this.btDeleteE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteE.ForeColor = System.Drawing.Color.White;
            this.btDeleteE.Location = new System.Drawing.Point(144, 532);
            this.btDeleteE.Name = "btDeleteE";
            this.btDeleteE.Size = new System.Drawing.Size(120, 34);
            this.btDeleteE.TabIndex = 5;
            this.btDeleteE.Text = "Delete Entry";
            this.btDeleteE.UseVisualStyleBackColor = true;
            this.btDeleteE.Click += new System.EventHandler(this.btDeleteE_Click);
            // 
            // pnlListBox
            // 
            this.pnlListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(143)))), ((int)(((byte)(163)))));
            this.pnlListBox.Controls.Add(this.lblPickDateListBox);
            this.pnlListBox.Location = new System.Drawing.Point(14, 334);
            this.pnlListBox.Name = "pnlListBox";
            this.pnlListBox.Size = new System.Drawing.Size(250, 27);
            this.pnlListBox.TabIndex = 4;
            // 
            // lblPickDateListBox
            // 
            this.lblPickDateListBox.AutoSize = true;
            this.lblPickDateListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickDateListBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPickDateListBox.Location = new System.Drawing.Point(0, 2);
            this.lblPickDateListBox.Name = "lblPickDateListBox";
            this.lblPickDateListBox.Size = new System.Drawing.Size(247, 20);
            this.lblPickDateListBox.TabIndex = 0;
            this.lblPickDateListBox.Text = "Selected Date // On calendar click";
            // 
            // lbThisDateEntries
            // 
            this.lbThisDateEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.lbThisDateEntries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbThisDateEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThisDateEntries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.lbThisDateEntries.FormattingEnabled = true;
            this.lbThisDateEntries.ItemHeight = 20;
            this.lbThisDateEntries.Location = new System.Drawing.Point(14, 360);
            this.lbThisDateEntries.Name = "lbThisDateEntries";
            this.lbThisDateEntries.Size = new System.Drawing.Size(250, 162);
            this.lbThisDateEntries.TabIndex = 3;
            this.ttTips.SetToolTip(this.lbThisDateEntries, "Click to select an Entry and view it in the editor");
            this.lbThisDateEntries.SelectedIndexChanged += new System.EventHandler(this.lbThisDateEntries_SelectedIndexChanged);
            this.lbThisDateEntries.SelectedValueChanged += new System.EventHandler(this.lbThisDateEntries_SelectedValueChanged);
            // 
            // lblHelloMessage
            // 
            this.lblHelloMessage.AutoSize = true;
            this.lblHelloMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHelloMessage.Location = new System.Drawing.Point(121, 45);
            this.lblHelloMessage.Name = "lblHelloMessage";
            this.lblHelloMessage.Size = new System.Drawing.Size(117, 40);
            this.lblHelloMessage.TabIndex = 2;
            this.lblHelloMessage.Text = "Hello, User!\r\nWelcome back.\r\n";
            // 
            // pbUserIcon
            // 
            this.pbUserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUserIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUserIcon.Image = global::My_Personal_Diary.Properties.Resources.User_Icon;
            this.pbUserIcon.InitialImage = null;
            this.pbUserIcon.Location = new System.Drawing.Point(15, 14);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.Size = new System.Drawing.Size(101, 99);
            this.pbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserIcon.TabIndex = 1;
            this.pbUserIcon.TabStop = false;
            this.ttTips.SetToolTip(this.pbUserIcon, "Click to change the User Icon");
            this.pbUserIcon.Click += new System.EventHandler(this.pbUserIcon_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.monthCalendar.Cursor = System.Windows.Forms.Cursors.Default;
            this.monthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.monthCalendar.Location = new System.Drawing.Point(25, 142);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.Salmon;
            this.ttTips.SetToolTip(this.monthCalendar, "Click to choose a date");
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(15, 131);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(249, 182);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.panel3.Controls.Add(this.pbCalendarIcon);
            this.panel3.Controls.Add(this.btnEntry);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.toolStrip);
            this.panel3.Controls.Add(this.rtEditorDiary);
            this.panel3.Controls.Add(this.tbTitle);
            this.panel3.Controls.Add(this.lblDateNewEntry);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(275, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 585);
            this.panel3.TabIndex = 2;
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
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(213)))), ((int)(((byte)(199)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.btnClose.Location = new System.Drawing.Point(686, 544);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 31);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Save Entry";
            this.ttTips.SetToolTip(this.btnClose, "Save the entry in the list");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(143)))), ((int)(((byte)(163)))));
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsBold,
            this.tsItalic,
            this.tsUnderline,
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
            this.toolStrip.Size = new System.Drawing.Size(791, 40);
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
            // tsBold
            // 
            this.tsBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBold.Image = global::My_Personal_Diary.Properties.Resources.bold;
            this.tsBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBold.Name = "tsBold";
            this.tsBold.Size = new System.Drawing.Size(23, 37);
            this.tsBold.Text = "Make the text bold";
            this.tsBold.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsItalic
            // 
            this.tsItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsItalic.Image = global::My_Personal_Diary.Properties.Resources.italicc;
            this.tsItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsItalic.Name = "tsItalic";
            this.tsItalic.Size = new System.Drawing.Size(23, 37);
            this.tsItalic.Text = "Make the text italic";
            this.tsItalic.Click += new System.EventHandler(this.tsItalic_Click);
            // 
            // tsUnderline
            // 
            this.tsUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUnderline.Image = global::My_Personal_Diary.Properties.Resources.underline;
            this.tsUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUnderline.Name = "tsUnderline";
            this.tsUnderline.Size = new System.Drawing.Size(23, 37);
            this.tsUnderline.Text = "Make the text underlined";
            this.tsUnderline.Click += new System.EventHandler(this.tsUnderline_Click);
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
            // tsbFontColor
            // 
            this.tsbFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFontColor.Image = global::My_Personal_Diary.Properties.Resources.color;
            this.tsbFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFontColor.Name = "tsbFontColor";
            this.tsbFontColor.Size = new System.Drawing.Size(23, 37);
            this.tsbFontColor.Text = "Change the color of the text";
            this.tsbFontColor.Click += new System.EventHandler(this.tsbFontColor_Click);
         
            // 
            // tsbFontHighLighter
            // 
            this.tsbFontHighLighter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFontHighLighter.Image = global::My_Personal_Diary.Properties.Resources.highlight;
            this.tsbFontHighLighter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFontHighLighter.Name = "tsbFontHighLighter";
            this.tsbFontHighLighter.Size = new System.Drawing.Size(23, 37);
            this.tsbFontHighLighter.Text = "Highlight the text";
            this.tsbFontHighLighter.Click += new System.EventHandler(this.tsbFontHighLighter_Click);
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
            this.ddlFontPicker.AutoToolTip = true;
            this.ddlFontPicker.BackColor = System.Drawing.Color.White;
            this.ddlFontPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFontPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlFontPicker.Name = "ddlFontPicker";
            this.ddlFontPicker.Size = new System.Drawing.Size(180, 40);
            this.ddlFontPicker.ToolTipText = "Change the font of the text";
            this.ddlFontPicker.SelectedIndexChanged += new System.EventHandler(this.ddlFontPicker_SelectedIndexChanged);
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
            this.ddlSizePick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlSizePick.Name = "ddlSizePick";
            this.ddlSizePick.Size = new System.Drawing.Size(75, 40);
            this.ddlSizePick.ToolTipText = "Change the size of the text";
            this.ddlSizePick.SelectedIndexChanged += new System.EventHandler(this.ddlSizePick_SelectedIndexChanged);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(10, 37);
            this.toolStripLabel8.Text = " ";
            // 
            // rtEditorDiary
            // 
            this.rtEditorDiary.AcceptsTab = true;
            this.rtEditorDiary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtEditorDiary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtEditorDiary.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtEditorDiary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.rtEditorDiary.Location = new System.Drawing.Point(18, 142);
            this.rtEditorDiary.Name = "rtEditorDiary";
            this.rtEditorDiary.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtEditorDiary.Size = new System.Drawing.Size(761, 401);
            this.rtEditorDiary.TabIndex = 3;
            this.rtEditorDiary.Text = "";
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.Salmon;
            this.tbTitle.Location = new System.Drawing.Point(18, 90);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(761, 28);
            this.tbTitle.TabIndex = 2;
            this.tbTitle.Text = "Diary Title";
            this.tbTitle.Click += new System.EventHandler(this.tbTitle_Click);
            this.tbTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitle_Validating);
            // 
            // lblDateNewEntry
            // 
            this.lblDateNewEntry.AutoSize = true;
            this.lblDateNewEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNewEntry.ForeColor = System.Drawing.Color.Salmon;
            this.lblDateNewEntry.Location = new System.Drawing.Point(49, 54);
            this.lblDateNewEntry.Name = "lblDateNewEntry";
            this.lblDateNewEntry.Size = new System.Drawing.Size(84, 20);
            this.lblDateNewEntry.TabIndex = 1;
            this.lblDateNewEntry.Text = "08-May-16";
            // 
            // cdColor
            // 
            this.cdColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            // 
            // UserDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1066, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlTop);
            this.MinimumSize = new System.Drawing.Size(1082, 682);
            this.Name = "UserDiary";
            this.Text = "UserDiary";
            this.Load += new System.EventHandler(this.UserDiary_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlListBox.ResumeLayout(false);
            this.pnlListBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalendarIcon)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbUserIcon;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblDateNewEntry;
        private System.Windows.Forms.RichTextBox rtEditorDiary;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsBold;
        private System.Windows.Forms.ToolStripButton tsItalic;
        private System.Windows.Forms.ToolStripButton tsUnderline;
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
        private System.Windows.Forms.ColorDialog cdColor;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btDeleteE;
        private System.Windows.Forms.Button btEditEntry;
        private System.Windows.Forms.ToolTip ttTips;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}