using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AC_Timer
{
    public partial class Form1 : Form
    {
        int h = 0, m = 0, s = 0;
        string str = "Ví dụ minh họa sử dụng Control Timer ",
            s1 = "", s2 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.BackColor = Color.Transparent;
            this.lbGio.Text = DateTime.Now.Hour.ToString();
            this.lbPhut.Text = DateTime.Now.Minute.ToString();
            this.lbGiay.Text = DateTime.Now.Second.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Top--;
            if (textBox1.Top + textBox1.Height == panel1.Top)
                textBox1.Top += textBox1.Height + panel1.Height;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            s1 = str.Substring(0, 1);
            s2 = str.Substring(1, str.Length - 1);
            str = s1 + s2;
            this.Text = str;
        }



        private void timer3_Tick(object sender, EventArgs e)
        {
            /*int h = int.Parse(this.lbGio.Text);
            m = int.Parse(this.lbPhut.Text);
            s = int.Parse(this.lbGiay.Text);
            if (s < 60) s++;
            else
            {
                s = 0;
                if (m < 60) m++;
                else
                {
                    m = 0;
                    if (h < 24) h++;
                    else h = 0;
                }
            }
            this.lbGio.Text = h.ToString();
            this.lbPhut.Text = m.ToString();
            this.lbGiay.Text = s.ToString();*/
            this.lbGio.Text = DateTime.Now.Hour.ToString();
            this.lbPhut.Text = DateTime.Now.Minute.ToString();
            this.lbGiay.Text = DateTime.Now.Second.ToString();
        }



        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }
    }
}
