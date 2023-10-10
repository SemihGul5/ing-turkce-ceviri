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

namespace ing_tr_sozluk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=verita.accdb");
        OleDbCommand komut = new OleDbCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            string ara = textBox1.Text;
            bool kelimeyok = true;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from sozluk1";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (ara==oku[0].ToString())
                {
                    kelimeyok = false;
                    label1.Text = oku[0].ToString();
                    label2.Text = oku[1].ToString();
                }
            }
            oku.Close();
            baglanti.Close();
            if (kelimeyok)
            {
                MessageBox.Show("kelime bulunamadı");
            }

        }
    }
}
