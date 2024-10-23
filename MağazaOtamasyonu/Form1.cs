using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MağazaOtamasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

             if (listBox1.Text == "Saten Gömlek")
                label8.Text = "100";

            if (listBox1.Text == "Kadife Gömlek")
                label8.Text = "190";

            if (listBox1.Text == "Hakim Yaka Gömlek")
                label8.Text = "110";

             if (listBox1.Text == "Keten Gömlek")
                label8.Text = "150";

            if (listBox1.Text == "Oduncu Gömleği")
                label8.Text = "170";

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
             if (listBox2.Text == "Kot Pantolon")
                label9.Text = "120";

            if (listBox2.Text == "Kumaş Pantolon")
                label9.Text = "180";

            if (listBox2.Text == "Kadife Pantolon")
                label9.Text = "190";

             if (listBox2.Text == "Kargo Pantolon")
                label9.Text = "130";

            if (listBox2.Text == "İspanyol Paça Pantolon")
                label9.Text = "110";
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (listBox3.Text == "Crop T-Shirt")
                label10.Text = "90";

             if (listBox3.Text == "Basic T-Shirt")
                label10.Text = "100";

             if (listBox3.Text == "Polo Yaka T-Shirt")
                label10.Text = "120";

            if (listBox3.Text == "Hakim Yaka T-Shirt")
                label10.Text = "150";

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            if (listBox4.Text == "Blazer Ceket")
                label11.Text = "1250";

             if (listBox4.Text == "Kot Ceket")
                label11.Text = "750";

             if (listBox4.Text == "Deri Ceket")
                label11.Text = "1000";

             if (listBox4.Text == "Günlük Ceket")
                label11.Text = "700";


        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (listBox6.Text == "Spor Ayakkabısı")
                label12.Text = "2000";

            if (listBox6.Text == "Topuklu Ayakkabı")
                label12.Text = "900";

            if (listBox6.Text == "Sandalet")
                label12.Text = "750";
        }

        private void button1_Click(object sender, EventArgs e)

        {
            listBox5.Items.Clear();



            if (listBox1.Text != "")
                listBox5.Items.Add(listBox1.Text + " " + label8.Text);

            if (listBox2.Text != "")
                listBox5.Items.Add(listBox2.Text + " " + label9.Text);

            if (listBox3.Text != "")
                listBox5.Items.Add(listBox3.Text + " " + label10.Text);

            if (listBox4.Text != "")
                listBox5.Items.Add(listBox4.Text + " " + label11.Text);

            if (listBox6.Text != "")
                listBox5.Items.Add(listBox6.Text + " " + label12.Text);

            int toplam;
            toplam = int.Parse(label8.Text) + int.Parse(label9.Text) + int.Parse(label10.Text) + int.Parse(label11.Text) + int.Parse(label12.Text);

            textBox1.Text = toplam.ToString();

        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazaDataSet.Ürünler' table. You can move, or remove it, as needed.
            this.ürünlerTableAdapter.Fill(this.magazaDataSet.Ürünler);

        }
    }
}
