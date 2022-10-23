using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnketMiniProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton4.Checked = true;
            radioButton6.Checked = true;
            checkBox1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AdSoyad = "Ad Soyad: " + textBox1.Text.ToUpper() + " " + textBox2.Text.ToUpper() + "\n" ;


            foreach (var cinsiyet in groupBox1.Controls.OfType<RadioButton>())

            {
                if (cinsiyet.Checked) AdSoyad += groupBox1.Text + ": " + cinsiyet.Text +  "\n";                           
            }

            foreach (var medenihal in groupBox2.Controls.OfType<RadioButton>())

            {
                if (medenihal.Checked) AdSoyad += groupBox2.Text + ": " + medenihal.Text + "\n";
            }

            foreach (var mezuniyet in groupBox3.Controls.OfType<RadioButton>())

            {
                if (mezuniyet.Checked) AdSoyad += groupBox3.Text + ": " + mezuniyet.Text + "\n";
            }

            foreach (var hobiler in groupBox4.Controls.OfType<CheckBox>())

            {
                if (hobiler.Checked) AdSoyad += groupBox4.Text + ": " + hobiler.Text + "\n";
            }

            DialogResult veri = DialogResult.OK;

            veri = MessageBox.Show(AdSoyad, "Form Kaydedilsin mi?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (veri == DialogResult.Yes)
            {
                MessageBox.Show("Kaydedildi");
            }
            else if (veri == DialogResult.No)
            {
                Application.Exit();
            }



        }
    }
}
