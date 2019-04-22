using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Comparison : Form
    {
        public Comparison()
        {
            InitializeComponent();


            recSector.Text = Form1.recPerTrack_Sector.ToString();
            recBlock.Text = Form1.recPerTrack_Block.ToString();
            FragBlock.Text = Form1.TotalFragmentation_Block.ToString();
            FragSector.Text = Form1.TotalFragmentation_Sector.ToString();
            saving_myfile.Visible = false;
            if (Form1.SM.Most_Effcient())
                BlockME.Visible = true;
            else
                SectorME.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            panel_benfu2.Visible = true;
            panel_bef1.Visible = false;

            if (Sectorcheck.Checked)
            {


                chart1.Series["Series1"].Points.Add(Form1.SM.RecordPerTrack_Sector());
                chart1.Series["Series1"].Points[0].Color = Color.Blue;
                chart1.Series["Series1"].Points[0].AxisLabel = "Record /Track";
                chart1.Series["Series1"].Points[0].LegendText = "Record /Track";
                chart1.Series["Series1"].Points[0].Label = Form1.SM.RecordPerTrack_Sector().ToString();

                chart1.Series["Series1"].Points.Add(Form1.SM.TotalSectors);
                chart1.Series["Series1"].Points[1].Color = Color.Green;
                chart1.Series["Series1"].Points[1].AxisLabel = "Filled Sectors";
                chart1.Series["Series1"].Points[1].LegendText = "Filled Sectors";
                chart1.Series["Series1"].Points[1].Label = Form1.SM.TotalSectors.ToString();

                chart1.Series["Series1"].Points.Add(Form1.SM.Fragmentation_sector());
                chart1.Series["Series1"].Points[2].Color = Color.Red;
                chart1.Series["Series1"].Points[2].AxisLabel = "Fragmentation";
                chart1.Series["Series1"].Points[2].LegendText = "Fragmentation";
                chart1.Series["Series1"].Points[2].Label = Form1.SM.Fragmentation_sector().ToString();

                chart1.Series["Series1"].Points.Add(Form1.SM.Total_Tracks_Sector());
                chart1.Series["Series1"].Points[3].Color = Color.Brown;
                chart1.Series["Series1"].Points[3].AxisLabel = "Filled Tracks";
                chart1.Series["Series1"].Points[3].LegendText = "Filled Tracks";
                chart1.Series["Series1"].Points[3].Label = Form1.SM.Total_Tracks_Sector().ToString();
                saving_myfile.Visible = true;


            }
            if (BlockCheck.Checked)
            {


                chart1.Series["Series1"].Points.Add(Form1.SM.RecordPerTrack_Block());
                chart1.Series["Series1"].Points[0].Color = Color.Blue;
                chart1.Series["Series1"].Points[0].AxisLabel = "Record /Track";
                chart1.Series["Series1"].Points[0].LegendText = "Record /Track";
                chart1.Series["Series1"].Points[0].Label = Form1.SM.RecordPerTrack_Block().ToString();

                chart1.Series["Series1"].Points.Add(Form1.SM.Total_Blocks_Block());
                chart1.Series["Series1"].Points[1].Color = Color.Green;
                chart1.Series["Series1"].Points[1].AxisLabel = "Filled Blocks";
                chart1.Series["Series1"].Points[1].LegendText = "Filled Blocks";
                chart1.Series["Series1"].Points[1].Label = Form1.SM.Total_Blocks_Block().ToString();

                chart1.Series["Series1"].Points.Add(Form1.SM.Fragmentation_Block());
                chart1.Series["Series1"].Points[2].Color = Color.Red;
                chart1.Series["Series1"].Points[2].AxisLabel = "Fragmentation";
                chart1.Series["Series1"].Points[2].LegendText = "Fragmentation";
                chart1.Series["Series1"].Points[2].Label = Form1.SM.Fragmentation_Block().ToString();

                chart1.Series["Series1"].Points.Add(Form1.SM.total_tracks_Block);
                chart1.Series["Series1"].Points[3].Color = Color.Brown;
                chart1.Series["Series1"].Points[3].AxisLabel = "Filled Tracks";
                chart1.Series["Series1"].Points[3].LegendText = "Filled Tracks";
                chart1.Series["Series1"].Points[3].Label = Form1.SM.total_tracks_Block.ToString();

                saving_myfile.Visible = true;

            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog s = new SaveFileDialog();
            s.Filter = "File|*.xml";
            s.FileName = "My File";
            s.Title = "Save XML File";

            if (s.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                string path = s.FileName;
                BinaryWriter bw = new BinaryWriter(File.Create(path));
                bw.Write();
                bw.Dispose();
            }*/

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Comparison_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saving_myfile_Click(object sender, EventArgs e)
        {
            if (Sectorcheck.Checked)
            {

                Form1.SM.Sector_Case();

            }
            if (BlockCheck.Checked)
            {


                //block case
                Form1.SM.Block_Case();

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            chart1.Series["Series1"].Points.Clear();
            panel_benfu2.Visible = true;
            panel_bef1.Visible = false;

            if (Sectorcheck.Checked)
            {


                chart1.Series["Series1"].Points.Add(Form1.SM.RecordPerTrack_Sector());
                chart1.Series["Series1"].Points[0].Color = Color.Blue;
                chart1.Series["Series1"].Points[0].AxisLabel = "Record /Track";
                chart1.Series["Series1"].Points[0].LegendText = "Record /Track";
                chart1.Series["Series1"].Points[0].Label = Form1.SM.RecordPerTrack_Sector().ToString();

                chart1.Series["Series1"].Points.Add(Form1.SM.TotalSectors);
                chart1.Series["Series1"].Points[1].Color = Color.Green;
                chart1.Series["Series1"].Points[1].AxisLabel = "Filled Sectors";
                chart1.Series["Series1"].Points[1].LegendText = "Filled Sectors";
                chart1.Series["Series1"].Points[1].Label = Form1.SM.TotalSectors.ToString();

                chart1.Series["Series1"].Points.Add(Form1.SM.Fragmentation_sector());
                chart1.Series["Series1"].Points[2].Color = Color.Red;
                chart1.Series["Series1"].Points[2].AxisLabel = "Fragmentation";
                chart1.Series["Series1"].Points[2].LegendText = "Fragmentation";
                chart1.Series["Series1"].Points[2].Label = Form1.SM.Fragmentation_sector().ToString();

                chart1.Series["Series1"].Points.Add(Form1.SM.Total_Tracks_Sector());
                chart1.Series["Series1"].Points[3].Color = Color.Brown;
                chart1.Series["Series1"].Points[3].AxisLabel = "Filled Tracks";
                chart1.Series["Series1"].Points[3].LegendText = "Filled Tracks";
                chart1.Series["Series1"].Points[3].Label = Form1.SM.Total_Tracks_Sector().ToString();
                saving_myfile.Visible = true;


            }
            if (BlockCheck.Checked)
            {


                chart1.Series["Series1"].Points.Add(Form1.SM.RecordPerTrack_Block());
                chart1.Series["Series1"].Points[0].Color = Color.Blue;
                chart1.Series["Series1"].Points[0].AxisLabel = "Record /Track";
                chart1.Series["Series1"].Points[0].LegendText = "Record /Track";
                chart1.Series["Series1"].Points[0].Label = Form1.SM.RecordPerTrack_Block().ToString();

                chart1.Series["Series1"].Points.Add(Form1.SM.Total_Blocks_Block());
                chart1.Series["Series1"].Points[1].Color = Color.Green;
                chart1.Series["Series1"].Points[1].AxisLabel = "Filled Blocks";
                chart1.Series["Series1"].Points[1].LegendText = "Filled Blocks";
                chart1.Series["Series1"].Points[1].Label = Form1.SM.Total_Blocks_Block().ToString();

                chart1.Series["Series1"].Points.Add(Form1.SM.Fragmentation_Block());
                chart1.Series["Series1"].Points[2].Color = Color.Red;
                chart1.Series["Series1"].Points[2].AxisLabel = "Fragmentation";
                chart1.Series["Series1"].Points[2].LegendText = "Fragmentation";
                chart1.Series["Series1"].Points[2].Label = Form1.SM.Fragmentation_Block().ToString();

                chart1.Series["Series1"].Points.Add(Form1.SM.total_tracks_Block);
                chart1.Series["Series1"].Points[3].Color = Color.Brown;
                chart1.Series["Series1"].Points[3].AxisLabel = "Filled Tracks";
                chart1.Series["Series1"].Points[3].LegendText = "Filled Tracks";
                chart1.Series["Series1"].Points[3].Label = Form1.SM.total_tracks_Block.ToString();

                saving_myfile.Visible = true;
            }



        }

        private void FragSector_Click(object sender, EventArgs e)
        {

        }

        private void recSector_Click(object sender, EventArgs e)
        {

        }
    }
}

