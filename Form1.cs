using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public static int recPerTrack_Sector, recPerTrack_Block, TotalFragmentation_Sector, TotalFragmentation_Block;
        public static StorageManager SM;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            /*XmlTextWriter xw = new XmlTextWriter("F:\\Courses\\xdoc.xml", Encoding.UTF8);
             xw.Formatting = Formatting.Indented;
             xw.WriteStartElement("sector");
             //xw.WriteString(txt_sec.Text);

             xw.WriteStartElement("track");
             //xw.WriteString(txt_track.Text);
             
             xw.WriteStartElement("Blocking factor");
             xw.WriteString(txt_bf.Text);
             xw.WriteEndElement();
             xw.WriteStartElement("NO RECORD");

             xw.WriteString(txt_nrec.Text);
             xw.WriteEndElement();
             xw.WriteStartElement("REC SIZE");



             xw.WriteString(txt_rsize.Text);
             xw.WriteEndElement();

             xw.WriteEndElement();
            xw.WriteEndElement();
            xw.Close();

           /* XmlDocument m = new XmlDocument();
            m.Load("F:\\Courses\\xdoc.xml");

            XmlNode trac = m.CreateElement("track");
            XmlNode bf = m.CreateElement("Blocking factor");
            bf.InnerText = txt_sec.Text;
            trac.AppendChild(bf);
            m.DocumentElement.AppendChild(trac);
            m.Save("F:\\Courses\\xdoc.xml");*/

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            try
            {
                SM = new StorageManager(int.Parse(no_data.Text), int.Parse(txt_rsize.Text), int.Parse(txt_bf.Text), int.Parse(txt_track.Text), int.Parse(txt_sec.Text), int.Parse(txt_nrec.Text));


                recPerTrack_Sector = SM.RecordPerTrack_Sector();
                TotalFragmentation_Sector = SM.Fragmentation_sector();
                recPerTrack_Block = SM.RecordPerTrack_Block();
                TotalFragmentation_Block = SM.Fragmentation_Block();

            }
            catch
            {
                MessageBox.Show("The Values is't Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Comparison c = new Comparison();
            c.Show();
            
        }

        private void txt_sec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 0x08)
            {
                e.Handled = true;
            }
        }

        private void txt_track_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 0x08)
            {
                e.Handled = true;
            }
        }

        private void txt_bf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 0x08)
            {
                e.Handled = true;
            }
        }

        private void txt_nrec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 0x08)
            {
                e.Handled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                SM = new StorageManager(int.Parse(no_data.Text), int.Parse(txt_rsize.Text), int.Parse(txt_bf.Text), int.Parse(txt_track.Text), int.Parse(txt_sec.Text), int.Parse(txt_nrec.Text));


                recPerTrack_Sector = SM.RecordPerTrack_Sector();
                TotalFragmentation_Sector = SM.Fragmentation_sector();
                recPerTrack_Block = SM.RecordPerTrack_Block();
                TotalFragmentation_Block = SM.Fragmentation_Block();
                Comparison c = new Comparison();
                c.Show();
            }
            catch
            {
                MessageBox.Show("Invalid Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void txt_rsize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 0x08)
            {
                e.Handled = true;
            }
        }

        private void no_data_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 0x08)
            {
                e.Handled = true;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try {
                
                SM.Save(txt_sec.Text, txt_track.Text, txt_bf.Text, txt_nrec.Text, txt_rsize.Text, no_data.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Iformation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
