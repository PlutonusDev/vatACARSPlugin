﻿namespace vatACARS.Components
{
    partial class EditorWindow
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
            this.lbl_receivedMsgs = new vatsys.TextLabel();
            this.btn_escape = new vatsys.GenericButton();
            this.insetPanel2 = new vatsys.InsetPanel();
            this.lvw_messages = new vatsys.ListViewEx();
            this.scr_messageSelector = new VATSYSControls.ScrollBar();
            this.lvw_messageSelector = new vatsys.ListViewEx();
            this.insetPanel1 = new vatsys.InsetPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_level = new vatsys.GenericButton();
            this.btn_expect = new vatsys.GenericButton();
            this.btn_surv = new vatsys.GenericButton();
            this.btn_cross = new vatsys.GenericButton();
            this.btn_route = new vatsys.GenericButton();
            this.btn_wx = new vatsys.GenericButton();
            this.btn_transfr = new vatsys.GenericButton();
            this.btn_comm = new vatsys.GenericButton();
            this.btn_enq = new vatsys.GenericButton();
            this.btn_speed = new vatsys.GenericButton();
            this.btn_emerg = new vatsys.GenericButton();
            this.btn_blk = new vatsys.GenericButton();
            this.btn_cfm = new vatsys.GenericButton();
            this.btn_misc = new vatsys.GenericButton();
            this.btn_suspend = new vatsys.GenericButton();
            this.btn_restore = new vatsys.GenericButton();
            this.btn_send = new vatsys.GenericButton();
            this.insetPanel3 = new vatsys.InsetPanel();
            this.lvw_freetextInput = new vatsys.ListViewEx();
            this.btn_1 = new vatsys.GenericButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UnableLabel = new vatsys.TextLabel();
            this.ToEditLabel = new vatsys.TextLabel();
            this.DelayLabel = new vatsys.TextLabel();
            this.label1 = new vatsys.TextLabel();
            this.btn_tfc = new vatsys.GenericButton();
            this.btn_air = new vatsys.GenericButton();
            this.btn_def = new vatsys.GenericButton();
            this.btn_stanby = new vatsys.GenericButton();
            this.btn_editor = new vatsys.GenericButton();
            this.insetPanel2.SuspendLayout();
            this.insetPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.insetPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_receivedMsgs
            // 
            this.lbl_receivedMsgs.AutoSize = true;
            this.lbl_receivedMsgs.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_receivedMsgs.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_receivedMsgs.HasBorder = false;
            this.lbl_receivedMsgs.InteractiveText = false;
            this.lbl_receivedMsgs.Location = new System.Drawing.Point(13, 13);
            this.lbl_receivedMsgs.Name = "lbl_receivedMsgs";
            this.lbl_receivedMsgs.Size = new System.Drawing.Size(144, 17);
            this.lbl_receivedMsgs.TabIndex = 0;
            this.lbl_receivedMsgs.Text = "Received Messages";
            this.lbl_receivedMsgs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_escape
            // 
            this.btn_escape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_escape.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_escape.Location = new System.Drawing.Point(10, 404);
            this.btn_escape.Name = "btn_escape";
            this.btn_escape.Size = new System.Drawing.Size(90, 28);
            this.btn_escape.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_escape.SubText = "";
            this.btn_escape.TabIndex = 2;
            this.btn_escape.Text = "Escape";
            this.btn_escape.UseVisualStyleBackColor = true;
            this.btn_escape.Click += new System.EventHandler(this.btn_reply_Click);
            // 
            // insetPanel2
            // 
            this.insetPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.insetPanel2.Controls.Add(this.lvw_messages);
            this.insetPanel2.Location = new System.Drawing.Point(11, 12);
            this.insetPanel2.Name = "insetPanel2";
            this.insetPanel2.Size = new System.Drawing.Size(565, 80);
            this.insetPanel2.TabIndex = 3;
            // 
            // lvw_messages
            // 
            this.lvw_messages.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvw_messages.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvw_messages.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lvw_messages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvw_messages.HideSelection = false;
            this.lvw_messages.LabelWrap = false;
            this.lvw_messages.Location = new System.Drawing.Point(3, 3);
            this.lvw_messages.MultiSelect = false;
            this.lvw_messages.Name = "lvw_messages";
            this.lvw_messages.Scrollable = false;
            this.lvw_messages.ShowGroups = false;
            this.lvw_messages.Size = new System.Drawing.Size(559, 74);
            this.lvw_messages.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvw_messages.TabIndex = 2;
            this.lvw_messages.TileSize = new System.Drawing.Size(550, 26);
            this.lvw_messages.UseCompatibleStateImageBehavior = false;
            this.lvw_messages.View = System.Windows.Forms.View.Tile;
            this.lvw_messages.SelectedIndexChanged += new System.EventHandler(this.lvw_messages_SelectedIndexChanged);
            // 
            // scr_messageSelector
            // 
            this.scr_messageSelector.ActualHeight = 10;
            this.scr_messageSelector.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.scr_messageSelector.Change = 1;
            this.scr_messageSelector.Location = new System.Drawing.Point(559, 185);
            this.scr_messageSelector.Name = "scr_messageSelector";
            this.scr_messageSelector.Orientation = System.Windows.Forms.ScrollOrientation.VerticalScroll;
            this.scr_messageSelector.PreferredHeight = 10;
            this.scr_messageSelector.Size = new System.Drawing.Size(17, 176);
            this.scr_messageSelector.TabIndex = 5;
            this.scr_messageSelector.Value = 0;
            this.scr_messageSelector.Scrolling += new System.EventHandler(this.scr_messageSelector_Scroll);
            // 
            // lvw_messageSelector
            // 
            this.lvw_messageSelector.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvw_messageSelector.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvw_messageSelector.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lvw_messageSelector.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvw_messageSelector.HideSelection = false;
            this.lvw_messageSelector.LabelWrap = false;
            this.lvw_messageSelector.Location = new System.Drawing.Point(3, 3);
            this.lvw_messageSelector.MultiSelect = false;
            this.lvw_messageSelector.Name = "lvw_messageSelector";
            this.lvw_messageSelector.ShowGroups = false;
            this.lvw_messageSelector.Size = new System.Drawing.Size(539, 170);
            this.lvw_messageSelector.TabIndex = 2;
            this.lvw_messageSelector.TileSize = new System.Drawing.Size(440, 20);
            this.lvw_messageSelector.UseCompatibleStateImageBehavior = false;
            this.lvw_messageSelector.View = System.Windows.Forms.View.Tile;
            // 
            // insetPanel1
            // 
            this.insetPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.insetPanel1.Controls.Add(this.lvw_messageSelector);
            this.insetPanel1.Location = new System.Drawing.Point(11, 185);
            this.insetPanel1.Name = "insetPanel1";
            this.insetPanel1.Size = new System.Drawing.Size(546, 176);
            this.insetPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_level);
            this.panel2.Controls.Add(this.btn_expect);
            this.panel2.Controls.Add(this.btn_surv);
            this.panel2.Controls.Add(this.btn_cross);
            this.panel2.Controls.Add(this.btn_route);
            this.panel2.Controls.Add(this.btn_wx);
            this.panel2.Controls.Add(this.btn_transfr);
            this.panel2.Controls.Add(this.btn_comm);
            this.panel2.Controls.Add(this.btn_enq);
            this.panel2.Controls.Add(this.btn_speed);
            this.panel2.Controls.Add(this.btn_emerg);
            this.panel2.Controls.Add(this.btn_blk);
            this.panel2.Controls.Add(this.btn_cfm);
            this.panel2.Controls.Add(this.btn_misc);
            this.panel2.Location = new System.Drawing.Point(11, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 84);
            this.panel2.TabIndex = 34;
            this.panel2.Visible = false;
            // 
            // btn_level
            // 
            this.btn_level.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_level.Location = new System.Drawing.Point(-1, 3);
            this.btn_level.Name = "btn_level";
            this.btn_level.Size = new System.Drawing.Size(80, 28);
            this.btn_level.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_level.SubText = "";
            this.btn_level.TabIndex = 7;
            this.btn_level.Text = "LEVEL";
            this.btn_level.UseVisualStyleBackColor = true;
            this.btn_level.Click += new System.EventHandler(this.btn_level_Click);
            // 
            // btn_expect
            // 
            this.btn_expect.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_expect.Location = new System.Drawing.Point(485, 3);
            this.btn_expect.Name = "btn_expect";
            this.btn_expect.Size = new System.Drawing.Size(80, 28);
            this.btn_expect.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expect.SubText = "";
            this.btn_expect.TabIndex = 8;
            this.btn_expect.Text = "EXPECT";
            this.btn_expect.UseVisualStyleBackColor = true;
            this.btn_expect.Click += new System.EventHandler(this.btn_expect_Click);
            // 
            // btn_surv
            // 
            this.btn_surv.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_surv.Location = new System.Drawing.Point(404, 3);
            this.btn_surv.Name = "btn_surv";
            this.btn_surv.Size = new System.Drawing.Size(80, 28);
            this.btn_surv.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_surv.SubText = "";
            this.btn_surv.TabIndex = 9;
            this.btn_surv.Text = "SURV";
            this.btn_surv.UseVisualStyleBackColor = true;
            this.btn_surv.Click += new System.EventHandler(this.btn_surv_Click);
            // 
            // btn_cross
            // 
            this.btn_cross.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_cross.Location = new System.Drawing.Point(242, 3);
            this.btn_cross.Name = "btn_cross";
            this.btn_cross.Size = new System.Drawing.Size(80, 28);
            this.btn_cross.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cross.SubText = "";
            this.btn_cross.TabIndex = 11;
            this.btn_cross.Text = "CROSS";
            this.btn_cross.UseVisualStyleBackColor = true;
            this.btn_cross.Click += new System.EventHandler(this.btn_cross_Click);
            // 
            // btn_route
            // 
            this.btn_route.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_route.Location = new System.Drawing.Point(80, 3);
            this.btn_route.Name = "btn_route";
            this.btn_route.Size = new System.Drawing.Size(80, 28);
            this.btn_route.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_route.SubText = "";
            this.btn_route.TabIndex = 13;
            this.btn_route.Text = "ROUTE";
            this.btn_route.UseVisualStyleBackColor = true;
            this.btn_route.Click += new System.EventHandler(this.btn_route_Click);
            // 
            // btn_wx
            // 
            this.btn_wx.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_wx.Location = new System.Drawing.Point(80, 37);
            this.btn_wx.Name = "btn_wx";
            this.btn_wx.Size = new System.Drawing.Size(80, 28);
            this.btn_wx.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wx.SubText = "";
            this.btn_wx.TabIndex = 20;
            this.btn_wx.Text = "WX/OFF";
            this.btn_wx.UseVisualStyleBackColor = true;
            this.btn_wx.Click += new System.EventHandler(this.btn_wx_Click);
            // 
            // btn_transfr
            // 
            this.btn_transfr.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_transfr.Location = new System.Drawing.Point(161, 3);
            this.btn_transfr.Name = "btn_transfr";
            this.btn_transfr.Size = new System.Drawing.Size(80, 28);
            this.btn_transfr.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transfr.SubText = "";
            this.btn_transfr.TabIndex = 12;
            this.btn_transfr.Text = "TRANSFR";
            this.btn_transfr.UseVisualStyleBackColor = true;
            this.btn_transfr.Click += new System.EventHandler(this.btn_transfr_Click);
            // 
            // btn_comm
            // 
            this.btn_comm.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_comm.Location = new System.Drawing.Point(161, 37);
            this.btn_comm.Name = "btn_comm";
            this.btn_comm.Size = new System.Drawing.Size(80, 28);
            this.btn_comm.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comm.SubText = "";
            this.btn_comm.TabIndex = 19;
            this.btn_comm.Text = "COMM";
            this.btn_comm.UseVisualStyleBackColor = true;
            this.btn_comm.Click += new System.EventHandler(this.btn_comm_Click);
            // 
            // btn_enq
            // 
            this.btn_enq.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_enq.Location = new System.Drawing.Point(323, 3);
            this.btn_enq.Name = "btn_enq";
            this.btn_enq.Size = new System.Drawing.Size(80, 28);
            this.btn_enq.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enq.SubText = "";
            this.btn_enq.TabIndex = 10;
            this.btn_enq.Text = "ENQ/TXT";
            this.btn_enq.UseVisualStyleBackColor = true;
            this.btn_enq.Click += new System.EventHandler(this.btn_enq_Click);
            // 
            // btn_speed
            // 
            this.btn_speed.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_speed.Location = new System.Drawing.Point(242, 37);
            this.btn_speed.Name = "btn_speed";
            this.btn_speed.Size = new System.Drawing.Size(80, 28);
            this.btn_speed.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_speed.SubText = "";
            this.btn_speed.TabIndex = 18;
            this.btn_speed.Text = "SPEED";
            this.btn_speed.UseVisualStyleBackColor = true;
            this.btn_speed.Click += new System.EventHandler(this.btn_speed_Click);
            // 
            // btn_emerg
            // 
            this.btn_emerg.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_emerg.Location = new System.Drawing.Point(485, 37);
            this.btn_emerg.Name = "btn_emerg";
            this.btn_emerg.Size = new System.Drawing.Size(80, 28);
            this.btn_emerg.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emerg.SubText = "";
            this.btn_emerg.TabIndex = 15;
            this.btn_emerg.Text = "EMERG";
            this.btn_emerg.UseVisualStyleBackColor = true;
            this.btn_emerg.Click += new System.EventHandler(this.btn_emerg_Click);
            // 
            // btn_blk
            // 
            this.btn_blk.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_blk.Location = new System.Drawing.Point(0, 37);
            this.btn_blk.Name = "btn_blk";
            this.btn_blk.Size = new System.Drawing.Size(80, 28);
            this.btn_blk.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_blk.SubText = "";
            this.btn_blk.TabIndex = 14;
            this.btn_blk.Text = "BLK/CND";
            this.btn_blk.UseVisualStyleBackColor = true;
            this.btn_blk.Click += new System.EventHandler(this.btn_blk_Click);
            // 
            // btn_cfm
            // 
            this.btn_cfm.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_cfm.Location = new System.Drawing.Point(323, 37);
            this.btn_cfm.Name = "btn_cfm";
            this.btn_cfm.Size = new System.Drawing.Size(80, 28);
            this.btn_cfm.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cfm.SubText = "";
            this.btn_cfm.TabIndex = 17;
            this.btn_cfm.Text = "CFM/RPT";
            this.btn_cfm.UseVisualStyleBackColor = true;
            this.btn_cfm.Click += new System.EventHandler(this.btn_cfm_Click);
            // 
            // btn_misc
            // 
            this.btn_misc.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_misc.Location = new System.Drawing.Point(404, 37);
            this.btn_misc.Name = "btn_misc";
            this.btn_misc.Size = new System.Drawing.Size(80, 28);
            this.btn_misc.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_misc.SubText = "";
            this.btn_misc.TabIndex = 16;
            this.btn_misc.Text = "MISC";
            this.btn_misc.UseVisualStyleBackColor = true;
            this.btn_misc.Click += new System.EventHandler(this.btn_misc_Click);
            // 
            // btn_suspend
            // 
            this.btn_suspend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_suspend.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_suspend.Location = new System.Drawing.Point(202, 404);
            this.btn_suspend.Name = "btn_suspend";
            this.btn_suspend.Size = new System.Drawing.Size(90, 28);
            this.btn_suspend.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suspend.SubText = "";
            this.btn_suspend.TabIndex = 21;
            this.btn_suspend.Text = "Suspend";
            this.btn_suspend.UseVisualStyleBackColor = true;
            this.btn_suspend.Click += new System.EventHandler(this.btn_suspend_Click);
            // 
            // btn_restore
            // 
            this.btn_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_restore.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_restore.Location = new System.Drawing.Point(106, 404);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(90, 28);
            this.btn_restore.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restore.SubText = "";
            this.btn_restore.TabIndex = 22;
            this.btn_restore.Text = "Restore";
            this.btn_restore.UseVisualStyleBackColor = true;
            // 
            // btn_send
            // 
            this.btn_send.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_send.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_send.Location = new System.Drawing.Point(466, 404);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(111, 28);
            this.btn_send.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.SubText = "";
            this.btn_send.TabIndex = 23;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // insetPanel3
            // 
            this.insetPanel3.Controls.Add(this.lvw_freetextInput);
            this.insetPanel3.Location = new System.Drawing.Point(47, 367);
            this.insetPanel3.Name = "insetPanel3";
            this.insetPanel3.Size = new System.Drawing.Size(529, 31);
            this.insetPanel3.TabIndex = 7;
            // 
            // lvw_freetextInput
            // 
            this.lvw_freetextInput.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvw_freetextInput.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvw_freetextInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lvw_freetextInput.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvw_freetextInput.HideSelection = false;
            this.lvw_freetextInput.LabelWrap = false;
            this.lvw_freetextInput.Location = new System.Drawing.Point(3, 3);
            this.lvw_freetextInput.MultiSelect = false;
            this.lvw_freetextInput.Name = "lvw_freetextInput";
            this.lvw_freetextInput.Scrollable = false;
            this.lvw_freetextInput.Size = new System.Drawing.Size(523, 25);
            this.lvw_freetextInput.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvw_freetextInput.TabIndex = 2;
            this.lvw_freetextInput.TileSize = new System.Drawing.Size(440, 26);
            this.lvw_freetextInput.UseCompatibleStateImageBehavior = false;
            this.lvw_freetextInput.View = System.Windows.Forms.View.Tile;
            // 
            // btn_1
            // 
            this.btn_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_1.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_1.Location = new System.Drawing.Point(10, 367);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(31, 31);
            this.btn_1.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.SubText = "";
            this.btn_1.TabIndex = 24;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UnableLabel);
            this.panel1.Controls.Add(this.ToEditLabel);
            this.panel1.Controls.Add(this.DelayLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_tfc);
            this.panel1.Controls.Add(this.btn_air);
            this.panel1.Controls.Add(this.btn_def);
            this.panel1.Controls.Add(this.btn_stanby);
            this.panel1.Controls.Add(this.btn_editor);
            this.panel1.Location = new System.Drawing.Point(11, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 84);
            this.panel1.TabIndex = 47;
            // 
            // UnableLabel
            // 
            this.UnableLabel.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UnableLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.UnableLabel.HasBorder = false;
            this.UnableLabel.InteractiveText = false;
            this.UnableLabel.Location = new System.Drawing.Point(377, 16);
            this.UnableLabel.Name = "UnableLabel";
            this.UnableLabel.Size = new System.Drawing.Size(185, 18);
            this.UnableLabel.TabIndex = 43;
            this.UnableLabel.Text = "Unable Due To";
            this.UnableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToEditLabel
            // 
            this.ToEditLabel.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ToEditLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ToEditLabel.HasBorder = false;
            this.ToEditLabel.InteractiveText = false;
            this.ToEditLabel.Location = new System.Drawing.Point(191, 16);
            this.ToEditLabel.Name = "ToEditLabel";
            this.ToEditLabel.Size = new System.Drawing.Size(180, 18);
            this.ToEditLabel.TabIndex = 41;
            this.ToEditLabel.Text = "To Editor";
            this.ToEditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DelayLabel
            // 
            this.DelayLabel.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DelayLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.DelayLabel.HasBorder = false;
            this.DelayLabel.InteractiveText = false;
            this.DelayLabel.Location = new System.Drawing.Point(-1, 16);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(186, 18);
            this.DelayLabel.TabIndex = 44;
            this.DelayLabel.Text = "Delay Response";
            this.DelayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.HasBorder = false;
            this.label1.InteractiveText = false;
            this.label1.Location = new System.Drawing.Point(252, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_tfc
            // 
            this.btn_tfc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_tfc.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_tfc.Location = new System.Drawing.Point(377, 53);
            this.btn_tfc.Name = "btn_tfc";
            this.btn_tfc.Size = new System.Drawing.Size(90, 28);
            this.btn_tfc.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tfc.SubText = "";
            this.btn_tfc.TabIndex = 39;
            this.btn_tfc.Text = "Traffic";
            this.btn_tfc.UseVisualStyleBackColor = true;
            // 
            // btn_air
            // 
            this.btn_air.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_air.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_air.Location = new System.Drawing.Point(473, 53);
            this.btn_air.Name = "btn_air";
            this.btn_air.Size = new System.Drawing.Size(90, 28);
            this.btn_air.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_air.SubText = "";
            this.btn_air.TabIndex = 38;
            this.btn_air.Text = "Airspace";
            this.btn_air.UseVisualStyleBackColor = true;
            // 
            // btn_def
            // 
            this.btn_def.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_def.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_def.Location = new System.Drawing.Point(95, 53);
            this.btn_def.Name = "btn_def";
            this.btn_def.Size = new System.Drawing.Size(90, 28);
            this.btn_def.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_def.SubText = "";
            this.btn_def.TabIndex = 36;
            this.btn_def.Text = "Deferred";
            this.btn_def.UseVisualStyleBackColor = true;
            // 
            // btn_stanby
            // 
            this.btn_stanby.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_stanby.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_stanby.Location = new System.Drawing.Point(-1, 53);
            this.btn_stanby.Name = "btn_stanby";
            this.btn_stanby.Size = new System.Drawing.Size(90, 28);
            this.btn_stanby.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stanby.SubText = "";
            this.btn_stanby.TabIndex = 35;
            this.btn_stanby.Text = "Standby";
            this.btn_stanby.UseVisualStyleBackColor = true;
            // 
            // btn_editor
            // 
            this.btn_editor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_editor.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_editor.Location = new System.Drawing.Point(242, 53);
            this.btn_editor.Name = "btn_editor";
            this.btn_editor.Size = new System.Drawing.Size(80, 28);
            this.btn_editor.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editor.SubText = "";
            this.btn_editor.TabIndex = 42;
            this.btn_editor.Text = "Edit";
            this.btn_editor.UseVisualStyleBackColor = true;
            // 
            // EditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 452);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.insetPanel3);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.btn_suspend);
            this.Controls.Add(this.insetPanel1);
            this.Controls.Add(this.scr_messageSelector);
            this.Controls.Add(this.insetPanel2);
            this.Controls.Add(this.btn_escape);
            this.Controls.Add(this.lbl_receivedMsgs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HasSendBackButton = false;
            this.HideOnClose = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MiddleClickClose = false;
            this.Name = "EditorWindow";
            this.Resizeable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ACARS Editor";
            this.TopMost = true;
            this.insetPanel2.ResumeLayout(false);
            this.insetPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.insetPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private vatsys.TextLabel lbl_receivedMsgs;
        private vatsys.GenericButton btn_escape;
        private vatsys.InsetPanel insetPanel2;
        private vatsys.ListViewEx lvw_messages;
        private VATSYSControls.ScrollBar scr_messageSelector;
        private vatsys.ListViewEx lvw_messageSelector;
        private vatsys.InsetPanel insetPanel1;
        private vatsys.GenericButton btn_suspend;
        private vatsys.GenericButton btn_restore;
        private vatsys.GenericButton btn_send;
        private vatsys.InsetPanel insetPanel3;
        private vatsys.ListViewEx lvw_freetextInput;
        private vatsys.GenericButton btn_1;
        private System.Windows.Forms.Panel panel2;
        private vatsys.GenericButton btn_level;
        private vatsys.GenericButton btn_expect;
        private vatsys.GenericButton btn_surv;
        private vatsys.GenericButton btn_cross;
        private vatsys.GenericButton btn_route;
        private vatsys.GenericButton btn_wx;
        private vatsys.GenericButton btn_transfr;
        private vatsys.GenericButton btn_comm;
        private vatsys.GenericButton btn_enq;
        private vatsys.GenericButton btn_speed;
        private vatsys.GenericButton btn_emerg;
        private vatsys.GenericButton btn_blk;
        private vatsys.GenericButton btn_cfm;
        private vatsys.GenericButton btn_misc;
        private vatsys.GenericButton btn_tfc;
        private vatsys.GenericButton btn_air;
        private vatsys.GenericButton btn_def;
        private vatsys.GenericButton btn_stanby;
        private vatsys.GenericButton btn_editor;
        private System.Windows.Forms.Panel panel1;
        private vatsys.TextLabel UnableLabel;
        private vatsys.TextLabel ToEditLabel;
        private vatsys.TextLabel DelayLabel;
        private vatsys.TextLabel label1;
    }
}