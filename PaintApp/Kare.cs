using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    class Kare : Sekil // Çok biçimliliği ifade etmiş oluyoruz sanırım.
    {

        private float kenarUzunluk;

        public Kare()
        {
            SekilAdi = "kare";
            kenarUzunluk = 0;
        }

        public override void BitisNoktalari(float bitisNoktasiX, float bitisNoktasiY)
        {
            if (bitisNoktasiX > MaxKoordinatX)
            {
                kenarUzunluk = MaxKoordinatX - 2 - X;
                BitisNoktasiX = MaxKoordinatX - 2;
                BitisNoktasiY = Y + kenarUzunluk;
            }



            else if (bitisNoktasiY > MaxKoordinatY)
            {
                kenarUzunluk = MaxKoordinatY - 2 - Y;
                BitisNoktasiX = X + kenarUzunluk;
                BitisNoktasiY = MaxKoordinatY - 2;
            }

            else
            {
                kenarUzunluk = bitisNoktasiX - X;
                BitisNoktasiX = bitisNoktasiX;
                BitisNoktasiY = bitisNoktasiY;
            }





        }
        public override float Getir()
        {
            return kenarUzunluk;
        }

        public override void KenarCiz(Graphics cizimAraci)
        {
            cizimAraci.DrawRectangle(RenkliKalem, X, Y, kenarUzunluk, kenarUzunluk);
        }

        public override void DolguCiz(Graphics cizimAraci)
        {
            cizimAraci.FillRectangle(new SolidBrush(DolguRengi), X, Y, kenarUzunluk, kenarUzunluk);
        }


        public override bool IcindeMi(float X, float Y)
        {
            if (X >= this.X && X <= this.X + kenarUzunluk && Y >= this.Y && Y <= this.Y + kenarUzunluk)
            {
                return true;
            }
            return false;

        }
    }
}
