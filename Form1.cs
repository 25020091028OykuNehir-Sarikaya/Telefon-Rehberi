using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TelefonRehberi
{
    public partial class Form1 : Form
    {
        ImageList resimler = new ImageList();
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Button buttonEkle;
        private ImageList ımageList1;
        private System.ComponentModel.IContainer components;
        private ImageList ımageList2;
        private ImageList ımageList3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonKlavye;
        private System.Windows.Forms.Button buttonSonArama;
        private System.Windows.Forms.Button buttonKisiler;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label13;
        private Label label15;
        private Label label16;
        List<string> rehber = new List<string>();

        public Form1()
        {
            InitializeComponent();

            // ListView ayarları
            resimler.ImageSize = new Size(40, 40);
            listView1.SmallImageList = resimler;
            listView1.View = View.List;
            listView1.Font = new Font("Arial", 12);
            listView1.FullRowSelect = true;

            // Başlangıç kişileri
            rehber.Add("Annem");
            rehber.Add("Babam");
            rehber.Add("Abim");
            rehber.Add("Meryem");
            rehber.Add("Melike");
            rehber.Add("Zehra");
            rehber.Add("Buğra");
            rehber.Add("Ahmet");

            // Alfabetik sırala
            rehber.Sort();

            foreach (var kisi in rehber)
            {
                KisiEkle(kisi);
            }

            // Kişiler butonunun arka planı gri
            buttonKisiler.BackColor = Color.Gray;

            // Arama kutusu
            textBoxAra.TextChanged += textBoxAra_TextChanged;
        }

        // Harfe göre sabit renk
        Color RenkHesapla(string harf)
        {
            switch (harf.ToUpper())
            {
                case "A": return Color.Orange;
                case "B": return Color.Blue;
                case "M": return Color.Green;
                case "Z": return Color.Purple;
                default: return Color.Gray;
            }
        }

        // Kişi ekleme
        void KisiEkle(string isim)
        {
            string harf = isim.Substring(0, 1).ToUpper();

            Bitmap bmp = new Bitmap(40, 40);
            Graphics g = Graphics.FromImage(bmp);

            Color renk = RenkHesapla(harf);
            Brush brush = new SolidBrush(renk);

            // Kare avatar
            g.FillRectangle(brush, 0, 0, 40, 40);

            g.DrawString(harf, new Font("Arial", 16, FontStyle.Bold), Brushes.White, 10, 8);

            resimler.Images.Add(bmp);

            ListViewItem item = new ListViewItem(isim);
            item.ImageIndex = resimler.Images.Count - 1;

            listView1.Items.Add(item);
        }

        // + butonu
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string isim = Microsoft.VisualBasic.Interaction.InputBox("Yeni kişi adı gir:", "Kişi Ekle");

            if (!string.IsNullOrWhiteSpace(isim))
            {
                rehber.Add(isim);
                rehber.Sort();

                listView1.Items.Clear();

                foreach (var kisi in rehber)
                {
                    KisiEkle(kisi);
                }
            }
        }

        // Arama
        private void textBoxAra_TextChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text.ToLower().Contains(textBoxAra.Text.ToLower()))
                    item.ForeColor = Color.Black;
                else
                    item.ForeColor = Color.LightGray;
            }
        }

        // Klavye
        private void buttonKlavye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Klavye açılacak (örnek)");
        }

        // Son arama
        private void buttonSonArama_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Son aramalar açılacak (örnek)");
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBoxAra = new System.Windows.Forms.TextBox();
            buttonEkle = new System.Windows.Forms.Button();
            ımageList1 = new ImageList(components);
            ımageList2 = new ImageList(components);
            ımageList3 = new ImageList(components);
            listView1 = new System.Windows.Forms.ListView();
            buttonKlavye = new System.Windows.Forms.Button();
            buttonSonArama = new System.Windows.Forms.Button();
            buttonKisiler = new System.Windows.Forms.Button();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxAra
            // 
            textBoxAra.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxAra.Location = new Point(66, 47);
            textBoxAra.Name = "textBoxAra";
            textBoxAra.Size = new Size(200, 26);
            textBoxAra.TabIndex = 0;
            textBoxAra.Text = "Ara";
            textBoxAra.TextChanged += textBoxAra_TextChanged_1;
            // 
            // buttonEkle
            // 
            buttonEkle.FlatStyle = FlatStyle.Flat;
            buttonEkle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonEkle.Location = new Point(299, 47);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(28, 28);
            buttonEkle.TabIndex = 1;
            buttonEkle.Text = "+";
            buttonEkle.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageSize = new Size(16, 16);
            ımageList1.TransparentColor = Color.Transparent;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageSize = new Size(16, 16);
            ımageList2.TransparentColor = Color.Transparent;
            // 
            // ımageList3
            // 
            ımageList3.ColorDepth = ColorDepth.Depth32Bit;
            ımageList3.ImageSize = new Size(16, 16);
            ımageList3.TransparentColor = Color.Transparent;
            // 
            // listView1
            // 
            listView1.BackColor = Color.White;
            listView1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listView1.FullRowSelect = true;
            listView1.Location = new Point(66, 96);
            listView1.Name = "listView1";
            listView1.Size = new Size(226, 454);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            // 
            // buttonKlavye
            // 
            buttonKlavye.BackColor = Color.White;
            buttonKlavye.FlatAppearance.BorderSize = 0;
            buttonKlavye.FlatStyle = FlatStyle.Flat;
            buttonKlavye.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonKlavye.Location = new Point(55, 588);
            buttonKlavye.Name = "buttonKlavye";
            buttonKlavye.Size = new Size(80, 40);
            buttonKlavye.TabIndex = 17;
            buttonKlavye.Text = "Klavye";
            buttonKlavye.UseVisualStyleBackColor = false;
            // 
            // buttonSonArama
            // 
            buttonSonArama.BackColor = Color.White;
            buttonSonArama.FlatAppearance.BorderSize = 0;
            buttonSonArama.FlatStyle = FlatStyle.Flat;
            buttonSonArama.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonSonArama.Location = new Point(150, 588);
            buttonSonArama.Name = "buttonSonArama";
            buttonSonArama.Size = new Size(121, 40);
            buttonSonArama.TabIndex = 17;
            buttonSonArama.Text = "Son Arama";
            buttonSonArama.UseVisualStyleBackColor = false;
            buttonSonArama.Click += buttonSonArama_Click_1;
            // 
            // buttonKisiler
            // 
            buttonKisiler.BackColor = Color.Gray;
            buttonKisiler.FlatAppearance.BorderSize = 0;
            buttonKisiler.FlatStyle = FlatStyle.Flat;
            buttonKisiler.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonKisiler.Location = new Point(289, 588);
            buttonKisiler.Name = "buttonKisiler";
            buttonKisiler.Size = new Size(80, 40);
            buttonKisiler.TabIndex = 17;
            buttonKisiler.Text = "Kişiler";
            buttonKisiler.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            label16.BackColor = Color.White;
            label16.FlatStyle = FlatStyle.Flat;
            label16.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label16.Location = new Point(114, 376);
            label16.Name = "label16";
            label16.Size = new Size(100, 40);
            label16.TabIndex = 14;
            label16.Text = "Zehra";
            label16.Visible = false;
            // 
            // label15
            // 
            label15.BackColor = Color.Purple;
            label15.ForeColor = Color.White;
            label15.Location = new Point(66, 376);
            label15.Name = "label15";
            label15.Size = new Size(42, 40);
            label15.TabIndex = 16;
            label15.Text = "Z";
            label15.Visible = false;
            // 
            // label14
            // 
            label14.BackColor = Color.White;
            label14.FlatStyle = FlatStyle.Flat;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label14.Location = new Point(114, 336);
            label14.Name = "label14";
            label14.Size = new Size(100, 40);
            label14.TabIndex = 14;
            label14.Text = "Meryem";
            label14.Visible = false;
            // 
            // label13
            // 
            label13.BackColor = Color.Green;
            label13.FlatStyle = FlatStyle.Flat;
            label13.ForeColor = Color.White;
            label13.Location = new Point(66, 336);
            label13.Name = "label13";
            label13.Size = new Size(42, 40);
            label13.TabIndex = 15;
            label13.Text = "M";
            label13.Visible = false;
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label12.Location = new Point(114, 296);
            label12.Name = "label12";
            label12.Size = new Size(100, 40);
            label12.TabIndex = 14;
            label12.Text = "Melike";
            label12.Visible = false;
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.BackColor = Color.Green;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.White;
            label11.Location = new Point(66, 296);
            label11.Name = "label11";
            label11.Size = new Size(42, 40);
            label11.TabIndex = 13;
            label11.Text = "M";
            label11.Visible = false;
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.Location = new Point(114, 256);
            label10.Name = "label10";
            label10.Size = new Size(100, 40);
            label10.TabIndex = 14;
            label10.Text = "Buğra";
            label10.Visible = false;
            // 
            // label9
            // 
            label9.BackColor = Color.Blue;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.White;
            label9.Location = new Point(66, 256);
            label9.Name = "label9";
            label9.Size = new Size(42, 40);
            label9.TabIndex = 11;
            label9.Text = "B";
            label9.Visible = false;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(114, 216);
            label8.Name = "label8";
            label8.Size = new Size(100, 40);
            label8.TabIndex = 14;
            label8.Text = "Babam";
            label8.Visible = false;
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.Blue;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(66, 216);
            label7.Name = "label7";
            label7.Size = new Size(42, 40);
            label7.TabIndex = 9;
            label7.Text = "B";
            label7.Visible = false;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(114, 176);
            label6.Name = "label6";
            label6.Size = new Size(100, 40);
            label6.TabIndex = 14;
            label6.Text = "Annem";
            label6.Visible = false;
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Orange;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(66, 176);
            label5.Name = "label5";
            label5.Size = new Size(42, 40);
            label5.TabIndex = 7;
            label5.Text = "A";
            label5.Visible = false;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(114, 136);
            label4.Name = "label4";
            label4.Size = new Size(100, 40);
            label4.TabIndex = 14;
            label4.Text = "Ahmet";
            label4.Visible = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Orange;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(66, 136);
            label3.Name = "label3";
            label3.Size = new Size(42, 40);
            label3.TabIndex = 5;
            label3.Text = "A";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(114, 97);
            label2.Name = "label2";
            label2.Size = new Size(100, 34);
            label2.TabIndex = 14;
            label2.Text = "Abim";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Visible = false;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Orange;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 96);
            label1.Name = "label1";
            label1.Size = new Size(42, 40);
            label1.TabIndex = 3;
            label1.Text = "A";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(958, 694);
            Controls.Add(buttonKisiler);
            Controls.Add(buttonSonArama);
            Controls.Add(buttonKlavye);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(buttonEkle);
            Controls.Add(textBoxAra);
            Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "Form1";
            Text = "Telefon Rehberi";
            ResumeLayout(false);
            PerformLayout();

        }

        // Kişiler butonu
        private void buttonKisiler_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAra_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void buttonSonArama_Click_1(object sender, EventArgs e)
        {

        }
    }
}