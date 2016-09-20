namespace Nightfall
{
    partial class frmConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsole));
            this.muConControl = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ttsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ttsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.ttsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ttsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ttsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnaMenu = new System.Windows.Forms.Panel();
            this.lblNightDay = new System.Windows.Forms.Label();
            this.panRoomDesc = new System.Windows.Forms.Panel();
            this.lblItem4 = new System.Windows.Forms.Label();
            this.lblItem3 = new System.Windows.Forms.Label();
            this.lblItem2 = new System.Windows.Forms.Label();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.lblEnemy4 = new System.Windows.Forms.Label();
            this.lblEnemy3 = new System.Windows.Forms.Label();
            this.lblEnemy2 = new System.Windows.Forms.Label();
            this.lblEnemy1 = new System.Windows.Forms.Label();
            this.lblRoomTitle = new System.Windows.Forms.Label();
            this.lblRoomDesc = new System.Windows.Forms.Label();
            this.panMap = new System.Windows.Forms.PictureBox();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.panParty = new System.Windows.Forms.Panel();
            this.picGender = new System.Windows.Forms.PictureBox();
            this.lblNameAllyTwo = new System.Windows.Forms.Label();
            this.lblNameAllyOne = new System.Windows.Forms.Label();
            this.pbarHealthAllyTwo = new System.Windows.Forms.ProgressBar();
            this.pbarHealthAllyOne = new System.Windows.Forms.ProgressBar();
            this.lblYourName = new System.Windows.Forms.Label();
            this.pbarManaYours = new System.Windows.Forms.ProgressBar();
            this.pbarHealthYours = new System.Windows.Forms.ProgressBar();
            this.lblPatry = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnRunAway = new System.Windows.Forms.Button();
            this.btnUseItem = new System.Windows.Forms.Button();
            this.btnTalk = new System.Windows.Forms.Button();
            this.btnInspect = new System.Windows.Forms.Button();
            this.btnGrabItem = new System.Windows.Forms.Button();
            this.btnDropItem = new System.Windows.Forms.Button();
            this.btnSpell = new System.Windows.Forms.Button();
            this.lblInteractions = new System.Windows.Forms.Label();
            this.lblItemInteractions = new System.Windows.Forms.Label();
            this.lblBattle = new System.Windows.Forms.Label();
            this.lbxBattle = new System.Windows.Forms.ListBox();
            this.btnNav1 = new System.Windows.Forms.Button();
            this.btnNav2 = new System.Windows.Forms.Button();
            this.btnNav3 = new System.Windows.Forms.Button();
            this.picModeBattle = new System.Windows.Forms.PictureBox();
            this.lblNav = new System.Windows.Forms.Label();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.muConControl.SuspendLayout();
            this.panRoomDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panMap)).BeginInit();
            this.panParty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModeBattle)).BeginInit();
            this.SuspendLayout();
            // 
            // muConControl
            // 
            this.muConControl.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.muConControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmAbout});
            this.muConControl.Location = new System.Drawing.Point(0, 0);
            this.muConControl.Name = "muConControl";
            this.muConControl.Size = new System.Drawing.Size(842, 28);
            this.muConControl.TabIndex = 0;
            this.muConControl.Text = "menuConsole";
            this.muConControl.MouseLeave += new System.EventHandler(this.menuConsole_MouseLeave);
            this.muConControl.MouseHover += new System.EventHandler(this.menuConsole_MouseHover);
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttsmiNew,
            this.ttsmiLoad,
            this.ttsmiSave,
            this.ttsmiQuit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(44, 24);
            this.tsmiFile.Text = "File";
            // 
            // ttsmiNew
            // 
            this.ttsmiNew.Name = "ttsmiNew";
            this.ttsmiNew.Size = new System.Drawing.Size(117, 26);
            this.ttsmiNew.Text = "New";
            this.ttsmiNew.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // ttsmiLoad
            // 
            this.ttsmiLoad.Name = "ttsmiLoad";
            this.ttsmiLoad.Size = new System.Drawing.Size(117, 26);
            this.ttsmiLoad.Text = "Load";
            this.ttsmiLoad.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // ttsmiSave
            // 
            this.ttsmiSave.Name = "ttsmiSave";
            this.ttsmiSave.Size = new System.Drawing.Size(117, 26);
            this.ttsmiSave.Text = "Save";
            this.ttsmiSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // ttsmiQuit
            // 
            this.ttsmiQuit.Name = "ttsmiQuit";
            this.ttsmiQuit.Size = new System.Drawing.Size(117, 26);
            this.ttsmiQuit.Text = "Quit";
            this.ttsmiQuit.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // tsmAbout
            // 
            this.tsmAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttsmiAbout});
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(62, 24);
            this.tsmAbout.Text = "About";
            // 
            // ttsmiAbout
            // 
            this.ttsmiAbout.Name = "ttsmiAbout";
            this.ttsmiAbout.Size = new System.Drawing.Size(212, 26);
            this.ttsmiAbout.Text = "About this project...";
            this.ttsmiAbout.Click += new System.EventHandler(this.aboutThisProjectToolStripMenuItem_Click);
            // 
            // pnaMenu
            // 
            this.pnaMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnaMenu.Location = new System.Drawing.Point(0, 3);
            this.pnaMenu.Name = "pnaMenu";
            this.pnaMenu.Size = new System.Drawing.Size(842, 25);
            this.pnaMenu.TabIndex = 1;
            this.pnaMenu.MouseEnter += new System.EventHandler(this.menuPanel_MouseEnter);
            // 
            // lblNightDay
            // 
            this.lblNightDay.AutoSize = true;
            this.lblNightDay.Font = new System.Drawing.Font("Poor Richard", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightDay.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNightDay.Location = new System.Drawing.Point(12, 45);
            this.lblNightDay.Name = "lblNightDay";
            this.lblNightDay.Size = new System.Drawing.Size(237, 68);
            this.lblNightDay.TabIndex = 2;
            this.lblNightDay.Text = "Nightfall";
            // 
            // panRoomDesc
            // 
            this.panRoomDesc.BackgroundImage = global::Nightfall.Properties.Resources.robotic;
            this.panRoomDesc.Controls.Add(this.lblItem4);
            this.panRoomDesc.Controls.Add(this.lblItem3);
            this.panRoomDesc.Controls.Add(this.lblItem2);
            this.panRoomDesc.Controls.Add(this.lblItem1);
            this.panRoomDesc.Controls.Add(this.lblEnemy4);
            this.panRoomDesc.Controls.Add(this.lblEnemy3);
            this.panRoomDesc.Controls.Add(this.lblEnemy2);
            this.panRoomDesc.Controls.Add(this.lblEnemy1);
            this.panRoomDesc.Controls.Add(this.lblRoomTitle);
            this.panRoomDesc.Controls.Add(this.lblRoomDesc);
            this.panRoomDesc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panRoomDesc.Location = new System.Drawing.Point(229, 45);
            this.panRoomDesc.Name = "panRoomDesc";
            this.panRoomDesc.Size = new System.Drawing.Size(579, 312);
            this.panRoomDesc.TabIndex = 3;
            // 
            // lblItem4
            // 
            this.lblItem4.AutoSize = true;
            this.lblItem4.BackColor = System.Drawing.Color.Transparent;
            this.lblItem4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblItem4.Location = new System.Drawing.Point(400, 277);
            this.lblItem4.Name = "lblItem4";
            this.lblItem4.Size = new System.Drawing.Size(93, 20);
            this.lblItem4.TabIndex = 16;
            this.lblItem4.Text = "default text";
            this.lblItem4.Click += new System.EventHandler(this.lblItem4_Click);
            // 
            // lblItem3
            // 
            this.lblItem3.AutoSize = true;
            this.lblItem3.BackColor = System.Drawing.Color.Transparent;
            this.lblItem3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblItem3.Location = new System.Drawing.Point(400, 262);
            this.lblItem3.Name = "lblItem3";
            this.lblItem3.Size = new System.Drawing.Size(93, 20);
            this.lblItem3.TabIndex = 15;
            this.lblItem3.Text = "default text";
            this.lblItem3.Click += new System.EventHandler(this.lblItem3_Click);
            // 
            // lblItem2
            // 
            this.lblItem2.AutoSize = true;
            this.lblItem2.BackColor = System.Drawing.Color.Transparent;
            this.lblItem2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblItem2.Location = new System.Drawing.Point(400, 247);
            this.lblItem2.Name = "lblItem2";
            this.lblItem2.Size = new System.Drawing.Size(93, 20);
            this.lblItem2.TabIndex = 14;
            this.lblItem2.Text = "default text";
            this.lblItem2.Click += new System.EventHandler(this.lblItem2_Click);
            // 
            // lblItem1
            // 
            this.lblItem1.AutoSize = true;
            this.lblItem1.BackColor = System.Drawing.Color.Transparent;
            this.lblItem1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblItem1.Location = new System.Drawing.Point(400, 230);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Size = new System.Drawing.Size(147, 20);
            this.lblItem1.TabIndex = 13;
            this.lblItem1.Text = "default text (items)";
            this.lblItem1.Click += new System.EventHandler(this.lblItem1_Click);
            // 
            // lblEnemy4
            // 
            this.lblEnemy4.AutoSize = true;
            this.lblEnemy4.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemy4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEnemy4.Location = new System.Drawing.Point(16, 277);
            this.lblEnemy4.Name = "lblEnemy4";
            this.lblEnemy4.Size = new System.Drawing.Size(0, 20);
            this.lblEnemy4.TabIndex = 12;
            this.lblEnemy4.Click += new System.EventHandler(this.lblEnemy4_Click);
            // 
            // lblEnemy3
            // 
            this.lblEnemy3.AutoSize = true;
            this.lblEnemy3.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemy3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEnemy3.Location = new System.Drawing.Point(16, 262);
            this.lblEnemy3.Name = "lblEnemy3";
            this.lblEnemy3.Size = new System.Drawing.Size(0, 20);
            this.lblEnemy3.TabIndex = 11;
            this.lblEnemy3.Click += new System.EventHandler(this.lblEnemy3_Click);
            // 
            // lblEnemy2
            // 
            this.lblEnemy2.AutoSize = true;
            this.lblEnemy2.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemy2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEnemy2.Location = new System.Drawing.Point(16, 247);
            this.lblEnemy2.Name = "lblEnemy2";
            this.lblEnemy2.Size = new System.Drawing.Size(0, 20);
            this.lblEnemy2.TabIndex = 10;
            this.lblEnemy2.Click += new System.EventHandler(this.lblEnemy2_Click);
            // 
            // lblEnemy1
            // 
            this.lblEnemy1.AutoSize = true;
            this.lblEnemy1.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemy1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEnemy1.Location = new System.Drawing.Point(16, 230);
            this.lblEnemy1.Name = "lblEnemy1";
            this.lblEnemy1.Size = new System.Drawing.Size(0, 20);
            this.lblEnemy1.TabIndex = 9;
            this.lblEnemy1.Click += new System.EventHandler(this.lblEnemy1_Click);
            // 
            // lblRoomTitle
            // 
            this.lblRoomTitle.AutoSize = true;
            this.lblRoomTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomTitle.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRoomTitle.Location = new System.Drawing.Point(15, 9);
            this.lblRoomTitle.Name = "lblRoomTitle";
            this.lblRoomTitle.Size = new System.Drawing.Size(108, 31);
            this.lblRoomTitle.TabIndex = 8;
            this.lblRoomTitle.Text = "default text";
            // 
            // lblRoomDesc
            // 
            this.lblRoomDesc.AutoSize = true;
            this.lblRoomDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomDesc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDesc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRoomDesc.Location = new System.Drawing.Point(16, 42);
            this.lblRoomDesc.Name = "lblRoomDesc";
            this.lblRoomDesc.Size = new System.Drawing.Size(103, 23);
            this.lblRoomDesc.TabIndex = 7;
            this.lblRoomDesc.Text = "default text";
            this.lblRoomDesc.Click += new System.EventHandler(this.lblRoomDesc_Click);
            // 
            // panMap
            // 
            this.panMap.Location = new System.Drawing.Point(12, 117);
            this.panMap.Name = "panMap";
            this.panMap.Size = new System.Drawing.Size(190, 205);
            this.panMap.TabIndex = 4;
            this.panMap.TabStop = false;
            // 
            // cmbItems
            // 
            this.cmbItems.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbItems.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(12, 336);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(190, 25);
            this.cmbItems.TabIndex = 5;
            this.cmbItems.TextChanged += new System.EventHandler(this.cmbItems_TextChanged);
            // 
            // panParty
            // 
            this.panParty.Controls.Add(this.picGender);
            this.panParty.Controls.Add(this.lblNameAllyTwo);
            this.panParty.Controls.Add(this.lblNameAllyOne);
            this.panParty.Controls.Add(this.pbarHealthAllyTwo);
            this.panParty.Controls.Add(this.pbarHealthAllyOne);
            this.panParty.Controls.Add(this.lblYourName);
            this.panParty.Controls.Add(this.pbarManaYours);
            this.panParty.Controls.Add(this.pbarHealthYours);
            this.panParty.Controls.Add(this.lblPatry);
            this.panParty.Location = new System.Drawing.Point(12, 380);
            this.panParty.Name = "panParty";
            this.panParty.Size = new System.Drawing.Size(190, 181);
            this.panParty.TabIndex = 6;
            // 
            // picGender
            // 
            this.picGender.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picGender.Location = new System.Drawing.Point(97, 7);
            this.picGender.Name = "picGender";
            this.picGender.Size = new System.Drawing.Size(87, 46);
            this.picGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGender.TabIndex = 35;
            this.picGender.TabStop = false;
            // 
            // lblNameAllyTwo
            // 
            this.lblNameAllyTwo.AutoSize = true;
            this.lblNameAllyTwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNameAllyTwo.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAllyTwo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNameAllyTwo.Location = new System.Drawing.Point(7, 130);
            this.lblNameAllyTwo.Name = "lblNameAllyTwo";
            this.lblNameAllyTwo.Size = new System.Drawing.Size(84, 22);
            this.lblNameAllyTwo.TabIndex = 30;
            this.lblNameAllyTwo.Text = "default name";
            this.lblNameAllyTwo.Click += new System.EventHandler(this.lblNameAllyTwo_Click);
            // 
            // lblNameAllyOne
            // 
            this.lblNameAllyOne.AutoSize = true;
            this.lblNameAllyOne.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNameAllyOne.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAllyOne.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNameAllyOne.Location = new System.Drawing.Point(7, 91);
            this.lblNameAllyOne.Name = "lblNameAllyOne";
            this.lblNameAllyOne.Size = new System.Drawing.Size(84, 22);
            this.lblNameAllyOne.TabIndex = 34;
            this.lblNameAllyOne.Text = "default name";
            this.lblNameAllyOne.Click += new System.EventHandler(this.lblNameAllyOne_Click);
            // 
            // pbarHealthAllyTwo
            // 
            this.pbarHealthAllyTwo.ForeColor = System.Drawing.Color.Lime;
            this.pbarHealthAllyTwo.Location = new System.Drawing.Point(10, 150);
            this.pbarHealthAllyTwo.Maximum = 200;
            this.pbarHealthAllyTwo.Name = "pbarHealthAllyTwo";
            this.pbarHealthAllyTwo.Size = new System.Drawing.Size(166, 10);
            this.pbarHealthAllyTwo.TabIndex = 33;
            this.pbarHealthAllyTwo.Value = 100;
            // 
            // pbarHealthAllyOne
            // 
            this.pbarHealthAllyOne.ForeColor = System.Drawing.Color.Lime;
            this.pbarHealthAllyOne.Location = new System.Drawing.Point(10, 110);
            this.pbarHealthAllyOne.Maximum = 200;
            this.pbarHealthAllyOne.Name = "pbarHealthAllyOne";
            this.pbarHealthAllyOne.Size = new System.Drawing.Size(166, 10);
            this.pbarHealthAllyOne.TabIndex = 31;
            this.pbarHealthAllyOne.Value = 100;
            // 
            // lblYourName
            // 
            this.lblYourName.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lblYourName.AutoSize = true;
            this.lblYourName.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblYourName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblYourName.Location = new System.Drawing.Point(7, 31);
            this.lblYourName.Name = "lblYourName";
            this.lblYourName.Size = new System.Drawing.Size(84, 22);
            this.lblYourName.TabIndex = 29;
            this.lblYourName.Text = "default name";
            this.lblYourName.Click += new System.EventHandler(this.lblYourName_Click);
            // 
            // pbarManaYours
            // 
            this.pbarManaYours.ForeColor = System.Drawing.Color.Navy;
            this.pbarManaYours.Location = new System.Drawing.Point(10, 72);
            this.pbarManaYours.Name = "pbarManaYours";
            this.pbarManaYours.Size = new System.Drawing.Size(166, 10);
            this.pbarManaYours.TabIndex = 30;
            this.pbarManaYours.Value = 100;
            // 
            // pbarHealthYours
            // 
            this.pbarHealthYours.ForeColor = System.Drawing.Color.Lime;
            this.pbarHealthYours.Location = new System.Drawing.Point(10, 56);
            this.pbarHealthYours.Maximum = 200;
            this.pbarHealthYours.Name = "pbarHealthYours";
            this.pbarHealthYours.Size = new System.Drawing.Size(166, 10);
            this.pbarHealthYours.TabIndex = 29;
            this.pbarHealthYours.Value = 100;
            // 
            // lblPatry
            // 
            this.lblPatry.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lblPatry.AutoSize = true;
            this.lblPatry.BackColor = System.Drawing.Color.Black;
            this.lblPatry.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatry.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPatry.Location = new System.Drawing.Point(3, 0);
            this.lblPatry.Name = "lblPatry";
            this.lblPatry.Size = new System.Drawing.Size(59, 31);
            this.lblPatry.TabIndex = 28;
            this.lblPatry.Text = "Allies";
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAttack.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAttack.Location = new System.Drawing.Point(229, 401);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 29);
            this.btnAttack.TabIndex = 17;
            this.btnAttack.Text = "Attack!";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnRunAway
            // 
            this.btnRunAway.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRunAway.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunAway.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRunAway.Location = new System.Drawing.Point(229, 436);
            this.btnRunAway.Name = "btnRunAway";
            this.btnRunAway.Size = new System.Drawing.Size(75, 29);
            this.btnRunAway.TabIndex = 18;
            this.btnRunAway.Text = "Run Away";
            this.btnRunAway.UseVisualStyleBackColor = false;
            this.btnRunAway.Click += new System.EventHandler(this.btnRunAway_Click);
            // 
            // btnUseItem
            // 
            this.btnUseItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUseItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUseItem.Location = new System.Drawing.Point(733, 506);
            this.btnUseItem.Name = "btnUseItem";
            this.btnUseItem.Size = new System.Drawing.Size(75, 29);
            this.btnUseItem.TabIndex = 19;
            this.btnUseItem.Text = "Use Item";
            this.btnUseItem.UseVisualStyleBackColor = false;
            this.btnUseItem.Click += new System.EventHandler(this.btnUseItem_Click);
            // 
            // btnTalk
            // 
            this.btnTalk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTalk.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTalk.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTalk.Location = new System.Drawing.Point(229, 506);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(75, 29);
            this.btnTalk.TabIndex = 20;
            this.btnTalk.Text = "Talk";
            this.btnTalk.UseVisualStyleBackColor = false;
            this.btnTalk.Click += new System.EventHandler(this.btnTalk_Click);
            // 
            // btnInspect
            // 
            this.btnInspect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInspect.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInspect.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInspect.Location = new System.Drawing.Point(733, 401);
            this.btnInspect.Name = "btnInspect";
            this.btnInspect.Size = new System.Drawing.Size(75, 29);
            this.btnInspect.TabIndex = 21;
            this.btnInspect.Text = "Inspect";
            this.btnInspect.UseVisualStyleBackColor = false;
            this.btnInspect.Click += new System.EventHandler(this.btnInspect_Click);
            // 
            // btnGrabItem
            // 
            this.btnGrabItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGrabItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGrabItem.Location = new System.Drawing.Point(733, 436);
            this.btnGrabItem.Name = "btnGrabItem";
            this.btnGrabItem.Size = new System.Drawing.Size(75, 29);
            this.btnGrabItem.TabIndex = 22;
            this.btnGrabItem.Text = "Grab";
            this.btnGrabItem.UseVisualStyleBackColor = false;
            this.btnGrabItem.Click += new System.EventHandler(this.btnGrabItem_Click);
            // 
            // btnDropItem
            // 
            this.btnDropItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDropItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDropItem.Location = new System.Drawing.Point(733, 471);
            this.btnDropItem.Name = "btnDropItem";
            this.btnDropItem.Size = new System.Drawing.Size(75, 29);
            this.btnDropItem.TabIndex = 23;
            this.btnDropItem.Text = "Drop";
            this.btnDropItem.UseVisualStyleBackColor = false;
            this.btnDropItem.Click += new System.EventHandler(this.btnDropItem_Click);
            // 
            // btnSpell
            // 
            this.btnSpell.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSpell.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpell.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSpell.Location = new System.Drawing.Point(229, 471);
            this.btnSpell.Name = "btnSpell";
            this.btnSpell.Size = new System.Drawing.Size(75, 29);
            this.btnSpell.TabIndex = 24;
            this.btnSpell.Text = "Use Spell";
            this.btnSpell.UseVisualStyleBackColor = false;
            this.btnSpell.Click += new System.EventHandler(this.btnSpell_Click);
            // 
            // lblInteractions
            // 
            this.lblInteractions.AutoSize = true;
            this.lblInteractions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInteractions.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteractions.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInteractions.Location = new System.Drawing.Point(225, 360);
            this.lblInteractions.Name = "lblInteractions";
            this.lblInteractions.Size = new System.Drawing.Size(110, 31);
            this.lblInteractions.TabIndex = 25;
            this.lblInteractions.Text = "Interactions";
            // 
            // lblItemInteractions
            // 
            this.lblItemInteractions.AutoSize = true;
            this.lblItemInteractions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItemInteractions.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemInteractions.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblItemInteractions.Location = new System.Drawing.Point(747, 360);
            this.lblItemInteractions.Name = "lblItemInteractions";
            this.lblItemInteractions.Size = new System.Drawing.Size(60, 31);
            this.lblItemInteractions.TabIndex = 26;
            this.lblItemInteractions.Text = "Items";
            // 
            // lblBattle
            // 
            this.lblBattle.AutoSize = true;
            this.lblBattle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBattle.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBattle.Location = new System.Drawing.Point(348, 360);
            this.lblBattle.Name = "lblBattle";
            this.lblBattle.Size = new System.Drawing.Size(110, 31);
            this.lblBattle.TabIndex = 27;
            this.lblBattle.Text = "Battle Table";
            // 
            // lbxBattle
            // 
            this.lbxBattle.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbxBattle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxBattle.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbxBattle.FormattingEnabled = true;
            this.lbxBattle.ItemHeight = 20;
            this.lbxBattle.Location = new System.Drawing.Point(352, 401);
            this.lbxBattle.Name = "lbxBattle";
            this.lbxBattle.Size = new System.Drawing.Size(357, 124);
            this.lbxBattle.TabIndex = 28;
            // 
            // btnNav1
            // 
            this.btnNav1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNav1.Location = new System.Drawing.Point(22, 144);
            this.btnNav1.Name = "btnNav1";
            this.btnNav1.Size = new System.Drawing.Size(166, 46);
            this.btnNav1.TabIndex = 29;
            this.btnNav1.Text = "nav1";
            this.btnNav1.UseVisualStyleBackColor = true;
            this.btnNav1.Click += new System.EventHandler(this.nav1_Click);
            // 
            // btnNav2
            // 
            this.btnNav2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNav2.Location = new System.Drawing.Point(22, 198);
            this.btnNav2.Name = "btnNav2";
            this.btnNav2.Size = new System.Drawing.Size(166, 54);
            this.btnNav2.TabIndex = 30;
            this.btnNav2.Text = "nav2";
            this.btnNav2.UseVisualStyleBackColor = true;
            this.btnNav2.Click += new System.EventHandler(this.nav2_Click);
            // 
            // btnNav3
            // 
            this.btnNav3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNav3.Location = new System.Drawing.Point(22, 258);
            this.btnNav3.Name = "btnNav3";
            this.btnNav3.Size = new System.Drawing.Size(166, 51);
            this.btnNav3.TabIndex = 32;
            this.btnNav3.Text = "nav3";
            this.btnNav3.UseVisualStyleBackColor = true;
            this.btnNav3.Click += new System.EventHandler(this.nav3_Click);
            // 
            // picModeBattle
            // 
            this.picModeBattle.Location = new System.Drawing.Point(12, 119);
            this.picModeBattle.Name = "picModeBattle";
            this.picModeBattle.Size = new System.Drawing.Size(190, 203);
            this.picModeBattle.TabIndex = 33;
            this.picModeBattle.TabStop = false;
            // 
            // lblNav
            // 
            this.lblNav.AutoSize = true;
            this.lblNav.BackColor = System.Drawing.Color.Black;
            this.lblNav.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNav.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNav.Location = new System.Drawing.Point(63, 117);
            this.lblNav.Name = "lblNav";
            this.lblNav.Size = new System.Drawing.Size(101, 31);
            this.lblNav.TabIndex = 34;
            this.lblNav.Text = "Navigation";
            // 
            // txtItems
            // 
            this.txtItems.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtItems.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtItems.Location = new System.Drawing.Point(12, 337);
            this.txtItems.Name = "txtItems";
            this.txtItems.ReadOnly = true;
            this.txtItems.Size = new System.Drawing.Size(176, 24);
            this.txtItems.TabIndex = 35;
            // 
            // frmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::Nightfall.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(842, 573);
            this.ControlBox = false;
            this.Controls.Add(this.txtItems);
            this.Controls.Add(this.picModeBattle);
            this.Controls.Add(this.lblNav);
            this.Controls.Add(this.btnNav3);
            this.Controls.Add(this.btnNav2);
            this.Controls.Add(this.btnNav1);
            this.Controls.Add(this.lbxBattle);
            this.Controls.Add(this.lblBattle);
            this.Controls.Add(this.lblItemInteractions);
            this.Controls.Add(this.lblInteractions);
            this.Controls.Add(this.btnSpell);
            this.Controls.Add(this.btnDropItem);
            this.Controls.Add(this.btnGrabItem);
            this.Controls.Add(this.btnInspect);
            this.Controls.Add(this.btnTalk);
            this.Controls.Add(this.btnUseItem);
            this.Controls.Add(this.btnRunAway);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.panParty);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.panMap);
            this.Controls.Add(this.panRoomDesc);
            this.Controls.Add(this.lblNightDay);
            this.Controls.Add(this.muConControl);
            this.Controls.Add(this.pnaMenu);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.muConControl;
            this.Name = "frmConsole";
            this.Text = "Control Console";
            this.Load += new System.EventHandler(this.frmConsole_Load);
            this.Shown += new System.EventHandler(this.frmConsole_Shown);
            this.muConControl.ResumeLayout(false);
            this.muConControl.PerformLayout();
            this.panRoomDesc.ResumeLayout(false);
            this.panRoomDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panMap)).EndInit();
            this.panParty.ResumeLayout(false);
            this.panParty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModeBattle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip muConControl;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem ttsmiNew;
        private System.Windows.Forms.ToolStripMenuItem ttsmiLoad;
        private System.Windows.Forms.ToolStripMenuItem ttsmiSave;
        private System.Windows.Forms.ToolStripMenuItem ttsmiQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStripMenuItem ttsmiAbout;
        private System.Windows.Forms.Panel pnaMenu;
        private System.Windows.Forms.Label lblNightDay;
        public System.Windows.Forms.Panel panRoomDesc;
        private System.Windows.Forms.PictureBox panMap;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Panel panParty;
        private System.Windows.Forms.Label lblRoomDesc;
        private System.Windows.Forms.Label lblRoomTitle;
        private System.Windows.Forms.Label lblItem4;
        private System.Windows.Forms.Label lblItem3;
        private System.Windows.Forms.Label lblItem2;
        private System.Windows.Forms.Label lblItem1;
        private System.Windows.Forms.Label lblEnemy4;
        private System.Windows.Forms.Label lblEnemy3;
        private System.Windows.Forms.Label lblEnemy2;
        private System.Windows.Forms.Label lblEnemy1;
        private System.Windows.Forms.Label lblPatry;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnRunAway;
        private System.Windows.Forms.Button btnUseItem;
        private System.Windows.Forms.Button btnTalk;
        private System.Windows.Forms.Button btnInspect;
        private System.Windows.Forms.Button btnGrabItem;
        private System.Windows.Forms.Button btnDropItem;
        private System.Windows.Forms.Button btnSpell;
        private System.Windows.Forms.Label lblInteractions;
        private System.Windows.Forms.Label lblItemInteractions;
        private System.Windows.Forms.Label lblBattle;
        private System.Windows.Forms.ListBox lbxBattle;
        private System.Windows.Forms.Label lblNameAllyTwo;
        private System.Windows.Forms.Label lblNameAllyOne;
        private System.Windows.Forms.ProgressBar pbarHealthAllyTwo;
        private System.Windows.Forms.ProgressBar pbarHealthAllyOne;
        private System.Windows.Forms.Label lblYourName;
        private System.Windows.Forms.ProgressBar pbarManaYours;
        private System.Windows.Forms.ProgressBar pbarHealthYours;
        private System.Windows.Forms.Button btnNav1;
        private System.Windows.Forms.Button btnNav2;
        private System.Windows.Forms.Button btnNav3;
        private System.Windows.Forms.PictureBox picModeBattle;
        private System.Windows.Forms.Label lblNav;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.PictureBox picGender;
        private System.Windows.Forms.TextBox txtItems;
    }
}

