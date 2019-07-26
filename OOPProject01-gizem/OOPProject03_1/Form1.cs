using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPProject03;


namespace OOPProject03_1
{
    public partial class Form1 : Form
        //OOPProject 03 ile OOPProject 03_1 projelerini birbirine bağladık
    {   //Projemizin bu katmanına UI katmanı diyebiliriz.
        //OOPProject oluşturduğumuz class library bu projede 
        //yani OOPProject03_1 projesinde kullanılacaktır
        //OOPProject03-class library(Veri üretmek için hazırladığımız bir kütüphanedir
        //OOPProject03_1-UI( User Interface)katmanı
        //OOPProject03_1 UI katmanının, OOPProject03 class library'sini kullanabilmesi için 
        //bu librarynin OOPProject03_1 projesine dahil edilmesi gerekir
        //dahil etmek için OOPProject03 once referancelara eklenir
        //sonra using satırı eklenir
        //dll dosyası class library kütüphanesi compile edildiğinde oluşan dosyanın uzantısı
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Ogrenci> olist = new List<Ogrenci>();
            for(int i=1;i<=100; i++)
            {
                Ogrenci ogr = new Ogrenci();
                BAU sourceOfData = new BAU();

                ogr.Ad = sourceOfData.GetName();
                ogr.SoyAd = sourceOfData.GetSurname();
                ogr.DogumYeri = sourceOfData.GetCity();
                ogr.DogumTarih = sourceOfData.GetBackDate(30);
                ogr.Id = i;
                ogr.KursBitisTarih = sourceOfData.GetForwardDate(5);
                olist.Add(ogr);

                //object initializer yöntemi ile classın instancesinin oluşturulması ve 
                //değerlerinin doldurulması
                //tutorial  teacher da c# da object initializer syntax ı incele
                //Ogrenci ogr = new Ogrenci()
                //{
                //    Ad = "gizem",
                //    SoyAd = "sürer",
                //    DogumYeri = "hatay",
                //    DogumTarih = Convert.ToDateTime("07/05/1992"),
                //    Id = i,
                //    KursBitisTarih = Convert.ToDateTime("31/10/2019")
                //};

                //olist.Add(ogr);
            }
            dataGridView1.DataSource = olist;//olistdeki tüm verileri viewe atıyorum
        }

        private void btnVeriDetay_Click(object sender, EventArgs e)
        {
           
          DialogResult dr=MessageBox.Show("seçili satırın detayını görmek istediğinizden emin misiniz?", "uyarı",MessageBoxButtons.YesNoCancel);
          if(dr==DialogResult.Cancel|| dr==DialogResult.No)
            {
                return;
            }
          else if(dr==DialogResult.Yes)
            {
                FormDetay frmDet = new FormDetay();
                frmDet.ShowDialog();
            }
          else
            {
                return;
            }
        }
    }
}
