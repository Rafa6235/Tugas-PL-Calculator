using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int hasil = 0;

                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Penambahan":
                        hasil = Penambahan(a, b);
                        break;
                    case "Pengurangan":
                        hasil = Pengurangan(a, b);
                        break;
                    case "Perkalian":
                        hasil = Perkalian(a, b);
                        break;
                    case "Pembagian":
                        if (b == 0)
                        {
                            MessageBox.Show("Tidak bisa membagi dengan nol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        hasil = Pembagian(a, b);
                        break;
                    default:
                        MessageBox.Show("Pilih operasi terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                textBox3.Text = hasil.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Input harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
