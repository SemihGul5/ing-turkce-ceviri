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

namespace kullaniciadi_sözlük
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ara;
            int kayitci;
            ara = textBox1.Text;
          kayitci=dataView1.Find(ara);
            DataRowView akayitci;
            if (kayitci!=-1)
            {
                akayitci = dataView1[kayitci];
                label1.Text = akayitci["kelime"].ToString();
                label2.Text = akayitci["anlami"].ToString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Fill(dataSet11, "Tablo2");
        }
    }
}
