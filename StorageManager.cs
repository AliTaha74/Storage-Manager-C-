using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
namespace WindowsFormsApplication2
{
    public class StorageManager
    {
        public int NonDataOverHead;
        public int RecSize;
        public int BlockingFactor;
        public int BlockSize;
        public int SectorSize;
        public int BlockPerTrack;
        public int RecPerSector;
        public int RecordNo;
        public int SecPerTrack;
        public int TrackSize;

        public int total_tracks_Block;
        public int TotalSectors;

        public StorageManager()
        {
            NonDataOverHead = 0;
            RecSize = 0;
            BlockingFactor = 0;
            SecPerTrack = 0;
            SectorSize = 0;
            BlockPerTrack = 0;
            BlockSize = 0;
            RecPerSector = 0;
            RecordNo = 0;
            TrackSize = 0;

            total_tracks_Block = 0;
            TotalSectors = 0;
        }

        public void Block_Case()
        {


            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "xmlfilelol |*.xml";
            sf.FileName = "my lol";
            sf.Title = "titlol";
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = sf.FileName;


                XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();

                writer.WriteStartElement("Data");

                writer.WriteStartElement("Fragmentation in Case of Block");
                writer.WriteString(Fragmentation_Block().ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("Track");

                writer.WriteStartElement("Total Number of used Tracks");
                writer.WriteString(total_tracks_Block.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("Block");


                writer.WriteStartElement("Number of Blocks per Track");
                writer.WriteString(BlockPerTrack.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("Record");

                writer.WriteStartElement("Record Per Track in Case of Block");
                writer.WriteString(RecordPerTrack_Block().ToString());
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Close();
                sf.Dispose();
            }
        }

        public void Sector_Case()
        {

            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "xmlfilelol |*.xml";
            sf.FileName = "my lol";
            sf.Title = "titlol";
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = sf.FileName;


                XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;


                writer.WriteStartDocument();

                writer.WriteStartElement("Data");



                writer.WriteStartElement("Total Number of used Sectors");
                writer.WriteString(TotalSectors.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("Record Per Track in Case of Sector");
                writer.WriteString(RecordPerTrack_Sector().ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("Fragmentation in Case of sector");
                writer.WriteString(Fragmentation_sector().ToString());
                writer.WriteEndElement();

                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Close();

                sf.Dispose();
            }
        }
        public StorageManager(int ndo, int RS, int bf, int SecTr, int sz, int recNo)
        {
            NonDataOverHead = ndo;
            RecSize = RS;
            BlockingFactor = bf;
            SecPerTrack = SecTr;
            SectorSize = sz;
            BlockPerTrack = 0;
            BlockSize = 0;
            RecPerSector = SectorSize / RecSize;
            RecordNo = recNo;
            TrackSize = SecPerTrack * SectorSize;

            total_tracks_Block = 0;
            TotalSectors = 0;
        }

        public int RecordPerTrack_Block()
        {
            BlockSize = NonDataOverHead + (RecSize * BlockingFactor);
            BlockPerTrack = TrackSize / BlockSize;
            return (BlockPerTrack * BlockingFactor);

        }
        public int RecordPerTrack_Sector()
        {
            return (RecPerSector * SecPerTrack);
        }
        public int Fragmentation_Block()
        {

            total_tracks_Block = RecordNo / RecordPerTrack_Block();
            int usedspace = BlockSize * BlockPerTrack;
            return ((total_tracks_Block) * (TrackSize - usedspace));
        }
        public int Fragmentation_sector()
        {
            int usedspaceinsec = RecPerSector * RecSize;
            int fragPerSector = SectorSize - usedspaceinsec;
            TotalSectors = RecordNo / RecPerSector;
            return (fragPerSector) * (TotalSectors);
        }

        public bool Most_Effcient()
        {
            if (Fragmentation_sector() > Fragmentation_Block())
                return true;
            else if (Fragmentation_sector() < Fragmentation_Block())
                return false;
            else
            {
                if (RecordPerTrack_Sector() > RecordPerTrack_Block())
                    return false;
                else
                    return true;
            }
        }


        public int Total_Blocks_Block()
        {
            return total_tracks_Block * BlockPerTrack;
        }

        public int Total_Tracks_Sector()
        {
            return TotalSectors / SecPerTrack;
        }
        //func save data into file
        public void Save(string sec_sz, string secPtrk, string bf, string noRec, string rec_sz, string nDo)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "txtfilelol|*.txt";
            sf.FileName = "myDATA";
            sf.Title = "titlo";
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = sf.FileName;

                string full = sec_sz + "*" + secPtrk + "*" + bf + "*" + noRec + "*" + rec_sz + "*" + nDo;
                FileStream f = new FileStream(path, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(f);
                sw.Write(full);
                sw.Close();
            }
        }
 
    }
}

