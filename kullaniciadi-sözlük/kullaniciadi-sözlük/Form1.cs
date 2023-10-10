using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;

namespace kullaniciadi_sözlük
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList kdizi = new ArrayList();
        ArrayList sifredizi = new ArrayList();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dataveri.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komu = new OleDbCommand("select * from Tablo1", baglanti);
            OleDbDataReader oku = komu.ExecuteReader();
            while (oku.Read())
            {
                kdizi
            }
        }
    }
}
