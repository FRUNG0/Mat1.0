using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buteksi_Click(object sender, EventArgs e)
        {
            int derece1=Convert.ToInt32(textderece1.Text);
            int derece2=Convert.ToInt32(textderece2.Text);

            int dakika1=Convert.ToInt32(textdakika1.Text);
            int dakika2=Convert.ToInt32(textdakika2.Text);

            int saniye1=Convert.ToInt32(textsaniye1.Text);
            int saniye2=Convert.ToInt32(textsaniye2.Text);

            int saniyeeksi=saniye1 - saniye2;
            int dakikaeksi=dakika1 - dakika2;

            if (saniyeeksi < 0)
            {
                saniye1 = saniye1+60;
                dakika1 = dakika1-1;
            }
            if (dakikaeksi < 0)
            {
                dakika1 =dakika1+60;
                derece1 = derece1 - 1;
            }
            
            int saniyesonuc=saniye1 - saniye2;
            int dakikasonuc=dakika1 - dakika2;
            int derecesonuc=derece1 - derece2;

            labelderece.Text=derecesonuc.ToString();
            labeldakika.Text=dakikasonuc.ToString();
            labelsaniye.Text=saniyesonuc.ToString();

        }

        private void butartı_Click(object sender, EventArgs e)
        {
            int derece1 = Convert.ToInt32(textderece1.Text);
            int derece2 = Convert.ToInt32(textderece2.Text);

            int dakika1 = Convert.ToInt32(textdakika1.Text);
            int dakika2 = Convert.ToInt32(textdakika2.Text);

            int saniye1 = Convert.ToInt32(textsaniye1.Text);
            int saniye2 = Convert.ToInt32(textsaniye2.Text);

            int saniyeartı = saniye1 + saniye2;
            int dakikaartı = dakika1 + dakika2;

            if (saniyeartı >= 60)
            {
                saniye1=saniye1-60;
                dakika1=dakika1+1;
            }

            if(dakikaartı >= 60)
            {
                dakika1=dakika1-60;
                derece1 = derece1+1;
            }

            int saniyesonuc = saniye1 + saniye2;
            int dakikasonuc = dakika1 + dakika2;
            int derecesonuc = derece1 + derece2;

            labelderece.Text = derecesonuc.ToString();
            labeldakika.Text = dakikasonuc.ToString();
            labelsaniye.Text = saniyesonuc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a =Convert.ToInt32(textBox1.Text);
            int b= Convert.ToInt32(textBox2.Text);
            label1.Text=(""+a % b);
            label8.Text=(""+a/b);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
