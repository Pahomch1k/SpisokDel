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
    public partial class FSearchZ : Form
    {
        SoundPlayer soundAudio;
        public Button[] bColor;
        public ComboBox[] cbColor;
         
        public int zvukSearch { get; set; }
        public int flag { get; set; } 

        public FSearchZ(int f)
        { 
            InitializeComponent(); 
            zvukSearch = 0;
            flag = f; 

            bColor = new Button[5] { bClose, bDell, bEdit, bSearch, bDellP };
            cbColor = new ComboBox[4] { comboBox1, comboBox2, comboBox3, comboBox4};

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
             
            if (flag == 0)
            {
                comboBox4.Hide();
                label2.Hide();  
            }
            else InItProjects();

            if (CTemaZvuk.GetTema() == 1) DarkTema();

            comboBox2.Hide();
            textBox1.Hide();
            dateTimePicker1.Hide(); 
            bSearch.Hide();
            bDellP.Hide();

            bSearch.Enabled = false;

            comboBox2.Enabled = false;
            textBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        #region Projects
        public void InItProjects()
        {
            comboBox1.Hide(); 
            comboBox4.Location = new Point(12, 32);

            label1.Hide();
            label2.Location = new Point(8, 9);
             
            bDellP.Location = new Point(14, 85);

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Projects.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null) comboBox4.Items.Add(attr.Value);
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox3.Items.Clear();
            bDellP.Show();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Projects.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            int y = 0;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        if (attr.Value == comboBox4.Text)
                        {
                            listBox1.Items.Add($"Название проекта: {attr.Value}");
                            y++;
                        } 
                    }   
                }
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (y == 1)
                    { 
                        if (xnode.Attributes.Count > 0)
                        {
                            XmlNode attr = childnode.Attributes.GetNamedItem("name");
                            if (attr != null)
                            { 
                                listBox1.Items.Add($"Название задачи: {attr.Value}");
                                comboBox3.Items.Add(attr.Value);
                            }
                        }
                        foreach (XmlNode childnode1 in childnode.ChildNodes)
                        {
                            if (childnode1.Name == "Tag") listBox1.Items.Add($"Тэг: {childnode1.FirstChild.Value}");
                            if (childnode1.Name == "Date") listBox1.Items.Add($"Дата: {childnode1.InnerText}");
                            if (childnode1.Name == "Comment")
                            {
                                listBox1.Items.Add($"Комент: {childnode1.InnerText}");
                                listBox1.Items.Add("\n");
                            }
                        } 
                    }  
                }
                if (y == 1) break;
            }
            xDoc.Save("Projects.xml");
        }  
        #endregion
         
        #region Zadachi
        //Скрывает/расскрывает эл. упарв.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox2.Hide();
            textBox1.Hide();
            dateTimePicker1.Hide();
            bSearch.Show();
            bSearch.Enabled = true;
            

            comboBox2.Enabled = false;
            textBox1.Enabled = false;
            dateTimePicker1.Enabled = false;

            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Location = new Point(12, 59);
                comboBox2.Show();
                comboBox2.Enabled = true;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Location = new Point(12, 59);
                textBox1.Show();
                textBox1.Enabled = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                dateTimePicker1.Location = new Point(12, 59);
                dateTimePicker1.Show();
                dateTimePicker1.Enabled = true;
            } 
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if (CTemaZvuk.GetZvuk() == 0 && zvukSearch == 0)
            {
                soundAudio = new SoundPlayer(Resource1.zvukSearch);
                soundAudio.Play();
            }
            else zvukSearch = 0;

            listBox1.Items.Clear();

            if (comboBox1.SelectedIndex == 3) VivodVse();
            else
            {
                if (comboBox2.Text == "" && comboBox2.Enabled == true) MessageBox.Show("Выберите тэг");
                else if (textBox1.Text == "" && textBox1.Enabled == true) MessageBox.Show("Напишите название");
                else if (dateTimePicker1.Text == "" && dateTimePicker1.Enabled == true) MessageBox.Show("Выберите дату");
                else
                {
                    XElement root = XElement.Load("Zadachi.xml");
                    if (comboBox1.SelectedIndex == 0) VivodTag(root);
                    else if (comboBox1.SelectedIndex == 1) VivodName(root);
                    else VivodDate(root);
                }
            }
        }

        #region Поиск и Вывод в listBox
        public void VivodVse()
        {
            comboBox3.Items.Clear();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Zadachi.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        listBox1.Items.Add($"Название: {attr.Value}");
                        comboBox3.Items.Add(attr.Value);
                    }
                }
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "Tag") listBox1.Items.Add($"Тэг: {childnode.FirstChild.Value}");
                    if (childnode.Name == "Date") listBox1.Items.Add($"Дата: {childnode.InnerText}");
                    if (childnode.Name == "Comment")
                    {
                        listBox1.Items.Add($"Комент: {childnode.InnerText}");
                        listBox1.Items.Add("\n");
                    }
                }
            }
        }

        public void VivodTag(XElement root)
        {
            IEnumerable<XElement> tests;
            tests = from el in root.Elements("Zadacha")
                    where (string)el.Element("Tag") == comboBox2.Text
                    select el;
            VivodInListbox(tests);
        }

        public void VivodDate(XElement root)
        {
            IEnumerable<XElement> tests;
            tests = from el in root.Elements("Zadacha")
                    where (string)el.Element("Date") == dateTimePicker1.Text
                    select el;
            VivodInListbox(tests);
        }

        public void VivodName(XElement root)
        {
            IEnumerable<XElement> tests;
            tests = from el in root.Elements("Zadacha")
                    where (string)el.Attribute("name") == textBox1.Text
                    select el;
            VivodInListbox(tests);
        }

        public void VivodInListbox(IEnumerable<XElement> tests)
        {
            comboBox3.Items.Clear();
            foreach (XElement el in tests)
            {
                listBox1.Items.Add($"Название: {(string)el.Attribute("name")}");
                listBox1.Items.Add($"Тэг: {(string)el.Element("Tag")}");
                listBox1.Items.Add($"Дата: {(string)el.Element("Date")}");
                listBox1.Items.Add($"Комент: {(string)el.Element("Comment")}");
                listBox1.Items.Add("\n");
                comboBox3.Items.Add((string)el.Attribute("name"));
            }
        }
        #endregion

        #endregion
         
        //Закрывает окно
        private void bClose_Click(object sender, EventArgs e)
        {
            if (CTemaZvuk.GetZvuk() == 0)
            {
                soundAudio = new SoundPlayer(Resource1.zvukClose);
                soundAudio.Play();
            }
            Close();
        }

        #region Удаление
        //Удаляет выбранный эл
        private void bDell_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "") MessageBox.Show("Выберите задачу");
            else
            {
                if (CTemaZvuk.GetZvuk() == 0)
                {
                    soundAudio = new SoundPlayer(Resource1.zvukDell);
                    soundAudio.Play();
                }

                if (bSearch.Enabled == false)
                { 
                    XElement root = XElement.Load("Projects.xml");
                    IEnumerable<XElement> tests;
                    tests = from el in root.Elements("Project")
                            where (string)el.Attribute("name") == comboBox4.Text
                            select el;
                    foreach (XElement el in tests)
                    {
                        IEnumerable<XElement> tests1;
                        tests1 = from el1 in tests.Elements("Zadacha")
                                where (string)el1.Attribute("name") == comboBox3.Text
                                select el1;
                        foreach (XElement el1 in tests1) el1.Remove(); 
                    } 
                    root.Save("Projects.xml");

                    comboBox3.Items.Remove(comboBox3.Text);
                    comboBox3.Text = "";
                    zvukSearch = 1;
                    comboBox4_SelectedIndexChanged(sender, e); 
                }
                else
                {
                    XElement root = XElement.Load("Zadachi.xml");
                    IEnumerable<XElement> tests;
                    tests = from el in root.Elements("Zadacha")
                            where (string)el.Attribute("name") == comboBox3.Text
                            select el;
                    foreach (XElement el in tests) el.Remove();
                    root.Save("Zadachi.xml");

                    comboBox3.Items.Remove(comboBox3.Text);
                    comboBox3.Text = "";
                    zvukSearch = 1;
                    bSearch_Click(sender, e);
                }
            }
        }

        //Удаляет выбранный проект
        private void bDellP_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "") MessageBox.Show("Выберите задачу");
            else
            {
                if (CTemaZvuk.GetZvuk() == 0)
                {
                    soundAudio = new SoundPlayer(Resource1.zvukDell);
                    soundAudio.Play();
                }
                XElement root = XElement.Load("Projects.xml");
                IEnumerable<XElement> tests;
                tests = from el in root.Elements("Project")
                        where (string)el.Attribute("name") == comboBox4.Text
                        select el;
                foreach (XElement el in tests) el.Remove();
                root.Save("Projects.xml");

                comboBox4.Items.Remove(comboBox4.Text);
                comboBox4.Text = "";
                zvukSearch = 1;

                comboBox3.Items.Clear();
                comboBox3.Text = "";
                listBox1.Items.Clear();
            }
        }
        #endregion 

        //Редактирует выбранный эл
        private void bEdit_Click(object sender, EventArgs e)
        {
            if (CTemaZvuk.GetZvuk() == 0)
            {
                soundAudio = new SoundPlayer(Resource1.zvukButton);
                soundAudio.Play();
            }
            if (comboBox3.Text == "") MessageBox.Show("Выберите задачу");
            else
            { 
                if (bSearch.Enabled == false)
                {
                    if (comboBox4.Text == "") MessageBox.Show("Выберите проект");  
                    else
                    {
                        FEdit f = new FEdit(comboBox3.Text, comboBox4.Text, 1);
                        comboBox3.Text = "";
                        f.ShowDialog();
                        zvukSearch = 1;
                        comboBox4_SelectedIndexChanged(sender, e);
                    } 
                }
                else
                {
                    FEdit f = new FEdit(comboBox3.Text,"", 0);
                    comboBox3.Text = "";
                    f.ShowDialog();
                    zvukSearch = 1;
                    bSearch_Click(sender, e);
                } 
            } 
        }

        //Темная тема
        public void DarkTema()
        {
            BackColor = Color.Black;

            //Кнопки 
            for (int i = 0; i < 5; i++)
            {
                bColor[i].BackColor = Color.Gray;
                bColor[i].ForeColor = Color.White;
            }

            //Комбобоксы 
            for (int i = 0; i < 4; i++)
            {
                cbColor[i].BackColor = Color.Gray;
                cbColor[i].ForeColor = Color.White;
            }

            //Лейблы
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;

            textBox1.BackColor = Color.Gray;
            textBox1.ForeColor = Color.White;

            listBox1.BackColor = Color.Gray;
            listBox1.ForeColor = Color.White;
        }   
    }
} 