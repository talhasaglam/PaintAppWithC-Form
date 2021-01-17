using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
  
    class Daire : Sekil
    {
        private float yaricap;
        public Daire()
        {
            yaricap = 0;
            SekilAdi = "daire";
        }

        public override void BitisNoktalari(float bitisNoktasiX, float bitisNoktasiY)
        {
            if (bitisNoktasiX > MaxKoordinatX)
            {
                yaricap = MaxKoordinatX - 2 - X;
                BitisNoktasiX = MaxKoordinatX - 2;
                BitisNoktasiY = Y + yaricap;
            }

            else if (X - (bitisNoktasiX - X) < 0)
            {

                yaricap = X;
                bitisNoktasiX = 2 * X;
                BitisNoktasiY = Y + yaricap;
            }

            else if (Y - (bitisNoktasiY - Y) < 0)
            {

                yaricap = Y;
                bitisNoktasiY = 2 * Y;
                BitisNoktasiX = X + yaricap;
            }

            else if (bitisNoktasiY > MaxKoordinatY)
            {
                yaricap = MaxKoordinatY - 2 - Y;
                BitisNoktasiX = X + yaricap;
                BitisNoktasiY = MaxKoordinatY - 2;
            }

            else
            {
                yaricap = bitisNoktasiX - X;
                BitisNoktasiX = bitisNoktasiX;
                BitisNoktasiY = bitisNoktasiY;
            }
        }
        public override float Getir()
        {
            return yaricap;
        }

        public override void DolguCiz(Graphics cizimAraci)
        {
            cizimAraci.FillEllipse(new SolidBrush(DolguRengi), X - yaricap, Y - yaricap, yaricap * 2, yaricap * 2);
        }

        public override void KenarCiz(Graphics cizimAraci)
        {
            cizimAraci.DrawEllipse(RenkliKalem, X - yaricap, Y - yaricap, yaricap * 2, yaricap * 2);

        }

        public override bool IcindeMi(float X, float Y)
        {
            if (X >= this.X - yaricap && X <= this.X + yaricap && Y >= this.Y - yaricap && Y <= this.Y + yaricap)
            {
                return true;
            }
            return false;

        }
    }
}
