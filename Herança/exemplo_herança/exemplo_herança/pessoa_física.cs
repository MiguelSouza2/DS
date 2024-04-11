using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_herança
{
    //O sinal de : demonstra que a classe 'pessoa-_física está HERDANDO o conteúdo da classe pessoa'
    class pessoa_física : pessoa
    {
        private string RG;

        public void setRG(string RG)
        {
            this.RG = RG;
        }
        public string getRG()
        {
            return this.RG;
        }
    }
}
