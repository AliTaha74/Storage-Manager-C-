namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sec = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_track = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_bf = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_nrec = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_rsize = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.no_data = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(2, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Non-Data Overhead";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sector Size";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(50, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Record Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(34, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sector/Track";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(34, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "No. of Records";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(34, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Blocking Factor";
            // 
            // txt_sec
            // 
            this.txt_sec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_sec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sec.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sec.HintForeColor = System.Drawing.Color.Empty;
            this.txt_sec.HintText = "";
            this.txt_sec.isPassword = false;
            this.txt_sec.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.txt_sec.LineIdleColor = System.Drawing.Color.DimGray;
            this.txt_sec.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.txt_sec.LineThickness = 4;
            this.txt_sec.Location = new System.Drawing.Point(239, 42);
            this.txt_sec.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sec.Name = "txt_sec";
            this.txt_sec.Size = new System.Drawing.Size(226, 28);
            this.txt_sec.TabIndex = 28;
            this.txt_sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_sec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sec_KeyPress);
            // 
            // txt_track
            // 
            this.txt_track.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_track.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_track.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_track.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_track.HintForeColor = System.Drawing.Color.Empty;
            this.txt_track.HintText = "";
            this.txt_track.isPassword = false;
            this.txt_track.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.txt_track.LineIdleColor = System.Drawing.Color.DimGray;
            this.txt_track.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.txt_track.LineThickness = 4;
            this.txt_track.Location = new System.Drawing.Point(239, 96);
            this.txt_track.Margin = new System.Windows.Forms.Padding(4);
            this.txt_track.Name = "txt_track";
            this.txt_track.Size = new System.Drawing.Size(226, 29);
            this.txt_track.TabIndex = 29;
            this.txt_track.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_track.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_track_KeyPress);
            // 
            // txt_bf
            // 
            this.txt_bf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_bf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bf.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_bf.HintForeColor = System.Drawing.Color.Empty;
            this.txt_bf.HintText = "";
            this.txt_bf.isPassword = false;
            this.txt_bf.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.txt_bf.LineIdleColor = System.Drawing.Color.DimGray;
            this.txt_bf.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.txt_bf.LineThickness = 4;
            this.txt_bf.Location = new System.Drawing.Point(239, 149);
            this.txt_bf.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bf.Name = "txt_bf";
            this.txt_bf.Size = new System.Drawing.Size(226, 28);
            this.txt_bf.TabIndex = 30;
            this.txt_bf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_bf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bf_KeyPress);
            // 
            // txt_nrec
            // 
            this.txt_nrec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_nrec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nrec.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nrec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nrec.HintForeColor = System.Drawing.Color.Empty;
            this.txt_nrec.HintText = "";
            this.txt_nrec.isPassword = false;
            this.txt_nrec.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.txt_nrec.LineIdleColor = System.Drawing.Color.DimGray;
            this.txt_nrec.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.txt_nrec.LineThickness = 4;
            this.txt_nrec.Location = new System.Drawing.Point(239, 211);
            this.txt_nrec.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nrec.Name = "txt_nrec";
            this.txt_nrec.Size = new System.Drawing.Size(226, 28);
            this.txt_nrec.TabIndex = 31;
            this.txt_nrec.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nrec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nrec_KeyPress);
            // 
            // txt_rsize
            // 
            this.txt_rsize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_rsize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_rsize.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rsize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_rsize.HintForeColor = System.Drawing.Color.Empty;
            this.txt_rsize.HintText = "";
            this.txt_rsize.isPassword = false;
            this.txt_rsize.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.txt_rsize.LineIdleColor = System.Drawing.Color.DimGray;
            this.txt_rsize.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.txt_rsize.LineThickness = 4;
            this.txt_rsize.Location = new System.Drawing.Point(239, 271);
            this.txt_rsize.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rsize.Name = "txt_rsize";
            this.txt_rsize.Size = new System.Drawing.Size(226, 28);
            this.txt_rsize.TabIndex = 32;
            this.txt_rsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_rsize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rsize_KeyPress);
            // 
            // no_data
            // 
            this.no_data.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.no_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.no_data.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.no_data.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.no_data.HintForeColor = System.Drawing.Color.Empty;
            this.no_data.HintText = "";
            this.no_data.isPassword = false;
            this.no_data.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.no_data.LineIdleColor = System.Drawing.Color.DimGray;
            this.no_data.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.no_data.LineThickness = 4;
            this.no_data.Location = new System.Drawing.Point(239, 334);
            this.no_data.Margin = new System.Windows.Forms.Padding(4);
            this.no_data.Name = "no_data";
            this.no_data.Size = new System.Drawing.Size(226, 28);
            this.no_data.TabIndex = 33;
            this.no_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.no_data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.no_data_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.no_data);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_rsize);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_nrec);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_bf);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_track);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_sec);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 454);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.ActiveBorderThickness = 1;
            this.bunifuFlatButton1.ActiveCornerRadius = 20;
            this.bunifuFlatButton1.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.BackgroundImage")));
            this.bunifuFlatButton1.ButtonText = "Calculate";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuFlatButton1.IdleBorderThickness = 1;
            this.bunifuFlatButton1.IdleCornerRadius = 20;
            this.bunifuFlatButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.IdleForecolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.IdleLineColor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(288, 392);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Size = new System.Drawing.Size(136, 34);
            this.bunifuFlatButton1.TabIndex = 36;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Save Data ";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.MidnightBlue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(49, 392);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(136, 34);
            this.bunifuThinButton21.TabIndex = 35;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(-3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(535, 27);
            this.label7.TabIndex = 37;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(505, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 434);
            this.label8.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(533, 453);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_sec;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_track;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_bf;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_nrec;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_rsize;
        private Bunifu.Framework.UI.BunifuMaterialTextbox no_data;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuFlatButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

