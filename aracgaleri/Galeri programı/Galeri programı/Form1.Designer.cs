namespace galari_programı
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
            this.marka = new System.Windows.Forms.ComboBox();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.ğ = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.aekle = new System.Windows.Forms.Button();
            this.agüncelle = new System.Windows.Forms.Button();
            this.asil = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // marka
            // 
            this.marka.BackColor = System.Drawing.Color.White;
            this.marka.FormattingEnabled = true;
            this.marka.Items.AddRange(new object[] {
            "wolswagen",
            "skoda",
            "renault",
            "opel",
            "mercedes",
            "bmv",
            "range-rover",
            "tofaş",
            "kia",
            "hyundai",
            "seat",
            "fıat",
            "mazda",
            "toyoto\t",
            "audi",
            "volvo",
            "cıtroen",
            "ısızu",
            "subaru",
            "minicopper"});
            this.marka.Location = new System.Drawing.Point(125, 91);
            this.marka.Margin = new System.Windows.Forms.Padding(4);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(165, 24);
            this.marka.TabIndex = 0;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.a.Location = new System.Drawing.Point(23, 95);
            this.a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(55, 20);
            this.a.TabIndex = 2;
            this.a.Text = "Marka";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.BackColor = System.Drawing.Color.Transparent;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b.Location = new System.Drawing.Point(23, 153);
            this.b.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(54, 20);
            this.b.TabIndex = 3;
            this.b.Text = "Model";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.BackColor = System.Drawing.Color.Transparent;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.c.Location = new System.Drawing.Point(23, 201);
            this.c.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(45, 20);
            this.c.TabIndex = 5;
            this.c.Text = "Fiyat";
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.BackColor = System.Drawing.Color.Transparent;
            this.g.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.g.Location = new System.Drawing.Point(23, 249);
            this.g.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(47, 20);
            this.g.TabIndex = 7;
            this.g.Text = "Kasa";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.BackColor = System.Drawing.Color.Transparent;
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.d.Location = new System.Drawing.Point(363, 61);
            this.d.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(47, 20);
            this.d.TabIndex = 9;
            this.d.Text = "Renk";
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.BackColor = System.Drawing.Color.Transparent;
            this.f.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f.ForeColor = System.Drawing.Color.Black;
            this.f.Location = new System.Drawing.Point(366, 110);
            this.f.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(47, 20);
            this.f.TabIndex = 10;
            this.f.Text = "Vites";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.BackColor = System.Drawing.Color.Transparent;
            this.e.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.e.Location = new System.Drawing.Point(366, 160);
            this.e.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(77, 20);
            this.e.TabIndex = 12;
            this.e.Text = "Yakıt Tipi";
            // 
            // ğ
            // 
            this.ğ.AutoSize = true;
            this.ğ.BackColor = System.Drawing.Color.Transparent;
            this.ğ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ğ.Location = new System.Drawing.Point(366, 207);
            this.ğ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ğ.Name = "ğ";
            this.ğ.Size = new System.Drawing.Size(81, 20);
            this.ğ.TabIndex = 14;
            this.ğ.Text = "Model Yılı";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.BackColor = System.Drawing.Color.Transparent;
            this.h.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.h.Location = new System.Drawing.Point(363, 255);
            this.h.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(112, 20);
            this.h.TabIndex = 16;
            this.h.Text = "Kaza Durumu";
            // 
            // model
            // 
            this.model.BackColor = System.Drawing.Color.White;
            this.model.Location = new System.Drawing.Point(125, 153);
            this.model.Margin = new System.Windows.Forms.Padding(4);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(165, 22);
            this.model.TabIndex = 21;
            // 
            // fiyat
            // 
            this.fiyat.BackColor = System.Drawing.Color.White;
            this.fiyat.Location = new System.Drawing.Point(125, 201);
            this.fiyat.Margin = new System.Windows.Forms.Padding(4);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(165, 22);
            this.fiyat.TabIndex = 22;
            // 
            // aekle
            // 
            this.aekle.BackColor = System.Drawing.Color.Transparent;
            this.aekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aekle.BackgroundImage")));
            this.aekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.aekle.Location = new System.Drawing.Point(768, 248);
            this.aekle.Margin = new System.Windows.Forms.Padding(4);
            this.aekle.Name = "aekle";
            this.aekle.Size = new System.Drawing.Size(52, 57);
            this.aekle.TabIndex = 33;
            this.aekle.UseVisualStyleBackColor = false;
            this.aekle.Click += new System.EventHandler(this.aekle_Click_1);
            // 
            // agüncelle
            // 
            this.agüncelle.BackColor = System.Drawing.Color.Transparent;
            this.agüncelle.BackgroundImage = global::galari_programı.Properties.Resources.images__1_2;
            this.agüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.agüncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.agüncelle.Location = new System.Drawing.Point(768, 186);
            this.agüncelle.Margin = new System.Windows.Forms.Padding(4);
            this.agüncelle.Name = "agüncelle";
            this.agüncelle.Size = new System.Drawing.Size(48, 48);
            this.agüncelle.TabIndex = 32;
            this.agüncelle.UseVisualStyleBackColor = false;
            this.agüncelle.Click += new System.EventHandler(this.button3_Click);
            // 
            // asil
            // 
            this.asil.BackColor = System.Drawing.Color.Transparent;
            this.asil.BackgroundImage = global::galari_programı.Properties.Resources.indir1;
            this.asil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.asil.Location = new System.Drawing.Point(768, 44);
            this.asil.Margin = new System.Windows.Forms.Padding(4);
            this.asil.Name = "asil";
            this.asil.Size = new System.Drawing.Size(48, 50);
            this.asil.TabIndex = 31;
            this.asil.UseVisualStyleBackColor = false;
            this.asil.Click += new System.EventHandler(this.button2_Click);
            // 
            // ara
            // 
            this.ara.BackColor = System.Drawing.Color.Transparent;
            this.ara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ara.BackgroundImage")));
            this.ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ara.Location = new System.Drawing.Point(768, 114);
            this.ara.Margin = new System.Windows.Forms.Padding(4);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(48, 53);
            this.ara.TabIndex = 30;
            this.ara.UseVisualStyleBackColor = false;
            this.ara.Click += new System.EventHandler(this.aekle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sno
            // 
            this.sno.BackColor = System.Drawing.Color.White;
            this.sno.Location = new System.Drawing.Point(125, 28);
            this.sno.Margin = new System.Windows.Forms.Padding(4);
            this.sno.Name = "sno";
            this.sno.Size = new System.Drawing.Size(165, 22);
            this.sno.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "İlan No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(13, 337);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(820, 204);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sedan",
            "Hatchback",
            "Suv",
            "Cabrio",
            "Coupe",
            "Station Wagon"});
            this.comboBox1.Location = new System.Drawing.Point(125, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 24);
            this.comboBox1.TabIndex = 40;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Bej",
            "Beyaz",
            "Kırmızı",
            "Sarı",
            "Yeşil",
            "Mavi",
            "Siyah",
            "Gri",
            "Lacivert",
            "Bordo",
            "Bal Köpüğü",
            "Kahverengi",
            "Turuncu"});
            this.comboBox2.Location = new System.Drawing.Point(506, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 24);
            this.comboBox2.TabIndex = 41;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Manuel",
            "Yarı Otomatik",
            "Tam Otomatik"});
            this.comboBox3.Location = new System.Drawing.Point(506, 110);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(168, 24);
            this.comboBox3.TabIndex = 42;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Benzin",
            "Benzin + Tüp",
            "Benzin + Hybrid",
            "Hybrid",
            "Dizel"});
            this.comboBox4.Location = new System.Drawing.Point(506, 160);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(168, 24);
            this.comboBox4.TabIndex = 43;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018"});
            this.comboBox5.Location = new System.Drawing.Point(506, 207);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(168, 24);
            this.comboBox5.TabIndex = 44;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Var",
            "Yok"});
            this.comboBox6.Location = new System.Drawing.Point(506, 251);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(168, 24);
            this.comboBox6.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 554);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sno);
            this.Controls.Add(this.aekle);
            this.Controls.Add(this.agüncelle);
            this.Controls.Add(this.asil);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.model);
            this.Controls.Add(this.h);
            this.Controls.Add(this.ğ);
            this.Controls.Add(this.e);
            this.Controls.Add(this.f);
            this.Controls.Add(this.d);
            this.Controls.Add(this.g);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.marka);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox marka;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label ğ;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.Button asil;
        private System.Windows.Forms.Button agüncelle;
        private System.Windows.Forms.Button aekle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox sno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
    }
}

