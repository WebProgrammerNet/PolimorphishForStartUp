using System;
using System.Collections.Generic;
using System.Text;

namespace WhatisPoliMorphism
{
    class TranportShip : BaseShip
    {
        public override string Move(int distance)
        {
            double time = (double)distance / 100;
            return string.Format("Yol Gedildi : {0} vaxt erzinde {1}", distance, time);
        }

        public override string Fight()
        {
            return "TransportShip doyuse bilmir";
        }

        public override string ToString()
        {
            return "TransportShip Gemisi";
        }
    }
}
