using System;
using System.Collections.Generic;
using System.Text;

namespace Radio_El
{
    class Rad_el
    {
        //Номер в обозначениях
        private uint ObNum;
        //Единицы измерения
        private string EdIzm;
        //Величина
        private float Value;
        //Расположение 0 - горизонтально, 1 - вертикально
        private bool Poloz;
        //Координаты для рисования
        private uint x, y;



        public void SetX(uint x)
        {
            this.x = x;
        }
        public void SetY(uint y)
        {
            this.y = y;
        }
        public void SetXY(uint x, uint y)
        {
            this.x = x;
            this.y = y;
        }

        public uint GetX()
        {
            return x;
        }
        public uint GetY()
        {
            return y;
        }
        
        public void SetOboznNumber(uint n)
        {
            ObNum = n;
        }
        public uint GetOboznNumber()
        {
            return ObNum;
        }
        public void SetEdIzm(string edIzm)
        {
            if (edIzm == "")
            {
                throw new Exception("Единицы измерения не могут быть пустой строкой");
            }
            else
            {
                EdIzm = edIzm;
            }
        }
        public string GetEdIzm()
        {
            return EdIzm;
        }
        public void SetPoloz(bool poloz)
        {
            Poloz = poloz;
        }


    }
}
