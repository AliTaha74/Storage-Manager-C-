namespace WindowsFormsApplication2
{
    partial class Comparison
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comparison));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SectorME = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.recSector = new System.Windows.Forms.Label();
            this.FragSector = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BlockME = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.recBlock = new System.Windows.Forms.Label();
            this.FragBlock = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Sectorcheck = new System.Windows.Forms.RadioButton();
            this.BlockCheck = new System.Windows.Forms.RadioButton();
            this.panel_bef1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel_benfu2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.saving_myfile = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SectorME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.BlockME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel_bef1.SuspendLayout();
            this.panel_benfu2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(6, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fragmentation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Block";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sector";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 481);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(7, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Records/Track";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.SectorME);
            this.panel2.Controls.Add(this.recSector);
            this.panel2.Controls.Add(this.FragSector);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(255, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 481);
            this.panel2.TabIndex = 5;
            // 
            // SectorME
            // 
            this.SectorME.BackColor = System.Drawing.Color.Transparent;
            this.SectorME.Controls.Add(this.pictureBox1);
            this.SectorME.Controls.Add(this.label5);
            this.SectorME.Location = new System.Drawing.Point(13, 16);
            this.SectorME.Name = "SectorME";
            this.SectorME.Size = new System.Drawing.Size(229, 48);
            this.SectorME.TabIndex = 15;
            this.SectorME.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(56, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Most Efficient";
            // 
            // recSector
            // 
            this.recSector.AutoSize = true;
            this.recSector.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recSector.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.recSector.Location = new System.Drawing.Point(44, 171);
            this.recSector.Name = "recSector";
            this.recSector.Size = new System.Drawing.Size(189, 29);
            this.recSector.TabIndex = 4;
            this.recSector.Text = "Records/Track";
            this.recSector.Click += new System.EventHandler(this.recSector_Click);
            // 
            // FragSector
            // 
            this.FragSector.AutoSize = true;
            this.FragSector.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FragSector.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.FragSector.Location = new System.Drawing.Point(53, 294);
            this.FragSector.Name = "FragSector";
            this.FragSector.Size = new System.Drawing.Size(189, 29);
            this.FragSector.TabIndex = 5;
            this.FragSector.Text = "Fragmentation";
            this.FragSector.Click += new System.EventHandler(this.FragSector_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.BlockME);
            this.panel3.Controls.Add(this.recBlock);
            this.panel3.Controls.Add(this.FragBlock);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(517, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 481);
            this.panel3.TabIndex = 6;
            // 
            // BlockME
            // 
            this.BlockME.BackColor = System.Drawing.Color.Transparent;
            this.BlockME.Controls.Add(this.pictureBox2);
            this.BlockME.Controls.Add(this.label7);
            this.BlockME.Location = new System.Drawing.Point(0, 16);
            this.BlockME.Name = "BlockME";
            this.BlockME.Size = new System.Drawing.Size(229, 48);
            this.BlockME.TabIndex = 16;
            this.BlockME.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 43);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(56, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Most Efficient";
            // 
            // recBlock
            // 
            this.recBlock.AutoSize = true;
            this.recBlock.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recBlock.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.recBlock.Location = new System.Drawing.Point(25, 171);
            this.recBlock.Name = "recBlock";
            this.recBlock.Size = new System.Drawing.Size(189, 29);
            this.recBlock.TabIndex = 6;
            this.recBlock.Text = "Records/Track";
            // 
            // FragBlock
            // 
            this.FragBlock.AutoSize = true;
            this.FragBlock.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FragBlock.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.FragBlock.Location = new System.Drawing.Point(25, 294);
            this.FragBlock.Name = "FragBlock";
            this.FragBlock.Size = new System.Drawing.Size(189, 29);
            this.FragBlock.TabIndex = 7;
            this.FragBlock.Text = "Fragmentation";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 9);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(691, 569);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Sector Case";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Sectorcheck
            // 
            this.Sectorcheck.AutoSize = true;
            this.Sectorcheck.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sectorcheck.Location = new System.Drawing.Point(1054, 588);
            this.Sectorcheck.Name = "Sectorcheck";
            this.Sectorcheck.Size = new System.Drawing.Size(92, 27);
            this.Sectorcheck.TabIndex = 9;
            this.Sectorcheck.TabStop = true;
            this.Sectorcheck.Text = "Sector";
            this.Sectorcheck.UseVisualStyleBackColor = true;
            // 
            // BlockCheck
            // 
            this.BlockCheck.AutoSize = true;
            this.BlockCheck.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlockCheck.Location = new System.Drawing.Point(1165, 588);
            this.BlockCheck.Name = "BlockCheck";
            this.BlockCheck.Size = new System.Drawing.Size(83, 27);
            this.BlockCheck.TabIndex = 8;
            this.BlockCheck.TabStop = true;
            this.BlockCheck.Text = "Block";
            this.BlockCheck.UseVisualStyleBackColor = true;
            // 
            // panel_bef1
            // 
            this.panel_bef1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_bef1.BackgroundImage")));
            this.panel_bef1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_bef1.Controls.Add(this.panel3);
            this.panel_bef1.Controls.Add(this.panel2);
            this.panel_bef1.Controls.Add(this.panel1);
            this.panel_bef1.GradientBottomLeft = System.Drawing.Color.Indigo;
            this.panel_bef1.GradientBottomRight = System.Drawing.Color.Lavender;
            this.panel_bef1.GradientTopLeft = System.Drawing.Color.LightCoral;
            this.panel_bef1.GradientTopRight = System.Drawing.Color.SlateBlue;
            this.panel_bef1.Location = new System.Drawing.Point(3, 3);
            this.panel_bef1.Name = "panel_bef1";
            this.panel_bef1.Quality = 10;
            this.panel_bef1.Size = new System.Drawing.Size(817, 578);
            this.panel_bef1.TabIndex = 15;
            // 
            // panel_benfu2
            // 
            this.panel_benfu2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_benfu2.BackgroundImage")));
            this.panel_benfu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_benfu2.Controls.Add(this.panel_bef1);
            this.panel_benfu2.Controls.Add(this.chart1);
            this.panel_benfu2.GradientBottomLeft = System.Drawing.Color.White;
            this.panel_benfu2.GradientBottomRight = System.Drawing.Color.White;
            this.panel_benfu2.GradientTopLeft = System.Drawing.Color.White;
            this.panel_benfu2.GradientTopRight = System.Drawing.Color.White;
            this.panel_benfu2.Location = new System.Drawing.Point(-2, 1);
            this.panel_benfu2.Name = "panel_benfu2";
            this.panel_benfu2.Quality = 10;
            this.panel_benfu2.Size = new System.Drawing.Size(820, 581);
            this.panel_benfu2.TabIndex = 15;
            this.panel_benfu2.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // saving_myfile
            // 
            this.saving_myfile.ActiveBorderThickness = 1;
            this.saving_myfile.ActiveCornerRadius = 20;
            this.saving_myfile.ActiveFillColor = System.Drawing.Color.Green;
            this.saving_myfile.ActiveForecolor = System.Drawing.Color.Transparent;
            this.saving_myfile.ActiveLineColor = System.Drawing.Color.Green;
            this.saving_myfile.BackColor = System.Drawing.Color.SlateBlue;
            this.saving_myfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saving_myfile.BackgroundImage")));
            this.saving_myfile.ButtonText = "Save File";
            this.saving_myfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saving_myfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saving_myfile.ForeColor = System.Drawing.Color.SeaGreen;
            this.saving_myfile.IdleBorderThickness = 1;
            this.saving_myfile.IdleCornerRadius = 20;
            this.saving_myfile.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.saving_myfile.IdleForecolor = System.Drawing.Color.Navy;
            this.saving_myfile.IdleLineColor = System.Drawing.Color.Maroon;
            this.saving_myfile.Location = new System.Drawing.Point(370, 641);
            this.saving_myfile.Margin = new System.Windows.Forms.Padding(5);
            this.saving_myfile.Name = "saving_myfile";
            this.saving_myfile.Size = new System.Drawing.Size(181, 71);
            this.saving_myfile.TabIndex = 18;
            this.saving_myfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saving_myfile.Click += new System.EventHandler(this.saving_myfile_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumPurple;
            this.panel4.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.growth_3078544__340;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.bunifuCustomLabel1);
            this.panel4.Location = new System.Drawing.Point(818, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(666, 578);
            this.panel4.TabIndex = 19;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bunifuCustomLabel1.Image = global::WindowsFormsApplication2.Properties.Resources._069637_blue_metallic_orb_icon_alphanumeric_crossing;
            this.bunifuCustomLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(175, 510);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(332, 29);
            this.bunifuCustomLabel1.TabIndex = 20;
            this.bunifuCustomLabel1.Text = "Select The File Organization";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Select Organization";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(1027, 631);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(249, 83);
            this.bunifuThinButton21.TabIndex = 23;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Comparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1497, 726);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.saving_myfile);
            this.Controls.Add(this.panel_benfu2);
            this.Controls.Add(this.Sectorcheck);
            this.Controls.Add(this.BlockCheck);
            this.Name = "Comparison";
            this.Text = "Comparison";
            this.Load += new System.EventHandler(this.Comparison_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.SectorME.ResumeLayout(false);
            this.SectorME.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.BlockME.ResumeLayout(false);
            this.BlockME.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel_bef1.ResumeLayout(false);
            this.panel_benfu2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label recSector;
        private System.Windows.Forms.Label FragSector;
        private System.Windows.Forms.Label recBlock;
        private System.Windows.Forms.Label FragBlock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton Sectorcheck;
        private System.Windows.Forms.RadioButton BlockCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SectorME;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BlockME;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_bef1;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_benfu2;
        private Bunifu.Framework.UI.BunifuThinButton2 saving_myfile;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}