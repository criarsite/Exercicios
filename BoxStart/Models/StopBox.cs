using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoxStart 
{
    public abstract class StopBox // Classe abstrata n pode ser instanciada, apenas herdada e seus atributos e metodos sao obrigatorios de ser implementados
    {
        public int Id {get; protected set;}
    }
}