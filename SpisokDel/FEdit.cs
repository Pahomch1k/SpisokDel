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
using System.Xml;
using System.Xml.Linq;
using System.Threading;
using System.Media;

namespace SpisokDel
{
    public partial class FEdit : Form
    {
        SoundPlayer soundAudio;
        public Label[] lColor;

        public string Element { get; set; }
        public string ElProject { get; set; } 
        public int flag { get; set; } 
        public FEdit(string d1, string d2, int f)
        {
            InitializeComponent();
            Element = d1;
            ElProject = d2;
            flag = f; 

            lColor = new Label[4] { label2, label3, label4, label5 };

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";

            if (flag == 0) InitZadach();   
            else InitZadachProj();

            if (CTemaZvuk.GetTema() == 1) DarkTema();
        }
          
        private void bOK_Click(object sender, EventArgs e)
        {  
            if (flag == 0)
            {
                XElement root = XElement.Load("Zadachi.xml");
                IEnumerable<XElement> tests;
                tests = from el in root.Elements("Zadacha")
                        where (string)el.Attribute("name") == Element
                        select el;
                foreach (XElement el in tests)
                {
                    el.Attribute("name").Value = textBox1.Text;
                    el.Element("Tag").Value = comboBox1.Text;
                    el.Element("Date").Value = dateTimePicker1.Text;
                    el.Element("Comment").Value = textBox2.Text;
                }
                root.Save("Zadachi.xml");
            }
            else
            {
                XElement root = XElement.Load("Projects.xml");
                IEnumerable<XElement> tests;
                tests = from el in root.Elements("Project")
                        where (string)el.Attribute("name") == ElProject
                        select el;
                foreach (XElement el in tests)
                {
                    IEnumerable<XElement> tests1;
                    tests1 = from el1 in tests.Elements("Zadacha")
                             where (string)el1.Attribute("name") == Element
                             select el1;
                    foreach (XElement el1 in tests1)
                    {
                        el1.Attribute("name").Value = textBox1.Text;
                        el1.Element("Tag").Value = comboBox1.Text;
                        el1.Element("Date").Value = dateTimePicker1.Text;
                        el1.Element("Comment").Value = textBox2.Text;
                    }
                }
                root.Save("Projects.xml");
            } 
            

            if (CTemaZvuk.GetZvuk() == 0)
            {
                soundAudio = new SoundPlayer(Resource1.zvukEdit);
                soundAudio.Play();
            }
            MessageBox.Show("Задача изменена");
            Close();
        }

        public void InitZadach()
        { 
            XElement root = XElement.Load("Zadachi.xml");
            IEnumerable<XElement> tests;
            tests = from el in root.Elements("Zadacha")
                    where (string)el.Attribute("name") == Element
                    select el;
            foreach (XElement el in tests)
            {
                textBox1.Text = (string)el.Attribute("name");
                comboBox1.Text = (string)el.Element("Tag");
                dateTimePicker1.Value = (DateTime)el.Element("Date");
                textBox2.Text = (string)el.Element("Comment");
            }
            root.Save("Zadachi.xml");
        }

        public void InitZadachProj()
        {
            XElement root = XElement.Load("Projects.xml");
            IEnumerable<XElement> tests;
            tests = from el in root.Elements("Project")
                    where (string)el.Attribute("name") == ElProject
                    select el;
            foreach (XElement el in tests)
            { 
                IEnumerable<XElement> tests1;
                tests1 = from el1 in tests.Elements("Zadacha")
                         where (string)el1.Attribute("name") == Element
                         select el1;
                foreach (XElement el1 in tests1)
                {  
                    textBox1.Text = (string)el1.Attribute("name");
                    comboBox1.Text = (string)el1.Element("Tag");
                    dateTimePicker1.Value = (DateTime)el1.Element("Date");
                    textBox2.Text = (string)el1.Element("Comment");
                }
            }
            root.Save("Projects.xml"); 
        }

        //Темная тема
        public void DarkTema()
        {
            BackColor = Color.Black;

            bOk.BackColor = Color.Gray;
            bOk.ForeColor = Color.White;

            textBox1.BackColor = Color.Gray;
            textBox1.ForeColor = Color.White;
            textBox2.BackColor = Color.Gray;
            textBox2.ForeColor = Color.White;

            comboBox1.BackColor = Color.Gray;
            comboBox1.ForeColor = Color.White;

            //Лейблы
            for (int i = 0; i < 4; i++) lColor[i].ForeColor = Color.White; 
        }
    }
}
