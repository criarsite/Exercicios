using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoxStart.Enum;

namespace BoxStart.Models
{
    public class Carro : StopBox
    {
        

        // Atributos
        private Veiculo Veiculo  {get; set;}
         private string Placa {get; set;}
         private string Marca  {get; set;}
         private string Modelo  {get; set;}
         private int Ano  {get; set;}
         private bool Removido {get; set;}

         // Construtor 
         public Carro(int id, Veiculo veiculo, string placa, string marca, string modelo, int ano)
        {
            this.Id = id;
            Veiculo = veiculo;
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            this.Removido = false;
        }

        public override string ToString()
        {

            string retorno ="";
            retorno += "Tipo de Veiculo: " + this.Veiculo + Environment.NewLine;
            retorno += "Placa: " + this.Placa + Environment.NewLine;
            retorno += "Marca: " + this.Marca + Environment.NewLine;
            retorno += "Modelo: " + this.Modelo + Environment.NewLine;
            retorno += "Ano de Fabricação: " + this.Ano + Environment.NewLine;
            retorno += "Removido: " + this.Removido + Environment.NewLine;
            return retorno;
        }

        public string retornaPlaca ()
        {
            return this.Placa;
        }

        public int retornaId()
        {
            return this.Id;
        }
        
        public void Remover()
        {
            this.Removido = true;
        }
    }
}