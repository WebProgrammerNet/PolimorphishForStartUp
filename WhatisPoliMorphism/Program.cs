using System;

namespace WhatisPoliMorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseShip ship = GetShip(ShipType.FightShip);
            string result = ship.Fight();

            BaseShip ship2 = GetShip(ShipType.TransportShip);
            string result2 = ship2.Fight();

            BadShip badShip = new BadShip();
            string result3 = badShip.Fight(ShipType.TransportShip);

            Console.WriteLine($"I am FightShip : {result}");
            Console.WriteLine($"I am TransportShip : {result2}");
            Console.WriteLine($"I am BadShip : {result3}");
            Console.ReadLine();
        }

        static BaseShip GetShip(ShipType shipType)
        {
            switch (shipType)
            {
                case ShipType.TransportShip:
                    return new TranportShip();

                case ShipType.FightShip:
                    return new FightShip();

                default:
                    throw new Exception("Namelum tip Gemi");
            }

        }
    }
    public class BaseShip
    {
        public virtual string Move(int distance)
        {
            string result = string.Format($"Gedilen Yol {distance}");
            return result;
        }

        public virtual string Fight()
        {
            return "Doyus Basladi";
        }

    }
}
