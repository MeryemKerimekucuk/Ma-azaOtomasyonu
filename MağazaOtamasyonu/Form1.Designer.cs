namespace MağazaOtamasyonu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.magazaDataSet = new MağazaOtamasyonu.MagazaDataSet();
            this.ürünlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ürünlerTableAdapter = new MağazaOtamasyonu.MagazaDataSetTableAdapters.ÜrünlerTableAdapter();
            this.gÖMLEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pANTOLONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSHİRTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEKETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aYAKKABIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "GÖMLEK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "PANTOLON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "T-Shirt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CEKET";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Saten Gömlek",
            "Kadife Gömlek",
            "Hakim Yaka Gömlek",
            "Keten Gömlek",
            "Oduncu Gömleği"});
            this.listBox1.Location = new System.Drawing.Point(21, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(134, 84);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "Kot Pantolon",
            "Kumaş Pantolon",
            "Kadife Pantolon",
            "Kargo Pantolon",
            "İspanyol Paça Pantolon"});
            this.listBox2.Location = new System.Drawing.Point(238, 77);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(173, 84);
            this.listBox2.TabIndex = 5;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Items.AddRange(new object[] {
            "Crop T-Shirt",
            "Basic T-Shirt",
            "Polo Yaka T-Shirt",
            "Hakim Yaka T-Shirt"});
            this.listBox3.Location = new System.Drawing.Point(468, 77);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(142, 84);
            this.listBox3.TabIndex = 6;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Items.AddRange(new object[] {
            "Blazer Ceket",
            "Kot Ceket",
            "Deri Ceket",
            "Günlük Ceket"});
            this.listBox4.Location = new System.Drawing.Point(668, 77);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 84);
            this.listBox4.TabIndex = 7;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "SEPET";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(24, 314);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(139, 148);
            this.listBox5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(930, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "AYAKKABI";
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 16;
            this.listBox6.Items.AddRange(new object[] {
            "Spor Ayakkabısı",
            "Topuklu Ayakkabı",
            "Sandalet"});
            this.listBox6.Location = new System.Drawing.Point(933, 77);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(120, 84);
            this.listBox6.TabIndex = 11;
            this.listBox6.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "TOPLAM TUTAR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(498, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(700, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(966, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "SEPETE EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 395);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gÖMLEKDataGridViewTextBoxColumn,
            this.pANTOLONDataGridViewTextBoxColumn,
            this.tSHİRTDataGridViewTextBoxColumn,
            this.cEKETDataGridViewTextBoxColumn,
            this.aYAKKABIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ürünlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(501, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // magazaDataSet
            // 
            this.magazaDataSet.DataSetName = "MagazaDataSet";
            this.magazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ürünlerBindingSource
            // 
            this.ürünlerBindingSource.DataMember = "Ürünler";
            this.ürünlerBindingSource.DataSource = this.magazaDataSet;
            // 
            // ürünlerTableAdapter
            // 
            this.ürünlerTableAdapter.ClearBeforeFill = true;
            // 
            // gÖMLEKDataGridViewTextBoxColumn
            // 
            this.gÖMLEKDataGridViewTextBoxColumn.DataPropertyName = "GÖMLEK";
            this.gÖMLEKDataGridViewTextBoxColumn.HeaderText = "GÖMLEK";
            this.gÖMLEKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gÖMLEKDataGridViewTextBoxColumn.Name = "gÖMLEKDataGridViewTextBoxColumn";
            this.gÖMLEKDataGridViewTextBoxColumn.Width = 125;
            // 
            // pANTOLONDataGridViewTextBoxColumn
            // 
            this.pANTOLONDataGridViewTextBoxColumn.DataPropertyName = "PANTOLON";
            this.pANTOLONDataGridViewTextBoxColumn.HeaderText = "PANTOLON";
            this.pANTOLONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pANTOLONDataGridViewTextBoxColumn.Name = "pANTOLONDataGridViewTextBoxColumn";
            this.pANTOLONDataGridViewTextBoxColumn.Width = 125;
            // 
            // tSHİRTDataGridViewTextBoxColumn
            // 
            this.tSHİRTDataGridViewTextBoxColumn.DataPropertyName = "T-SHİRT";
            this.tSHİRTDataGridViewTextBoxColumn.HeaderText = "T-SHİRT";
            this.tSHİRTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tSHİRTDataGridViewTextBoxColumn.Name = "tSHİRTDataGridViewTextBoxColumn";
            this.tSHİRTDataGridViewTextBoxColumn.Width = 125;
            // 
            // cEKETDataGridViewTextBoxColumn
            // 
            this.cEKETDataGridViewTextBoxColumn.DataPropertyName = "CEKET";
            this.cEKETDataGridViewTextBoxColumn.HeaderText = "CEKET";
            this.cEKETDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cEKETDataGridViewTextBoxColumn.Name = "cEKETDataGridViewTextBoxColumn";
            this.cEKETDataGridViewTextBoxColumn.Width = 125;
            // 
            // aYAKKABIDataGridViewTextBoxColumn
            // 
            this.aYAKKABIDataGridViewTextBoxColumn.DataPropertyName = "AYAKKABI";
            this.aYAKKABIDataGridViewTextBoxColumn.HeaderText = "AYAKKABI";
            this.aYAKKABIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aYAKKABIDataGridViewTextBoxColumn.Name = "aYAKKABIDataGridViewTextBoxColumn";
            this.aYAKKABIDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MagazaDataSet magazaDataSet;
        private System.Windows.Forms.BindingSource ürünlerBindingSource;
        private MagazaDataSetTableAdapters.ÜrünlerTableAdapter ürünlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gÖMLEKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pANTOLONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSHİRTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEKETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aYAKKABIDataGridViewTextBoxColumn;
    }
}

