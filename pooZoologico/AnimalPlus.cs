using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooZoologico
{
    public class AnimalPlus:Animal
    {
        public AnimalPlus():base()
        {
            TipoAlimentacao = "";
        }

        public AnimalPlus(String especie, Double peso, String tipoAlimentacao) : base(especie, peso)
        {
            TipoAlimentacao = tipoAlimentacao;
        }
        public String TipoAlimentacao { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine("Especie: " + Especie);
            Console.WriteLine("Peso: " + Peso);
            Console.WriteLine("Alimentação: " + TipoAlimentacao);
        }
    }
}
