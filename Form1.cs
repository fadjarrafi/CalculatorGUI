using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Button1_Click(object sender, EventArgs e)
        {
            var a = int.Parse(textBox_A.Text);
            var b = Convert.ToInt32(textBox_B.Text);

            int tambah = a + b;
            int kurang = a - b;
            int kali = a * b;
            int bagi = a / b;

            listBox_hasil.Items.Clear();

            if (comboBox_op.SelectedItem == "Penambahan")
            {
                listBox_hasil.Items.Add(string.Format("Hasl Penambahan: {0} + {1} = {2}", a, b, tambah));
            }
            else if (comboBox_op.SelectedItem == "Pengurangan")
            {
                listBox_hasil.Items.Add(string.Format("Hasl Pengurangan: {0} - {1} = {2}", a, b, kurang));
            }
            else if (comboBox_op.SelectedItem == "Perkalian")
            {
                listBox_hasil.Items.Add(string.Format("Hasl Perkalian: {0} * {1} = {2}", a, b, kali));
            }
            else if (comboBox_op.SelectedItem == "Pembagian")
            {
                listBox_hasil.Items.Add(string.Format("Hasl Pembagian: {0} / {1} = {2}", a, b, bagi));
            }
        }
    }
}
