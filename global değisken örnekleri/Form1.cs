using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace global_değisken_örnekleri
{
    public partial class Form1 : Form
    {
        //buradaki değiskenler globaldır

        double bakiye = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = "bakiye :" +bakiye.ToString();
            lblBakiye.ForeColor = Color.Green;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {


            bakiye = bakiye + 50;
            MessageBox.Show(bakiye.ToString());
            lblBakiye.Text = "bakiye :" + bakiye.ToString();
            lblBakiye.ForeColor = Color.Green;
        }

        private void lblBakiye_Click(object sender, EventArgs e)
        {

        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            if(bakiye <= 8)
            {
                bakiye = bakiye - 8;
                lblBakiye.Text="bakiye : "+bakiye.ToString();
            }
            else
            {
                lblBakiye.Text = "paran yok sükeyna fakiri...";
                lblBakiye.ForeColor = Color.Red;
            }
          
        }
    }
}
