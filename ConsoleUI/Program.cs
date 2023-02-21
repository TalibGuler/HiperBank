using Business.Abstract;
using Business.Concrete;
using DataAccess.Repository.Abstract;
using DataAccess.Repository.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteriService bilancoService = new GercekMusteriService(new GercekMusteriRepository());

            foreach (var bilanco in bilancoService.GetAll().Data)
            {
                Console.WriteLine(bilanco.Ad + " " + bilanco.Soyad);
            }
        }
    }
}
