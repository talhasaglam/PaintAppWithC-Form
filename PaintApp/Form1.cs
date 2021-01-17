using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp

{


    public partial class Form1 : Form
    {
        private bool mouseDown = false;
        private Bitmap bm;
        private Color dolguRengi;
        private bool kareCiz;
        private bool daireCiz;
        private bool ucgenCiz;
        private bool altigenCiz;
        private bool sekilSec;
        List<Sekil> sekiller;
        Sekil aktifSekil = null;
        private float X = 0;
        private float Y = 0;

        public Form1()
        {
            DoubleBuffered = true;
            InitializeComponent();
            bm = new Bitmap(CizimEkrani.Width, CizimEkrani.Height);
            sekiller = new List<Sekil>();
        }


        private void CizimEkrani_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (kareCiz)
                    aktifSekil = new Kare();

                else if (daireCiz)
                    aktifSekil = new Daire();

                else if (ucgenCiz)
                    aktifSekil = new Ucgen();
                else if (altigenCiz)
                    aktifSekil = new Altigen();

                mouseDown = true;
                if (aktifSekil != null)
                {
                    aktifSekil.X = e.X;
                    aktifSekil.Y = e.Y;
                    aktifSekil.DolguRengi = dolguRengi;
                }
                X = e.X;
                Y = e.Y;
                


                for (int i = 0; i < sekilSayisi; i++)
                {
                    sekiller[i].RenkliKalem = new Pen(Color.Aqua, 2);
                  
                    if (sekilSec)
                    {

                        if (sekiller[i].IcindeMi(X, Y))
                        {

                            if (sekiller[i].SekilAdi == "kare")                           
                                sekiller[i].RenkliKalem = new Pen(Color.Black, 5);
                            
                            else if (sekiller[i].SekilAdi == "daire")
                                sekiller[i].RenkliKalem = new Pen(Color.Black, 5);
                    
                            else if (sekiller[i].SekilAdi == "üçgen")
                                sekiller[i].RenkliKalem = new Pen(Color.Black, 5);
                            else if (sekiller[i].SekilAdi == "altıgen")
                                sekiller[i].RenkliKalem = new Pen(Color.Black, 5);

                        }

                    }

                }

            }
        }

        private void CizimEkrani_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown == true)
            {
                
                if (aktifSekil != null) { 

                aktifSekil.BitisNoktalari(e.X, e.Y);
                    }
                CizimEkrani.Invalidate(); // Çizilme anını felan gösteriyorlar.
            }
            else
            {
                CizimEkrani.Invalidate();
            }
        }

        int sekilSayisi = 0;

        private void CizimEkrani_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = false;
                if (sekilSayisi != 100)
                    if (aktifSekil != null)
                    {
                        sekiller.Add(aktifSekil);
                        sekilSayisi++;
                    }
            }
        }
        private void CizimEkrani_Paint(object sender, PaintEventArgs e)
        {
 
            Graphics setPaint = e.Graphics;
            if (mouseDown == true)
            {
                if (aktifSekil != null)
                {
                    aktifSekil.KenarCiz(setPaint);
                    aktifSekil.DolguCiz(setPaint);
                }
             
            }

            for (int i = 0; i < sekilSayisi; i++)  // Renk değiştirmede anında görüntü alıyoruz.
            {
                sekiller[i].KenarCiz(setPaint);
                sekiller[i].DolguCiz(setPaint);

            }

  

            setPaint.DrawImage(bm, new Point(0, 0));
        }



        private void Kare_Click(object sender, EventArgs e)
        {

            Kare.BackColor = Color.Plum;
            Daire.BackColor = Color.Khaki;
            Ucgen.BackColor = Color.Khaki;
            Altigen.BackColor = Color.Khaki;
            SekilSec.BackColor = Color.Khaki;
            sekilSec = false;
            kareCiz = true;
            ucgenCiz = false;
            daireCiz = false;
            altigenCiz = false;
        }

        private void Daire_Click(object sender, EventArgs e)
        {
            Kare.BackColor = Color.Khaki;
            Ucgen.BackColor = Color.Khaki;
            Altigen.BackColor = Color.Khaki;
            Daire.BackColor = Color.Plum;
            SekilSec.BackColor = Color.Khaki;
            sekilSec = false;
            kareCiz = false;
            ucgenCiz = false;
            daireCiz = true;
            altigenCiz = false;

        }

        private void Ucgen_Click(object sender, EventArgs e)
        {
            Kare.BackColor = Color.Khaki;
            Ucgen.BackColor = Color.Plum;
            Altigen.BackColor = Color.Khaki;
            Daire.BackColor = Color.Khaki;
            SekilSec.BackColor = Color.Khaki;
            sekilSec = false;
            kareCiz = false;
            ucgenCiz = true;
            daireCiz = false;
            altigenCiz = false;

        }

        private void Altigen_Click(object sender, EventArgs e)
        {
            Kare.BackColor = Color.Khaki;
            Ucgen.BackColor = Color.Khaki;
            Altigen.BackColor = Color.Plum;
            Daire.BackColor = Color.Khaki;
            SekilSec.BackColor = Color.Khaki;
            sekilSec = false;
            kareCiz = false;
            ucgenCiz = false;
            daireCiz = false;
            altigenCiz = true;
        }

        private void Kirmizi_Click(object sender, EventArgs e)
        {
            dolguRengi = Color.Red;

            for (int i = 0; i < sekilSayisi; i++)
            {
                if (sekilSec)
                {

                    if (sekiller[i].IcindeMi(X, Y))
                    {

                        sekiller[i].DolguRengi = dolguRengi;
                        CizimEkrani.Refresh();
                    }
                }

            }
        }

        private void Mavi_Click(object sender, EventArgs e)
        {
            dolguRengi = Color.Blue;

            for (int i = 0; i < sekilSayisi; i++)
            {
                if (sekilSec)
                {

                    if (sekiller[i].IcindeMi(X, Y))
                    {

                        sekiller[i].DolguRengi = dolguRengi;
                        CizimEkrani.Refresh();
                    }
                }

            }
        }

        private void Yesil_Click(object sender, EventArgs e)
        {
            dolguRengi = Color.Green;

            for (int i = 0; i < sekilSayisi; i++)
            {
                if (sekilSec)
                {

                    if (sekiller[i].IcindeMi(X, Y))
                    {

                        sekiller[i].DolguRengi = dolguRengi;
                        CizimEkrani.Refresh();
                    }
                }

            }
        }

        private void Turuncu_Click(object sender, EventArgs e)
        {
            dolguRengi = Color.Orange;

            for (int i = 0; i < sekilSayisi; i++)
            {
                if (sekilSec)
                {

                    if (sekiller[i].IcindeMi(X, Y))
                    {

                        sekiller[i].DolguRengi = dolguRengi;
                        CizimEkrani.Refresh();
                    }
                }

            }
        }

        private void Siyah_Click(object sender, EventArgs e)
        {
            dolguRengi = Color.Black;

            for (int i = 0; i < sekilSayisi; i++)
            {
                if (sekilSec)
                {

                    if (sekiller[i].IcindeMi(X, Y))
                    {

                        sekiller[i].DolguRengi = dolguRengi;
                        CizimEkrani.Refresh();
                    }
                }

            }
        }

        private void Sari_Click(object sender, EventArgs e)
        {
            dolguRengi = Color.Yellow;

            for (int i = 0; i < sekilSayisi; i++)
            {
                if (sekilSec)
                {

                    if (sekiller[i].IcindeMi(X, Y))
                    {

                        sekiller[i].DolguRengi = dolguRengi;
                        CizimEkrani.Refresh();
                    }
                }

            }
        }

        private void Mor_Click(object sender, EventArgs e)
        {
            dolguRengi = Color.Purple;

            for (int i = 0; i < sekilSayisi; i++)
            {
                if (sekilSec)
                {

                    if (sekiller[i].IcindeMi(X, Y))
                    {

                        sekiller[i].DolguRengi = dolguRengi;
                        CizimEkrani.Refresh();
                    }
                }

            }
        }

        private void Kahverengi_Click(object sender, EventArgs e)
        {
            dolguRengi = Color.Brown;

            for (int i = 0; i < sekilSayisi; i++)
            {
                if (sekilSec)
                {

                    if (sekiller[i].IcindeMi(X, Y))
                    {

                        sekiller[i].DolguRengi = dolguRengi;
                        CizimEkrani.Refresh();
                    }
                }

            }
        }

        private void Beyaz_Click(object sender, EventArgs e)
        {
            dolguRengi = Color.White;

            for (int i = 0; i < sekilSayisi; i++)
            {
                if (sekilSec)
                {

                    if (sekiller[i].IcindeMi(X, Y))
                    {

                        sekiller[i].DolguRengi = dolguRengi;
                        CizimEkrani.Refresh();
                    }
                }

            }
        }

        private void SekilSec_Click(object sender, EventArgs e)
        {
            Kare.BackColor = Color.Khaki;
            Ucgen.BackColor = Color.Khaki;
            Altigen.BackColor = Color.Khaki;
            Daire.BackColor = Color.Khaki;
            SekilSec.BackColor = Color.Plum;
            aktifSekil =null; 
            sekilSec = false;
            kareCiz = false;
            ucgenCiz = false;
            daireCiz = false;
            altigenCiz = false;
            sekilSec = true;
        }

        private void SekilSil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sekilSayisi; i++)
            {
                if (sekilSec)
                {

                    if (sekiller[i].IcindeMi(X, Y))
                    {

                            sekiller.Remove(sekiller[i]);
                            sekilSayisi--;
                            CizimEkrani.Refresh();
                             break;
                    }
                }

            }
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Metin Dosyası|*.txt";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(save.FileName);

                for (int i = 0; i < sekilSayisi; i++)
                {
                    Kayit.WriteLine(sekiller[i].SekilAdi+" "+ sekiller[i].DolguRengi.ToArgb()+" "+ sekiller[i].X+" "+ sekiller[i].Y+ " "+sekiller[i].BitisNoktasiX+" "+ sekiller[i].BitisNoktasiY);
                }
                Kayit.Close();
            }
        }

        private void DosyaAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader oku = new StreamReader(theDialog.FileName);
                string metin;
                    metin = oku.ReadLine();
                while (metin != null)
                {
                    string[] kelime = metin.Split(' ');
                    if (kelime[0] == "kare")
                        aktifSekil = new Kare();
                    else if (kelime[0] == "daire")
                        aktifSekil = new Daire();
                    else if (kelime[0] == "üçgen")
                        aktifSekil = new Ucgen();
                    else if (kelime[0] == "altıgen")
                        aktifSekil = new Altigen();
                    aktifSekil.SekilAdi = kelime[0];
                    
                    aktifSekil.DolguRengi = Color.FromArgb(int.Parse(kelime[1]));
                    aktifSekil.X = Convert.ToSingle(kelime[2]);
                    aktifSekil.Y = Convert.ToSingle(kelime[3]);
                    aktifSekil.BitisNoktalari(float.Parse(kelime[4]), float.Parse(kelime[5]));
                    sekiller.Add(aktifSekil);
                    sekilSayisi++;
                    metin = oku.ReadLine();
                }

                aktifSekil = null;
            }
        }
    }

}