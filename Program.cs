﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Homework_Delegati
{
    internal class Program
    {
        public delegate void MojDelegat(string message);
        static void Main(string[] args)
        {
            MojDelegat del1 = Metoda1;
            MojDelegat del2 = Metoda2;
            MojDelegat del3 = Metoda3;
            del1("Pero");
            del2("Marko");
            del3("Stipe");

            MojDelegat del = del1 + del2 +del3;
            del("rezultat");
            
            var proizvod = new Artikli();
            proizvod.MaloprodajnaCijena.PovecajMaloprodajnuCijenu(10);
            proizvod.VeleprodajnaCijena.PovecajVeleprodajnuCijenu(20);
            proizvod.MaloprodajnaCijena.PovecajMaloprodajnuCijenu(50);
            proizvod.VeleprodajnaCijena.PovecajVeleprodajnuCijenu(100);
        }

        public static void Metoda1 (string poruka)
        {
            Console.WriteLine($"Izvršavamo metodu 1 sa tekstom: {poruka}.");
        }
        public static void Metoda2(string tekst)
        {
            Console.WriteLine($"Izvršavamo metodu 2 sa tekstom: {tekst}.");
        }
        public static void Metoda3(string message)
        {
            Console.WriteLine($"Izvršavamo metodu 3 sa tekstom: {message}.");
            
        }
        
    }
}
