using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    class Sekil
    {
        private float maxKoordinatX = 565;
        private float maxKoordinatY = 469;
        private float baslangicNoktasiX;
        private float baslangicNoktasiY;
        private float bitisNoktasiX;
        private float bitisNoktasiY;
        private string sekilAd;
        private Pen kalem = new Pen(Color.Cyan, 2);
        private Color dolguRenk;
        public string SekilAdi { get { return sekilAd; } set { sekilAd = value; } }
        public Color DolguRengi { get { return dolguRenk; } set { dolguRenk = value; } }
        public Pen RenkliKalem { get { return kalem; } set { kalem = value; } }
        public float MaxKoordinatX { get { return maxKoordinatX; } }
        public float MaxKoordinatY { get { return maxKoordinatY; } }
        public float X { get { return baslangicNoktasiX; } set { baslangicNoktasiX = value; } }
        public float Y { get { return baslangicNoktasiY; } set { baslangicNoktasiY = value; } }
        public float BitisNoktasiX { get { return bitisNoktasiX; } set { bitisNoktasiX = value; } }
        public float BitisNoktasiY { get { return bitisNoktasiY; } set { bitisNoktasiY = value; } }
        public virtual bool IcindeMi(float X, float Y) { return false; }
        public virtual float Getir() { return 0; }
        public virtual void BitisNoktalari(float bitisNoktasiX, float bitisNoktasiY) { }
        public virtual void KenarCiz(Graphics cizimAraci) { }
        public virtual void DolguCiz(Graphics cizimAraci) { }

    }
}
