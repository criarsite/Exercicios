using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoxStart.Interfaces;

namespace BoxStart.Models
{
    public class CarroRepositorio : IRepositorio<Carro>
    {
        private List<Carro> listaCarro = new List<Carro>();
        public void Atualizar(int id, Carro carro)
        {
           listaCarro[id] = carro;
        }

        public void Excluir(int id)
        {
            listaCarro[id].Remover();
        }

        public void Inserir(Carro carro)
        {
            listaCarro.Add(carro);
        }

        public List<Carro> Lista()
        {
           return listaCarro;
        }

        public int ProximoId()
        {
            return listaCarro.Count;
        }

        public Carro RetornaPorId(int id)
        {
           return  listaCarro[id];
        }
    }
}