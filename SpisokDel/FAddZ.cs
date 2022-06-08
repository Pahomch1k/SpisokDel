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
using System.Media;
using System.Xml;

namespace SpisokDel
{
    public partial class FAddZ : Form
    {
        SoundPlayer soundAudio;
        public Label[] lColor; 

        public FAddZ()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd"; 

            lColor = new Label[5] { label1, label2, label3, label4, label5 };

            if (CTemaZvuk.GetTema() == 1) DarkTema(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CTemaZvuk.GetZvuk() == 0)
            {
                soundAudio = new SoundPlayer(Resource1.zvukClose);
                soundAudio.Play();
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (textBox2.Text == "" && comboBox1.Text == "")
            {
                if (CTemaZvuk.GetZvuk() == 0) ZvukB();
                MessageBox.Show("Заполните все поля");
            }
                
            else if (textBox2.Text == "")
            {
                if (CTemaZvuk.GetZvuk() == 0) ZvukB();
                MessageBox.Show("Заполните Навзание"); 
            }
                
            else if (comboBox1.Text == "")
            {
                if (CTemaZvuk.GetZvuk() == 0) ZvukB();
                MessageBox.Show("Выберите Тег");
            } 
            else
            { 
                if (CTemaZvuk.GetZvuk() == 0)
                {
                    soundAudio = new SoundPlayer(Resource1.zvukAdd);
                    soundAudio.Play();
                }  

                string[] AtribteName = new string[4] { "Zadacha", "Tag", "Date", "Comment" };
                Control[] c = new Control[4] { comboBox1, dateTimePicker1, textBox5, textBox2 };
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("Zadachi.xml");
                XmlElement xRoot = xDoc.DocumentElement;
                 
                XmlElement KatalElem = xDoc.CreateElement(AtribteName[0]);
                xRoot.AppendChild(KatalElem);
                XmlAttribute nameAttr = xDoc.CreateAttribute("name");
                nameAttr.Value = c[3].Text;
                KatalElem.Attributes.Append(nameAttr);
                 
                XmlElement AtrElem;
                XmlText Text;
                for (int i = 0; i < 3; i++)
                {
                    AtrElem = xDoc.CreateElement(AtribteName[i + 1]);
                    KatalElem.AppendChild(AtrElem);
                    if (c[i].Text == "") Text = xDoc.CreateTextNode("-"); 
                    else Text = xDoc.CreateTextNode(c[i].Text); 
                    AtrElem.AppendChild(Text);
                } 
                xDoc.Save("Zadachi.xml"); 
                 
                listBox1.Items.Clear();
                listBox1.Items.Add(textBox2.Text);
                listBox1.Items.Add(comboBox1.Text);
                listBox1.Items.Add(dateTimePicker1.Text);
                listBox1.Items.Add(textBox5.Text);

                textBox2.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text = "";
                textBox5.Text = "";
            }
        }

        #region Тема и звук
        public void ZvukB()
        {
            soundAudio = new SoundPlayer(Resource1.zvukButton);
            soundAudio.Play();
        } 

        public void DarkTema()
        {
            BackColor = Color.Black;

            //Кнопки 
            bAdd.BackColor = Color.Gray;
            bAdd.ForeColor = Color.White;
            bClose.BackColor = Color.Gray;
            bClose.ForeColor = Color.White;

            //Лейблы
            for (int i = 0; i < 5; i++) lColor[i].ForeColor = Color.White;

            textBox2.BackColor = Color.Gray;
            textBox2.ForeColor = Color.White;
            textBox5.BackColor = Color.Gray;
            textBox5.ForeColor = Color.White;

            comboBox1.BackColor = Color.Gray;
            comboBox1.ForeColor = Color.White; 

            listBox1.BackColor = Color.Gray;
            listBox1.ForeColor = Color.White; 
        }
        #endregion 
    }
} 