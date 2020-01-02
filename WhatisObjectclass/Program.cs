using System;

namespace WhatisObjectclass
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Console.WriteLine("Hello World!");

            //BaseShip baseShip = new BaseShip("BaseShip Classindan instal aldim");
            //baseShip.Move(20);
            //TransportShip transportShip = new TransportShip("TransportShip Classindan instal aldim");
            //transportShip.Move(100);

            //Console.WriteLine("\n");
            //Simple1 simple1 = new Simple1();
            //simple1.ToString();
            // string get = simple1.ToString();
            //  Console.WriteLine(get);
            #endregion

            Console.WriteLine("Java"+10+20);  //Java1020
            Console.WriteLine(15+20+"Java");   //35Java
            Console.ReadLine();
        }
    }
    public class Simple1 : System.Object
    {
        public override string ToString()
        {
            Console.WriteLine("Me toString() Methodunu Simple1 Classinda override eyledim.");
            return "Me toString() Methodunu Simple1 Classinda override eyledim.";
        }
    }
    public class BaseShip : Object
    {
        private int _counter = 10;
        protected int _spped = 20;

        public BaseShip(string note)
        {
            _counter++;
            _spped++;
            Console.WriteLine($"Note{note} : _counter = {_counter} : _sped = {_spped}");
            Console.WriteLine();

        }
        public virtual string Fight()
        {
            return "Deniz Quldurlari ile Muharibe Geir";
        }


        public virtual string Move(int distance)
        {
            _counter++;
            string result = string.Format($"Gedilen Yol {distance}").ToString();
            Console.WriteLine(result);
            return result;
            //toString ozu //  public sealed class String : IEnumerable<char>, IEnumerable, ICloneable, IComparable, IComparable<String>,
            //IConvertible, IEquatable<String>{}

        }
    }
    public class TransportShip : BaseShip
    {

        public TransportShip(string note1) : base(note1)
        {
            Console.WriteLine(note1);
        }

        public override string Move(int distance)
        {
            // string result = string.Format($"Gedilen Yol override olunub {distance}").ToString();
            string result = Move(20); // Bu Rekursiyadir.
            Console.WriteLine(result);
            return result;
        }

    }
    // Dostlar Bu Trigger uucun real numunedir.
    // Bir classda (Table-da) bas veren deyisikliyin diger bir classda(Table-da) da mueyyen bir deyisikliyin bas vermesine sebeb olur.
}
