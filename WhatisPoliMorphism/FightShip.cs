using System;
using System.Collections.Generic;
using System.Text;

namespace WhatisPoliMorphism
{
    class FightShip : BaseShip
    {
        public override string Move(int distance)
        {
            double time = (double)distance / 200;
            return string.Format("Yol Gedildi : {0} vaxt erzinde {1}", distance, time);
        }
        public override string Fight()
        {
            return "Dusmen mehv edildi";
        }
        public override string ToString()
        {
            return "Doyus Gemisi";
        }
    }
}
