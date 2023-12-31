﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooZoologico
{
     class Program
    {
        static void Main(string[] args)
        {
            List<AnimalPlus> animais = new List<AnimalPlus>();
            int countCar = 0, countHer = 0;
            Console.WriteLine("Programa que conta quantos animais são carnívoros e herbívoros");
            for (int i = 0; i < 4; i++) 
            {
                AnimalPlus animal = new AnimalPlus();
                Console.Write("Espécie: ");
                animal.Especie = Console.ReadLine();
                Console.Write("Peso: ");
                animal.Peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Alimentação: ");
                animal.TipoAlimentacao = Console.ReadLine();
                if (animal.TipoAlimentacao == "Carnívoro")
                {
                    countCar++;
                }
                else
                {
                    countHer++;
                }
                animais.Add(animal);
            }   
            Console.WriteLine("Total de animais carnívoros: " + countCar);
            Console.WriteLine("Total de animais herbívoros: " + countHer);
            Console.ReadKey();
        }
    }
}
