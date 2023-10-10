using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList k_dizi = new ArrayList();
        ArrayList sifredizi = new ArrayList();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from tablo1", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                k_dizi.Add(oku["k_adi"].ToString());
                sifredizi.Add(oku["sifre"].ToString());
            }
            var kullaniciadi = textBox1.Text;
            var sifre = textBox2.Text;
            if (k_dizi.IndexOf(kullaniciadi)!=-1)
            {
                int sira = k_dizi.IndexOf(kullaniciadi);
                label1.Text = k_dizi[sira].ToString();
                label2.Text = sifredizi[sira].ToString();
                if (kullaniciadi==label1.Text&&sifre==label2.Text)
                {
                    MessageBox.Show("başarılı");
                }
                else
                {
                    MessageBox.Show("hata");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
