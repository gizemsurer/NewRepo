using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject03_1
{
    public partial class FormDetay : Form
    {
        public FormDetay()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //    if(lblYasadiniz.Visible)
            //    {
            //        lblYasadiniz.Visible=false;
            //    }
            //    else
            //    {
            //        lblYasadiniz.Visible=true;
            //    }
            //ternary operator ile tek satırda yazma
            var res = lblYasadiniz.Visible ? lblYasadiniz.Visible = false : lblYasadiniz.Visible = true;
        }

        private void FormDetay_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();

        }
    }
}
