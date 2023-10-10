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

namespace WindowsFormsApplication22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Fill(dataSet11, "sozluk");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ara;
            int kayit;
            if (radioButton1.Checked==true)
            {
                ara = textBox1.Text;
                dataView1.Sort = "kelime";
                kayit = dataView1.Find(ara);
                DataRowView akayit;
                if (kayit!=-1)
                {
                    akayit = dataView1[kayit];
                    label1.Text = akayit["kelime"].ToString();
                    label2.Text = akayit["anlami"].ToString();
                }
                else
                {
                    MessageBox.Show("kelime bulunamadı");
                }
            }
        }
    }
}
