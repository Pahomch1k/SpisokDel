
namespace SpisokDel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bAddZ = new System.Windows.Forms.Button();
            this.bAddP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bSeeP = new System.Windows.Forms.Button();
            this.bSeeZ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bSearchP = new System.Windows.Forms.Button();
            this.bSearchZ = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bOnToday = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.звукONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звукToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.светляТемаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светлаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bpdf = new System.Windows.Forms.Button();
            this.bAddZP = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAddZ
            // 
            this.bAddZ.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bAddZ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddZ.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddZ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAddZ.Location = new System.Drawing.Point(57, 60);
            this.bAddZ.Name = "bAddZ";
            this.bAddZ.Size = new System.Drawing.Size(143, 23);
            this.bAddZ.TabIndex = 0;
            this.bAddZ.Text = "Задачу";
            this.bAddZ.UseVisualStyleBackColor = false;
            this.bAddZ.Click += new System.EventHandler(this.bAddZ_Click);
            // 
            // bAddP
            // 
            this.bAddP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bAddP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAddP.Location = new System.Drawing.Point(57, 89);
            this.bAddP.Name = "bAddP";
            this.bAddP.Size = new System.Drawing.Size(143, 23);
            this.bAddP.TabIndex = 1;
            this.bAddP.Text = "Проект";
            this.bAddP.UseVisualStyleBackColor = false;
            this.bAddP.Click += new System.EventHandler(this.bAddP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(86, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(76, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Просмотреть";
            // 
            // bSeeP
            // 
            this.bSeeP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bSeeP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSeeP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSeeP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSeeP.Location = new System.Drawing.Point(57, 212);
            this.bSeeP.Name = "bSeeP";
            this.bSeeP.Size = new System.Drawing.Size(143, 23);
            this.bSeeP.TabIndex = 6;
            this.bSeeP.Text = "Все проекты";
            this.bSeeP.UseVisualStyleBackColor = false;
            this.bSeeP.Click += new System.EventHandler(this.bSeeP_Click);
            // 
            // bSeeZ
            // 
            this.bSeeZ.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bSeeZ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSeeZ.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSeeZ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSeeZ.Location = new System.Drawing.Point(57, 183);
            this.bSeeZ.Name = "bSeeZ";
            this.bSeeZ.Size = new System.Drawing.Size(143, 23);
            this.bSeeZ.TabIndex = 5;
            this.bSeeZ.Text = "Все задачи";
            this.bSeeZ.UseVisualStyleBackColor = false;
            this.bSeeZ.Click += new System.EventHandler(this.bSeeZ_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Поиск/Редакт/Удаление";
            // 
            // bSearchP
            // 
            this.bSearchP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bSearchP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSearchP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSearchP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSearchP.Location = new System.Drawing.Point(59, 337);
            this.bSearchP.Name = "bSearchP";
            this.bSearchP.Size = new System.Drawing.Size(143, 23);
            this.bSearchP.TabIndex = 9;
            this.bSearchP.Text = "Проекта";
            this.bSearchP.UseVisualStyleBackColor = false;
            this.bSearchP.Click += new System.EventHandler(this.bSearchP_Click);
            // 
            // bSearchZ
            // 
            this.bSearchZ.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bSearchZ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSearchZ.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSearchZ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSearchZ.Location = new System.Drawing.Point(59, 308);
            this.bSearchZ.Name = "bSearchZ";
            this.bSearchZ.Size = new System.Drawing.Size(143, 23);
            this.bSearchZ.TabIndex = 8;
            this.bSearchZ.Text = "Задачи";
            this.bSearchZ.UseVisualStyleBackColor = false;
            this.bSearchZ.Click += new System.EventHandler(this.bSearchZ_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bExit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bExit.Location = new System.Drawing.Point(58, 410);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(143, 23);
            this.bExit.TabIndex = 13;
            this.bExit.Text = "Выйти";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bOnToday
            // 
            this.bOnToday.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bOnToday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bOnToday.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOnToday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bOnToday.Location = new System.Drawing.Point(57, 241);
            this.bOnToday.Name = "bOnToday";
            this.bOnToday.Size = new System.Drawing.Size(143, 23);
            this.bOnToday.TabIndex = 11;
            this.bOnToday.Text = "По датам";
            this.bOnToday.UseVisualStyleBackColor = false;
            this.bOnToday.Click += new System.EventHandler(this.bOnToday_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.звукONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(261, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // звукONToolStripMenuItem
            // 
            this.звукONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.звукToolStripMenuItem1,
            this.светляТемаToolStripMenuItem});
            this.звукONToolStripMenuItem.Name = "звукONToolStripMenuItem";
            this.звукONToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.звукONToolStripMenuItem.Text = "Настройки";
            // 
            // звукToolStripMenuItem1
            // 
            this.звукToolStripMenuItem1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.звукToolStripMenuItem1.Name = "звукToolStripMenuItem1";
            this.звукToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.звукToolStripMenuItem1.Text = "Звук ON";
            this.звукToolStripMenuItem1.Click += new System.EventHandler(this.звукToolStripMenuItem1_Click);
            // 
            // светляТемаToolStripMenuItem
            // 
            this.светляТемаToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.светляТемаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.светлаяToolStripMenuItem,
            this.темнаяToolStripMenuItem});
            this.светляТемаToolStripMenuItem.Name = "светляТемаToolStripMenuItem";
            this.светляТемаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.светляТемаToolStripMenuItem.Text = "Тема";
            // 
            // светлаяToolStripMenuItem
            // 
            this.светлаяToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.светлаяToolStripMenuItem.Name = "светлаяToolStripMenuItem";
            this.светлаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.светлаяToolStripMenuItem.Text = "Светлая";
            this.светлаяToolStripMenuItem.Click += new System.EventHandler(this.светлаяToolStripMenuItem_Click);
            // 
            // темнаяToolStripMenuItem
            // 
            this.темнаяToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.темнаяToolStripMenuItem.Name = "темнаяToolStripMenuItem";
            this.темнаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.темнаяToolStripMenuItem.Text = "Темная";
            this.темнаяToolStripMenuItem.Click += new System.EventHandler(this.темнаяToolStripMenuItem_Click);
            // 
            // bpdf
            // 
            this.bpdf.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bpdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bpdf.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bpdf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bpdf.Location = new System.Drawing.Point(58, 366);
            this.bpdf.Name = "bpdf";
            this.bpdf.Size = new System.Drawing.Size(143, 23);
            this.bpdf.TabIndex = 15;
            this.bpdf.Text = "Экспорт PDF";
            this.bpdf.UseVisualStyleBackColor = false;
            this.bpdf.Click += new System.EventHandler(this.bpdf_Click);
            // 
            // bAddZP
            // 
            this.bAddZP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bAddZP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddZP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddZP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAddZP.Location = new System.Drawing.Point(57, 118);
            this.bAddZP.Name = "bAddZP";
            this.bAddZP.Size = new System.Drawing.Size(143, 23);
            this.bAddZP.TabIndex = 16;
            this.bAddZP.Text = "Задачу в проект";
            this.bAddZP.UseVisualStyleBackColor = false;
            this.bAddZP.Click += new System.EventHandler(this.bAddZP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(261, 458);
            this.Controls.Add(this.bAddZP);
            this.Controls.Add(this.bpdf);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bOnToday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bSearchP);
            this.Controls.Add(this.bSearchZ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bSeeP);
            this.Controls.Add(this.bSeeZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAddP);
            this.Controls.Add(this.bAddZ);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dela";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddZ;
        private System.Windows.Forms.Button bAddP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSeeP;
        private System.Windows.Forms.Button bSeeZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSearchP;
        private System.Windows.Forms.Button bSearchZ;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bOnToday;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem звукONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem звукToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem светляТемаToolStripMenuItem;
        private System.Windows.Forms.Button bpdf;
        private System.Windows.Forms.Button bAddZP;
        private System.Windows.Forms.ToolStripMenuItem светлаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темнаяToolStripMenuItem;
    }
}

