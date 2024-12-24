using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BasitGorevYonetimSistemiUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_isEkle_Click(object sender, EventArgs e)
        {
            string gorev = textBox_is.Text;
            listBox_is.Items.Add(gorev);

            
        }

        private void button_isSil_Click(object sender, EventArgs e)
        {
            string silinecek = listBox_is.SelectedItem.ToString();
            listBox_is.Items.Remove(silinecek);
        }

        private void button_isTamamla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Görev tamamlanmıştır","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Information);
            textBox_is.Text = "";
            checkBox1_is.Checked = false;
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false; // Seçili durumu kaldır
                }
            }
            listBox_is.Items.Clear();
            
        }

        private void button_kisiselEkle_Click(object sender, EventArgs e)
        {
            string gorev = textBox_kisisel.Text;
            listBox_kisisel.Items.Add(gorev);
        }

        private void button_kisiselSil_Click(object sender, EventArgs e)
        {
            string silinecek = listBox_kisisel.SelectedItem.ToString();
            listBox_kisisel.Items.Remove(silinecek);
        }

        private void button_kTamamla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Görev tamamlanmıştır", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_kisisel.Text = "";
            checkBox_kisisel.Checked = false;
            foreach (Control control in groupBox2.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false; 
                }
            }
            listBox_kisisel.Items.Clear();

        }

        private void button_alisverisEkle_Click(object sender, EventArgs e)
        {
            string gorev = textBox_alisveris.Text;
            listBox_alisveris.Items.Add(gorev);
        }

        private void button_alisverisSil_Click(object sender, EventArgs e)
        {
            string silinecek = listBox_alisveris.SelectedItem.ToString();
            listBox_alisveris.Items.Remove(silinecek);
        }

        private void button_aTamamla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Görev tamamlanmıştır", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_alisveris.Text = "";
            checkBox_alisveris.Checked = false;
            foreach (Control control in groupBox3.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false; 
                }
            }
            listBox_alisveris.Items.Clear();
        }
    }
}
