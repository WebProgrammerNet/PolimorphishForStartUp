using System;
using System.Collections.Generic;
using System.Text;

namespace WhatisPoliMorphism
{
    public class BadShip
    {
        public ShipType shipType { get; set; }

        public string Move(int distance)
        {
            double time = 0;
            if (shipType == ShipType.TransportShip)
            {
                time = distance / 100;
            }

            if (shipType == ShipType.FightShip)
            {
                time = distance / 200;
            }
            return string.Format("Gedilen Yol: {0} vaxt erzinde {1}", distance, time);
        }

        public string Fight(ShipType shipType)
        {
            if (shipType == ShipType.TransportShip)
            {
                return "Neqliyyat Gemisi Doyuse bilmir";
            }

            if (shipType == ShipType.FightShip)
            {
                return "Dusmen mehv edilib";
            }
            return "Namelum obyekt";
        }
        public override string ToString()
        {
            return "Pirat Gemisi";
        }
    }
}
