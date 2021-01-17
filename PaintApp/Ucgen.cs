using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    class Ucgen : Sekil
    {


        private float merkezKenarUzunuluk;

        double kok = Math.Sqrt(3); // Aşağıdaki ifadede currentlerde x kullanıyorum çnkü diğer tarafta aynısı oluşması için. Eşkenar üçgen değil ama...

        public Ucgen()
        {
            SekilAdi = "üçgen";
            merkezKenarUzunuluk = 0;

        }

        public PointF[] UcgenKoordinat()
        {
            PointF birinciNokta = new PointF(X, Y - ((merkezKenarUzunuluk / (float)kok) * 2));
            PointF ikinciNokta = new PointF(X - merkezKenarUzunuluk, Y + (merkezKenarUzunuluk / (float)kok));
            PointF ucuncuNokta = new PointF(X + merkezKenarUzunuluk, Y + (merkezKenarUzunuluk / (float)kok));

            PointF[] ucgen = { ucuncuNokta, birinciNokta, ikinciNokta }; // buraya taşıyınca  tersten çıkmaya başladı :(


            return ucgen;
        }

        public override void BitisNoktalari(float bitisNoktasiX, float bitisNoktasiY)
        {
            if (bitisNoktasiX > MaxKoordinatX)
            {
                merkezKenarUzunuluk = MaxKoordinatX - 2 - X;
                BitisNoktasiX = MaxKoordinatX - 2;
                BitisNoktasiY = Y + merkezKenarUzunuluk;
            }

            else if (X - (bitisNoktasiX - X) < 0)
            {

                merkezKenarUzunuluk = X;
                bitisNoktasiX = 2 * X;
                BitisNoktasiY = Y + merkezKenarUzunuluk;
            }

            else if (Y - (bitisNoktasiY - Y) < 0)
            {

                merkezKenarUzunuluk = Y;
                bitisNoktasiY = 2 * Y;
                BitisNoktasiX = X + merkezKenarUzunuluk;
            }


            else if (bitisNoktasiY > MaxKoordinatY)
            {
                merkezKenarUzunuluk = 2 * (MaxKoordinatY - Y);
                BitisNoktasiX = X + merkezKenarUzunuluk;
                BitisNoktasiY = MaxKoordinatY;
            }

            else
            {
                merkezKenarUzunuluk = bitisNoktasiX - X;
                BitisNoktasiX = bitisNoktasiX;
                BitisNoktasiY = bitisNoktasiY;
            }
        }

        public override float Getir()
        {
            return merkezKenarUzunuluk;
        }
        public override void DolguCiz(Graphics cizimAraci)
        {
            cizimAraci.FillPolygon(new SolidBrush(DolguRengi), UcgenKoordinat());
        }

        public override void KenarCiz(Graphics cizimAraci)
        {
            cizimAraci.DrawPolygon(RenkliKalem, UcgenKoordinat());

        }

        public override bool IcindeMi(float X, float Y)
        {
            if (X >= this.X - merkezKenarUzunuluk && X <= this.X + merkezKenarUzunuluk && Y >= this.Y - merkezKenarUzunuluk && Y <= this.Y + merkezKenarUzunuluk / 2)
            {
                return true;
            }
            return false;

        }



    }
}
