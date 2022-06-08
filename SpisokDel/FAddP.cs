using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;


namespace SpisokDel
{
    public partial class FAddP : Form
    {
        SoundPlayer soundAudio;
        public XmlElement KatalElem;
        public XmlAttribute nameAttr;
        public Label[] lColor;
        public TextBox[] tColor;
         
        public int flag { get; set; } 
        public FAddP(int x)
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd"; 
            flag = x; 

            lColor = new Label[6] { label1, label2, label3, label4, label5, label6 }; 
            tColor = new TextBox[3] { textBox1, textBox2, textBox5 }; 

            if (flag == 0)
            {
                comboBox2.Text = "."; 
                comboBox2.Hide();
            }
            else InItCB();

            if (CTemaZvuk.GetTema() == 1) DarkTema();
        } 

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" && comboBox1.Text == "" && dateTimePicker1.Text == "" && (textBox1.Text == "" || comboBox2.Text == ""))
                MessageBox.Show("Заполните все поля");
            else if (textBox1.Text == "" || comboBox2.Text == "")
                MessageBox.Show("Заполните Навзание проекта");
            else if (textBox2.Text == "")
                MessageBox.Show("Заполните Навзание задачи");
            else if (comboBox1.Text == "")
                MessageBox.Show("Выберите Тег");
            else if (dateTimePicker1.Text == "")
                MessageBox.Show("Заполните Дату");
            else
            {
                int Check = CheckNameProject(); 
                if (Check == 1) MessageBox.Show("Такое название проекта уже существует");
                else
                {
                    if (CTemaZvuk.GetZvuk() == 0)
                    {
                        soundAudio = new SoundPlayer(Resource1.zvukAdd);
                        soundAudio.Play();
                    }

                    string[] AtribteName = new string[5] { "Project", "Zadacha", "Tag", "Date", "Comment" };
                    Control[] c = new Control[5] { comboBox1, dateTimePicker1, textBox5, textBox2, textBox1 };

                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load("Projects.xml");
                    XmlElement xRoot = xDoc.DocumentElement;
                    XmlElement KatalElem2;

                    if (flag == 0)
                    {
                        KatalElem = xDoc.CreateElement(AtribteName[0]);
                        xRoot.AppendChild(KatalElem);
                        nameAttr = xDoc.CreateAttribute("name");
                        nameAttr.Value = c[4].Text;
                        KatalElem.Attributes.Append(nameAttr);

                        KatalElem2 = xDoc.CreateElement(AtribteName[1]);
                        KatalElem.AppendChild(KatalElem2);
                        XmlAttribute nameAttr2 = xDoc.CreateAttribute("name");
                        nameAttr2.Value = c[3].Text;
                        KatalElem2.Attributes.Append(nameAttr2);

                        listBox1.Items.Add(textBox1.Text);
                        textBox1.ReadOnly = true;
                        flag++;
                    }
                    else
                    {
                        XmlNode temp = null;
                        foreach (XmlNode i in xRoot)
                            if (i.Attributes["name"].Value == textBox1.Text || i.Attributes["name"].Value == comboBox2.Text) temp = i;

                        KatalElem2 = xDoc.CreateElement(AtribteName[1]);
                        XmlAttribute nameAttr2 = xDoc.CreateAttribute("name");
                        nameAttr2.Value = c[3].Text;
                        KatalElem2.Attributes.Append(nameAttr2);
                        temp.AppendChild(KatalElem2);

                    }

                    XmlElement AtrElem;
                    XmlText Text;
                    for (int i = 0; i < 3; i++)
                    {
                        AtrElem = xDoc.CreateElement(AtribteName[i + 2]);
                        KatalElem2.AppendChild(AtrElem);
                        if (c[i].Text == "") Text = xDoc.CreateTextNode("-");
                        else Text = xDoc.CreateTextNode(c[i].Text);
                        AtrElem.AppendChild(Text);
                    }
                     
                    listBox1.Items.Add(textBox2.Text);
                    listBox1.Items.Add(comboBox1.Text);
                    listBox1.Items.Add(dateTimePicker1.Text);
                    listBox1.Items.Add(textBox5.Text);

                    textBox2.Text = "";
                    comboBox1.Text = "";
                    dateTimePicker1.Text = "";
                    textBox5.Text = "";

                    xDoc.Save("Projects.xml");
                } 
            }
        } 

        //Проверяет уникальное ли имя проекта
        public int CheckNameProject()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Projects.xml");
            XmlElement xRoot = xDoc.DocumentElement;  

            int y = 0;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null) if (attr.Value == textBox1.Text) y++;
                }
                if (y == 1) break;
            }
            return y;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (CTemaZvuk.GetZvuk() == 0)
            {
                soundAudio = new SoundPlayer(Resource1.zvukClose);
                soundAudio.Play();
            }
            Close();
        }

        public void InItCB()
        {
            comboBox2.Location = new Point(12, 28);
            comboBox2.Show(); 
            textBox1.Text = ".";
            textBox1.Hide();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Projects.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null) comboBox2.Items.Add(attr.Value); 
                } 
            }
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
            for (int i = 0; i < 6; i++) lColor[i].ForeColor = Color.White;

            //ТекстБокс
            for (int i = 0; i < 3; i++)
            {
                tColor[i].BackColor = Color.Gray;
                tColor[i].ForeColor = Color.White;
            } 

            comboBox1.BackColor = Color.Gray;
            comboBox1.ForeColor = Color.White; 

            listBox1.BackColor = Color.Gray;
            listBox1.ForeColor = Color.White;
        }
    }
} 