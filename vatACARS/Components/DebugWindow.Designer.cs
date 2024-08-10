using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vatACARS.Components
{
    partial class DebugWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugWindow));
            this.tbx_content = new vatsys.TextField();
            this.insetPanel2 = new vatsys.InsetPanel();
            this.dd_type = new VATSYSControls.DropDownBox();
            this.lbl_type = new vatsys.TextLabel();
            this.btn_add = new vatsys.GenericButton();
            this.dd_state = new VATSYSControls.DropDownBox();
            this.lbl_state = new vatsys.TextLabel();
            this.lbl_content = new vatsys.TextLabel();
            this.tbx_station = new vatsys.TextField();
            this.lbl_callsign = new vatsys.TextLabel();
            this.lbl_messagecreate = new vatsys.TextLabel();
            this.insetPanel1 = new vatsys.InsetPanel();
            this.lbl_rdmstn = new vatsys.TextLabel();
            this.btn_rdmstn = new vatsys.GenericButton();
            this.lbl_prov = new vatsys.TextLabel();
            this.dd_prov = new VATSYSControls.DropDownBox();
            this.btn_screate = new vatsys.GenericButton();
            this.tbx_stationc = new vatsys.TextField();
            this.lbl_stationc = new vatsys.TextLabel();
            this.lbl_stationcreate = new vatsys.TextLabel();
            this.btn_netchecks = new vatsys.GenericButton();
            this.lbl_netchecks = new vatsys.TextLabel();
            this.insetPanel3 = new vatsys.InsetPanel();
            this.btn_w = new vatsys.GenericButton();
            this.lbl_content2 = new vatsys.TextLabel();
            this.tbx_response = new vatsys.TextField();
            this.tbx_content2 = new vatsys.TextField();
            this.lbl_code = new vatsys.TextLabel();
            this.tbx_replyid = new vatsys.TextField();
            this.lbl_reply = new vatsys.TextLabel();
            this.tbx_msgid = new vatsys.TextField();
            this.lbl_msgid = new vatsys.TextLabel();
            this.btn_send = new vatsys.GenericButton();
            this.tbx_callsign = new vatsys.TextField();
            this.lbl_call = new vatsys.TextLabel();
            this.lbl_pilotres = new vatsys.TextLabel();
            this.btn_u = new vatsys.GenericButton();
            this.btn_s = new vatsys.GenericButton();
            this.btn_r = new vatsys.GenericButton();
            this.btn_a = new vatsys.GenericButton();
            this.btn_n = new vatsys.GenericButton();
            this.insetPanel2.SuspendLayout();
            this.insetPanel1.SuspendLayout();
            this.insetPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_content
            // 
            this.tbx_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_content.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_content.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tbx_content.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_content.Location = new System.Drawing.Point(81, 63);
            this.tbx_content.Name = "tbx_content";
            this.tbx_content.NumericCharOnly = false;
            this.tbx_content.OctalOnly = false;
            this.tbx_content.Size = new System.Drawing.Size(360, 25);
            this.tbx_content.TabIndex = 16;
            // 
            // insetPanel2
            // 
            this.insetPanel2.Controls.Add(this.dd_type);
            this.insetPanel2.Controls.Add(this.lbl_type);
            this.insetPanel2.Controls.Add(this.btn_add);
            this.insetPanel2.Controls.Add(this.dd_state);
            this.insetPanel2.Controls.Add(this.lbl_state);
            this.insetPanel2.Controls.Add(this.lbl_content);
            this.insetPanel2.Controls.Add(this.tbx_station);
            this.insetPanel2.Controls.Add(this.lbl_callsign);
            this.insetPanel2.Controls.Add(this.lbl_messagecreate);
            this.insetPanel2.Controls.Add(this.tbx_content);
            this.insetPanel2.Location = new System.Drawing.Point(12, 12);
            this.insetPanel2.Name = "insetPanel2";
            this.insetPanel2.Size = new System.Drawing.Size(457, 128);
            this.insetPanel2.TabIndex = 17;
            // 
            // dd_type
            // 
            this.dd_type.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dd_type.FocusColor = System.Drawing.Color.Cyan;
            this.dd_type.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.dd_type.Items = new ObservableCollection<string>();
            this.dd_type.Location = new System.Drawing.Point(205, 94);
            this.dd_type.Name = "dd_type";
            this.dd_type.SelectedIndex = -1;
            this.dd_type.Size = new System.Drawing.Size(131, 25);
            this.dd_type.TabIndex = 108;
            // 
            // lbl_type
            // 
            this.lbl_type.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_type.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_type.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_type.HasBorder = false;
            this.lbl_type.InteractiveText = true;
            this.lbl_type.Location = new System.Drawing.Point(127, 92);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(72, 26);
            this.lbl_type.TabIndex = 107;
            this.lbl_type.Text = "TYPE:";
            this.lbl_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_add.Location = new System.Drawing.Point(342, 94);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(99, 28);
            this.btn_add.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.SubText = "";
            this.btn_add.TabIndex = 106;
            this.btn_add.Text = "ADD MESSAGE";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dd_state
            // 
            this.dd_state.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dd_state.FocusColor = System.Drawing.Color.Cyan;
            this.dd_state.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.dd_state.Items = new ObservableCollection<string>();
            this.dd_state.Location = new System.Drawing.Point(81, 94);
            this.dd_state.Name = "dd_state";
            this.dd_state.SelectedIndex = -1;
            this.dd_state.Size = new System.Drawing.Size(40, 25);
            this.dd_state.TabIndex = 103;
            // 
            // lbl_state
            // 
            this.lbl_state.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_state.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_state.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_state.HasBorder = false;
            this.lbl_state.InteractiveText = true;
            this.lbl_state.Location = new System.Drawing.Point(3, 92);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(72, 26);
            this.lbl_state.TabIndex = 33;
            this.lbl_state.Text = "STATE:";
            this.lbl_state.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_content
            // 
            this.lbl_content.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_content.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_content.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_content.HasBorder = false;
            this.lbl_content.InteractiveText = true;
            this.lbl_content.Location = new System.Drawing.Point(3, 61);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(72, 26);
            this.lbl_content.TabIndex = 31;
            this.lbl_content.Text = "CONTENT:";
            this.lbl_content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_station
            // 
            this.tbx_station.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_station.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_station.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tbx_station.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_station.Location = new System.Drawing.Point(81, 32);
            this.tbx_station.Name = "tbx_station";
            this.tbx_station.NumericCharOnly = false;
            this.tbx_station.OctalOnly = false;
            this.tbx_station.Size = new System.Drawing.Size(107, 25);
            this.tbx_station.TabIndex = 30;
            // 
            // lbl_callsign
            // 
            this.lbl_callsign.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_callsign.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_callsign.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_callsign.HasBorder = false;
            this.lbl_callsign.InteractiveText = true;
            this.lbl_callsign.Location = new System.Drawing.Point(3, 29);
            this.lbl_callsign.Name = "lbl_callsign";
            this.lbl_callsign.Size = new System.Drawing.Size(72, 26);
            this.lbl_callsign.TabIndex = 29;
            this.lbl_callsign.Text = "STATION:";
            this.lbl_callsign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_messagecreate
            // 
            this.lbl_messagecreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_messagecreate.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_messagecreate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_messagecreate.HasBorder = false;
            this.lbl_messagecreate.InteractiveText = true;
            this.lbl_messagecreate.Location = new System.Drawing.Point(3, 3);
            this.lbl_messagecreate.Name = "lbl_messagecreate";
            this.lbl_messagecreate.Size = new System.Drawing.Size(192, 26);
            this.lbl_messagecreate.TabIndex = 28;
            this.lbl_messagecreate.Text = "MESSAGE CREATOR";
            this.lbl_messagecreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // insetPanel1
            // 
            this.insetPanel1.Controls.Add(this.lbl_rdmstn);
            this.insetPanel1.Controls.Add(this.btn_rdmstn);
            this.insetPanel1.Controls.Add(this.lbl_prov);
            this.insetPanel1.Controls.Add(this.dd_prov);
            this.insetPanel1.Controls.Add(this.btn_screate);
            this.insetPanel1.Controls.Add(this.tbx_stationc);
            this.insetPanel1.Controls.Add(this.lbl_stationc);
            this.insetPanel1.Controls.Add(this.lbl_stationcreate);
            this.insetPanel1.Location = new System.Drawing.Point(12, 146);
            this.insetPanel1.Name = "insetPanel1";
            this.insetPanel1.Size = new System.Drawing.Size(457, 97);
            this.insetPanel1.TabIndex = 109;
            // 
            // lbl_rdmstn
            // 
            this.lbl_rdmstn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_rdmstn.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_rdmstn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_rdmstn.HasBorder = false;
            this.lbl_rdmstn.InteractiveText = true;
            this.lbl_rdmstn.Location = new System.Drawing.Point(3, 60);
            this.lbl_rdmstn.Name = "lbl_rdmstn";
            this.lbl_rdmstn.Size = new System.Drawing.Size(134, 26);
            this.lbl_rdmstn.TabIndex = 112;
            this.lbl_rdmstn.Text = "RANDOM STATION:";
            this.lbl_rdmstn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_rdmstn
            // 
            this.btn_rdmstn.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_rdmstn.Location = new System.Drawing.Point(143, 62);
            this.btn_rdmstn.Name = "btn_rdmstn";
            this.btn_rdmstn.Size = new System.Drawing.Size(99, 28);
            this.btn_rdmstn.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rdmstn.SubText = "";
            this.btn_rdmstn.TabIndex = 110;
            this.btn_rdmstn.Text = "ADD STATION";
            this.btn_rdmstn.UseVisualStyleBackColor = true;
            this.btn_rdmstn.Click += new System.EventHandler(this.btn_rdmstn_Click);
            // 
            // lbl_prov
            // 
            this.lbl_prov.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_prov.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_prov.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_prov.HasBorder = false;
            this.lbl_prov.InteractiveText = true;
            this.lbl_prov.Location = new System.Drawing.Point(194, 29);
            this.lbl_prov.Name = "lbl_prov";
            this.lbl_prov.Size = new System.Drawing.Size(83, 26);
            this.lbl_prov.TabIndex = 109;
            this.lbl_prov.Text = "PROVIDER:";
            this.lbl_prov.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dd_prov
            // 
            this.dd_prov.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dd_prov.FocusColor = System.Drawing.Color.Cyan;
            this.dd_prov.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.dd_prov.Items = new ObservableCollection<string>();
            this.dd_prov.Location = new System.Drawing.Point(283, 32);
            this.dd_prov.Name = "dd_prov";
            this.dd_prov.SelectedIndex = -1;
            this.dd_prov.Size = new System.Drawing.Size(40, 25);
            this.dd_prov.TabIndex = 109;
            // 
            // btn_screate
            // 
            this.btn_screate.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_screate.Location = new System.Drawing.Point(342, 32);
            this.btn_screate.Name = "btn_screate";
            this.btn_screate.Size = new System.Drawing.Size(99, 28);
            this.btn_screate.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_screate.SubText = "";
            this.btn_screate.TabIndex = 106;
            this.btn_screate.Text = "ADD STATION";
            this.btn_screate.UseVisualStyleBackColor = true;
            this.btn_screate.Click += new System.EventHandler(this.btn_screate_Click);
            // 
            // tbx_stationc
            // 
            this.tbx_stationc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_stationc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_stationc.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tbx_stationc.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_stationc.Location = new System.Drawing.Point(81, 32);
            this.tbx_stationc.Name = "tbx_stationc";
            this.tbx_stationc.NumericCharOnly = false;
            this.tbx_stationc.OctalOnly = false;
            this.tbx_stationc.Size = new System.Drawing.Size(107, 25);
            this.tbx_stationc.TabIndex = 30;
            // 
            // lbl_stationc
            // 
            this.lbl_stationc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_stationc.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_stationc.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_stationc.HasBorder = false;
            this.lbl_stationc.InteractiveText = true;
            this.lbl_stationc.Location = new System.Drawing.Point(3, 29);
            this.lbl_stationc.Name = "lbl_stationc";
            this.lbl_stationc.Size = new System.Drawing.Size(72, 26);
            this.lbl_stationc.TabIndex = 29;
            this.lbl_stationc.Text = "STATION:";
            this.lbl_stationc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_stationcreate
            // 
            this.lbl_stationcreate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_stationcreate.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_stationcreate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_stationcreate.HasBorder = false;
            this.lbl_stationcreate.InteractiveText = true;
            this.lbl_stationcreate.Location = new System.Drawing.Point(3, 3);
            this.lbl_stationcreate.Name = "lbl_stationcreate";
            this.lbl_stationcreate.Size = new System.Drawing.Size(134, 26);
            this.lbl_stationcreate.TabIndex = 28;
            this.lbl_stationcreate.Text = "STATION CREATOR";
            this.lbl_stationcreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_netchecks
            // 
            this.btn_netchecks.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_netchecks.Location = new System.Drawing.Point(174, 249);
            this.btn_netchecks.Name = "btn_netchecks";
            this.btn_netchecks.Size = new System.Drawing.Size(26, 26);
            this.btn_netchecks.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_netchecks.SubText = "";
            this.btn_netchecks.TabIndex = 111;
            this.btn_netchecks.UseVisualStyleBackColor = true;
            this.btn_netchecks.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_netchecks_MouseUp);
            // 
            // lbl_netchecks
            // 
            this.lbl_netchecks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_netchecks.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_netchecks.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_netchecks.HasBorder = false;
            this.lbl_netchecks.InteractiveText = true;
            this.lbl_netchecks.Location = new System.Drawing.Point(9, 249);
            this.lbl_netchecks.Name = "lbl_netchecks";
            this.lbl_netchecks.Size = new System.Drawing.Size(159, 26);
            this.lbl_netchecks.TabIndex = 110;
            this.lbl_netchecks.Text = "TOGGLE NET CHECKS:";
            this.lbl_netchecks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // insetPanel3
            // 
            this.insetPanel3.Controls.Add(this.btn_n);
            this.insetPanel3.Controls.Add(this.btn_a);
            this.insetPanel3.Controls.Add(this.btn_r);
            this.insetPanel3.Controls.Add(this.btn_s);
            this.insetPanel3.Controls.Add(this.btn_u);
            this.insetPanel3.Controls.Add(this.btn_w);
            this.insetPanel3.Controls.Add(this.lbl_content2);
            this.insetPanel3.Controls.Add(this.tbx_response);
            this.insetPanel3.Controls.Add(this.tbx_content2);
            this.insetPanel3.Controls.Add(this.lbl_code);
            this.insetPanel3.Controls.Add(this.tbx_replyid);
            this.insetPanel3.Controls.Add(this.lbl_reply);
            this.insetPanel3.Controls.Add(this.tbx_msgid);
            this.insetPanel3.Controls.Add(this.lbl_msgid);
            this.insetPanel3.Controls.Add(this.btn_send);
            this.insetPanel3.Controls.Add(this.tbx_callsign);
            this.insetPanel3.Controls.Add(this.lbl_call);
            this.insetPanel3.Controls.Add(this.lbl_pilotres);
            this.insetPanel3.Location = new System.Drawing.Point(12, 281);
            this.insetPanel3.Name = "insetPanel3";
            this.insetPanel3.Size = new System.Drawing.Size(457, 147);
            this.insetPanel3.TabIndex = 113;
            // 
            // btn_w
            // 
            this.btn_w.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_w.Location = new System.Drawing.Point(6, 110);
            this.btn_w.Name = "btn_w";
            this.btn_w.Size = new System.Drawing.Size(28, 28);
            this.btn_w.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_w.SubText = "";
            this.btn_w.TabIndex = 115;
            this.btn_w.Text = "W";
            this.btn_w.UseVisualStyleBackColor = true;
            this.btn_w.Click += new System.EventHandler(this.btn_w_Click);
            // 
            // lbl_content2
            // 
            this.lbl_content2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_content2.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_content2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_content2.HasBorder = false;
            this.lbl_content2.InteractiveText = true;
            this.lbl_content2.Location = new System.Drawing.Point(3, 81);
            this.lbl_content2.Name = "lbl_content2";
            this.lbl_content2.Size = new System.Drawing.Size(72, 26);
            this.lbl_content2.TabIndex = 110;
            this.lbl_content2.Text = "CONTENT:";
            this.lbl_content2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_response
            // 
            this.tbx_response.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_response.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_response.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tbx_response.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_response.Location = new System.Drawing.Point(319, 56);
            this.tbx_response.Name = "tbx_response";
            this.tbx_response.NumericCharOnly = false;
            this.tbx_response.OctalOnly = false;
            this.tbx_response.Size = new System.Drawing.Size(40, 25);
            this.tbx_response.TabIndex = 114;
            // 
            // tbx_content2
            // 
            this.tbx_content2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_content2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_content2.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tbx_content2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_content2.Location = new System.Drawing.Point(81, 83);
            this.tbx_content2.Name = "tbx_content2";
            this.tbx_content2.NumericCharOnly = false;
            this.tbx_content2.OctalOnly = false;
            this.tbx_content2.Size = new System.Drawing.Size(360, 25);
            this.tbx_content2.TabIndex = 109;
            // 
            // lbl_code
            // 
            this.lbl_code.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_code.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_code.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_code.HasBorder = false;
            this.lbl_code.InteractiveText = true;
            this.lbl_code.Location = new System.Drawing.Point(202, 54);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(121, 26);
            this.lbl_code.TabIndex = 113;
            this.lbl_code.Text = "RESPONSE CODE:";
            this.lbl_code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_replyid
            // 
            this.tbx_replyid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_replyid.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_replyid.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tbx_replyid.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_replyid.Location = new System.Drawing.Point(280, 30);
            this.tbx_replyid.Name = "tbx_replyid";
            this.tbx_replyid.NumericCharOnly = false;
            this.tbx_replyid.OctalOnly = false;
            this.tbx_replyid.Size = new System.Drawing.Size(40, 25);
            this.tbx_replyid.TabIndex = 112;
            // 
            // lbl_reply
            // 
            this.lbl_reply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_reply.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_reply.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_reply.HasBorder = false;
            this.lbl_reply.InteractiveText = true;
            this.lbl_reply.Location = new System.Drawing.Point(202, 29);
            this.lbl_reply.Name = "lbl_reply";
            this.lbl_reply.Size = new System.Drawing.Size(83, 26);
            this.lbl_reply.TabIndex = 111;
            this.lbl_reply.Text = "REPLY ID:";
            this.lbl_reply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_msgid
            // 
            this.tbx_msgid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_msgid.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_msgid.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tbx_msgid.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_msgid.Location = new System.Drawing.Point(81, 56);
            this.tbx_msgid.Name = "tbx_msgid";
            this.tbx_msgid.NumericCharOnly = false;
            this.tbx_msgid.OctalOnly = false;
            this.tbx_msgid.Size = new System.Drawing.Size(40, 25);
            this.tbx_msgid.TabIndex = 110;
            // 
            // lbl_msgid
            // 
            this.lbl_msgid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_msgid.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_msgid.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_msgid.HasBorder = false;
            this.lbl_msgid.InteractiveText = true;
            this.lbl_msgid.Location = new System.Drawing.Point(3, 55);
            this.lbl_msgid.Name = "lbl_msgid";
            this.lbl_msgid.Size = new System.Drawing.Size(83, 26);
            this.lbl_msgid.TabIndex = 109;
            this.lbl_msgid.Text = "MSG ID:";
            this.lbl_msgid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_send.Location = new System.Drawing.Point(342, 3);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(112, 28);
            this.btn_send.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.SubText = "";
            this.btn_send.TabIndex = 106;
            this.btn_send.Text = "SEND MESSAGE";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tbx_callsign
            // 
            this.tbx_callsign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_callsign.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_callsign.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tbx_callsign.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbx_callsign.Location = new System.Drawing.Point(81, 32);
            this.tbx_callsign.Name = "tbx_callsign";
            this.tbx_callsign.NumericCharOnly = false;
            this.tbx_callsign.OctalOnly = false;
            this.tbx_callsign.Size = new System.Drawing.Size(107, 25);
            this.tbx_callsign.TabIndex = 30;
            // 
            // lbl_call
            // 
            this.lbl_call.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_call.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_call.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_call.HasBorder = false;
            this.lbl_call.InteractiveText = true;
            this.lbl_call.Location = new System.Drawing.Point(3, 29);
            this.lbl_call.Name = "lbl_call";
            this.lbl_call.Size = new System.Drawing.Size(86, 26);
            this.lbl_call.TabIndex = 29;
            this.lbl_call.Text = "CALLSIGN:";
            this.lbl_call.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_pilotres
            // 
            this.lbl_pilotres.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_pilotres.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_pilotres.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_pilotres.HasBorder = false;
            this.lbl_pilotres.InteractiveText = true;
            this.lbl_pilotres.Location = new System.Drawing.Point(3, 3);
            this.lbl_pilotres.Name = "lbl_pilotres";
            this.lbl_pilotres.Size = new System.Drawing.Size(153, 26);
            this.lbl_pilotres.TabIndex = 28;
            this.lbl_pilotres.Text = "PILOT SENT MESSAGE";
            this.lbl_pilotres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_u
            // 
            this.btn_u.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_u.Location = new System.Drawing.Point(40, 110);
            this.btn_u.Name = "btn_u";
            this.btn_u.Size = new System.Drawing.Size(28, 28);
            this.btn_u.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_u.SubText = "";
            this.btn_u.TabIndex = 116;
            this.btn_u.Text = "U";
            this.btn_u.UseVisualStyleBackColor = true;
            this.btn_u.Click += new System.EventHandler(this.btn_u_Click);
            // 
            // btn_s
            // 
            this.btn_s.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_s.Location = new System.Drawing.Point(74, 110);
            this.btn_s.Name = "btn_s";
            this.btn_s.Size = new System.Drawing.Size(28, 28);
            this.btn_s.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_s.SubText = "";
            this.btn_s.TabIndex = 117;
            this.btn_s.Text = "S";
            this.btn_s.UseVisualStyleBackColor = true;
            this.btn_s.Click += new System.EventHandler(this.btn_s_Click);
            // 
            // btn_r
            // 
            this.btn_r.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_r.Location = new System.Drawing.Point(109, 110);
            this.btn_r.Name = "btn_r";
            this.btn_r.Size = new System.Drawing.Size(28, 28);
            this.btn_r.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_r.SubText = "";
            this.btn_r.TabIndex = 118;
            this.btn_r.Text = "R";
            this.btn_r.UseVisualStyleBackColor = true;
            this.btn_r.Click += new System.EventHandler(this.btn_r_Click);
            // 
            // btn_a
            // 
            this.btn_a.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_a.Location = new System.Drawing.Point(143, 110);
            this.btn_a.Name = "btn_a";
            this.btn_a.Size = new System.Drawing.Size(28, 28);
            this.btn_a.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_a.SubText = "";
            this.btn_a.TabIndex = 119;
            this.btn_a.Text = "A";
            this.btn_a.UseVisualStyleBackColor = true;
            this.btn_a.Click += new System.EventHandler(this.btn_a_Click);
            // 
            // btn_n
            // 
            this.btn_n.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_n.Location = new System.Drawing.Point(177, 110);
            this.btn_n.Name = "btn_n";
            this.btn_n.Size = new System.Drawing.Size(28, 28);
            this.btn_n.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n.SubText = "";
            this.btn_n.TabIndex = 120;
            this.btn_n.Text = "N";
            this.btn_n.UseVisualStyleBackColor = true;
            this.btn_n.Click += new System.EventHandler(this.btn_n_Click);
            // 
            // DebugWindow
            // 
            this.ClientSize = new System.Drawing.Size(481, 458);
            this.Controls.Add(this.insetPanel3);
            this.Controls.Add(this.btn_netchecks);
            this.Controls.Add(this.lbl_netchecks);
            this.Controls.Add(this.insetPanel1);
            this.Controls.Add(this.insetPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "DebugWindow";
            this.Resizeable = false;
            this.Text = "vatACARS DEBUG";
            this.Load += new System.EventHandler(this.DebugWindow_Load);
            this.Shown += new System.EventHandler(this.DebugWindow_Shown);
            this.insetPanel2.ResumeLayout(false);
            this.insetPanel2.PerformLayout();
            this.insetPanel1.ResumeLayout(false);
            this.insetPanel1.PerformLayout();
            this.insetPanel3.ResumeLayout(false);
            this.insetPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private vatsys.TextField tbx_content;
        private vatsys.InsetPanel insetPanel2;
        private vatsys.TextLabel lbl_messagecreate;
        private vatsys.TextLabel lbl_content;
        private vatsys.TextField tbx_station;
        private vatsys.TextLabel lbl_callsign;
        private vatsys.TextLabel lbl_state;
        private VATSYSControls.DropDownBox dd_state;
        private vatsys.GenericButton btn_add;
        private VATSYSControls.DropDownBox dd_type;
        private vatsys.TextLabel lbl_type;
        private vatsys.InsetPanel insetPanel1;
        private vatsys.GenericButton btn_screate;
        private vatsys.TextField tbx_stationc;
        private vatsys.TextLabel lbl_stationc;
        private vatsys.TextLabel lbl_stationcreate;
        private vatsys.TextLabel lbl_prov;
        private VATSYSControls.DropDownBox dd_prov;
        private vatsys.GenericButton btn_netchecks;
        private vatsys.TextLabel lbl_netchecks;
        private vatsys.GenericButton btn_rdmstn;
        private vatsys.TextLabel lbl_rdmstn;
        private vatsys.InsetPanel insetPanel3;
        private vatsys.TextLabel lbl_msgid;
        private vatsys.GenericButton btn_send;
        private vatsys.TextField tbx_callsign;
        private vatsys.TextLabel lbl_call;
        private vatsys.TextLabel lbl_pilotres;
        private vatsys.TextField tbx_msgid;
        private vatsys.TextField tbx_response;
        private vatsys.TextLabel lbl_code;
        private vatsys.TextField tbx_replyid;
        private vatsys.TextLabel lbl_reply;
        private vatsys.TextLabel lbl_content2;
        private vatsys.TextField tbx_content2;
        private vatsys.GenericButton btn_w;
        private vatsys.GenericButton btn_u;
        private vatsys.GenericButton btn_n;
        private vatsys.GenericButton btn_a;
        private vatsys.GenericButton btn_r;
        private vatsys.GenericButton btn_s;
    }
}