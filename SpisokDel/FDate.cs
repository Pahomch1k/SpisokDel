using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Threading;

namespace SpisokDel
{ 
    public partial class FDate : Form
    { 
        SoundPlayer soundAudio;
        public Button[] bColor; 
         
        public FDate()
        {
            InitializeComponent();  

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy/MM/dd";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "yyyy/MM/dd";

            dateTimePicker1.Hide();
            dateTimePicker4.Hide();

            bColor = new Button[6] { bClose, bOnMounth, bOnNed, bOnToday, bShowDate, bProsroch };

            if (CTemaZvuk.GetTema() == 1) DarkTema();
        } 

        #region Вывод всего
        private void bOnTNM_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (CTemaZvuk.GetZvuk() == 0) ZvukB();

            listBox1.Items.Clear();
            dateTimePicker1.Show();
            dateTimePicker4.Show();

            DateTime newValue = dateTimePicker4.Value;
            dateTimePicker1.Value = newValue;

            XElement root = XElement.Load("Zadachi.xml");
            Button b = (Button)sender;

            if (b.Name == "bOnToday") x = 1;
            else if (b.Name == "bOnNed") x = 7;
            else x = 30;

            for (int i = 0; i < x; i++)
            {
                IEnumerable<XElement> tests;
                tests = from el in root.Elements("Zadacha")
                        where (string)el.Element("Date") == dateTimePicker1.Text
                        select el;
                foreach (XElement el in tests)
                {
                    listBox1.Items.Add($"Название: {(string)el.Attribute("name")}");
                    listBox1.Items.Add($"Тэг: {(string)el.Element("Tag")}");
                    listBox1.Items.Add($"Дата: {(string)el.Element("Date")}");
                    listBox1.Items.Add($"Комент: {(string)el.Element("Comment")}");
                    listBox1.Items.Add("\n");
                }

                newValue = newValue.AddDays(Double.Parse("1"));
                dateTimePicker1.Value = newValue;
            }

            root.Save("Zadachi.xml");
            dateTimePicker1.Hide();
            dateTimePicker4.Hide();
        }

        private void bShowDate_Click(object sender, EventArgs e)
        {
            int x = 10000;
            if (CTemaZvuk.GetZvuk() == 0) ZvukB();
            dateTimePicker1.Show();
            dateTimePicker4.Show();
            listBox1.Items.Clear();
            XElement root = XElement.Load("Zadachi.xml");
            DateTime newValue = dateTimePicker2.Value;
            dateTimePicker1.Value = newValue;

            for (int i = 0; i < x; i++)
            {
                if (dateTimePicker1.Text == dateTimePicker3.Text)
                {
                    IEnumerable<XElement> tests;
                    tests = from el in root.Elements("Zadacha")
                            where (string)el.Element("Date") == dateTimePicker2.Text
                            select el;
                    foreach (XElement el in tests)
                    {
                        listBox1.Items.Add($"Название: {(string)el.Attribute("name")}");
                        listBox1.Items.Add($"Тэг: {(string)el.Element("Tag")}");
                        listBox1.Items.Add($"Дата: {(string)el.Element("Date")}");
                        listBox1.Items.Add($"Комент: {(string)el.Element("Comment")}");
                        listBox1.Items.Add("\n");
                    }
                    break;
                }
                else
                {
                    newValue = newValue.AddDays(Double.Parse("1"));
                    dateTimePicker1.Value = newValue;

                    IEnumerable<XElement> tests;
                    tests = from el in root.Elements("Zadacha")
                            where (string)el.Element("Date") == dateTimePicker1.Text
                            select el;
                    foreach (XElement el in tests)
                    {
                        listBox1.Items.Add($"Название: {(string)el.Attribute("name")}");
                        listBox1.Items.Add($"Тэг: {(string)el.Element("Tag")}");
                        listBox1.Items.Add($"Дата: {(string)el.Element("Date")}");
                        listBox1.Items.Add($"Комент: {(string)el.Element("Comment")}");
                        listBox1.Items.Add("\n");
                    }
                }
            }
            dateTimePicker1.Hide();
            dateTimePicker4.Hide();
            root.Save("Zadachi.xml");
        }

        private void bProsroch_Click(object sender, EventArgs e)
        {
            int x = 1000;
            if (CTemaZvuk.GetZvuk() == 0) ZvukB();
            dateTimePicker1.Show();
            dateTimePicker4.Show();
            listBox1.Items.Clear();
            XElement root = XElement.Load("Zadachi.xml");
            DateTime newValue = dateTimePicker4.Value;
            dateTimePicker1.Value = newValue;

            for (int i = 0; i < x; i++)
            {
                newValue = newValue.AddDays(Double.Parse("-1"));
                dateTimePicker1.Value = newValue;

                IEnumerable<XElement> tests;
                tests = from el in root.Elements("Zadacha")
                        where (string)el.Element("Date") == dateTimePicker1.Text
                        select el;
                foreach (XElement el in tests)
                {
                    listBox1.Items.Add($"Название: {(string)el.Attribute("name")}");
                    listBox1.Items.Add($"Тэг: {(string)el.Element("Tag")}");
                    listBox1.Items.Add($"Дата: {(string)el.Element("Date")}");
                    listBox1.Items.Add($"Комент: {(string)el.Element("Comment")}");
                    listBox1.Items.Add("\n");
                }
            }
            dateTimePicker1.Hide();
            dateTimePicker4.Hide();
            root.Save("Zadachi.xml");
        } 
        #endregion
         
        

        private void bClose_Click(object sender, EventArgs e)
        {
            if (CTemaZvuk.GetZvuk() == 0)
            {
                soundAudio = new SoundPlayer(Resource1.zvukClose);
                soundAudio.Play();
            }
            Close();
        }
        #region Звук и тема
        public void ZvukB()
        {
            soundAudio = new SoundPlayer(Resource1.zvukButton);
            soundAudio.Play();
        }

        public void DarkTema()
        {
            BackColor = Color.Black; 

            //Кнопки
            for (int i = 0; i < 6; i++)
            {
                bColor[i].BackColor = Color.Gray;
                bColor[i].ForeColor = Color.White;
            } 
              
            listBox1.BackColor = Color.Gray;
            listBox1.ForeColor = Color.White;
        }
        #endregion 
    }
}  