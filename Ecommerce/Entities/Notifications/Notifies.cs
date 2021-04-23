using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notifications
{
   public class Notifies
    {
        public Notifies()
        {
            //Carregando a lista de notificaçoes ao chamar a entidade
            Notitycoes = new List<Notifies>();
        }

        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }

        [NotMapped]
        public List<Notifies> Notitycoes { get; set; }


        //Metodos recebo o valor e o nome da propriedade  
        public bool ValidarPropriedadeString(string valor, string nomepropriedade)
        {
            //verifica se esta vazio ou com espaço
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                //se verdade devolve a msg e retorna falso
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomepropriedade
                });
                return false;
            }
            // se tiver tudo certo retorna verdadeiro
            return true;
        }


        //Metodos recebo o valor e o nome da propriedade  
        public bool ValidarPropriedadeInt(int valor, string nomepropriedade)
        {
            //verifica se o valor informado é maior ou igual a 1
            if (valor <= 1 || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                //se verdade devolve a msg e retorna falso
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "Valor deve ser maior que 0",
                    NomePropriedade = nomepropriedade
                });
                return false;
            }
            // se tiver tudo certo retorna verdadeiro
            return true;
        }

        //Metodos recebo o valor e o nome da propriedade  
        public bool ValidarPropriedadeDecimal(decimal valor, string nomepropriedade)
        {
            //verifica se o valor informado é maior ou igual a 1
            if (valor <= 1 || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                //se verdade devolve a msg e retorna falso
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "Valor deve ser maior que 0",
                    NomePropriedade = nomepropriedade
                });
                return false;
            }
            // se tiver tudo certo retorna verdadeiro
            return true;
        }
    }
}
