using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_kullanimi3_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;

            DateTime odemeGunu = dateTimePicker1.Value;


            lblTarih.Text = "Tarih: " + bugun.ToShortDateString();
            lblOdemeGunu.Text = "Ödeme Günü: " + odemeGunu.ToShortDateString();
        }
    }
}
