using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4A_kalkip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KalkIP ip = new KalkIP();
            ip.AdresIP = 0x0a0a0a0a;
            ip.MaskaSieci = 0xffffff00;

            textBox1.Text = Convert.ToString(ip.AdresIP,2)+"\r\n";
            textBox1.Text += Convert.ToString(ip.MaskaSieci, 2) + "\r\n";
            textBox1.Text += Convert.ToString(ip.AdresSieci, 2) + "\r\n";
            textBox1.Text += Convert.ToString(ip.AdresRozgloszeniowy, 2) + "\r\n";
            textBox1.Text += Convert.ToString(ip.PierwszyAdresSieci, 2) + "\r\n";
            textBox1.Text += Convert.ToString(ip.OstatniAdresSieci, 2) + "\r\n";
            textBox1.Text += ip.LiczbaHostowWSieci + "\r\n";

        }
    }
}
