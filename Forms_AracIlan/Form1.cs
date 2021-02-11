using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms_AracIlan.Classes;


namespace Forms_AracIlan
{
    public partial class Form1 : Form
    {
        Arac arac = new Arac();
        int ilanNo = 1;
        

        public Random rasgele = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////
            
            //Araç 1 Tanımla

           arac.Id = rasgele.Next(1,200);
           arac.Marka = tbMarka.Text;
           arac.Model = tbModel.Text;
           arac.Beygir = Int32.Parse(tbBeygir.Text);
           arac.Agirlik = Int32.Parse(tbAgirlik.Text);
           arac.Km = Double.Parse(tbKm.Text);
           arac.Fiyat = Double.Parse(tbFiyat.Text);
           arac.Gorsel = tbGorsel.Text;

           
       

           switch (ilanNo)
           {
                case 1:
                    //Araç 1 Yansıt
                    lId.Text = "#" + (Convert.ToString(arac.Id));
                    lMarka.Text = arac.Marka;
                    lModel.Text = arac.Model;
                    lAgirlik.Text = Convert.ToString(arac.Agirlik) + "Kg";
                    lBeygir.Text = Convert.ToString(arac.Beygir);
                    lKm.Text = Convert.ToString(arac.Km) + "Km";
                    lFiyat.Text = Convert.ToString(arac.Fiyat) + "₺";
                    pbGorsel.ImageLocation = arac.Gorsel;

                    lId.Visible = true;
                    lMarka.Visible = true;
                    lModel.Visible = true;
                    lAgirlik.Visible = true;
                    lBeygir.Visible = true;
                    lKm.Visible = true;
                    lFiyat.Visible = true;
                    pbGorsel.Visible = true;
                    break;

                case 2:
                    //Araç 2 Yansıt
                    lId2.Text = "#" + (Convert.ToString(arac.Id));
                    lMarka2.Text = arac.Marka;
                    lModel2.Text = arac.Model;
                    lAgirlik2.Text = Convert.ToString(arac.Agirlik) + "Kg";
                    lBeygir2.Text = Convert.ToString(arac.Beygir);
                    lKm2.Text = Convert.ToString(arac.Km) + "Km";
                    lFiyat2.Text = Convert.ToString(arac.Fiyat) + "₺";
                    pbGorsel2.ImageLocation = arac.Gorsel;

                    lId2.Visible = true;
                    lMarka2.Visible = true;
                    lModel2.Visible = true;
                    lAgirlik2.Visible = true;
                    lBeygir2.Visible = true;
                    lKm2.Visible = true;
                    lFiyat2.Visible = true;
                    pbGorsel2.Visible = true;
                    break;

                case 3:
                    //Araç 3 Yansıt
                    lId3.Text = "#" + (Convert.ToString(arac.Id));
                    lMarka3.Text = arac.Marka;
                    lModel3.Text = arac.Model;
                    lAgirlik3.Text = Convert.ToString(arac.Agirlik) + "Kg";
                    lBeygir3.Text = Convert.ToString(arac.Beygir);
                    lKm3.Text = Convert.ToString(arac.Km) + "Km";
                    lFiyat3.Text = Convert.ToString(arac.Fiyat) + "₺";
                    pbGorsel3.ImageLocation = arac.Gorsel;

                    lId3.Visible = true;
                    lMarka3.Visible = true;
                    lModel3.Visible = true;
                    lAgirlik3.Visible = true;
                    lBeygir3.Visible = true;
                    lKm3.Visible = true;
                    lFiyat3.Visible = true;
                    pbGorsel3.Visible = true;
                    break;

                case 4:
                    //Araç 4 Yansıt
                    lId4.Text = "#" + (Convert.ToString(arac.Id));
                    lMarka4.Text = arac.Marka;
                    lModel4.Text = arac.Model;
                    lAgirlik4.Text = Convert.ToString(arac.Agirlik) + "Kg";
                    lBeygir4.Text = Convert.ToString(arac.Beygir);
                    lKm4.Text = Convert.ToString(arac.Km) + "Km";
                    lFiyat4.Text = Convert.ToString(arac.Fiyat) + "₺";
                    pbGorsel4.ImageLocation = arac.Gorsel;

                    lId4.Visible = true;
                    lMarka4.Visible = true;
                    lModel4.Visible = true;
                    lAgirlik4.Visible = true;
                    lBeygir4.Visible = true;
                    lKm4.Visible = true;
                    lFiyat4.Visible = true;
                    pbGorsel4.Visible = true;
                    break;

                case 5:
                    //Araç 5 Yansıt
                    lId5.Text = "#" + (Convert.ToString(arac.Id));
                    lMarka5.Text = arac.Marka;
                    lModel5.Text = arac.Model;
                    lAgirlik5.Text = Convert.ToString(arac.Agirlik) + "Kg";
                    lBeygir5.Text = Convert.ToString(arac.Beygir);
                    lKm5.Text = Convert.ToString(arac.Km) + "Km";
                    lFiyat5.Text = Convert.ToString(arac.Fiyat) + "₺";
                    pbGorsel5.ImageLocation = arac.Gorsel;

                    lId5.Visible = true;
                    lMarka5.Visible = true;
                    lModel5.Visible = true;
                    lAgirlik5.Visible = true;
                    lBeygir5.Visible = true;
                    lKm5.Visible = true;
                    lFiyat5.Visible = true;
                    pbGorsel5.Visible = true;
                    break;
            }

           

           ////////////////////////////////////////
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            IlanSifirla();
            ilanNo += 1;
            lIlanNo.Text = ilanNo.ToString();
        }

        public void IlanSifirla()
        {
            tbMarka.Text = null;
            tbBeygir.Text = null;
            tbAgirlik.Text = null;
            tbGorsel.Text = null;
            tbKm.Text = null;
            tbModel.Text = null;
            tbFiyat.Text = null;
            
        }

        private void tbGorsel_TextChanged(object sender, EventArgs e)
        {
        

            lOnizlemeBekle.Visible = false;
            pbOnizleme.ImageLocation = tbGorsel.Text;
        }

       
    }
}
