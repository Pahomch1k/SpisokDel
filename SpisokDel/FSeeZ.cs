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
    public partial class FSeeZ : Form
    {
        Thread thread2;
        SoundPlayer soundAudio; 
        public int flag { get; set; } 

        public FSeeZ(int f)
        {
            InitializeComponent(); 
            flag = f; 

            listBox1.Items.Clear(); 

            if (flag == 0) thread2 = new Thread(Zadachi); 
            else thread2 = new Thread(Projects); 

            thread2.Start();
            if (CTemaZvuk.GetTema() == 1) DarkTema();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CTemaZvuk.GetZvuk() == 0)
            {
                soundAudio = new SoundPlayer(Resource1.zvukClose);
                soundAudio.Play();
            }
            thread2.Abort();
            Close();
        }

        //Выводит все в лист
        public void Zadachi()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Zadachi.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null) listBox1.Items.Add($"Название: {attr.Value}");
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
            xDoc.Save("Zadachi.xml");
        }

        public void Projects()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Projects.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null) listBox1.Items.Add($"Название проекта: {attr.Value}");
                }
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (xnode.Attributes.Count > 0)
                    {
                        XmlNode attr = childnode.Attributes.GetNamedItem("name");
                        if (attr != null) listBox1.Items.Add($"Название задачи: {attr.Value}");
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
            xDoc.Save("Projects.xml");
        }

        public void DarkTema()
        {
            BackColor = Color.Black;

            button2.BackColor = Color.Gray;
            button2.ForeColor = Color.White;

            listBox1.BackColor = Color.Gray;
            listBox1.ForeColor = Color.White;
        }
    }
} 