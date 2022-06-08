
namespace SpisokDel
{
    partial class FSearchZ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSearchZ));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bDell = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.bClose = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bDellP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Тегу",
            "Названию",
            "Дате",
            "Все"});
            this.comboBox1.Location = new System.Drawing.Point(12, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Работа ",
            "Учеба",
            "Спорт",
            "Тело",
            "Семья",
            "Здоровье",
            "Бизнес",
            "Другое"});
            this.comboBox2.Location = new System.Drawing.Point(169, 286);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSearch.Location = new System.Drawing.Point(33, 85);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 3;
            this.bSearch.Text = "Поиск";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 340);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(153, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 160);
            this.listBox1.TabIndex = 6;
            // 
            // bDell
            // 
            this.bDell.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bDell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDell.Location = new System.Drawing.Point(12, 215);
            this.bDell.Name = "bDell";
            this.bDell.Size = new System.Drawing.Size(75, 23);
            this.bDell.TabIndex = 7;
            this.bDell.Text = "Удалить";
            this.bDell.UseVisualStyleBackColor = false;
            this.bDell.Click += new System.EventHandler(this.bDell_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEdit.Location = new System.Drawing.Point(93, 215);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(96, 23);
            this.bEdit.TabIndex = 8;
            this.bEdit.Text = "Редактировать";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 188);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(177, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bClose.Location = new System.Drawing.Point(279, 216);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 10;
            this.bClose.Text = "Назад";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(32, 310);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 11;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Проекты";
            // 
            // bDellP
            // 
            this.bDellP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bDellP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDellP.Location = new System.Drawing.Point(33, 337);
            this.bDellP.Name = "bDellP";
            this.bDellP.Size = new System.Drawing.Size(121, 23);
            this.bDellP.TabIndex = 13;
            this.bDellP.Text = "Удалить проект";
            this.bDellP.UseVisualStyleBackColor = false;
            this.bDellP.Click += new System.EventHandler(this.bDellP_Click);
            // 
            // FSearchZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(362, 246);
            this.Controls.Add(this.bDellP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bDell);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FSearchZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск задачи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bDell;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bDellP;
    }
}