using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SameUppgift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Button knapp = sender as Button;
            int Pris, Payment;
            Pris = int.Parse(textBox1.Text);
            Payment = int.Parse(textBox2.Text);
            int diff = Payment - Pris;

            if (diff > 0)
            {
                listBox1.Items.Add($"Kunde får tillbaka: {diff}Kr");

                listBox1.Items.Add($"500-Lappar {(diff - diff % 500) / 500}st");
                diff = diff % 500;
                listBox1.Items.Add($"200-Lappar {(diff - diff % 200) / 200}st");
                diff = diff % 200;
                listBox1.Items.Add($"100-Lappar {(diff - diff % 100) / 100}st");
                diff = diff % 100;
                listBox1.Items.Add($"50-Lappar {(diff - diff % 50) / 50}st");
                diff = diff % 50;
                listBox1.Items.Add($"20-Lappar {(diff - diff % 20) / 20}st");
                diff = diff % 20;
                listBox1.Items.Add($"10-mynt {(diff - diff % 10) / 10}st");
                diff = diff % 10;
                listBox1.Items.Add($"5-mynt {(diff - diff % 5) / 5}st");
                diff = diff % 5;
                listBox1.Items.Add($"2-mynt {(diff - diff % 2) / 2}st");
                diff = diff % 2;
                listBox1.Items.Add($"1-mynt {(diff - diff % 1) / 1}st");
                diff = diff % 1;
            }
            else if (diff == Payment)
            {
                listBox1.Items.Add("Du får ingen växel tillbaka :P");
            }
            else
            {
                listBox1.Items.Add($"Poor bastard, du saknar {-1 * diff}kr");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
