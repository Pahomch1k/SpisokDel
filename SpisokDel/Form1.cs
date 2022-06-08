using System;
using System.Media;
using System.Xml;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing;

namespace SpisokDel
{
    public partial class Form1 : Form
    {
        SoundPlayer soundAudio;
        public Button[] bColor;
        public Label[] lColor;
           
         
        public Form1()
        {
            InitializeComponent();
                
            bColor = new Button[10] { bAddZ, bAddP, bAddZP, bSeeP, bSeeZ, bSearchP, bSearchZ, bExit, bOnToday, bpdf };
            lColor = new Label[3] { label1, label2, label3 };
        }

        #region Добавить 
        private void bAddZ_Click(object sender, EventArgs e)
        {
            if (CTemaZvuk.GetZvuk() == 0) ZvukB();
            FAddZ f = new FAddZ();
            f.ShowDialog();
        }

        private void bAddP_Click(object sender, EventArgs e)
        { 
            if (CTemaZvuk.GetZvuk() == 0) ZvukB();
            FAddP f = new FAddP(0);
            f.ShowDialog();
        }

        private void bAddZP_Click(object sender, EventArgs e)
        { 
            if (CTemaZvuk.GetZvuk() == 0) ZvukB();
            FAddP f = new FAddP(1);
            f.ShowDialog();
        }
        #endregion

        #region Просмотр 
        private void bSeeZ_Click(object sender, EventArgs e)
        { 
            if (CTemaZvuk.GetZvuk() == 0) ZvukB();
            FSeeZ f = new FSeeZ(0);
            f.ShowDialog();
        }

        private void bSeeP_Click(object sender, EventArgs e)
        {
            if (CTemaZvuk.GetZvuk() == 0) ZvukB();
            FSeeZ f = new FSeeZ(1);
            //FProgB f = new FProgB();
            f.ShowDialog();
        }

        private void bOnToday_Click(object sender, EventArgs e)
        {
            if (CTemaZvuk.GetZvuk() == 0) ZvukB();

            FDate f = new FDate();
            f.ShowDialog();
        }
        #endregion

        #region Поиск/Правки 
        private void bSearchZ_Click(object sender, EventArgs e)
        {
            if (CTemaZvuk.GetZvuk() == 0) ZvukB();
            FSearchZ f = new FSearchZ(0);
            f.ShowDialog();
        }

        private void bSearchP_Click(object sender, EventArgs e)
        {
            if (CTemaZvuk.GetZvuk() == 0) ZvukB();
            FSearchZ f = new FSearchZ(1);
            f.ShowDialog();
        }

        private void bpdf_Click(object sender, EventArgs e)
        {
            if (CTemaZvuk.GetZvuk() == 0)
            {
                soundAudio = new SoundPlayer(Resource1.ToPdf);
                soundAudio.Play();
            }

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Zadachi.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            string s = "";
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null) s += $"Name: {attr.Value}\n";
                }
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "Tag") s += $"Tag: {childnode.FirstChild.Value}\n";
                    if (childnode.Name == "Date") s += $"Date: {childnode.InnerText}\n";
                    if (childnode.Name == "Comment")
                    {
                        s += $"Comment: {childnode.InnerText}";
                        s += "\n";
                    }
                }
            }
            xDoc.Save("Zadachi.xml");
              
            var document = new iTextSharp.text.Document();
            using (var writer = PdfWriter.GetInstance(document, new FileStream("Zadachi.pdf", FileMode.OpenOrCreate)))
            {
                document.Open(); 
                document.Add(new Paragraph(s)); 
                document.Close();
                writer.Close();
            }  
        } 
        #endregion

        #region Меню
        private void звукToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (CTemaZvuk.GetZvuk() == 0)
            {
                CTemaZvuk.SetZvuk(1);
                звукToolStripMenuItem1.Text = "Звук OFF";
            }
            else
            {
                CTemaZvuk.SetZvuk(0);
                звукToolStripMenuItem1.Text = "Звук ON";
            }
        }
          
        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            BackColor = Color.WhiteSmoke;

            //Кнопки 
            for (int i = 0; i < 10; i++)
            {
                bColor[i].BackColor = Color.LightSkyBlue;
                bColor[i].ForeColor = Color.Black;
            }

            //Лейблы
            for (int i = 0; i < 3; i++) lColor[i].ForeColor = Color.Black;

            //Меню
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.ForeColor = Color.Black;
            звукONToolStripMenuItem.BackColor = Color.WhiteSmoke;
            звукONToolStripMenuItem.ForeColor = Color.Black;
            звукToolStripMenuItem1.BackColor = Color.WhiteSmoke;
            звукToolStripMenuItem1.ForeColor = Color.Black;
            светляТемаToolStripMenuItem.BackColor = Color.WhiteSmoke;
            светляТемаToolStripMenuItem.ForeColor = Color.Black;
            светлаяToolStripMenuItem.BackColor = Color.WhiteSmoke;
            светлаяToolStripMenuItem.ForeColor = Color.Black;
            темнаяToolStripMenuItem.BackColor = Color.WhiteSmoke;
            темнаяToolStripMenuItem.ForeColor = Color.Black;

            CTemaZvuk.SetTema(0);
        }

        private void темнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;

            //Кнопки 
            for (int i = 0; i < 10; i++)
            {
                bColor[i].BackColor = Color.Gray;
                bColor[i].ForeColor = Color.White;
            }

            //Лейблы
            for (int i = 0; i < 3; i++) lColor[i].ForeColor = Color.White;

            //Меню
            menuStrip1.BackColor = Color.Gray;
            menuStrip1.ForeColor = Color.White;
            звукONToolStripMenuItem.BackColor = Color.Gray;
            звукONToolStripMenuItem.ForeColor = Color.White;
            звукToolStripMenuItem1.BackColor = Color.Gray;
            звукToolStripMenuItem1.ForeColor = Color.White;
            светляТемаToolStripMenuItem.BackColor = Color.Gray;
            светляТемаToolStripMenuItem.ForeColor = Color.White;
            светлаяToolStripMenuItem.BackColor = Color.Gray;
            светлаяToolStripMenuItem.ForeColor = Color.White;
            темнаяToolStripMenuItem.BackColor = Color.Gray;
            темнаяToolStripMenuItem.ForeColor = Color.White;

            CTemaZvuk.SetTema(1);
        }
        #endregion

        //звук кнопки
        public void ZvukB()
        {
            soundAudio = new SoundPlayer(Resource1.zvukButton);
            soundAudio.Play();
        }

        //Выход
        private void bExit_Click(object sender, EventArgs e)
        {
            if (CTemaZvuk.GetZvuk() == 0)
            {
                soundAudio = new SoundPlayer(Resource1.zvukExit);
                soundAudio.Play();
                Thread.Sleep(850);
            }
            Application.Exit();
        } 
    }
}